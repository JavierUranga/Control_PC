using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DEFS;

namespace ReadSerial.FORMS
{
    public partial class frmAqusitionConfig : Form
    {
        Firmw_Config_Acquisition AcqConfig;
        string ConfigFile = string.Empty;
        bool Return = false;
        bool Cancel = false;

        public frmAqusitionConfig()
        {
            InitializeComponent();
        }

        public bool ShowAcquisitionConfig(ref Firmw_Config_Acquisition AcquisitionConfig, ref string ConfigurationFile, ref Firmw_Config_Camera CameraConfig)
        {
            this.AcqConfig = AcquisitionConfig;
            this.ConfigFile = ConfigurationFile;
            this.lbl_Config.Text = this.ConfigFile;

            this.lbl_Resolution.Text = CameraConfig.Resolution.ToString();
            this.lbl_Gain.Text = CameraConfig.Gain.ToString();
            this.lbl_Exposure_Time.Text = CameraConfig.Exposure_Time.ToString();
            

            this.RefreshConfig();
            this.ShowDialog();
            if (this.Return == true && this.Cancel == false)
            {

                int Pos = this.ConfigFile.LastIndexOf('\\') + 1;
                int finalpos = this.ConfigFile.LastIndexOf('.');   //Añadido para intertar quitar el .ini. y asi cuando se guarda dos veces no se come parte de la configuración al poner el -4
                if (finalpos > 0)
                {
                    this.ConfigFile = this.ConfigFile.Remove(finalpos);
                }
                ConfigurationFile = this.ConfigFile.Substring(Pos, this.ConfigFile.Length - Pos);
                //ConfigurationFile = this.ConfigFile.Substring(Pos, this.ConfigFile.Length - Pos - 4);
                //ConfigurationFile = this.ConfigFile;

                this.AcqConfig.TimeInterval_seg = Convert.ToUInt16(this.numbox_Time_Interval.Value);
                this.AcqConfig.TimeScan_min = Convert.ToUInt16(this.numbox_Time_Scan.Value);
                AcquisitionConfig = this.AcqConfig;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Return = false;
            this.Cancel = true;
            this.Close();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Return = true;
            this.Cancel = false;
            this.Close();
        }

        private void RefreshConfig()
        {
            this.numbox_Time_Interval.Value = Program.AcquisitionConfig.TimeInterval_seg;
            this.numbox_Time_Scan.Value = Program.AcquisitionConfig.TimeScan_min;
        }

        private void btn_SaveCameraConfig_Click(object sender, EventArgs e)
        {
            SaveFileDialog NewFile = new SaveFileDialog ();
            NewFile.Filter = "ini files (*.ini)|*.ini";
            NewFile.InitialDirectory = Program.INI_PATH_CAMERA;
            //FilePath.RestoreDirectory = true;
            if (NewFile.ShowDialog() == DialogResult.OK)
            {
                this.ConfigFile = NewFile.FileName;
                this.Return = true;
                this.Cancel = false;
                this.Close();
            }
        }
    }

}
