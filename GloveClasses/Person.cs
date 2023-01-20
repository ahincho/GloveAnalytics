
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    #pragma warning disable CS8618
    public class Person : Recordable
    {

        // Attributes of Person Class

        private static string Table = "Persona";
        private string Name;
        private string Lastname;
        private string Dni;
        private string Birthday;
        private string PhoneNumber;
        private string Email;
        private string Address;
        private int CurrentStatus;
        private static List<string> Fields = new List<string>() { "PerNombre", "PerApellido", "PerDni", "PerFechaNac", "PerTelefono", "PerCorreo", "PerDireccion", "PerEstado" };
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        public Person(string name, string lastname, string dni, string birthday, string phoneNumber, string email, string address, int currentStatus)
        {
            setName(name);
            setLastname(lastname);
            setDni(dni);
            setBirthday(birthday);
            setPhoneNumber(phoneNumber);
            setEmail(email);
            setAddress(address);
            setCurrentStatus(currentStatus);
        }

        // Setters for Person Class

        public void setName(string name)
        {
            this.Name = name;
            this.DataSummary.Add("'" + name.ToString() + "'");
        }

        public void setLastname(string lastname)
        {
            this.Lastname = lastname;
            this.DataSummary.Add("'" + lastname.ToString() + "'");
        }

        public void setDni(string dni)
        {
            this.Dni = dni;
            this.DataSummary.Add("'" +  dni.ToString() + "'");
        }

        public void setBirthday(string birthday)
        {
            this.Birthday = birthday;
            this.DataSummary.Add("'" + birthday.ToString() + "'");
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
            this.DataSummary.Add("'" + phoneNumber.ToString() + "'");
        }

        public void setEmail(string email)
        {
            this.Email = email;
            this.DataSummary.Add("'" + email.ToString() + "'");
        }

        public void setAddress(string address)
        {
            this.Address = address;
            this.DataSummary.Add("'" + address.ToString() + "'");
        }

        public void setCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Getters for Person Class

        public string getName()
        {
            return this.Name;
        }

        public string getLastname()
        {
            return this.Lastname;
        }

        public string getDni()
        {
            return this.Dni;
        }

        public string getBirthday()
        {
            return this.Birthday;
        }

        public string getPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public string getAddress()
        {
            return this.Address;
        }

        public int getCurrentStatus()
        {
            return this.CurrentStatus;
        }

        private List<string> getDataSummary()
        {
            return this.DataSummary;
        }

        // Method which returns the name of the table associated

        public string getTableName()
        {
            return Person.Table;
        }

        private static List<string> getFields()
        {
            return Person.Fields;
        }

        // Method to concatenate all the Class Fields. Useful when
        // we need to do a query and need to enum the fields of the table

        public string getFieldsWithCommas()
        {
            return string.Join<Object>(",", getFields());
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