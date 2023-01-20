
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveClasses
{

    #pragma warning disable CS8618
    public class Medic
    {

        // Attributes of Medic Class

        private int Id;
        private string EntryDate;
        private int Specialism;
        private int CurrentStatus;
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
            this.DataSummary.Add(entryDate.ToString());
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

        // Method to concatenate all the Class Data
        // Useful when we need to insert this object in the Database

        public string mergedWithCommas()
        {
            string merged = string.Join<Object>(", ", getDataSummary());
            return merged;
        }

    }

}