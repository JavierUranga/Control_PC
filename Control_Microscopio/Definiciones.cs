using System;

namespace DEFS
{
     public enum enum_Resolution :  byte
    {
        VGA = 1,
        QVGA = 2,
        QQVGA = 3
    }

     public enum enum_Gain : byte
     {
         Auto = 0,
         X1 = 1,
         X10 = 2,
         X100 = 3
     }

    public enum enum_Exposure_Time : byte
     {
         Auto = 0,
         Short = 1,
         Medium = 2,
         Long = 3
     }

    public struct Firmw_Config_Acquisition 
    {
        public UInt16 TimeInterval_seg;
        public UInt16 TimeScan_min;
    }

    public struct Firmw_Config_Camera
    {
        public enum_Resolution Resolution;
        public enum_Gain Gain;
        public enum_Exposure_Time Exposure_Time;
    }

    public struct sCOMMAND
    {
      public bool Processed;
      public byte CMD;
      public byte ACK;  //Only RX packets
      public byte[] PARAM;
      public int ParamSize;
    }
  
  public static class CONST
  {
  /* **************************************************************
    ***                                                        ***
    ***                  COMUNICATIONS                          ***
    ***                                                        ***
    **************************************************************/
  public static Int16 STX             = 0x4161;  //Aa
  public static byte STX_1            = (byte)(STX >> 8);
  public static byte STX_2            = (byte)(STX);

  public static Int16 ETX             = 0x4262; //Bb
  public static byte ETX_1            = (byte)(ETX >> 8);
  public static byte ETX_2            = (byte)(ETX); 

  public const int    BUFFER_SIZE_RX  = 310000;
  public const int    BUFFER_SIZE_TX  = 100;
  public const byte   STX_1_POS       = 0;
  public const byte   STX_2_POS       = 1;
  public const int    CMD_POSITION    = 2;
  public const int    ACK_POSITION    = 3;
  public const byte   PARAM_START_POS = 4;
  public const byte   INFO_PARAM_START_POS = 3;

  public const int WATCHDOG_TIME_ms = 2000;
  public const byte CMD_WATCH_DOG   = 69;
  public const byte DBG_INF         = 63;
  public const byte INF             = 63;

 }

  public enum enumCiclo
  {
    WAIT_COMAND,
    SEND_COMMAND,
    WAIT_ACK
  }
}