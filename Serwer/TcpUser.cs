using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace ServerDrawOnline
{
    public class TcpUser
    {
        TcpClient klient;
        NetworkStream strumien;
        BinaryReader klient_czytaj;
        BinaryWriter klient_pisz;
        public string Imie { get; private set; }
        bool authorised;
        public BackgroundWorker worker;
        public EventHandler Loguje;
        public EventHandler DisconnectEvent;
        bool petla = true;
        public TcpUser(TcpClient klient)
        {
            this.klient = klient;
            strumien = klient.GetStream();
            klient_czytaj = new BinaryReader(strumien);
            klient_pisz = new BinaryWriter(strumien);
            authorised = false;
            worker = new BackgroundWorker();
            worker.DoWork += Worker_Do;
            worker.RunWorkerCompleted += Worker_End;
            worker.WorkerSupportsCancellation = true;

        }
        public bool Auth()
        {
            try
            {
                klient_pisz.Write("##AUTH##");
                string buffor = klient_czytaj.ReadString();
                if (buffor.Contains("##AUTH##"))
                {
                    authorised = true;
                    Imie = buffor.Substring(8);
                    if (Loguje != null) 
                    Loguje("Polaczono z " + Imie + " " + klient.Client.RemoteEndPoint.ToString(),null);
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Błąd Autoryzacji");
                
            }
            return false;
        }
        public void Disconnect()
        {
            try
            {
                if (Loguje != null) 
                Loguje("Rozlaczono z " + Imie + " " + klient.Client.RemoteEndPoint.ToString(), null);
                worker.CancelAsync();
                klient_pisz.Write("##EXIT##");
                klient_pisz.Close();
                klient_czytaj.Close();
                strumien.Close();
                klient.Close();
                Form1.lista_destrukcji.Add(this);
            }
            catch
            {

            }
        }
        public void Pisz(string text)
        {
            klient_pisz.Write(text);
        }
        public string Czytaj()
        {
            return klient_czytaj.ReadString();
        }
        public void Worker_Do(object obj,EventArgs e)
        {
            string buffor = Czytaj();
            if (buffor.Contains("##EXIT##"))
            {
                if (DisconnectEvent != null) DisconnectEvent(this, null);
                petla = false;
                Disconnect();
            }
            if (buffor.Contains("##PIXEL##"))
            {
                Loguje(buffor, null);
                Form1.Msg_To_Send.Add(buffor);

            }
            if (buffor.Contains("##DELPIXEL##"))
            {
                Loguje(buffor, null);
                Form1.Msg_To_Send.Add(buffor);

            }
        }
        public void Worker_End(object obj, EventArgs e)
        {
            if (petla == true) worker.RunWorkerAsync();
        }
        public override string ToString()
        {
            string buffor ="["+ Imie+"]"+klient.Client.RemoteEndPoint.ToString();
            return buffor;
        }
    }
}
