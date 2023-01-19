
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GloveDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class SQLite Connection");
            MySQLiteConnection m = new MySQLiteConnection();
            SQLiteConnection s = m.GetConnection();
            m.CloseConnection();
        }

    }
}
