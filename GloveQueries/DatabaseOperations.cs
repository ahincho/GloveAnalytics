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
    public class DatabaseOperations
    {

        private static MySQLiteConnection mSql = new MySQLiteConnection();
        private static SQLiteConnection sCon = mSql.GetConnection();
        private static SQLiteCommand mCommand;

        public static void initializeDatabase()
        {

            // Database have to contain the Active, Deleted and Playing Status

            sCon.Open();
            string activeStatus = "INSERT INTO Estado VALUES(1, 'Activo', 1);";
            mCommand = new SQLiteCommand(activeStatus, sCon);
            mCommand.ExecuteReader();
            sCon.Close();
            insertRecord(new Status("Eliminado", 1));
            insertRecord(new Status("Jugando", 1));

        }

        public static void insertRecord(Recordable newRecord)
        {

            sCon.Open();
            string query = "INSERT INTO " + newRecord.getTableName() + "(" + newRecord.getFieldsWithCommas() + ") VALUES(" + newRecord.mergedWithCommas() + ");";
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteReader();
            sCon.Close();

        }

        public static void deleteRecord(string table, int recordId)
        {

        }

    }

}
