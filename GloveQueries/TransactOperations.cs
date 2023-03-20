
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveClasses;
using GloveDatabase;
using GloveInterfaces;

namespace GloveQueries
{

    # pragma warning disable CS8618, CS8604, IDE0090
    public class TransactOperations
    {

        private readonly static MySQLiteConnection mSql = new MySQLiteConnection();
        private readonly static SQLiteConnection sCon = mSql.GetConnection();
        private static SQLiteCommand mCommand;
        private static SQLiteDataReader mDataReader;

        public static void RecoverSesions(int patientId, IRecordable newRecord )
        {
            string query = "INSERT INTO " + newRecord.GetTableName() + "(" + newRecord.GetFieldsWithCommas() + ") VALUES(" + newRecord.MergedWithCommas() + ");";
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteNonQuery();
            sCon.Close();
        }

    }

}
