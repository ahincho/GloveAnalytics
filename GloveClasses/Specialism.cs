
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveClasses
{
   
    public class Specialism
    {

        // Attributes of Specialism Class

        private string Name;
        private int CurrentStatus;
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        #pragma warning disable CS8618
        public Specialism(string name, int currentStatus)
        {
            setName(name);
            setCurrentStatus(currentStatus);
        }

        // Setters for Specialism Class

        public void setName(string name)
        {
            this.Name = name;
            this.DataSummary.Add(name.ToString());
        }

        public void setCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Specialism Class

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