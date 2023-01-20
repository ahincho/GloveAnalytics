
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
        private static List<string> Fields = new List<string>() { "EspNombre", "EspEstado" };
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
            this.DataSummary.Add("'" + name.ToString() + "'");
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

        private static List<string> getFields()
        {
            return Specialism.Fields;
        }

        // Method to concatenate all the Class Fields. Useful when
        // we need to do a query and need to enum the fields of the table

        public static string getFieldsWithCommas()
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