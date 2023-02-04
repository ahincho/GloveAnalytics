
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
        private static int activeStatusId;
        private static int deletedStatusId;

        public static void InitializeDatabase()
        {

            // Database have to contain the Active, Deleted and Playing Status

            DatabaseOperations.activeStatusId = RecoverAnId("Status", "StaId", "StaName", "Activo");
            if (DatabaseOperations.activeStatusId == -1)
            {
                // Adding the main states for our Database
                string insertActiveQuery = "INSERT INTO Status VALUES(1, 'Activo', 1);";
                sCon.Open();
                mCommand = new SQLiteCommand(insertActiveQuery, sCon);
                mCommand.ExecuteNonQuery();
                sCon.Close();
                DatabaseOperations.activeStatusId = DatabaseOperations.RecoverAnId("Status", "StaId", "StaName", "Activo");
                DatabaseOperations.InsertRecord(new Status("Eliminado", DatabaseOperations.activeStatusId));
                DatabaseOperations.InsertRecord(new Status("Jugando", DatabaseOperations.activeStatusId));
                // Adding a General Specialism in the Database
                DatabaseOperations.InsertRecord(new Specialism("Medicina General", DatabaseOperations.activeStatusId));
                int generalSpecialism = DatabaseOperations.RecoverAnId("Specialism", "SpeId", "SpeName", "Medicina General");
                // Adding a General Diagnosis in the Database
                DatabaseOperations.InsertRecord(new Diagnosis("Paciente Sano", "No posee un cuadro clínico concreto", DatabaseOperations.activeStatusId));
                int generalDiagnosis = DatabaseOperations.RecoverAnId("Diagnosis", "DiaId", "DiaName", "Paciente Sano");
                // Adding the five possible movements of the hand
                DatabaseOperations.InsertRecord(new MotionType("Flexion de Pulgar", "Movimiento del dedo pulgar", DatabaseOperations.activeStatusId));
                DatabaseOperations.InsertRecord(new MotionType("Flexion de Indice", "Movimiento del dedo indice", DatabaseOperations.activeStatusId));
                DatabaseOperations.InsertRecord(new MotionType("Flexion de Medio", "Movimiento del dedo medio", DatabaseOperations.activeStatusId));
                DatabaseOperations.InsertRecord(new MotionType("Flexion de Anular", "Movimiento del dedo anular", DatabaseOperations.activeStatusId));
                DatabaseOperations.InsertRecord(new MotionType("Flexion de Menique", "Movimiento del dedo menique", DatabaseOperations.activeStatusId));
                // Adding a General User for our application
                DatabaseOperations.InsertRecord(new Person("Admin", "Admin", "Admin123456", "04/02/2023", "123456789", "admin@citesoft.com", "Citesoft", DatabaseOperations.activeStatusId));
                int adminUser = DatabaseOperations.RecoverAnId("Person", "PerId", "PerName", "Admin");
                // Adding a new Medic using the Admin User
                DatabaseOperations.InsertRecord(new Medic(adminUser, "04/02/2023", generalSpecialism, DatabaseOperations.activeStatusId));
                // Adding a new Patient using the Admin User
                DatabaseOperations.InsertRecord(new Patient(adminUser, "04/02/2023", generalDiagnosis, "Admin probando la aplicacion", DatabaseOperations.activeStatusId));
            }
            DatabaseOperations.deletedStatusId = RecoverAnId("Status", "StaId", "StaNombre", "Eliminado");

        }

        public static void InsertRecord(IRecordable newRecord)
        {

            string query = "INSERT INTO " + newRecord.GetTableName() + "(" + newRecord.GetFieldsWithCommas() + ") VALUES(" + newRecord.MergedWithCommas() + ");";
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteNonQuery();
            sCon.Close();

        }

        public static void DeleteRecord(string table, string stateField, string idField, string idValue)
        {

            string query = "UPDATE " + table + " SET " + stateField + " = " + DatabaseOperations.deletedStatusId + " WHERE " + idField + " = '" + idValue + "';";
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            mCommand.ExecuteNonQuery();
            sCon.Close();

        }

        public static int RecoverAnId(string table, string idField, string uniqueField, string uniqueValue)
        {
            
            int recoveredId = -1;
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
