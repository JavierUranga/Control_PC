using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using MicroControl;


namespace AUX
{
  static class AUX_Functions
  {
    public static byte[] StructureToByteArray(object obj)
    {
      int len = Marshal.SizeOf(obj);
      byte[] arr = new byte[len];
      IntPtr ptr = Marshal.AllocHGlobal(len);
      Marshal.StructureToPtr(obj, ptr, true);
      Marshal.Copy(ptr, arr, 0, len);
      Marshal.FreeHGlobal(ptr);
      return arr;
    }

    public static object ByteArrayToStructure(byte[] bytearray, object structureObj)
    {
      int length = Marshal.SizeOf(structureObj);
      IntPtr ptr = Marshal.AllocHGlobal(length);
      Marshal.Copy(bytearray, 0, ptr, length);
      structureObj = Marshal.PtrToStructure(Marshal.UnsafeAddrOfPinnedArrayElement(bytearray, 0), structureObj.GetType());
      Marshal.FreeHGlobal(ptr);
      return structureObj;
    }

    public static void ShowDebugInfoERROR(bool inMessageBox, string Message)
    {
      Message = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " -- " + "ERROR: " + Message;
      if (inMessageBox)
         MessageBox.Show(Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
        Program.frmMainForm.ShowTextInfo(Message);
    }

    public static void ShowDebugInfo(bool inMessageBox, string Message)
    {
      Message = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " -- " + Message;
      if (inMessageBox)
        MessageBox.Show(Message);
      else
        Program.frmMainForm.ShowTextInfo(Message);
    }

    public static void Enqueue_Command(DEFS.sCOMMAND Comando)
    {
      if (Program.CicloControl.SerialPortOpened) Program.TX_Commands.Enqueue(Comando);     
    }


  }

  public class TimerEspera
    {
        int m_TiempoTranscurrido;
        int m_TiempoEspera;
        DateTime Date_Start;
        DateTime Date_Actual;
        TimeSpan interval;

        bool m_Iniciado;
        bool m_alcanzado;

        public TimerEspera()
        {
        }
        /// <summary>
        /// Tiempo Espera en Segundos
        /// </summary>
        /// <param name="TiempoEspera"></param>
        public TimerEspera(int TiempoEspera)
        {
            this.m_TiempoEspera = TiempoEspera;
        }

        /// <summary>
        /// Tiempo Espera en Segundos
        /// </summary>
        public int TiempoEspera
        {
            get { return m_TiempoEspera; }
            set { m_TiempoEspera = value; }
        }

        public void Start()
        {
            this.m_TiempoTranscurrido = 0;
            Date_Start = DateTime.Now;
            this.m_Iniciado = true;
        }

        public void Stop()
        {
            this.m_TiempoTranscurrido = 0;
            this.m_Iniciado = false;
        }

        public void Reset()
        {
            this.m_TiempoTranscurrido = 0;
            m_alcanzado = false;
        }

        /// <summary>
        /// Determina si se ha alcanzado el Tiempo de Espera configurado
        /// </summary>
        public bool Alcanzado
        {
            get
            {
                if (this.m_Iniciado)
                {
                    this.Date_Actual = DateTime.Now;
                    this.interval = Date_Actual - Date_Start;
                    if ((int)this.interval.TotalSeconds >= this.m_TiempoEspera)
                    {
                        m_alcanzado = true;
                    }
                    else
                    {
                        m_alcanzado = false;
                    }
                }
                else
                {
                    m_alcanzado = false;
                }

                return m_alcanzado;
            }
        }

        /// <summary>
        /// Determina el tiempo transcurrido desde el Start en SEGUNDOS
        /// </summary>
        public int TiempoTranscurrido
        {
            get
            {
                if (this.m_Iniciado)
                {
                    this.Date_Actual = DateTime.Now;
                    this.interval = Date_Actual - Date_Start;
                    this.m_TiempoTranscurrido = (int)this.interval.TotalSeconds;
                }
                else
                {
                    this.m_TiempoTranscurrido = 0;
                }

                return this.m_TiempoTranscurrido;
            }
        }

        public bool Iniciado
        {
            get { return m_Iniciado; }
        }



    }

  
}

