using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using DEFS;
using AUX;
using NspGestionDeFicheros;
using Microsoft.VisualBasic;
using System.Collections.Concurrent;

namespace MicroControl
{
    static class Program
    {
      // Definiciones Globales
      public static frmPrincipal frmMainForm;
      public static clsCiclo CicloControl;
      public static ConcurrentQueue<sCOMMAND> TX_Commands;
    

        //Configuraciones
      public const string INI_PATH = "..\\..\\FILES\\Config.ini";
      public const string INI_PATH_CAMERA = "..\\..\\FILES\\CAMERA\\";
      public const string INI_CAMERA_SECTION = "CAMERA";
      public const string INI_ACQUISITION_SECTION = "ACQUISITION";
      public static string Config_File = string.Empty;
      public static string AuxConfig_File = string.Empty;
      public static Firmw_Config_Acquisition AuxConfigAcq;
      public static Firmw_Config_Camera CameraConfig;
      public static Firmw_Config_Acquisition AcquisitionConfig;


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMainForm = new frmPrincipal();

            string CameraFile = string.Empty;
            CameraFile = FuncionesINI.IniGet(Program.INI_PATH, INI_CAMERA_SECTION, "ConfigFile ", "");
            ReadCameraConfig(CameraFile);
           // ReadAcquisitionConfig(CameraFile);

            TX_Commands = new ConcurrentQueue<sCOMMAND>();

            //Start Control Cycle
            CicloControl = new clsCiclo();

            // Start GUI
            Application.Run(frmMainForm);

            //Close Objects
            CicloControl.Dispose();
        }

        public static void ReadCameraConfig(string File)
        {
           Program.Config_File = INI_PATH_CAMERA + File + ".ini";
           Program.CameraConfig.Resolution = (DEFS.enum_Resolution)Convert.ToByte(FuncionesINI.IniGet(Program.Config_File, INI_CAMERA_SECTION, "Resolution", "0"));
           Program.CameraConfig.Gain = (DEFS.enum_Gain)Convert.ToByte(FuncionesINI.IniGet(Program.Config_File, INI_CAMERA_SECTION, "Gain", "0"));
           Program.CameraConfig.Exposure_Time = (DEFS.enum_Exposure_Time)Convert.ToByte(FuncionesINI.IniGet(Program.Config_File, INI_CAMERA_SECTION, "Exposure_Time", "0"));

           Program.AcquisitionConfig.TimeInterval_seg = Convert.ToUInt16(FuncionesINI.IniGet(Program.Config_File, INI_ACQUISITION_SECTION, "Time_Interval", "0"));
           Program.AcquisitionConfig.TimeScan_min = Convert.ToUInt16(FuncionesINI.IniGet(Program.Config_File, INI_ACQUISITION_SECTION, "Time_Scan", "0"));
           Program.AuxConfigAcq = Program.AcquisitionConfig;
        }

        //public static void ReadAcquisitionConfig(string File)
        //{
        //    Program.Config_File = INI_ACQUISITION_SECTION + File + ".ini";
        //    Program.AcquisitionConfig.TimeInterval_seg = Convert.ToUInt16(FuncionesINI.IniGet(Program.Config_File,INI_ACQUISITION_SECTION, "Time_Interval", "0"));
        //    Program.AcquisitionConfig.TimeScan_min = Convert.ToUInt16(FuncionesINI.IniGet(Program.Config_File, INI_ACQUISITION_SECTION, "Time_Scan", "0"));
        //}


        public static void SaveConfigFile()
        {
            FuncionesINI.IniWrite(Program.INI_PATH, INI_CAMERA_SECTION, "ConfigFile ", Program.Config_File);
        }

        //public static void ReadCameraConfig_FullPath(string File)
        //{
        //    Program.CameraConfig_File = File;
        //    Program.CameraConfig.Resolution = (DEFS.enum_Resolution)Convert.ToByte(FuncionesINI.IniGet(Program.CameraConfig_File, INI_CAMERA_SECTION, "Resolution", "0"));
        //}

        public static Firmw_Config_Camera ReadCameraConfig_FullPath_ret(string File)
        {
            Program.AuxConfig_File = File;
            Firmw_Config_Camera AuxConfig = new Firmw_Config_Camera();
            AuxConfig.Resolution = (DEFS.enum_Resolution)Convert.ToByte(FuncionesINI.IniGet(Program.AuxConfig_File, INI_CAMERA_SECTION, "Resolution", "1"));
            AuxConfig.Gain = (DEFS.enum_Gain)Convert.ToByte(FuncionesINI.IniGet(Program.AuxConfig_File, INI_CAMERA_SECTION, "Gain", "0"));
            AuxConfig.Exposure_Time = (DEFS.enum_Exposure_Time)Convert.ToByte(FuncionesINI.IniGet(Program.AuxConfig_File, INI_CAMERA_SECTION, "Exposure_Time", "0"));


            Program.AuxConfigAcq.TimeInterval_seg = Convert.ToUInt16(FuncionesINI.IniGet(Program.AuxConfig_File, INI_ACQUISITION_SECTION, "Time_Interval", "0"));
            Program.AuxConfigAcq.TimeScan_min = Convert.ToUInt16(FuncionesINI.IniGet(Program.AuxConfig_File, INI_ACQUISITION_SECTION, "Time_Scan", "0"));
            return AuxConfig;
        }

        //public static Firmw_Config_Acquisition ReadAcqConfig_FullPath_ret(string File)
        //{
        //    Program.Config_File = File;
        //    Firmw_Config_Acquisition AuxConfigAcq = new Firmw_Config_Acquisition();
        //    AuxConfigAcq.TimeInterval_seg = Convert.ToUInt16(FuncionesINI.IniGet(Program.Config_File, INI_ACQUISITION_SECTION, "Time_Interval", "0"));
        //    AuxConfigAcq.TimeScan_min = Convert.ToUInt16(FuncionesINI.IniGet(Program.Config_File, INI_ACQUISITION_SECTION, "Time_Scan", "0"));
        //    return AuxConfigAcq;
        //}

        public static void SaveConfig()
        {

            FuncionesINI.IniWrite(Program.INI_PATH_CAMERA + Program.Config_File + ".ini", INI_CAMERA_SECTION, "Resolution", ((byte)CameraConfig.Resolution).ToString());
            FuncionesINI.IniWrite(Program.INI_PATH_CAMERA + Program.Config_File + ".ini", INI_CAMERA_SECTION, "Gain", ((byte)CameraConfig.Gain).ToString());
            FuncionesINI.IniWrite(Program.INI_PATH_CAMERA + Program.Config_File + ".ini", INI_CAMERA_SECTION, "Exposure_Time", ((byte)CameraConfig.Exposure_Time).ToString());

            FuncionesINI.IniWrite(Program.INI_PATH_CAMERA + Program.Config_File + ".ini", INI_ACQUISITION_SECTION, "Time_Interval",AcquisitionConfig.TimeInterval_seg.ToString());
            FuncionesINI.IniWrite(Program.INI_PATH_CAMERA + Program.Config_File + ".ini", INI_ACQUISITION_SECTION, "Time_Scan", AcquisitionConfig.TimeScan_min.ToString());

        }
      
    }
}
