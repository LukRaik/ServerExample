using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ServerDrawOnline
{
    class TcpServer
    {
        TcpListener serwer;
        int port;
        public List<TcpUser> lista_polaczen = new List<TcpUser>();
        public EventHandler ZnalezionoKlienta;
        public EventHandler RozlaczonoKlienta;
        public EventHandler Loguje;
        public TcpServer(int port)
        {
            serwer = new TcpListener(port);
            this.port = port;
            
        }
        public void TcpServerStart()
        {
            serwer.Start();
        }
        public void TcpServerShutdown()
        {
            if (lista_polaczen.Count > 0)
            {
                foreach (TcpUser obj in lista_polaczen)
                {
                    obj.Disconnect();
                }
                serwer.Stop();
            }
        }
        public void Szukaj()
        {
            TcpClient user = serwer.AcceptTcpClient();
            TcpUser uzytkownik = new TcpUser(user);
            uzytkownik.Loguje += Loguje;
            uzytkownik.DisconnectEvent += RozlaczonoKlienta;
            if (uzytkownik.Auth() == true)
            {
                if(ZnalezionoKlienta!=null)ZnalezionoKlienta(uzytkownik, new StringEventArgs("CONNECTED"));
                lista_polaczen.Add(uzytkownik);
                uzytkownik.worker.RunWorkerAsync();
            }
        }
    }
}
