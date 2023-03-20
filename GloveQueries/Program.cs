
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using GloveClasses;
using GloveQueries;

namespace GloveDatabase
{
    class Program
    {
        
        static void Main()
        {

            // This is a pretty and quick testing of the SQLConnection
            // If you wanna try, just delete the comment annotation

            /*
             * Console.WriteLine("Class SQLite Connection");
             * MySQLiteConnection m = new MySQLiteConnection();
             * SQLiteConnection s = m.GetConnection();
             * m.CloseConnection();
             */

            // Here we are testing the created Entities to manage the
            // objects or records that we need to save in the Database

            /*
             * HandAngles h = new HandAngles(0.25f, 0.25f, 0.25f, 0.25f, 0.25f);
             * Console.WriteLine(h.mergedWithCommas());
             * Session a = new Session(1, 1, "19/01/2023", 10.5f, 50.0f, 100, 3, h, 1);
             * Console.WriteLine(a.mergedWithCommas());
             */

            // Now, we should initialize the Database with some default
            // records or configurations in order to use the GloveApp
            // Yup, Im doing some queries to test Database Operations

            /*
             * DatabaseOperations.initializeDatabase();
             * DatabaseOperations.insertRecord(new Status("Oculto", 1));
             * DatabaseOperations.insertRecord(new Specialism("Oftalmologia", 1));
             * DatabaseOperations.insertRecord(new Diagnosis("Malestar General", "Dolor Agudo", 1));
             * DatabaseOperations.insertRecord(new Person("Angel", "Hincho", "72190199", "02/12/2003", "933502139", "ahincho@unsa.edu.pe", "Paucarpata", 1));
             * DatabaseOperations.insertRecord(new Medic(3, "20/01/2019", 2, 1));
             * DatabaseOperations.insertRecord(new Patient(3, "20/01/2019", 5, "Cuidado Intensivo", 1));
             * HandAngles angles = new HandAngles(0.25f, 0.25f, 0.25f, 0.25f, 0.25f);
             * DatabaseOperations.insertRecord(new Session(3, "20/01/2019", 10.0f, 100.0f, 40, 5, angles, 1));
             */

            // Looking for a Person and recovering its Id
            // Looks good, this SQL Sentence return the 3rd PersonID

            // Console.WriteLine(DatabaseOperations.recoverPersonID("72190199"));

        }

    }
}
