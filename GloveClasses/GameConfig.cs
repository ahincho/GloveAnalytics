
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

#pragma warning disable CS8618, IDE0090
    public class GameConfig : IRecordable
    {

        // Attributes of Status Class

        private readonly static string Table = "GameConfig";
        private int ConId;
        private int PatId;
        private int Difficulty;
        private string SesDate;
        private readonly static List<string> Fields = new List<string>() { "ConId", "PatId", "Difficulty", "SesDate" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public GameConfig(int conId, int patId, int difficulty, string sesDate)
        {
            SetConId(conId);
            SetPatId(patId);
            SetDifficulty(difficulty);
            SetSesDate(sesDate);
        }

        // Setters for Status Class

        public void SetConId(int conId)
        {
            this.ConId = conId;
            this.DataSummary.Add(conId.ToString());
        }

        public void SetPatId(int patId)
        {
            this.PatId = patId;
            this.DataSummary.Add(patId.ToString());
        }

        public void SetDifficulty(int difficulty)
        {
            this.Difficulty = difficulty;
            this.DataSummary.Add(difficulty.ToString());
        }

        public void SetSesDate(string date)
        {
            this.SesDate = date;
            this.DataSummary.Add("'" + date.ToString() + "'");
        }

        // Getters for Status Class

        public int GetConId()
        {
            return this.ConId;
        }

        public int GetPatId()
        {
            return this.PatId;
        }

        public int GetDifficulty()
        {
            return this.Difficulty;
        }

        public string GetSesDate()
        {
            return this.SesDate;
        }

        private List<string> GetDataSummary()
        {
            return this.DataSummary;
        }

        private static List<string> GetFields()
        {
            return GameConfig.Fields;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return GameConfig.Table;
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
            return string.Join<Object>(", ", GetDataSummary());
        }

    }

}
