
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable CS8618, IDE0090
    public class MotionType : IRecordable
    {

        // Attributes of MotionType Class

        private readonly static string Table = "MotionType";
        private string Name;
        private string Description;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "MotName", "MotDescription", "MotStatus" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public MotionType(string name, string description, int currentStatus)
        {
            SetName(name);
            SetDescription(description);
            SetCurrentStatus(currentStatus);
        }

        // Setters for MotionType Class

        public void SetName(string name)
        {
            this.Name = name;
            this.DataSummary.Add(name.ToString());
        }

        public void SetDescription(string description)
        {
            this.Description = description;
            this.DataSummary.Add(description.ToString());
        }

        public void SetCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for MotionType Class

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
            return MotionType.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return MotionType.Table;
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
