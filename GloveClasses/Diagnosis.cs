
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable IDE0090, CS8618
    public class Diagnosis : IRecordable
    {

        // Attributes of Diagnosis Class

        private readonly static string Table = "Diagnostico";
        private string Name;
        private string Description;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "DiagNombre", "DiagDescripcion", "DiagEstado" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public Diagnosis(string name, string description, int currentStatus)
        {
            SetName(name);
            SetDescription(description);
            SetCurrentStatus(currentStatus);
        }

        // Setters for Diagnosis Class

        public void SetName(string name)
        {
            this.Name = name;
            this.DataSummary.Add("'" + name.ToString() + "'");
        }

        public void SetDescription(string description)
        {
            this.Description = description;
            this.DataSummary.Add("'" + description.ToString() + "'");
        }

        public void SetCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Setters for Diagnosis Class

        public string GetName()
        {
            return this.Name;
        }

        public string GetDescription()
        {
            return this.Description;
        }

        public int GetCurrentStatus()
        {
            return this.CurrentStatus;
        }

        private List<string> GetDataSummary()
        {
            return this.DataSummary;
        }

        private static List<string> GetFields()
        {
            return Diagnosis.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return Diagnosis.Table;
        }


        // Method to concatenate all the Class Fields. Useful when
        // we need to do a query and need to enum the fields of the table

        public string GetFieldsWithCommas()
        {
            return string.Join<Object>(",", GetFields());
        }

        // Method to concatenate all the Class Data
        // Useful when we need to insert this object in the Database

        public string MergedWithCommas()
        {
            string merged = string.Join<Object>(", ", GetDataSummary());
            return merged;
        }


        // Method to get the Status Field name in its table

        public static string GetStatusFieldName()
        {
            return Diagnosis.Table.Substring(0, 3) + "Estado";
        }

        // Method to get the Id Field name in its table

        public static string GetIdFieldName()
        {
            return Diagnosis.Table.Substring(0, 3) + "Id";
        }

    }

}
