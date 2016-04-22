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

}