using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DEFS;

namespace MicroControl.FORMS
{
    public partial class frmCameraConfig : Form
    {
        Firmw_Config_Camera Config;
        string ConfigFile = string.Empty;
        bool Return = false;
        bool Cancel = false;
        public frmCameraConfig()
        {
            InitializeComponent();
        }

       
        public bool ShowCameraConfig(ref Firmw_Config_Camera CameraConfig, ref string ConfigurationFile, ref Firmw_Config_Acquisition AcqConfig)
        {       
            this.Config = CameraConfig;
            this.ConfigFile = ConfigurationFile;
            this.InitControls();
            this.lbl_Config.Text = this.ConfigFile;

            this.RefreshConfig();          
            this.ShowDialog();

            if (this.Return == true && this.Cancel == false)
            {
                Config.Resolution = this.ParseResolution(this.cbox_Resolution.SelectedItem.ToString());
                Config.Gain = this.ParseGain(this.cbox_Gain.SelectedItem.ToString());
                Config.Exposure_Time = this.ParseExposure_Time(this.cbox_Exposure_Time.SelectedItem.ToString());
                CameraConfig = Config;
                int Pos = this.ConfigFile.LastIndexOf('\\') + 1;
                int finalpos = this.ConfigFile.LastIndexOf('.');   //Añadido para intertar quitar el .ini. y asi cuando se guarda dos veces no se come parte de la configuración al poner el -4
                if (finalpos > 0)
                { 
                    this.ConfigFile = this.ConfigFile.Remove(finalpos);  
                }  
                
                //Tiene que estar antes para no sobreescribir en Program.Config_File
                AcqConfig = Program.AuxConfigAcq;  
            

                ConfigurationFile = this.ConfigFile.Substring(Pos, this.ConfigFile.Length - Pos);
                //ConfigurationFile = this.ConfigFile.Substring(Pos, this.ConfigFile.Length - Pos - 4);
                //ConfigurationFile = this.ConfigFile;



                return true;
            }
            else
            {
                return false;
            }
        }

        private void InitControls()
        {
            
            this.cbox_Resolution.Items.AddRange(System.Enum.GetNames(this.Config.Resolution.GetType()));
            //this.cbox_Resolution.SelectedIndex = 0;
            this.cbox_Gain.Items.AddRange(System.Enum.GetNames(this.Config.Gain.GetType()));
           // this.cbox_Gain.SelectedIndex = 0;
            this.cbox_Exposure_Time.Items.AddRange(System.Enum.GetNames(this.Config.Exposure_Time.GetType()));
        }

        private void RefreshConfig()
        {
            if (this.Config.Resolution == DEFS.enum_Resolution.VGA) this.cbox_Resolution.SelectedIndex = 0;
            else if (this.Config.Resolution == DEFS.enum_Resolution.QVGA) this.cbox_Resolution.SelectedIndex = 1;
            else if (this.Config.Resolution == DEFS.enum_Resolution.QQVGA) this.cbox_Resolution.SelectedIndex = 2;

            if (this.Config.Gain == DEFS.enum_Gain.Auto) this.cbox_Gain.SelectedIndex = 0;
            else if (this.Config.Gain == DEFS.enum_Gain.X1) this.cbox_Gain.SelectedIndex = 1;
            else if (this.Config.Gain == DEFS.enum_Gain.X10) this.cbox_Gain.SelectedIndex = 2;
            else if (this.Config.Gain == DEFS.enum_Gain.X100) this.cbox_Gain.SelectedIndex = 3;

            if (this.Config.Exposure_Time == DEFS.enum_Exposure_Time.Auto) this.cbox_Exposure_Time.SelectedIndex= 0;
            else if (this.Config.Exposure_Time == DEFS.enum_Exposure_Time.Short) this.cbox_Exposure_Time.SelectedIndex = 1;
            else if (this.Config.Exposure_Time == DEFS.enum_Exposure_Time.Medium) this.cbox_Exposure_Time.SelectedIndex = 2;
            else if (this.Config.Exposure_Time == DEFS.enum_Exposure_Time.Long) this.cbox_Exposure_Time.SelectedIndex = 3;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Return = true;
            this.Cancel = false;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Return = false;
            this.Cancel = true;
            this.Close();
        }

        private DEFS.enum_Resolution ParseResolution(string Resolution)
        {

            if (Resolution == "VGA") return DEFS.enum_Resolution.VGA;
            else if (Resolution == "QVGA") return DEFS.enum_Resolution.QVGA;
            else if (Resolution == "QQVGA") return DEFS.enum_Resolution.QQVGA;
            else return this.Config.Resolution;
        }

        private DEFS.enum_Gain ParseGain(string Gain)
        {

            if (Gain == "Auto") return DEFS.enum_Gain.Auto;
            else if (Gain == "X1") return DEFS.enum_Gain.X1;
            else if (Gain == "X10") return DEFS.enum_Gain.X10;
            else if (Gain == "X100") return DEFS.enum_Gain.X100;
            else return this.Config.Gain;
        }

        private DEFS.enum_Exposure_Time ParseExposure_Time(string Gain)
        {

            if (Gain == "Auto") return DEFS.enum_Exposure_Time.Auto;
            else if (Gain == "Short") return DEFS.enum_Exposure_Time.Short;
            else if (Gain == "Medium") return DEFS.enum_Exposure_Time.Medium;
            else if (Gain == "Long") return DEFS.enum_Exposure_Time.Long;
            else return this.Config.Exposure_Time;
        }

        private void btn_LoadCameraConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog FilePath = new OpenFileDialog();
            FilePath.Filter = "ini files (*.ini)|*.ini";
            FilePath.InitialDirectory = Program.INI_PATH_CAMERA;
            //FilePath.RestoreDirectory = true;
            if (FilePath.ShowDialog() == DialogResult.OK)
            {
                this.ConfigFile = FilePath.FileName;
                this.lbl_Config.Text = this.ConfigFile;
                this.Config = Program.ReadCameraConfig_FullPath_ret(this.ConfigFile);
                this.RefreshConfig(); 
            }     
        }
    }
}
