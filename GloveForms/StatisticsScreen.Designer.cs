namespace GloveForms
{
    partial class StatisticsScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsScreen));
            this.AnglesLineChart = new System.Windows.Forms.PictureBox();
            this.AnglesTable = new System.Windows.Forms.DataGridView();
            this.Finger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sesion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sesion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sesion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sesion4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetersBySession = new System.Windows.Forms.PictureBox();
            this.CoinsBySession = new System.Windows.Forms.PictureBox();
            this.PatientIdOut = new System.Windows.Forms.TextBox();
            this.SessionComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnglesLineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnglesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetersBySession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinsBySession)).BeginInit();
            this.SuspendLayout();
            // 
            // AnglesLineChart
            // 
            this.AnglesLineChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnglesLineChart.Location = new System.Drawing.Point(25, 145);
            this.AnglesLineChart.Margin = new System.Windows.Forms.Padding(0);
            this.AnglesLineChart.Name = "AnglesLineChart";
            this.AnglesLineChart.Size = new System.Drawing.Size(624, 320);
            this.AnglesLineChart.TabIndex = 2;
            this.AnglesLineChart.TabStop = false;
            // 
            // AnglesTable
            // 
            this.AnglesTable.AllowUserToAddRows = false;
            this.AnglesTable.AllowUserToDeleteRows = false;
            this.AnglesTable.AllowUserToResizeColumns = false;
            this.AnglesTable.AllowUserToResizeRows = false;
            this.AnglesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AnglesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AnglesTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agent Orange", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AnglesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AnglesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnglesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Finger,
            this.Sesion1,
            this.Sesion2,
            this.Sesion3,
            this.Sesion4,
            this.Mean});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agent Orange", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AnglesTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.AnglesTable.GridColor = System.Drawing.SystemColors.Control;
            this.AnglesTable.Location = new System.Drawing.Point(25, 487);
            this.AnglesTable.Margin = new System.Windows.Forms.Padding(0);
            this.AnglesTable.Name = "AnglesTable";
            this.AnglesTable.ReadOnly = true;
            this.AnglesTable.RowTemplate.Height = 25;
            this.AnglesTable.Size = new System.Drawing.Size(624, 183);
            this.AnglesTable.TabIndex = 3;
            // 
            // Finger
            // 
            this.Finger.HeaderText = "Finger";
            this.Finger.Name = "Finger";
            this.Finger.ReadOnly = true;
            // 
            // Sesion1
            // 
            this.Sesion1.HeaderText = "Sesion1";
            this.Sesion1.Name = "Sesion1";
            this.Sesion1.ReadOnly = true;
            // 
            // Sesion2
            // 
            this.Sesion2.HeaderText = "Sesion2";
            this.Sesion2.Name = "Sesion2";
            this.Sesion2.ReadOnly = true;
            // 
            // Sesion3
            // 
            this.Sesion3.HeaderText = "Sesion3";
            this.Sesion3.Name = "Sesion3";
            this.Sesion3.ReadOnly = true;
            // 
            // Sesion4
            // 
            this.Sesion4.HeaderText = "Sesion4";
            this.Sesion4.Name = "Sesion4";
            this.Sesion4.ReadOnly = true;
            // 
            // Mean
            // 
            this.Mean.HeaderText = "Mean";
            this.Mean.Name = "Mean";
            this.Mean.ReadOnly = true;
            // 
            // MetersBySession
            // 
            this.MetersBySession.Location = new System.Drawing.Point(680, 145);
            this.MetersBySession.Margin = new System.Windows.Forms.Padding(0);
            this.MetersBySession.Name = "MetersBySession";
            this.MetersBySession.Size = new System.Drawing.Size(560, 255);
            this.MetersBySession.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MetersBySession.TabIndex = 5;
            this.MetersBySession.TabStop = false;
            // 
            // CoinsBySession
            // 
            this.CoinsBySession.Location = new System.Drawing.Point(680, 415);
            this.CoinsBySession.Margin = new System.Windows.Forms.Padding(0);
            this.CoinsBySession.Name = "CoinsBySession";
            this.CoinsBySession.Size = new System.Drawing.Size(560, 255);
            this.CoinsBySession.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CoinsBySession.TabIndex = 6;
            this.CoinsBySession.TabStop = false;
            // 
            // PatientIdOut
            // 
            this.PatientIdOut.Font = new System.Drawing.Font("Agent Orange", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientIdOut.Location = new System.Drawing.Point(25, 96);
            this.PatientIdOut.Margin = new System.Windows.Forms.Padding(0);
            this.PatientIdOut.Name = "PatientIdOut";
            this.PatientIdOut.Size = new System.Drawing.Size(335, 40);
            this.PatientIdOut.TabIndex = 7;
            // 
            // SessionComboBox
            // 
            this.SessionComboBox.Font = new System.Drawing.Font("Agent Orange", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SessionComboBox.Location = new System.Drawing.Point(389, 96);
            this.SessionComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.SessionComboBox.Name = "SessionComboBox";
            this.SessionComboBox.Size = new System.Drawing.Size(260, 40);
            this.SessionComboBox.TabIndex = 9;
            this.SessionComboBox.SelectedIndexChanged += new System.EventHandler(this.SessionComboBox_SelectedIndexChanged);
            // 
            // StatisticsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::GloveForms.Properties.Resources.StatisticsBackground;
            this.ClientSize = new System.Drawing.Size(1264, 716);
            this.Controls.Add(this.SessionComboBox);
            this.Controls.Add(this.PatientIdOut);
            this.Controls.Add(this.CoinsBySession);
            this.Controls.Add(this.MetersBySession);
            this.Controls.Add(this.AnglesTable);
            this.Controls.Add(this.AnglesLineChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "StatisticsScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CITESOFT - GloveApp (Statistics)";
            ((System.ComponentModel.ISupportInitialize)(this.AnglesLineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnglesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetersBySession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinsBySession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox AnglesLineChart;
        private DataGridView AnglesTable;
        private PictureBox MetersBySession;
        private PictureBox CoinsBySession;
        private TextBox PatientIdOut;
        private DataGridViewTextBoxColumn Finger;
        private DataGridViewTextBoxColumn Sesion1;
        private DataGridViewTextBoxColumn Sesion2;
        private DataGridViewTextBoxColumn Sesion3;
        private DataGridViewTextBoxColumn Sesion4;
        private DataGridViewTextBoxColumn Mean;
        private ComboBox SessionComboBox;
    }
}