﻿using System;
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
    public partial class GetDocument : Form
    {
        
        public GetDocument()
        {
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
                    // Here we can merge the forms or GUI with the videogame!
                    MessageBox.Show(Convert.ToString(documentId));
                }
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

    }

}