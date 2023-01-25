
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable IDE0090
    public class HandAngles : IRecordable
    {

        // Attributes of Hand Angles Class

        private readonly static string Table = "Angulos";
        private float ThumbAngle;
        private float IndexAngle;
        private float MiddleAngle;
        private float RingAngle;
        private float PinkyAngle;
        private readonly static List<string> Fields = new List<string>() { "SesAngPulgar", "SesAngIndice", "SesAngMedio", "SesAngAnular", "SesAngMenique" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public HandAngles(float thumb, float index, float middle, float ring, float pinky)
        {
            SetThumbAngle(thumb);
            SetIndexAngle(index);
            SetMiddleAngle(middle);
            SetRingAngle(ring);
            SetPinkyAngle(pinky);
        }

        // Setters for Hand Angles Class

        public void SetThumbAngle(float thumbAngle)
        {
            this.ThumbAngle = thumbAngle;
            this.DataSummary.Add(thumbAngle.ToString());
        }

        public void SetIndexAngle(float indexAngle)
        {
            this.IndexAngle = indexAngle;
            this.DataSummary.Add(indexAngle.ToString());
        }

        public void SetMiddleAngle(float middleAngle)
        {
            this.MiddleAngle = middleAngle;
            this.DataSummary.Add(middleAngle.ToString());
        }

        public void SetRingAngle(float ringAngle)
        {
            this.RingAngle = ringAngle;
            this.DataSummary.Add(ringAngle.ToString());
        }

        public void SetPinkyAngle(float pinkyAngle)
        {
            this.PinkyAngle = pinkyAngle;
            this.DataSummary.Add(pinkyAngle.ToString());
        }

        // Getters for Hand Angles Class

        public float GetThumbAngle()
        {
            return this.ThumbAngle;
        }

        public float GetIndexAngle()
        {
            return this.IndexAngle;
        }

        public float GetMiddleAngle()
        {
            return this.MiddleAngle;
        }

        public float GetRingAngle()
        {
            return this.RingAngle;
        }

        public float GetPinkyAngle()
        {
            return this.PinkyAngle;
        }

        private List<string> GetDataSummary()
        {
            return this.DataSummary;
        }

        private static List<string> GetFields()
        {
            return HandAngles.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return HandAngles.Table;
        }

        // Method to concatenate all the Class Fields. Useful when
        // we need to do a query and need to enum the fields of the table

        public string GetFieldsWithCommas()
        {
            return string.Join<Object>(",", GetFields());
        }

        public static string GetClassFields()
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
