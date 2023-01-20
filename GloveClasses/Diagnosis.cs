
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveClasses
{

    #pragma warning disable CS8618
    public class Diagnosis
    {

        // Attributes of Diagnosis Class

        private int Id;
        private string Name;
        private string Description;
        private int CurrentStatus;
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        public Diagnosis(int id, string name, string description, int currentStatus)
        {
            setId(id);
            setName(name);
            setDescription(description);
            setCurrentStatus(currentStatus);
        }

        // Setters for Diagnosis Class

        public void setId(int id)
        {
            this.Id = id;
            this.DataSummary.Add(id.ToString());
        }

        public void setName(string name)
        {
            this.Name = name;
            this.DataSummary.Add(name.ToString());
        }

        public void setDescription(string description)
        {
            this.Description = description;
            this.DataSummary.Add(description.ToString());
        }

        public void setCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Setters for Diagnosis Class

        public int getId()
        {
            return this.Id;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getDescription()
        {
            return this.Description;
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