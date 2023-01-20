
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveClasses
{

    #pragma warning disable CS8618
    public class Session
    {

        // Attributes of Session Class

        private int Id;
        private int Patient;
        private string Date;
        private float Time;
        private float Meters;
        private int Coins;
        private int Fails;
        private HandAngles Angles;
        private int CurrentStatus;
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        public Session(int id, int patient, string date, float time, float meters, int coins, int fails, HandAngles angles, int currentStatus)
        {
            setId(id);
            setPatient(patient);
            setDate(date);
            setTime(time);
            setMeters(meters);
            setCoins(coins);
            setFails(fails);
            setHandAngles(angles);
            setCurrentStatus(currentStatus);
        }

        // Setters for Session Class

        public void setId(int id)
        {
            this.Id = id;
            this.DataSummary.Add(id.ToString());
        }

        public void setPatient(int patient)
        {
            this.Patient = patient;
            this.DataSummary.Add(patient.ToString());
        }

        public void setDate(string date)
        {
            this.Date = date;
            this.DataSummary.Add(date.ToString());
        }

        public void setTime(float time)
        {
            this.Time = time;
            this.DataSummary.Add(time.ToString());
        }

        public void setMeters(float meters)
        {
            this.Meters = meters;
            this.DataSummary.Add(meters.ToString());
        }

        public void setCoins(int coins)
        {
            this.Coins = coins;
            this.DataSummary.Add(coins.ToString());
        }

        public void setFails(int fails)
        {
            this.Fails = fails;
            this.DataSummary.Add(fails.ToString());
        }

        public void setHandAngles(HandAngles angles)
        {
            this.Angles = angles;
            this.DataSummary.Add(angles.mergedWithCommas());
        }

        public void setCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Session Class

        public int getId()
        {
            return this.Id;
        }

        public int getPatient()
        {
            return this.Patient;
        }

        public string getDate()
        {
            return this.Date;
        }

        public float getTime()
        {
            return this.Time;
        }

        public float getMeters()
        {
            return this.Meters;
        }

        public int getCoins()
        {
            return this.Coins;
        }

        public int getFails()
        {
            return this.Fails;
        }

        public HandAngles getHandAngles()
        {
            return this.Angles;
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