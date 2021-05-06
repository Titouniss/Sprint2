using System;
using System.Threading;
using LoupGarou;

namespace test
{
    class Program
    {
        public static Plateforme plat = new Plateforme();
        static void Main(string[] args)
        {
            Thread leTread = new Thread(new ThreadStart(CommunicationClient));
            leTread.Start();
        }
        public static void CommunicationClient()
        {
            Client l = new Client("127.0.0.1", 2021, "Thais");
            l.Run();
        }
    }
}
