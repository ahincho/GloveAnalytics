
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    #pragma warning disable CS8618
    public class Medic : Recordable
    {

        // Attributes of Medic Class

        private static string Table = "Medico";
        private int Id;
        private string EntryDate;
        private int Specialism;
        private int CurrentStatus;
        private static List<string> Fields = new List<string>() { "MedId", "MedFechaIngreso", "MedEspecialidad", "MedEstado" };
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        public Medic(int id, string entryDate, int specialism, int currentStatus)
        {
            setId(id);
            setEntryDate(entryDate);
            setSpecialism(specialism);
            setCurrentStatus(currentStatus);
        }

        // Setters for Person Class

        public void setId(int id)
        {
            this.Id = id;
            this.DataSummary.Add(id.ToString());
        }

        public void setEntryDate(string entryDate)
        {
            this.EntryDate = entryDate;
            this.DataSummary.Add("'" + entryDate.ToString() + "'");
        }

        public void setSpecialism(int specialism)
        {
            this.Specialism = specialism;
            this.DataSummary.Add(specialism.ToString());
        }

        public void setCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Medic Class

        public int getId()
        {
            return this.Id;
        }

        public string getEntryDate()
        {
            return this.EntryDate;
        }

        public int getSpecialism()
        {
            return this.Specialism;
        }

        public int getCurrentStatus()
        {
            return this.CurrentStatus;
        }

        private List<string> getDataSummary()
        {
            return this.DataSummary;
        }

        private static List<string> getFields()
        {
            return Medic.Fields;
        }

        // Method which returns the name of the table associated

        public string getTableName()
        {
            return Medic.Table;
        }

        // Method to concatenate all the Class Fields. Useful when
        // we need to do a query and need to enum the fields of the table

        public string getFieldsWithCommas()
        {
            return string.Join<Object>(",", getFields());
        }

        // Method to concatenate all the Class Data
        // Useful when we need to insert this object in the Database

        public string mergedWithCommas()
        {
            string merged = string.Join<Object>(", ", getDataSummary());
            return merged;
        }

    }

}