
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable CS8618, IDE0090
    public class Medic : IRecordable
    {

        // Attributes of Medic Class

        private readonly static string Table = "Medico";
        private int Id;
        private string EntryDate;
        private int Specialism;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "MedId", "MedFechaIngreso", "MedEspecialidad", "MedEstado" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public Medic(int id, string entryDate, int specialism, int currentStatus)
        {
            SetId(id);
            SetEntryDate(entryDate);
            SetSpecialism(specialism);
            SetCurrentStatus(currentStatus);
        }

        // Setters for Person Class

        public void SetId(int id)
        {
            this.Id = id;
            this.DataSummary.Add(id.ToString());
        }

        public void SetEntryDate(string entryDate)
        {
            this.EntryDate = entryDate;
            this.DataSummary.Add("'" + entryDate.ToString() + "'");
        }

        public void SetSpecialism(int specialism)
        {
            this.Specialism = specialism;
            this.DataSummary.Add(specialism.ToString());
        }

        public void SetCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Medic Class

        public int GetId()
        {
            return this.Id;
        }

        public string GetEntryDate()
        {
            return this.EntryDate;
        }

        public int GetSpecialism()
        {
            return this.Specialism;
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
            return Medic.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return Medic.Table;
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
