
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveClasses
{
    
    public class Status
    {

        // Attributes of Status Class

        private int Id;
        private string Name;
        private int CurrentStatus;
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        public Status(int id, string name, int currentStatus)
        {
            setId(id);
            setName(name);
            setCurrentStatus(currentStatus);
        }

        // Setters for Status Class

        public void setId(int id)
        {
            this.Id = id;
            DataSummary.Add(id.ToString());
        }

        public void setName(string name)
        {
            this.Name = name;
            DataSummary.Add(name.ToString());
        }

        public void setCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Status Class

        public int getId()
        {
            return this.Id;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getCurrentStatus()
        {
            return this.CurrentStatus;
        }

        private List<string> getDataSummary()
        {
            return DataSummary;
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