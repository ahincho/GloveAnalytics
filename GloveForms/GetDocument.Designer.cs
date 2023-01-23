namespace GloveForms
{
    partial class GetDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetDocument));
            this.DocumentTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DocumentTextBox
            // 
            this.DocumentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocumentTextBox.Font = new System.Drawing.Font("Agent Orange", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentTextBox.Location = new System.Drawing.Point(162, 172);
            this.DocumentTextBox.Name = "DocumentTextBox";
            this.DocumentTextBox.Size = new System.Drawing.Size(314, 43);
            this.DocumentTextBox.TabIndex = 0;
            this.DocumentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(230, 266);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(180, 40);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // GetDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::GloveForms.Properties.Resources.GetDocumentBackground;
            this.ClientSize = new System.Drawing.Size(624, 356);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.DocumentTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GetDocument";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CITESOFT - GloveApp (Get Document)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox DocumentTextBox;
        private Button LoginButton;
    }
}