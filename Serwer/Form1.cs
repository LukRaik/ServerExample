using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerDrawOnline
{
    public partial class Form1 : Form
    {
        static public List<TcpUser> lista_destrukcji = new List<TcpUser>();
        static public List<string> Msg_To_Send = new List<string>();
        EventHandler Loguj;
        EventHandler DodajDoBoxa;
        EventHandler UsunZBoxa;
        TcpServer serwer;
        public Form1()
        {
            InitializeComponent();
            Loguj += Loguj_text;
            DodajDoBoxa += Dodaj_Do_Boxa;
            UsunZBoxa += Usun_Z_Boxa;
            UserSeeker.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Worker User_Seeker
        private void UserSeeker_DoWork(object sender, DoWorkEventArgs e)
        {
            serwer.Szukaj();
        }
        private void UserSeeker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UserSeeker.RunWorkerAsync();
        }
        #endregion
        #region INVOKES
        // DODAWANIE DO LISTY
        void Dodaj_Do_Boxa(object obj, EventArgs e)
        {
            if (users_list.InvokeRequired == true)
            {
                users_list.Invoke(DodajDoBoxa, new object[] { obj, e });
            }
            else
            {
                users_list.Items.Add((TcpUser)obj);
            }
        }
        // USUWANIE Z LISTY
        void Usun_Z_Boxa(object obj, EventArgs e)
        {
            if (users_list.InvokeRequired == true)
            {
                users_list.Invoke(UsunZBoxa, new object[] { obj, e });
            }
            else
            {
                users_list.Items.Remove((TcpUser)obj);
            }
        }
        // LOGI KONSOLOWE
        void Loguj_text(object obj, EventArgs e)
        {
            if (tx_log.InvokeRequired == true)
            {
                tx_log.Invoke(Loguj, new Object[] { obj, e });
            }
            else
            {
                tx_log.Text += "\n["+ DateTime.Now.ToString() +"]\n"+(string)obj;
                tx_log.ScrollToCaret();
            }
        }
        #endregion
        #region Przyciski
        //START NIE SUGERUJ SIE NAZWA !!
        private void bt_stop_Click(object sender, EventArgs e)
        {
            serwer = new TcpServer((int)num_port.Value);
            serwer.Loguje += Loguj;
            serwer.ZnalezionoKlienta += DodajDoBoxa;
            serwer.ZnalezionoKlienta += SendInfo;
            serwer.RozlaczonoKlienta += UsunZBoxa;
            serwer.TcpServerStart();
            UserSeeker.RunWorkerAsync();
            PackageSender.RunWorkerAsync();
            Loguj("SERWER RUSZYL:" + DateTime.Now.ToString(), null);
        }
        //STOP
        private void bt_start_Click(object sender, EventArgs e)
        {
            UserSeeker.CancelAsync();
            serwer.TcpServerShutdown();
            
            Loguj("SERWER STOP:" + DateTime.Now.ToString(), null);
        }
        #endregion


        private void SendInfo(object sender, EventArgs e)
        {
            foreach (TcpUser obj in serwer.lista_polaczen)
            {
                obj.Pisz("##MSG##["+"Server:" + (e as StringEventArgs).arg + ":" + (sender as TcpUser).Imie + "]");
            }
        }
        private void bt_send_Click(object sender, EventArgs e)
        {
            foreach (TcpUser obj in serwer.lista_polaczen)
            {
                obj.Pisz("##MSG##SERVER:" + tx_send.Text);
            }
        }

        private void PackageSender_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PackageSender.RunWorkerAsync();
        }

        private void PackageSender_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Msg_To_Send.Count > 0)
            {
                foreach (TcpUser obj in serwer.lista_polaczen)
                {
                    obj.Pisz(Msg_To_Send[0]);
                }
                Msg_To_Send.RemoveAt(0);
            }
        }

    }
}
