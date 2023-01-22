namespace GloveForms
{
    partial class MainScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.PlayButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.GameTitle = new System.Windows.Forms.PictureBox();
            this.LeftMenu = new System.Windows.Forms.PictureBox();
            this.RightMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Location = new System.Drawing.Point(460, 230);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(360, 85);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BackgroundImage = global::GloveForms.Properties.Resources.SignUpButton;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Location = new System.Drawing.Point(460, 330);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(360, 85);
            this.SignUpButton.TabIndex = 1;
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.OptionsButton.BackgroundImage = global::GloveForms.Properties.Resources.OptionsButton;
            this.OptionsButton.FlatAppearance.BorderSize = 0;
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Location = new System.Drawing.Point(460, 430);
            this.OptionsButton.Margin = new System.Windows.Forms.Padding(0);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(360, 85);
            this.OptionsButton.TabIndex = 2;
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // CreditsButton
            // 
            this.CreditsButton.BackColor = System.Drawing.Color.Transparent;
            this.CreditsButton.BackgroundImage = global::GloveForms.Properties.Resources.CreditsButton;
            this.CreditsButton.FlatAppearance.BorderSize = 0;
            this.CreditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsButton.Location = new System.Drawing.Point(460, 530);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(360, 85);
            this.CreditsButton.TabIndex = 3;
            this.CreditsButton.UseVisualStyleBackColor = false;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // GameTitle
            // 
            this.GameTitle.BackColor = System.Drawing.Color.Transparent;
            this.GameTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameTitle.BackgroundImage")));
            this.GameTitle.Location = new System.Drawing.Point(340, 25);
            this.GameTitle.Margin = new System.Windows.Forms.Padding(0);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(600, 180);
            this.GameTitle.TabIndex = 4;
            this.GameTitle.TabStop = false;
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.Transparent;
            this.LeftMenu.BackgroundImage = global::GloveForms.Properties.Resources.LeftMenuHolder;
            this.LeftMenu.Location = new System.Drawing.Point(0, 245);
            this.LeftMenu.Margin = new System.Windows.Forms.Padding(0);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(125, 360);
            this.LeftMenu.TabIndex = 5;
            this.LeftMenu.TabStop = false;
            // 
            // RightMenu
            // 
            this.RightMenu.BackColor = System.Drawing.Color.Transparent;
            this.RightMenu.Image = global::GloveForms.Properties.Resources.RightMenuHolder;
            this.RightMenu.Location = new System.Drawing.Point(1155, 245);
            this.RightMenu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.RightMenu.Name = "RightMenu";
            this.RightMenu.Size = new System.Drawing.Size(125, 360);
            this.RightMenu.TabIndex = 6;
            this.RightMenu.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GloveForms.Properties.Resources.GloveBackground;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.RightMenu);
            this.Controls.Add(this.LeftMenu);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.CreditsButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.PlayButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainScreen";
            this.Text = "CITESOFT - GloveApp (Main Screen)";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.PictureBox GameTitle;
        private System.Windows.Forms.PictureBox LeftMenu;
        private System.Windows.Forms.PictureBox RightMenu;
    }
}

