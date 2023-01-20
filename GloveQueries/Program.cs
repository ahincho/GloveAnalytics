
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
        
        static void Main(string[] args)
        {

            // This is a pretty and quick testing of the SQLConnection
            // If you wanna try, just delete the comment annotation

            /*
            Console.WriteLine("Class SQLite Connection");
            MySQLiteConnection m = new MySQLiteConnection();
            SQLiteConnection s = m.GetConnection();
            m.CloseConnection();
            */

            // Here we are testing the created Entities to manage the
            // objects or records that we need to save in the Database

            /*
            HandAngles h = new HandAngles(0.25f, 0.25f, 0.25f, 0.25f, 0.25f);
            Console.WriteLine(h.mergedWithCommas());
            Session a = new Session(1, 1, "19/01/2023", 10.5f, 50.0f, 100, 3, h, 1);
            Console.WriteLine(a.mergedWithCommas());
            */

            // Now, we should initialize the Database with some default
            // records or configurations in order to use the GloveApp
            // Yup, Im doing some queries to test Database Operations

            /*
            DatabaseOperations.initializeDatabase();
            DatabaseOperations.insertStatus(new Status("Eliminado", 1));
            DatabaseOperations.insertSpecialism(new Specialism("Oftalmologia", 1));
            DatabaseOperations.insertDiagnosis(new Diagnosis("Malestar General", "Dolor Agudo", 1));
            */

            DatabaseOperations.insertPerson(new Person("Angel", "Hincho", "72190199", "02/12/2003", "933502139", "ahincho@unsa.edu.pe", "Paucarpata", 1));

        }

    }
}
