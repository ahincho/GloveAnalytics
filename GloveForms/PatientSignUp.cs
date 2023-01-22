
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloveForms
{
    public partial class PatientSignUp : Form
    {
        public PatientSignUp()
        {
            InitializeComponent();
        }

        private void SaveRecordButton_Click(object sender, EventArgs e)
        {
            
            string name = NameTextBox.Text;
            string lastname = LastnameTextBox.Text;
            string document = DocumentTextBox.Text;
            string birthday = BirthdayTextBox.Text;
            string phoneNumber = PhoneTextBox.Text;
            string email = EmailTextBox.Text;
            string address = AddressTextBox.Text;
            string admissionDate = AdmissionTextBox.Text;

            // Person newPerson = new Person(name, lastname, document, birthday, phoneNumber, email, address, 1);

            // DatabaseOperations.insertRecord(newPerson);

            Console.WriteLine(name);

        }

    }
}
