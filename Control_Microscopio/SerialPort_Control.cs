using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using DEFS;
using AUX;

namespace MicroControl
{
 
    class SerialPort_Control
    {
        private enum enumRX_Status
        {
          WAITING_STX_1,
          WAITING_STX_2,
          WAITING_PARAM,
          WAITING_ETX_2,
        }
        private SerialPort mySerialPort;
        private bool m_PortOpened;
        private byte[] RX_Buffer;
        private int RXptn;
        public sCOMMAND RX_COMMAND;
        public sCOMMAND RX_INFO;
        private enumRX_Status RX_Status;
        //private bool STX_01_ctrl, STX_02_ctrl, ETX_01_ctrl, ETX_02_ctrl;

        public SerialPort_Control()
        {
            mySerialPort = new SerialPort();
            mySerialPort.BaudRate = 250000;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.ReadTimeout = 50;
            mySerialPort.ReadBufferSize = 200000;
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.RX_Buffer = new byte[CONST.BUFFER_SIZE_RX];
            this.RXptn = 0;
            this.RX_COMMAND = new sCOMMAND();
            this.RX_COMMAND.Processed = true;
            this.RX_INFO = new sCOMMAND();
            this.RX_INFO.Processed = true;
            this.RX_Status = enumRX_Status.WAITING_STX_1;
            this.m_PortOpened = false;
        }

        public bool PortOpened
        {
          get { return this.m_PortOpened && mySerialPort.IsOpen; }
        }

        public bool ACK_Received
        {
          get { return (this.RX_COMMAND.Processed = false); }
        }

       /// <summary>
       /// PortNumber en formato  "COM1"
       /// </summary>
       /// <param name="PortNumber">Formato: "COM1"</param>
        public void SetPortNumber(string PortNumber)
        {
          this.mySerialPort.PortName = PortNumber;          
        }

        public void OpenPort()
        {
          try
          {
            mySerialPort.Open();
            this.m_PortOpened = true;
          }
          catch (Exception ex)
          {
            this.m_PortOpened = false;
          }
            
        }
         public void ClosePort()
        {
            mySerialPort.Close();
            this.m_PortOpened = false;
        }

         public void Reset_RX_STATUS()
         {
           this.RX_Status = enumRX_Status.WAITING_STX_1;
         }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {          
          SerialPort sp = (SerialPort)sender;
          byte[] indata = Encoding.ASCII.GetBytes(sp.ReadExisting());
          for (int ii = 0; ii < indata.Length; ii++)
          {
            switch (this.RX_Status)
            {
              //STX_1
              case enumRX_Status.WAITING_STX_1:
                if (indata[ii] == CONST.STX_1) this.RX_Status = enumRX_Status.WAITING_STX_2;
                break;

              //STX_2
              case enumRX_Status.WAITING_STX_2:
                if (indata[ii] == CONST.STX_2)
                {
                  this.RX_COMMAND.Processed = true;
                  this.RXptn = 0;
                  this.RX_Buffer = new byte[CONST.BUFFER_SIZE_RX];
                  TO_RXBuffer(CONST.STX_1);
                  TO_RXBuffer(indata[ii]);
                  this.RX_Status = enumRX_Status.WAITING_PARAM;
                }
                else if (indata[ii] == CONST.STX_2)
                  this.RX_Status = enumRX_Status.WAITING_STX_2;
                else this.RX_Status = enumRX_Status.WAITING_STX_1;
                break;

              //PARAM
              case enumRX_Status.WAITING_PARAM:
                if (indata[ii] == CONST.ETX_1)
                {
                  this.RX_Status = enumRX_Status.WAITING_ETX_2;
                }
                TO_RXBuffer(indata[ii]);
                break;

              //ETX_2
              case enumRX_Status.WAITING_ETX_2:
                if (indata[ii] == CONST.ETX_2)
                {
                  TO_RXBuffer(indata[ii]);
                  if (this.CheckRXBufferData())
                  {
                    if (this.IsInfoPacket()) this.RXBuffer_to_RX_INFO();
                    else this.RXBuffer_to_RXCommand();
                  }                 
                  else MessageBox.Show("RXBuffer DATA ERROR!!!");
                  this.RX_Status = enumRX_Status.WAITING_STX_1;
                }
                else
                {
                  TO_RXBuffer(indata[ii]);
                  this.RX_Status = enumRX_Status.WAITING_PARAM;
                }
                break;
            }

          }// for

        }//function

      private void TO_RXBuffer(byte DATA)
      {
        if (this.RXptn < RX_Buffer.Length) this.RX_Buffer[this.RXptn++] = DATA;
        else this.RX_Status = enumRX_Status.WAITING_STX_1;
      }

     private bool CheckRXBufferData()
      {
	      //SIZE
        if (this.RXptn < 5) return false; // STX(2) + CMD(1) +ETX(2)
	      //STX
	      if (this.RX_Buffer[0] != CONST.STX_1) return false;
	      if (this.RX_Buffer[1] != CONST.STX_2) return false;
	      //ETX
	      if (this.RX_Buffer[this.RXptn -2] != CONST.ETX_1)  	return false;
	      if (this.RX_Buffer[this.RXptn -1] != CONST.ETX_2)		return false;
	      return true;
      }

      private bool IsInfoPacket()
      {
        if (( this.RX_Buffer[CONST.CMD_POSITION] == CONST.INF) || 
             (this.RX_Buffer[CONST.CMD_POSITION] == CONST.DBG_INF)) 
          return true; 
        else return false;
      }

      private void RXBuffer_to_RXCommand()
      {
 	      //COMMAND
        this.RX_COMMAND.CMD = this.RX_Buffer[CONST.CMD_POSITION];

        //ACK
        this.RX_COMMAND.ACK = this.RX_Buffer[CONST.ACK_POSITION];

	      //ParamSize
        this.RX_COMMAND.ParamSize = this.RXptn - 6;

	      //DATA
        this.RX_COMMAND.PARAM = new byte[this.RX_COMMAND.ParamSize];
        Array.Copy(this.RX_Buffer, CONST.PARAM_START_POS, this.RX_COMMAND.PARAM, 0, this.RX_COMMAND.ParamSize);
        this.RX_COMMAND.Processed = false;
      }

      private void RXBuffer_to_RX_INFO()
      {
        //COMMAND
        this.RX_INFO.CMD = this.RX_Buffer[CONST.CMD_POSITION];

        //ParamSize
        this.RX_INFO.ParamSize = this.RXptn - 5;

        //DATA
        this.RX_INFO.PARAM = new byte[this.RX_INFO.ParamSize];
        Array.Copy(this.RX_Buffer, CONST.INFO_PARAM_START_POS, this.RX_INFO.PARAM, 0, this.RX_INFO.ParamSize);
        this.RX_INFO.Processed = false;
      }

        public bool SendCommand(sCOMMAND Comando)
        {
          try
          {
            if (this.m_PortOpened && mySerialPort.IsOpen)
            {
              this.mySerialPort.Write(AUX_Functions.StructureToByteArray(Comando), 0, Comando.ParamSize + 5);
              return true;
            }
            else return false;
          }
          catch (Exception ex)
          {
            return false;
          }
        }

    
    }
}
