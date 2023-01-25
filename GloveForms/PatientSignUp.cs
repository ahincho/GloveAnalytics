
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

namespace GloveForms
{
    public partial class PatientSignUp : Form
    {
        
        public PatientSignUp()
        {
            
            InitializeComponent();
            this.InitializeTextBoxGroup();

        }

        private void PatientSignUp_Load(object sender, EventArgs e)
        {



        }

        private void SaveRecordButton_Click(object sender, EventArgs e)
        {
            
            if (this.FieldsAreEmpty())
            {
                MessageBox.Show("Debe completar la información solicitada!", "Tiene campos en blanco!", MessageBoxButtons.OK);
            }
            else
            {
                Person aPerson = this.CreatePersonFromFields();
                DatabaseOperations.InsertRecord(aPerson);
                // MessageBox.Show(aPerson.mergedWithCommas());
                int personId = DatabaseOperations.RecoverAnId(aPerson.GetTableName(), "PerId", "PerDni", aPerson.GetDni());
                Patient aPatient = this.CreatePatientFromFields(personId);
                DatabaseOperations.InsertRecord(aPatient);
                // MessageBox.Show(aPatient.mergedWithCommas());
                MessageBox.Show("Se ha registrado un nuevo paciente!", "Paciente Registrado!", MessageBoxButtons.OK);
                this.CleanFields();
            }

        }

        private void CleanFields()
        {

            foreach (TextBox tb in MyTextBoxGroup)
            {
                tb.Text = "";
            }

        }

        private bool FieldsAreEmpty()
        {

            foreach (TextBox tb in MyTextBoxGroup)
            {
                if (tb.Text.Length == 0)
                {
                    return true;
                }
            }
            return false;

        }

        private Person CreatePersonFromFields()
        {

            string name = this.NameTextBox.Text;
            string lastname = this.LastnameTextBox.Text;
            string document = this.DocumentTextBox.Text;
            string birthday = this.BirthdayTextBox.Text;
            string phoneNumber = this.PhoneTextBox.Text;
            string email = this.EmailTextBox.Text;
            string address = this.AddressTextBox.Text;

            return new Person(name, lastname, document, birthday, phoneNumber, email, address, 1);

        }

        private Patient CreatePatientFromFields(int personId)
        {

            string admissionDate = this.AdmissionTextBox.Text;
            int diagnosis = Convert.ToInt32(this.DiagnosisTextBox.Text);
            string comment = this.CommentTextBox.Text;
            
            return new Patient(personId, admissionDate, diagnosis, comment, 1);

        }

        private void InitializeTextBoxGroup()
        {

            //
            // MyTextBoxGroup
            // 
            this.MyTextBoxGroup.Add(NameTextBox);
            this.MyTextBoxGroup.Add(LastnameTextBox);
            this.MyTextBoxGroup.Add(DocumentTextBox);
            this.MyTextBoxGroup.Add(BirthdayTextBox);
            this.MyTextBoxGroup.Add(PhoneTextBox);
            this.MyTextBoxGroup.Add(EmailTextBox);
            this.MyTextBoxGroup.Add(AddressTextBox);
            this.MyTextBoxGroup.Add(AdmissionTextBox);
            this.MyTextBoxGroup.Add(DiagnosisTextBox);
            this.MyTextBoxGroup.Add(CommentTextBox);

        }

    }
}
