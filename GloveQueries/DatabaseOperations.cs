
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

    #pragma warning disable CS8618, CS8604, IDE0090
    public class DatabaseOperations
    {

        private readonly static MySQLiteConnection mSql = new MySQLiteConnection();
        private readonly static SQLiteConnection sCon = mSql.GetConnection();
        private static SQLiteCommand mCommand;
        private static SQLiteDataReader mDataReader;

        public static void InitializeDatabase()
        {

            // Database have to contain the Active, Deleted and Playing Status

            int activeStatusId = RecoverAnId("Estado", "EstId", "EstNombre", "Activo");
            if (activeStatusId == -1)
            {
                string insertActiveQuery = "INSERT INTO Estado VALUES(1, 'Activo', 1);";
                sCon.Open();
                mCommand = new SQLiteCommand(insertActiveQuery, sCon);
                mCommand.ExecuteNonQuery();
                sCon.Close();
                InsertRecord(new Status("Eliminado", 1));
                InsertRecord(new Status("Jugando", 1));
            }

        }

        public static void InsertRecord(IRecordable newRecord)
        {

            string query = "INSERT INTO " + newRecord.GetTableName() + "(" + newRecord.GetFieldsWithCommas() + ") VALUES(" + newRecord.MergedWithCommas() + ");";
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteNonQuery();
            sCon.Close();

        }

        public static void DeleteRecord(string table, string int recordId)
        {

            string query = "UPDATE Estado SET EstRegistro = 2 WHERE EstNombre = 'Jugando';";

        }

        public static int RecoverAnId(string table, string idField, string uniqueField, string uniqueValue)
        {
            
            int recoveredId = 0;
            string query = "SELECT " + idField + " FROM " + table + " WHERE " + uniqueField + " = '" + uniqueValue + "';";
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            try
            {
                mDataReader = mCommand.ExecuteReader();
                if (mDataReader.Read())
                {
                    recoveredId = int.Parse(Convert.ToString(mDataReader[0]));
                }
                mDataReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                recoveredId = -1;
            }
            finally
            {
                sCon.Close();
            }
            return recoveredId;

        }

    }

}
