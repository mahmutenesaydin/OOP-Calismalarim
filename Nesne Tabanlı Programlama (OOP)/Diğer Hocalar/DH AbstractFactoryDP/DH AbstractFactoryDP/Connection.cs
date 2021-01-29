using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_AbstractFactoryDP
{         //Interface'de olabilir
    public abstract class Connection
    {
        public abstract bool Baglandi();
        public abstract bool Baglanamadi();
        public abstract string Durum
        {
            get;
        }
    }
    public abstract class Command
    {
        public abstract void Execute(string Query);
    }


    public class Db2Connection : Connection
    {
        public override string Durum
        {
            get
            {
                return "Bağlantı durumu";
            }
        }

        public override bool Baglanamadi()
        {
            Console.WriteLine("Db2 Bağlantısı kapatılacak");
            return true;
        }

        public override bool Baglandi()
        {
            Console.WriteLine("Db2 Bağlantısı açılacak");
            return true;
        }
    }

    public class InterbaseConnection : Connection
    {
        public override string Durum
        {
            get
            {
                return "Interface durumu";
            }
        }

        public override bool Baglanamadi()
        {
            Console.WriteLine("Interface Bağlantısı kapatılacak");
            return true;
        }

        public override bool Baglandi()
        {
            Console.WriteLine("Interface Bağlantısı açılacak");
            return true;
        }
    }


    public class Db2Command : Command
    {
        public override void Execute(string Query)
        {
            Console.WriteLine("Db2 Sorgusu çalıştırılır");
        }
    }
    public class InterbaseCommand : Command
    {
        public override void Execute(string Query)
        {
            Console.WriteLine("Interbase Sorgusu çalıştırılır");
        }
    }

    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }

    public class Db2Factory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new Db2Command();
        }

        public override Connection CreateConnection()
        {
            return new Db2Connection();
        }
    }

    public class InterbaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterbaseConnection(); 
        }
    }

    public class Factory
    {
        private DatabaseFactory DatabaseFactory;
        private Connection Conn;
        private Command Cmd;

        public Factory(DatabaseFactory _dtbsFact)
        {
            DatabaseFactory = _dtbsFact;

            Conn = DatabaseFactory.CreateConnection();
            Cmd = DatabaseFactory.CreateCommand();
        }

        public void Start()
        {
            Conn.Baglandi();
            if (Conn.Durum == "Bağlantı durumu")
                Cmd.Execute("Select ...");
        }
    }
}
