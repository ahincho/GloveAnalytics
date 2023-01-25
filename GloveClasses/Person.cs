
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    # pragma warning disable CS8618, IDE0090
    public class Person : IRecordable
    {

        // Attributes of Person Class

        private readonly static string Table = "Persona";
        private string Name;
        private string Lastname;
        private string Dni;
        private string Birthday;
        private string PhoneNumber;
        private string Email;
        private string Address;
        private int CurrentStatus;
        private readonly static List<string> Fields = new List<string>() { "PerNombre", "PerApellido", "PerDni", "PerFechaNac", "PerTelefono", "PerCorreo", "PerDireccion", "PerEstado" };
        private readonly List<string> DataSummary = new List<string>();

        // Class Constructors

        public Person(string name, string lastname, string dni, string birthday, string phoneNumber, string email, string address, int currentStatus)
        {
            SetName(name);
            SetLastname(lastname);
            SetDni(dni);
            SetBirthday(birthday);
            SetPhoneNumber(phoneNumber);
            SetEmail(email);
            SetAddress(address);
            SetCurrentStatus(currentStatus);
        }

        // Setters for Person Class

        public void SetName(string name)
        {
            this.Name = name;
            this.DataSummary.Add("'" + name.ToString() + "'");
        }

        public void SetLastname(string lastname)
        {
            this.Lastname = lastname;
            this.DataSummary.Add("'" + lastname.ToString() + "'");
        }

        public void SetDni(string dni)
        {
            this.Dni = dni;
            this.DataSummary.Add("'" +  dni.ToString() + "'");
        }

        public void SetBirthday(string birthday)
        {
            this.Birthday = birthday;
            this.DataSummary.Add("'" + birthday.ToString() + "'");
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
            this.DataSummary.Add("'" + phoneNumber.ToString() + "'");
        }

        public void SetEmail(string email)
        {
            this.Email = email;
            this.DataSummary.Add("'" + email.ToString() + "'");
        }

        public void SetAddress(string address)
        {
            this.Address = address;
            this.DataSummary.Add("'" + address.ToString() + "'");
        }

        public void SetCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Person Class

        public string GetName()
        {
            return this.Name;
        }

        public string GetLastname()
        {
            return this.Lastname;
        }

        public string GetDni()
        {
            return this.Dni;
        }

        public string GetBirthday()
        {
            return this.Birthday;
        }

        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public string GetAddress()
        {
            return this.Address;
        }

        public int GetCurrentStatus()
        {
            return this.CurrentStatus;
        }

        private List<string> GetDataSummary()
        {
            return this.DataSummary;
        }

        // Method which returns the name of the table associated

        public string GetTableName()
        {
            return Person.Table;
        }

        private static List<string> GetFields()
        {
            return Person.Fields;
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
