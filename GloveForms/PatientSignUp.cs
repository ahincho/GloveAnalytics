
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GloveClasses;
using GloveQueries;
using GloveForms;

namespace GloveForms
{
    public partial class PatientSignUp : Form
    {
        
        public PatientSignUp()
        {
            InitializeComponent();
        }

        private void PatientSignUp_Load(object sender, EventArgs e)
        {



        }

        private void SaveRecordButton_Click(object sender, EventArgs e)
        {

            string name = this.NameTextBox.Text;
            string lastname = this.LastnameTextBox.Text;
            string document = this.DocumentTextBox.Text;
            string birthday = this.BirthdayTextBox.Text;
            string phoneNumber = this.PhoneTextBox.Text;
            string email = this.EmailTextBox.Text;
            string address = this.AddressTextBox.Text;
            string admissionDate = this.AdmissionTextBox.Text;
            int diagnosis = Convert.ToInt32(this.DiagnosisTextBox.Text);
            string comment = this.CommentTextBox.Text;

            Person aPerson = new Person(name, lastname, document, birthday, phoneNumber, email, address, 1);
            // DatabaseOperations.insertRecord(aPerson);
            MessageBox.Show(aPerson.mergedWithCommas());
            int personId = DatabaseOperations.recoverPersonID(document);
            Patient aPatient = new Patient(personId, admissionDate, diagnosis, comment, 1);
            MessageBox.Show(aPatient.mergedWithCommas());
            // DatabaseOperations.insertRecord(aPatient);
            this.CleanFields();

        }

        private void CleanFields()
        {

            foreach (TextBox tb in MyTextBoxGroup)
            {
                tb.Text = "";
            }

        }

    }
}
