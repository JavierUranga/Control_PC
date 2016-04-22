using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Reflection;
using ReadSerial.FORMS;

namespace ReadSerial
{

    public enum enum_Commands
    {
        READ_CAMERA_CONFIG,
        CAPTURE_IMAGE_FIFO,
        READ_IMAGE_FIFO,
        STORE_CATALOG_HEADER,
        READ_CATALOG_HEADER,
        STORE_STAR_PAIR,
        READ_STAR_PAIR,
        STORE_STAR_ID,
        READ_STAR_ID,
        STORE_UVECTOR,
        READ_UVECTOR,
        MANUAL_MODE,
        STAR_TRACKER_MODE,

        //RESOLUTION
        RESOLUTION_TYPE_VGA,
        RESOLUTION_TYPE_QVGA,
        RESOLUTION_TYPE_QQVGA,

        //Save SD
        SAVE_IMAGE_SD,

        //Automatic mode
        AUTOMATIC_MODE
    }

    public enum enum_Resolution
    {
        VGA,
        QVGA,
        QQVGA
    }

    public enum enum_ImageType
    {
        GRAY_SCALE,
        YUV,
        RGB
    }

    public partial class Form1 : Form
    {

        SerialPort mySerialPort;
        byte[] DataArray;
        byte[] HeaderBytes;
        byte[] StarPairBytes;
        byte[] StarIDBytes;
        byte[] UvectorBytes;
        int Pointer = 0;
        enum_Resolution Resolution;
        enum_ImageType ImageType;
        int Columns = 0;
        int Lines = 0;
        int Pixels = 0;

        // Constants
        // VGA
        const int VGA_COLUMNS   = 640;
        const int VGA_FILES     = 480;
        const int VGA_PIXELS = (VGA_COLUMNS * VGA_FILES);
        // QVGA
        const int QVGA_COLUMNS = 320;
        const int QVGA_FILES = 240;
        const int QVGA_PIXELS = (QVGA_COLUMNS * QVGA_FILES);
        // QQVGA
        const int QQVGA_COLUMNS = 160;
        const int QQVGA_FILES = 120;
        const int QQVGA_PIXELS = (QQVGA_COLUMNS * QQVGA_FILES);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetTabs(this.textBox1);
            mySerialPort = new SerialPort("COM4");

            mySerialPort.BaudRate = 250000;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.ReadTimeout = 50;
            mySerialPort.ReadBufferSize = 200000;
            mySerialPort.NewLine = "\r\n";
        

            //mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mySerialPort.Close();
        }

        static class NativeMethods
        {
          [DllImport("user32.dll")]
          public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, ref int lParam);
        }
        static void SetTabs(TextBox box)
        {
          int lParam = 8;  //Set tab size to 4 spaces
          NativeMethods.SendMessage(box.Handle, 0x00CB, new IntPtr(1), ref lParam);
          box.Invalidate();
        }

        delegate void DataReceivedHandlerCallback(object sender, SerialDataReceivedEventArgs e);
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox1.InvokeRequired)
            {
                DataReceivedHandlerCallback d = new DataReceivedHandlerCallback(DataReceivedHandler);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                SerialPort sp = (SerialPort)sender;
                //string indata = sp.ReadExisting();
                int indata = sp.Read(DataArray, Pointer, sp.BytesToRead);
                //Array.Copy(Encoding.ASCII.GetBytes(indata), 0, DataArray, Pointer, indata.Length);
                Pointer = Pointer + indata;
            }
        }

        public Image byteArrayToImage(int width, int height, byte[] imageData)
        {
            // Need to copy our 8 bit greyscale image into a 32bit layout.
            // Choosing 32bit rather than 24 bit as its easier to calculate stride etc.
            // This will be slow enough and isn't the most efficient method.
            var data = new byte[width * height * 4];
            int o = 0;

            for (var i = 0; i < width * height; i++)
            {
                var value = imageData[i];

                // Greyscale image so r, g, b, get the same intensity value.
                data[o++] = value;
                data[o++] = value;
                data[o++] = value;
                data[o++] = 0;  // Alpha isn't actually used
            }

            unsafe
            {
                fixed (byte* ptr = data)
                {
                    // Craete a bitmap wit a raw pointer to the data
                    Bitmap image = new Bitmap(width, height, width * 4, PixelFormat.Format32bppRgb, new IntPtr(ptr));
                    return image;
                }
            }
        }

       //RGB
        public Image byteArrayToImageRGB(int width, int height, byte[] imageData)
        {
            // Need to copy our 8 bit greyscale image into a 32bit layout.
            // Choosing 32bit rather than 24 bit as its easier to calculate stride etc.
            // This will be slow enough and isn't the most efficient method.
            mySerialPort.DataBits = 8;
            var data = new byte[width * height * 4];
            int o = 0;

            for (var i = 0; i < width * height; i++)
            {
                var value = imageData[i];

                // Greyscale image so r, g, b, get the same intensity value.
                data[o++] = value; //(value & 0f800)>>11;
                data[o++] = value; //(value & 0x07e0) >> 5;
                data[o++] = value; //value & 0x001f;
                data[o++] = 0;  // Alpha isn't actually used
            }

            unsafe
            {
                fixed (byte* ptr = data)
                {
                    // Craete a bitmap wit a raw pointer to the data
                    Bitmap image = new Bitmap(width, height, width * 4, PixelFormat.Format32bppRgb, new IntPtr(ptr));
                    return image;
                }
            }
        }

        private Bitmap ConvertBayerToRgb32(int width, int height, byte[] rawColorPixels)
        {
            var colorPixels = new byte[width * height * 4];
            // Demosaic using a basic nearest-neighbor algorithm, operating on groups of four pixels.
            for (int y = 0; y < height; y += 2)
            {
                for (int x = 0; x < width; x += 2)
                {
                    int firstRowOffset = (y * width) + x;
                    int secondRowOffset = firstRowOffset + width;

                    // Cache the Bayer component values.
                    byte red = rawColorPixels[firstRowOffset + 1];
                    byte green1 = rawColorPixels[firstRowOffset];
                    byte green2 = rawColorPixels[secondRowOffset + 1];
                    byte blue = rawColorPixels[secondRowOffset];

                    // Adjust offsets for RGB.
                    firstRowOffset *= 4;
                    secondRowOffset *= 4;

                    // Top left
                    colorPixels[firstRowOffset] = blue;
                    colorPixels[firstRowOffset + 1] = green1;
                    colorPixels[firstRowOffset + 2] = red;

                    // Top right
                    colorPixels[firstRowOffset + 4] = blue;
                    colorPixels[firstRowOffset + 5] = green1;
                    colorPixels[firstRowOffset + 6] = red;

                    // Bottom left
                    colorPixels[secondRowOffset] = blue;
                    colorPixels[secondRowOffset + 1] = green2;
                    colorPixels[secondRowOffset + 2] = red;

                    // Bottom right
                    colorPixels[secondRowOffset + 4] = blue;
                    colorPixels[secondRowOffset + 5] = green2;
                    colorPixels[secondRowOffset + 6] = red;
                }
            }
            unsafe
            {
                fixed (byte* ptr = colorPixels)
                {
                    // Craete a bitmap wit a raw pointer to the data
                    Bitmap image = new Bitmap(width, height, width * 4, PixelFormat.Format24bppRgb, new IntPtr(ptr));
                    return image;
                }
            }
        }


        public static Bitmap ByteToGrayBitmap(byte[] rawBytes, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                                            ImageLockMode.WriteOnly, bitmap.PixelFormat);

            Marshal.Copy(rawBytes, 0, bitmapData.Scan0, rawBytes.Length);
            bitmap.UnlockBits(bitmapData);

            var pal = bitmap.Palette;
            for (int i = 0; i < 256; i++) pal.Entries[i] = Color.FromArgb(i, i, i);
            bitmap.Palette = pal;

            return bitmap;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            this.SendCommand(enum_Commands.CAPTURE_IMAGE_FIFO, 1000);
        }
        //Botón para elegir leer de la SD
        private void btn_ReadSD_Click(object sender, EventArgs e)
        {
            this.SendCommand(enum_Commands.SAVE_IMAGE_SD, 1000);
        }
        private void btn_Receive_Click(object sender, EventArgs e)
        {
            this.SendCommand(enum_Commands.READ_IMAGE_FIFO, 1000);
        }

        private bool SendCommand(enum_Commands Command, int Timeout_ms)
        {
            string comm = string.Empty;
            string answer = string.Empty;
            int Retries = 0;
            string buffer = string.Empty;
            bool End = false;
            byte[] bytes_Num;
            int Num;

            try
            {
                mySerialPort.DiscardInBuffer();
  //              this.Resolution = enum_Resolution.VGA;
                switch (Resolution)
                {
                    case enum_Resolution.VGA:
                        this.Columns = VGA_COLUMNS;
                        this.Lines = VGA_FILES;
                        this.Pixels = VGA_PIXELS;
                        break;
                    case enum_Resolution.QVGA:
                         this.Columns = QVGA_COLUMNS;
                        this.Lines = QVGA_FILES;
                        this.Pixels = QVGA_PIXELS;
                        break;
                    case enum_Resolution.QQVGA:
                         this.Columns = QQVGA_COLUMNS;
                        this.Lines = QQVGA_FILES;
                        this.Pixels = QQVGA_PIXELS;
                        break;
                }
                DataArray = new byte[this.Pixels];
                Array.Clear(this.DataArray, 0, this.DataArray.Length);
                HeaderBytes = new byte[EEPROM.HEADER_SIZE];
                Array.Clear(this.HeaderBytes, 0, this.HeaderBytes.Length);
                StarPairBytes = new byte[EEPROM.STAR_PAIR_SIZE];
                Array.Clear(this.StarPairBytes, 0, this.StarPairBytes.Length);
                StarIDBytes = new byte[EEPROM.STAR_ID_SIZE];
                Array.Clear(this.StarIDBytes, 0, this.StarIDBytes.Length);
                UvectorBytes = new byte[EEPROM.U_VECTOR_SIZE];
                Array.Clear(this.UvectorBytes, 0, this.UvectorBytes.Length);

                Retries = (int)(Timeout_ms/50);

                // Send Command
                //_____________________________________________________________________________________________________________________
                comm = "<" + Command.ToString() + ">";
                answer = "<" + Command.ToString() + "><ACK>";
                mySerialPort.Write(comm);
                this.textBox1.Text = this.textBox1.Text + "Send Command: " + comm + mySerialPort.NewLine;
                this.Refresh();
                Thread.Sleep(100);

                this.textBox1.Text = this.textBox1.Text + WaitForSerial(answer, Retries);
                this.Refresh();

                // Send Num
                //_____________________________________________________________________________________________________________________
                Num = (int)this.Num.Value;
                switch (Command)
                {
                  case enum_Commands.STORE_STAR_PAIR:
                  case enum_Commands.READ_STAR_PAIR:
                  case enum_Commands.STORE_STAR_ID:
                  case enum_Commands.READ_STAR_ID:
                  case enum_Commands.STORE_UVECTOR:
                  case enum_Commands.READ_UVECTOR:
                    // Send NUM
                    bytes_Num = EEPROM.StructureToByteArray(Num);
                    mySerialPort.Write(bytes_Num, 0, Marshal.SizeOf(typeof(int)));
                    WaitForSerial(Num.ToString(), Retries);
                    break;  
                }

                               
                // Read Data
                //_____________________________________________________________________________________________________________________
                switch (Command)
                {
                    case enum_Commands.READ_CAMERA_CONFIG:
                        this.textBox1.Text = this.textBox1.Text + "Camera Configurarion: " + mySerialPort.NewLine; 
                        buffer = string.Empty;
                        End = false;
                        while (!End)
                        {
                            buffer = buffer + mySerialPort.ReadLine() + mySerialPort.NewLine;
                            End = (buffer.IndexOf("AD_END") >= 0);                    
                        }
                        this.textBox1.Text = this.textBox1.Text + buffer + mySerialPort.NewLine;
                       
                        break;
                    case enum_Commands.CAPTURE_IMAGE_FIFO:                     
                        break;
                    case enum_Commands.READ_IMAGE_FIFO:
                        // Read Image from FIFO
                        string StoredText = this.textBox1.Text;
                        while (Pointer < (this.Pixels))
                        {
                            int indata = mySerialPort.Read(DataArray, Pointer, mySerialPort.BytesToRead);
                            Pointer = Pointer + indata;
                            //this.textBox1.Text = StoredText + "     Read Image: " + Pointer.ToString() + " / " + (this.Pixels).ToString() + " pixels" + mySerialPort.NewLine;
                            //if ((Pointer % 100) == 0)this.textBox1.Refresh();
                            //System.Windows.Forms.Application.DoEvents();
                            //Thread.Sleep(5);
                        }
                        Array.Reverse(this.DataArray);

                        //Bitmap Afoto = ConvertBayerToRgb32(this.Columns, this.Lines, this.DataArray);
                        //Bitmap Afoto = ByteToGrayBitmap(this.DataArray, this.Columns, this.Lines);
                        Image Afoto = byteArrayToImage(this.Columns, this.Lines, this.DataArray);
                        Afoto.Save("myfile.png", ImageFormat.Bmp);

                        //Image Afoto = byteArrayToImageRGB(this.Columns, this.Lines, this.DataArray);
                    //    this.pictureBox1.Image= null;
                        this.pictureBox1.Image = Afoto;
                        this.Pointer = 0;
                        mySerialPort.DiscardInBuffer();
                        break;
                    // __________________________________________________________________
                    // CATALOG HEADER
                    // __________________________________________________________________
                    case enum_Commands.STORE_CATALOG_HEADER:
                        // Send Catalog Header
                        byte[] bytes;
                        bytes = EEPROM.StructureToByteArray(Program.Header);
                        mySerialPort.Write(bytes, 0, EEPROM.HEADER_SIZE);
                        break;
                    case enum_Commands.READ_CATALOG_HEADER:
                        // Read Catalog Header
                        while (Pointer < (EEPROM.HEADER_SIZE))
                        {
                          int indata = mySerialPort.Read(HeaderBytes, Pointer, mySerialPort.BytesToRead);
                            Pointer = Pointer + indata;
                            System.Windows.Forms.Application.DoEvents();
                            Thread.Sleep(5);
                        }
                        this.Pointer = 0;
                        mySerialPort.DiscardInBuffer();
                        EEPROM.HEADER Header_read = new EEPROM.HEADER();                      
                        Header_read = (EEPROM.HEADER)EEPROM.ByteArrayToStructure(HeaderBytes, Header_read);
                        MostrarObjeto(Header_read);
                        break;
                    // __________________________________________________________________
                    // STAR PAIRS
                    // __________________________________________________________________
                    case enum_Commands.STORE_STAR_PAIR:
                        byte[] bytes_pair;
                        bytes_pair = EEPROM.StructureToByteArray(Program.StarPairs[(int)this.Num.Value]);
                        mySerialPort.Write(bytes_pair, 0, EEPROM.STAR_PAIR_SIZE);
                        break;
                    case enum_Commands.READ_STAR_PAIR:
                        while (Pointer < (EEPROM.STAR_PAIR_SIZE))
                        {
                          int indata = mySerialPort.Read(StarPairBytes, Pointer, mySerialPort.BytesToRead);
                            Pointer = Pointer + indata;
                            System.Windows.Forms.Application.DoEvents();
                            Thread.Sleep(5);
                        }
                        this.Pointer = 0;
                        mySerialPort.DiscardInBuffer();
                        EEPROM.StarPair PAIR_read = new EEPROM.StarPair();
                        PAIR_read = (EEPROM.StarPair) EEPROM.ByteArrayToStructure(StarPairBytes, PAIR_read);
                        MostrarObjeto(PAIR_read);
                        break;

                    // __________________________________________________________________
                    // STAR ID
                    // __________________________________________________________________
                    case enum_Commands.STORE_STAR_ID:
                        byte[] bytes_StarID;
                        bytes_StarID = EEPROM.StructureToByteArray(Program.StarIDs[(int)this.Num.Value]);
                        mySerialPort.Write(bytes_StarID, 0, EEPROM.STAR_ID_SIZE);
                        break;
                    case enum_Commands.READ_STAR_ID:
                        while (Pointer < (EEPROM.STAR_ID_SIZE))
                        {
                          int indata = mySerialPort.Read(StarIDBytes, Pointer, mySerialPort.BytesToRead);
                          Pointer = Pointer + indata;
                          System.Windows.Forms.Application.DoEvents();
                          Thread.Sleep(5);
                        }
                        this.Pointer = 0;
                        mySerialPort.DiscardInBuffer();
                        uint STAR_ID_read = 0;
                        STAR_ID_read = (uint)EEPROM.ByteArrayToStructure(StarIDBytes, STAR_ID_read);
                        this.textBox1.Text = this.textBox1.Text + "StarID: " + STAR_ID_read.ToString() + mySerialPort.NewLine;
                        break;

                    // __________________________________________________________________
                    // U Vectors
                    // __________________________________________________________________
                    case enum_Commands.STORE_UVECTOR:
                        byte[] bytes_uvector;
                        bytes_uvector = EEPROM.StructureToByteArray(Program.StarUvectors[(int)this.Num.Value]);
                        mySerialPort.Write(bytes_uvector, 0, EEPROM.U_VECTOR_SIZE);
                        break;
                    case enum_Commands.READ_UVECTOR:
                        while (Pointer < (EEPROM.U_VECTOR_SIZE))
                        {
                          int indata = mySerialPort.Read(UvectorBytes, Pointer, mySerialPort.BytesToRead);
                          Pointer = Pointer + indata;
                          System.Windows.Forms.Application.DoEvents();
                          Thread.Sleep(5);
                        }
                        this.Pointer = 0;
                        mySerialPort.DiscardInBuffer();
                        EEPROM.unit_vector Uvector_read = new EEPROM.unit_vector();
                        Uvector_read = (EEPROM.unit_vector)EEPROM.ByteArrayToStructure(UvectorBytes, Uvector_read);
                        MostrarObjeto(Uvector_read);
                        break;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }


        bool WaitForSerial(string MatchString, int Retries)
        {
          string buffer = string.Empty;

          // Wait Answer
          //_____________________________________________________________________________________________________________________
          for (int ii = 0; ii < Retries; ii++)
          {
            try
            {
              buffer = mySerialPort.ReadLine();
              if (buffer == MatchString)
              {
                this.textBox1.Text = this.textBox1.Text + "Received Answer: " + MatchString + mySerialPort.NewLine;
                return true;
              }
            }
            catch (TimeoutException) { }
          }
          return false;             
        }


        object fromBytes(byte[] arr)
        {
            object str = new object();

            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            str = (object)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);

            return str;
        }

        private void btn_Prueba_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[640 * 480];
            int oo = 0;
            for (int ii = 0; ii < (480); ii++)
            {
                for (int jj = 0; jj < (640); jj++)
                {
                    bytes[oo] = (byte)((jj * 1) % 255);
                    oo++;
                }
            }
            Image Afoto = byteArrayToImage(640, 480, bytes);
            this.pictureBox1.Image = Afoto;
        }

        private void btn_CameraConfig_Click(object sender, EventArgs e)
        {
            this.SendCommand(enum_Commands.READ_CAMERA_CONFIG,  1000);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
          this.textBox1.Clear();
        }


        private void btn_SendHeader_Click(object sender, EventArgs e)
        {
            OpenFileDialog FilePath = new OpenFileDialog();
            FilePath.Filter = "txt files (*.csv)|*.csv";
            FilePath.RestoreDirectory = true;
            if (FilePath.ShowDialog() == DialogResult.OK)
            {
                Program.Header = EEPROM.ReadHeaderFile(FilePath.FileName);
                this.SendCommand(enum_Commands.STORE_CATALOG_HEADER, 1000);
            }     
        }

        private void btn_SendStarPairs_Click(object sender, EventArgs e)
        { 
            OpenFileDialog FilePath = new OpenFileDialog();
            FilePath.Filter = "txt files (*.csv)|*.csv";
            FilePath.RestoreDirectory = true;
            if (FilePath.ShowDialog() == DialogResult.OK)
            {
              Program.StarPairs = EEPROM.ReadStarPairsFile(FilePath.FileName);
              for (int ii=0; ii<(Program.StarPairs.Count); ii++)
              {
                this.Num.Value = ii;
                this.SendCommand(enum_Commands.STORE_STAR_PAIR, 1000);
                System.Threading.Thread.Sleep(300);
              }
            }     
        }

        private void btn_SendStarIDs_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog FilePath = new OpenFileDialog();
            FilePath.Filter = "txt files (*.csv)|*.csv";
            FilePath.RestoreDirectory = true;
            if (FilePath.ShowDialog() == DialogResult.OK)
            {
                Program.StarIDs = EEPROM.ReadStarIDsFile(FilePath.FileName);
                for (int ii = 0; ii < (Program.StarIDs.Count); ii++)
                {
                  this.Num.Value = ii;
                  this.SendCommand(enum_Commands.STORE_STAR_ID, 1000);
                  System.Threading.Thread.Sleep(300);
                }
            }     
        }

        private void btn_SendUvectors_Click(object sender, EventArgs e)
        {
            OpenFileDialog FilePath = new OpenFileDialog();
            FilePath.Filter = "txt files (*.csv)|*.csv";
            FilePath.RestoreDirectory = true;
            if (FilePath.ShowDialog() == DialogResult.OK)
            {
                Program.StarUvectors = EEPROM.ReadUvectorsFile(FilePath.FileName);
                for (int ii = 0; ii < (Program.StarUvectors.Count); ii++)
                {
                  this.Num.Value = ii;
                  this.SendCommand(enum_Commands.STORE_UVECTOR, 1000);
                  System.Threading.Thread.Sleep(300);
                }
            }
        }

        private void btn_ReadHeader_Click(object sender, EventArgs e)
        {
          this.SendCommand(enum_Commands.READ_CATALOG_HEADER, 1000);
        }

        private void btn_ReadStarPair_Click(object sender, EventArgs e)
        {
          this.SendCommand(enum_Commands.READ_STAR_PAIR, 1000);
        }

        private void btn_ReadStarID_Click(object sender, EventArgs e)
        {
          this.SendCommand(enum_Commands.READ_STAR_ID, 1000);
        }

        private void btn_ReadUvector_Click(object sender, EventArgs e)
        {
          this.SendCommand(enum_Commands.READ_UVECTOR, 1000);
        }

        private void MostrarObjeto(object Objeto)
        {
          this.textBox1.Text = this.textBox1.Text + Objeto.GetType().Name + mySerialPort.NewLine;
          FieldInfo[] fields = Objeto.GetType().GetFields();
          String str = "";
          foreach (FieldInfo f in fields)
          {
            str = "     " + f.Name + " = " + f.GetValue(Objeto) + mySerialPort.NewLine;
            this.textBox1.Text = this.textBox1.Text + str;
          }
        }

        private void Manual_CheckedChanged(object sender, EventArgs e)
        {
          if (Manual.Checked)
          {
            this.btn_CameraConfig.Enabled = true;
            this.btn_Send.Enabled = true;
            this.btn_Receive.Enabled = true;
            this.btn_ReadHeader.Enabled = true;
            this.btn_ReadStarPair.Enabled = true;
            this.btn_ReadStarID.Enabled = true;
            this.btn_ReadUvector.Enabled = true;
            this.btn_SendHeader.Enabled = true;
            this.btn_SendStarPairs.Enabled = true;
            this.btn_SendStarIDs.Enabled = true;
            this.btn_SendUvectors.Enabled = true;
            this.Num.Enabled = true;
              //New Buttons
            this.btn_ReadSD.Enabled = true;
            this.groupBox4.Enabled = true;
            this.SendCommand(enum_Commands.MANUAL_MODE, 1000);
            this.TIMESCAN.Enabled = false; //Hay que inactivarlo al principio también.
          }
          else
          {
            this.btn_CameraConfig.Enabled = false;
            this.btn_Send.Enabled = false;
            this.btn_Receive.Enabled = false;
            this.btn_ReadHeader.Enabled = false;
            this.btn_ReadStarPair.Enabled = false;
            this.btn_ReadStarID.Enabled = false;
            this.btn_ReadUvector.Enabled = false;
            this.btn_SendHeader.Enabled = false;
            this.btn_SendStarPairs.Enabled = false;
            this.btn_SendStarIDs.Enabled = false;
            this.btn_SendUvectors.Enabled = false;
            this.Num.Enabled = false;
            //New Buttons
            this.btn_ReadSD.Enabled = false;
            this.groupBox4.Enabled = false;
            this.SendCommand(enum_Commands.AUTOMATIC_MODE, 1000);
            this.TIMESCAN.Enabled = true;
          }
        }

        private void VGA_CheckedChanged(object sender, EventArgs e)
        {
            if (VGA.Checked)
            {
                this.SendCommand(enum_Commands.RESOLUTION_TYPE_VGA, 1000);
                this.Resolution = enum_Resolution.VGA;
            }
        }

        private void QVGA_CheckedChanged(object sender, EventArgs e)
        {
            if (QVGA.Checked && !QQVGA.Checked && !VGA.Checked)
            {
                this.SendCommand(enum_Commands.RESOLUTION_TYPE_QVGA, 1000);
                this.Resolution = enum_Resolution.QVGA;
            }
        }

        private void QQVGA_CheckedChanged(object sender, EventArgs e)
        {
            if (QQVGA.Checked)
            {
                this.SendCommand(enum_Commands.RESOLUTION_TYPE_QQVGA, 1000);
                this.Resolution = enum_Resolution.QQVGA;
            }
        }

        private void TIMESCAN_ValueChanged(object sender, EventArgs e)
        {
           // int tiemposcaneo = (int) this.TIMESCAN.Value;
           // byte[] tiemposcaneo1 = tiemposcaneo;
            mySerialPort.Write(this.TIMESCAN.Value.ToString());

        }



        #region MENU

        private void menuConfig_Camera_Click(object sender, EventArgs e)
        {
            frmCameraConfig CameraConfigForm = new frmCameraConfig();
            if (CameraConfigForm.ShowCameraConfig(ref Program.CameraConfig, ref Program.Config_File, ref Program.AcquisitionConfig))
            {
                Program.SaveConfigFile();
                Program.SaveConfig();
            }

      
        }


        private void menuConfig_Acquistion_Click(object sender, EventArgs e)
        {
            frmAqusitionConfig AcquisitionConfigForm = new frmAqusitionConfig();
            if (AcquisitionConfigForm.ShowAcquisitionConfig(ref Program.AcquisitionConfig, ref Program.Config_File, ref Program.CameraConfig))
            {
                Program.SaveConfigFile();
                Program.SaveConfig();
            }
          

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowSerialPorts();
        }
        private void ShowSerialPorts()
        {
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
        }



    }
}
