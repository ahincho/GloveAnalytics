
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable CS8618, IDE0090
    public class Session : IRecordable
    {

        // Attributes of Session Class

        private readonly static string Table = "Session";
        private int PatientId;
        private string Date;
        private float Time;
        private float Meters;
        private int Coins;
        private int Fails;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "SesPatientId", "SesDate", "SesTime", "SesMeters", "SesCoins", "SesFails", "SesStatus"};
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public Session(int patientId, string date, float time, float meters, int coins, int fails, int currentStatus)
        {
            SetPatientId(patientId);
            SetDate(date);
            SetTime(time);
            SetMeters(meters);
            SetCoins(coins);
            SetFails(fails);
            SetCurrentStatus(currentStatus);
        }

        // Setters for Session Class

        public void SetPatientId(int patientId)
        {
            this.PatientId = patientId;
            this.DataSummary.Add(patientId.ToString());
        }

        public void SetDate(string date)
        {
            this.Date = date;
            this.DataSummary.Add("'" + date.ToString() + "'");
        }

        public void SetTime(float time)
        {
            this.Time = time;
            this.DataSummary.Add(time.ToString());
        }

        public void SetMeters(float meters)
        {
            this.Meters = meters;
            this.DataSummary.Add(meters.ToString());
        }

        public void SetCoins(int coins)
        {
            this.Coins = coins;
            this.DataSummary.Add(coins.ToString());
        }

        public void SetFails(int fails)
        {
            this.Fails = fails;
            this.DataSummary.Add(fails.ToString());
        }

        public void SetCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Session Class

        public int GetPatientId()
        {
            return this.PatientId;
        }

        public string GetDate()
        {
            return this.Date;
        }

        public float GetTime()
        {
            return this.Time;
        }

        public float GetMeters()
        {
            return this.Meters;
        }

        public int GetCoins()
        {
            return this.Coins;
        }

        public int GetFails()
        {
            return this.Fails;
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
            return Session.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return Session.Table;
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
