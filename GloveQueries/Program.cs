
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using GloveClasses;

namespace GloveDatabase
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // This is a pretty and quick testing of the SQLConnection
            // If you wanna try, just delete the comment annotation

            /*
            Console.WriteLine("Class SQLite Connection");
            MySQLiteConnection m = new MySQLiteConnection();
            SQLiteConnection s = m.GetConnection();
            m.CloseConnection();
            */

            // Here we are testing the created Entities to manage the
            // objects or records that we need to save in the Database

            /*
            HandAngles h = new HandAngles(0.25f, 0.25f, 0.25f, 0.25f, 0.25f);
            Console.WriteLine(h.mergedWithCommas());
            Session a = new Session(1, 1, "19/01/2023", 10.5f, 50.0f, 100, 3, h, 1);
            Console.WriteLine(a.mergedWithCommas());
            */

        }

    }
}
