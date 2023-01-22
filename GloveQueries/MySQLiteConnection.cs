
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GloveDatabase
{
    class MySQLiteConnection
    {
        
        // You need to change this argument due the SQLite Database is an archive!
        private string Source = "D:/Proyectos Visual Studio/GloveAnalytics/GloveQueries/GloveTest.db";
        private SQLiteConnection? Instance = null;

        public SQLiteConnection GetConnection()
        {
            if (Instance == null)
            {
                Instance = new SQLiteConnection("Data Source = " + Source);
                // Console.WriteLine("Data Source = " + Source);
            }
            // Console.WriteLine("Abierto");
            return Instance;
        }

        public void CloseConnection()
        {
            if (Instance != null)
            {
                Instance.Close();
                Instance = null;
            }
            // Console.WriteLine("Cerrado");
        }

    }
}
