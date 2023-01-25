
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable CS8618, IDE0090
    public class Specialism : IRecordable
    {

        // Attributes of Specialism Class

        private readonly static string Table = "Especialidad";
        private string Name;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "EspNombre", "EspEstado" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        #pragma warning disable CS8618
        public Specialism(string name, int currentStatus)
        {
            SetName(name);
            SetCurrentStatus(currentStatus);
        }

        // Setters for Specialism Class

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

        // Getters for Specialism Class

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
            return Specialism.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return Specialism.Table;
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

    }

}
