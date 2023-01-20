
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloveClasses
{
    
    public class HandAngles
    {

        // Attributes of Hand Angles Class

        private float ThumbAngle;
        private float IndexAngle;
        private float MiddleAngle;
        private float RingAngle;
        private float PinkyAngle;
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        public HandAngles(float thumb, float index, float middle, float ring, float pinky)
        {
            setThumbAngle(thumb);
            setIndexAngle(index);
            setMiddleAngle(middle);
            setRingAngle(ring);
            setPinkyAngle(pinky);
        }

        // Setters for Hand Angles Class

        public void setThumbAngle(float thumbAngle)
        {
            this.ThumbAngle = thumbAngle;
            this.DataSummary.Add(thumbAngle.ToString());
        }

        public void setIndexAngle(float indexAngle)
        {
            this.IndexAngle = indexAngle;
            this.DataSummary.Add(indexAngle.ToString());
        }

        public void setMiddleAngle(float middleAngle)
        {
            this.MiddleAngle = middleAngle;
            this.DataSummary.Add(middleAngle.ToString());
        }

        public void setRingAngle(float ringAngle)
        {
            this.RingAngle = ringAngle;
            this.DataSummary.Add(ringAngle.ToString());
        }

        public void setPinkyAngle(float pinkyAngle)
        {
            this.PinkyAngle = pinkyAngle;
            this.DataSummary.Add(pinkyAngle.ToString());
        }

        // Getters for Hand Angles Class

        public float getThumbAngle()
        {
            return this.ThumbAngle;
        }

        public float getIndexAngle()
        {
            return this.IndexAngle;
        }

        public float getMiddleAngle()
        {
            return this.MiddleAngle;
        }

        public float getRingAngle()
        {
            return this.RingAngle;
        }

        public float getPinkyAngle()
        {
            return this.PinkyAngle;
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