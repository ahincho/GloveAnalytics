
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveClasses
{
    
    #pragma warning disable CS8618
    public class Patient
    {

        // Attributes of Patient Class

        private int Id;
        private string AdmissionDate;
        private int Diagnosis;
        private string Comment;
        private int CurrentStatus;
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        public Patient(int id, string admissionDate, int diagnosis, string comment, int currentStatus)
        {
            setId(id);
            setAdmissionDate(admissionDate);
            setDiagnosis(diagnosis);
            setComment(comment);
            setCurrentStatus(currentStatus);
        }

        // Setters for Patient Class

        public void setId(int id)
        {
            this.Id = id;
            this.DataSummary.Add(id.ToString());
        }

        public void setAdmissionDate(string admissionDate)
        {
            this.AdmissionDate = admissionDate;
            this.DataSummary.Add(admissionDate.ToString());
        }

        public void setDiagnosis(int diagnosis)
        {
            this.Diagnosis = diagnosis;
            this.DataSummary.Add(diagnosis.ToString());
        }

        public void setComment(string comment)
        {
            this.Comment = comment;
            this.DataSummary.Add(comment.ToString());
        }

        public void setCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Setters for Patient Class

        public int getId()
        {
            return this.Id;
        }

        public string getAdmissionDate()
        {
            return this.AdmissionDate;
        }

        public int getDiagnosis()
        {
            return this.Diagnosis;
        }

        public string getComment()
        {
            return this.Comment;
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