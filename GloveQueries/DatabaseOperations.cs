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
    #pragma warning disable CS8604
    public class DatabaseOperations
    {

        private static MySQLiteConnection mSql = new MySQLiteConnection();
        private static SQLiteConnection sCon = mSql.GetConnection();
        private static SQLiteCommand mCommand;
        private static SQLiteDataReader mDataReader;

        public static void InitializeDatabase()
        {

            // Database have to contain the Active, Deleted and Playing Status

            sCon.Open();
            string activeStatus = "INSERT INTO Estado VALUES(1, 'Activo', 1);";
            mCommand = new SQLiteCommand(activeStatus, sCon);
            mCommand.ExecuteReader();
            sCon.Close();
            InsertRecord(new Status("Eliminado", 1));
            InsertRecord(new Status("Jugando", 1));

        }

        public static void InsertRecord(Recordable newRecord)
        {

            sCon.Open();
            string query = "INSERT INTO " + newRecord.getTableName() + "(" + newRecord.getFieldsWithCommas() + ") VALUES(" + newRecord.mergedWithCommas() + ");";
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteNonQuery();
            sCon.Close();

        }

        public static void DeleteRecord(string table, int recordId)
        {

        }

        public static int RecoverAnId(string table, string idField, string uniqueField, string uniqueValue)
        {
            
            int recoveredId = -1;
            sCon.Open();
            string query = "SELECT " + idField + " FROM " + table + " WHERE " + uniqueField + " = " + uniqueValue;
            mCommand = new SQLiteCommand(query, sCon);
            mDataReader = mCommand.ExecuteReader();
            if (mDataReader.Read())
            {
                recoveredId = int.Parse(Convert.ToString(mDataReader[0]));
            }
            mDataReader.Close();
            sCon.Close();
            return recoveredId;

        }

    }

}
