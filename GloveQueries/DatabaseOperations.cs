using GloveClasses;
using GloveDatabase;
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

        public static void insertStatus(Status newStatus)
        {

            sCon.Open();
            string query = "INSERT INTO Estado(" + Status.getFieldsWithCommas() + ") VALUES(" + newStatus.mergedWithCommas() + ");";
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteReader();
            sCon.Close();

        }

        public static void insertSpecialism(Specialism newSpecialism)
        {

            sCon.Open();
            string query = "INSERT INTO Especialidad(" + Specialism.getFieldsWithCommas() + ") VALUES(" + newSpecialism.mergedWithCommas() + ");";
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteReader();
            sCon.Close();

        }

        public static void insertDiagnosis(Diagnosis newDiagnosis)
        {
            
            sCon.Open();
            string query = "INSERT INTO Diagnostico(" + Diagnosis.getFieldsWithCommas() + ") VALUES(" + newDiagnosis.mergedWithCommas() + ");";
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteReader();
            sCon.Close();

        }

        public static void insertPerson(Person newPerson)
        {
            
            sCon.Open();
            string query = "INSERT INTO Persona(" + Person.getFieldsWithCommas() + ") VALUES(" + newPerson.mergedWithCommas() + ");";
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteReader();
            sCon.Close();

        }

    }

}
