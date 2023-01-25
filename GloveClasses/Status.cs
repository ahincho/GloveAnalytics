
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable CS8618, IDE0090
    public class Status : IRecordable
    {

        // Attributes of Status Class

        private readonly static string Table = "Estado";
        private string Name;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "EstNombre", "EstRegistro" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public Status(string name, int currentStatus)
        {
            SetName(name);
            SetCurrentStatus(currentStatus);
        }

        // Setters for Status Class

        public void SetName(string name)
        {
            this.Name = name;
            this.DataSummary.Add("'" + name.ToString() + "'");
        }

        public void SetCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Status Class

        public string GetName()
        {
            return this.Name;
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
            return Status.Fields;
        }

        // Method which returns the name of the table associated
        
        public string GetTableName()
        {
            return Status.Table;
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
            return string.Join<Object>(", ", GetDataSummary());
        }

    }

}
