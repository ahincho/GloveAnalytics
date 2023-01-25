
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

        private static string AppPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "/");
        private static string BasePath = AppPath.Substring(0, AppPath.IndexOf("/GloveForms"));
        private string Source = "/GloveQueries/GloveTest.db";
        private SQLiteConnection? Instance = null;

        public SQLiteConnection GetConnection()
        {
            if (Instance == null)
            {
                Instance = new SQLiteConnection("Data Source = " + BasePath + Source);
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
