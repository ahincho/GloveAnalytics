
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GloveQueries;

namespace GloveForms
{
    public partial class GetDocument : Form
    {
        
        private static bool SuccessfulLogin;
        private int PatientId;

        public GetDocument()
        {
            SetSuccessfulLoginFlag(false);
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!FieldIsEmpty())
            {
                bool isInt = Int32.TryParse(DocumentTextBox.Text, out int documentId);
                if (!isInt)
                {
                    MessageBox.Show("Usted no ha ingresado un número entero!", "Ingresar Documento!", MessageBoxButtons.OK);
                }
                else
                {
                    // MessageBox.Show(Convert.ToString(documentId)); // When necessary you should comment this line
                    int personId = DatabaseOperations.RecoverAnId("Person", "PerId", "PerDocument", "" + documentId);
                    int patientId = DatabaseOperations.RecoverAnId("Patient", "PatId", "PatId", "" + personId);
                    if (patientId == -1)
                    {
                        MessageBox.Show("Usuario no registrado!", "Ingresar Documento!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        this.Hide();
                        this.SetPatientId(patientId);
                        GetDocument.SetSuccessfulLoginFlag(true);
                        this.Close();
                    }
                }
                ClearField();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese su documento", "Ingresar Documento!", MessageBoxButtons.OK);
            }
        }

        private bool FieldIsEmpty()
        {
            return DocumentTextBox.Text.Length == 0;
        }

        private void ClearField()
        {
            DocumentTextBox.Text = "";
        }

        private static void SetSuccessfulLoginFlag(bool flag)
        {
            GetDocument.SuccessfulLogin = flag;
        }

        public static bool GetSuccessfulLoginFlag()
        {
            return GetDocument.SuccessfulLogin;
        }

        private void SetPatientId(int patientId)
        {
            this.PatientId = patientId;
        }

        public int GetPatientId()
        {
            return this.PatientId;
        }

    }

}
