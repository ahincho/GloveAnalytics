
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{
    
    # pragma warning disable CS8618, IDE0090
    public class Patient : IRecordable
    {

        // Attributes of Patient Class

        private readonly static string Table = "Patient";
        private int Id;
        private string AdmissionDate;
        private int Diagnosis;
        private string Comment;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "PatId", "PatAdmissionDate", "PatDiagnosis", "PatComment", "PatStatus" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public Patient(int id, string admissionDate, int diagnosis, string comment, int currentStatus)
        {
            SetId(id);
            SetAdmissionDate(admissionDate);
            SetDiagnosis(diagnosis);
            SetComment(comment);
            SetCurrentStatus(currentStatus);
        }

        // Setters for Patient Class

        public void SetId(int id)
        {
            this.Id = id;
            this.DataSummary.Add(id.ToString());
        }

        public void SetAdmissionDate(string admissionDate)
        {
            this.AdmissionDate = admissionDate;
            this.DataSummary.Add("'" + admissionDate.ToString() + "'");
        }

        public void SetDiagnosis(int diagnosis)
        {
            this.Diagnosis = diagnosis;
            this.DataSummary.Add(diagnosis.ToString());
        }

        public void SetComment(string comment)
        {
            this.Comment = comment;
            this.DataSummary.Add("'" + comment.ToString() + "'");
        }

        public void SetCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Setters for Patient Class

        public int GetId()
        {
            return this.Id;
        }

        public string GetAdmissionDate()
        {
            return this.AdmissionDate;
        }

        public int GetDiagnosis()
        {
            return this.Diagnosis;
        }

        public string GetComment()
        {
            return this.Comment;
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
            return Patient.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return Patient.Table;
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
