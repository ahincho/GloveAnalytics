using GloveDatabase;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveQueries
{
    
    class DatabaseOperations
    {

        private static MySQLiteConnection mSql = new MySQLiteConnection();
        private SQLiteConnection sCon = mSql.GetConnection();

        public static void InitializeDatabase()
        {



        }

    }

}
