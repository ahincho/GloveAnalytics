
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable IDE0090
    public class HandMotion : IRecordable
    {

        // Attributes of Hand Motion Class

        private readonly static string Table = "HandMotion";
        private int SessionId;
        private float ThumbAngle;
        private float IndexAngle;
        private float MiddleAngle;
        private float RingAngle;
        private float PinkyAngle;
        private int MotionType;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "HanSessionId", "HanThumbAngle", "HanIndexAngle", "HanMiddleAngle", "HanRingAngle", "HanPinkyAngle", "HanMotionType", "HanStatus" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public HandMotion(int sessionId, float thumbAngle, float indexAngle, float middleAngle, float ringAngle, float pinkyAngle, int motionType, int currentStatus)
        {
            SetSessionId(sessionId);
            SetThumbAngle(thumbAngle);
            SetIndexAngle(indexAngle);
            SetMiddleAngle(middleAngle);
            SetRingAngle(ringAngle);
            SetPinkyAngle(pinkyAngle);
            SetMotionType(motionType);
            SetCurrentStatus(currentStatus);
        }

        // Setters for Hand Motion Class

        public void SetSessionId(int sessionId)
        {
            this.SessionId = sessionId;
            this.DataSummary.Add(sessionId.ToString());
        }

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

        public void SetMotionType(int motionType)
        {
            this.MotionType = motionType;
            this.DataSummary.Add(motionType.ToString());
        }

        public void SetCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Hand Motion Class

        public int GetSessionId()
        {
            return this.SessionId;
        }

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

        public int GetMotionType()
        {
            return this.MotionType;
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
            return HandMotion.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return HandMotion.Table;
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
