using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using DEFS;
using AUX;

namespace MicroControl
{
  
  class clsCiclo
  {
      //Control de ciclo 
      private TimerEspera T_EsperaACK;
      private bool PararCiclo;
      private enumCiclo EstadoCiclo;
      private System.Timers.Timer T_Watchdog;
      DEFS.sCOMMAND Wdg_Comando;

      //Hebra
      private Thread Hebra;

      //Comunicación Serie
      private SerialPort_Control SerialPort;

      public bool SerialPortOpened
      {
        get { return this.SerialPort.PortOpened; }
      }

      public clsCiclo()
      {
          this.SerialPort = new SerialPort_Control();
          this.SerialPort.SetPortNumber("COM4");
          this.SerialPort.OpenPort();
          this.T_EsperaACK = new TimerEspera();
          this.EstadoCiclo = enumCiclo.WAIT_COMAND;
          this.ArrancaCiclo();
          //WatchDog
          Wdg_Comando = new DEFS.sCOMMAND();
          Wdg_Comando.CMD = CONST.CMD_WATCH_DOG;
          Wdg_Comando.PARAM = new byte[1];
          Wdg_Comando.PARAM[0] = 0;
          T_Watchdog = new System.Timers.Timer(CONST.WATCHDOG_TIME_ms);
          T_Watchdog.Elapsed += Callback_WatchDogTimer;
          T_Watchdog.AutoReset = true;
          T_Watchdog.Enabled = false;      
      }

      private void Callback_WatchDogTimer(Object source, ElapsedEventArgs e)
      {
        //AUX_Functions.ShowDebugInfo(false, "PROCESANDO COMANDO: " + 66.ToString());
        //AUX_Functions.ShowDebugInfoERROR(false, "ENVIANDO COMANDO: " + 66.ToString());

        if ((this.EstadoCiclo == enumCiclo.WAIT_COMAND) && this.SerialPort.PortOpened)
        {
          Wdg_Comando.PARAM[0] =(byte) (++Wdg_Comando.PARAM[0] % 2);
         AUX_Functions.Enqueue_Command(Wdg_Comando);
        }
      }

      public void Dispose()
      {
          //Hebra de ciclo
          this.PararCiclo = true;
          if (!(this.Hebra == null)) this.Hebra.Join();
          this.SerialPort.ClosePort();
      }

      private void Ciclo()
      {
         DEFS.sCOMMAND TXComando = new sCOMMAND();

          while (!this.PararCiclo)
          {
              try
              {
                if (this.SerialPort.PortOpened)
                {
                   switch (this.EstadoCiclo)
                  {
                    case enumCiclo.WAIT_COMAND:
                      if (Program.TX_Commands.TryDequeue(out TXComando))
                      {
                        //NEW COMMAND
                        AUX_Functions.ShowDebugInfo(false, "PROCESANDO COMANDO: " + TXComando.CMD.ToString());
                        this.EstadoCiclo = enumCiclo.SEND_COMMAND;
                      }
                      break;
                    case enumCiclo.SEND_COMMAND:
                      if (this.SerialPort.SendCommand(TXComando))
                      {
                        this.T_EsperaACK.Stop();
                        this.T_EsperaACK.Reset();
                        this.T_EsperaACK.Start();
                        this.EstadoCiclo = enumCiclo.WAIT_ACK;
                      }
                      else
                      {
                        AUX_Functions.ShowDebugInfoERROR(false, "ENVIANDO COMANDO: " + TXComando.CMD.ToString());
                        this.EstadoCiclo = enumCiclo.WAIT_COMAND;
                      }
                      break;
                    case enumCiclo.WAIT_ACK:
                      if (this.T_EsperaACK.Alcanzado)
                      {
                        this.SerialPort.Reset_RX_STATUS();
                        AUX_Functions.ShowDebugInfoERROR(false, "TIEMOUT ESPERANDO ACK COMANDO: " + TXComando.CMD.ToString());
                        this.EstadoCiclo = enumCiclo.WAIT_COMAND;
                      }
                      else
                      {
                        if (this.SerialPort.ACK_Received)
                        {
                          //Comprobar coherencia ComandoEnviado <=> ACK_ComandoRecibido
                          if (TXComando.CMD == (0xFF - this.SerialPort.RX_COMMAND.CMD)) //AÑADIR VERIFICACIÓN TAMAÑO PARAMETROS Y ACK
                          {
                            //Proceder a procesar los datos recibidos
                          }
                          else AUX_Functions.ShowDebugInfoERROR(false, "ENVIADO COMANDO: " + TXComando.CMD.ToString() + " Recibido ACK: " + (0xFF - this.SerialPort.RX_COMMAND.CMD).ToString());
                          this.EstadoCiclo = enumCiclo.WAIT_COMAND;
                        }
                      }
                      
                      break;
                  }// END SWITCH  
           
                  //PROCESS INFO PACKETS
                   this.ProcessInfoPackets();
                }           
              
                Thread.Sleep(10);
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message + ex.StackTrace);
                  this.EstadoCiclo = enumCiclo.WAIT_COMAND;
              }
          }//END WHILE                    

      }//END FUNCIÓN Ciclo

      private void ArrancaCiclo()
      {
          this.Hebra = new Thread(new ThreadStart(Ciclo));
          this.Hebra.Start();
      }

      private void ProcessInfoPackets()
      {
        if (this.SerialPort.RX_INFO.Processed == false)
        {
          AUX_Functions.ShowDebugInfo(false, "FW DBG INFO: " + Encoding.ASCII.GetString(this.SerialPort.RX_INFO.PARAM));
          this.SerialPort.RX_INFO.Processed = true;
        }
      }
  }// End CLASS

}//End NAMESPACE
