using GloveClasses;
using GloveDatabase;
using GloveInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveQueries
{

    #pragma warning disable CS8618
    class DatabaseOperations
    {

        private static MySQLiteConnection mSql = new MySQLiteConnection();
        private static SQLiteConnection sCon = mSql.GetConnection();
        private static SQLiteCommand mCommand;

        public static void initializeDatabase()
        {

            // Database have to contain the Active status

            sCon.Open();
            string firstStatus = "INSERT INTO Estado VALUES(1, 'Activo', 1);";
            mCommand = new SQLiteCommand(firstStatus, sCon);
            mCommand.ExecuteReader();
            sCon.Close();

        }

        public static void insertRecord(Recordable newRecord)
        {

            sCon.Open();
            string query = "INSERT INTO " + newRecord.getTableName() + "(" + newRecord.getFieldsWithCommas() + ") VALUES(" + newRecord.mergedWithCommas() + ");";
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteReader();
            sCon.Close();

        }

        public static void deleteRecord(int recordId)
        {

        }

    }

}
