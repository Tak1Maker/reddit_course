namespace Reddit
{
    partial class UserPage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserNameUserPage = new System.Windows.Forms.Label();
            this.lblUserName2 = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.lblUserPageTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reddit.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(69, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserNameUserPage
            // 
            this.lblUserNameUserPage.AutoSize = true;
            this.lblUserNameUserPage.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserNameUserPage.Location = new System.Drawing.Point(317, 99);
            this.lblUserNameUserPage.Name = "lblUserNameUserPage";
            this.lblUserNameUserPage.Size = new System.Drawing.Size(51, 21);
            this.lblUserNameUserPage.TabIndex = 1;
            this.lblUserNameUserPage.Text = "Salim";
            // 
            // lblUserName2
            // 
            this.lblUserName2.AutoSize = true;
            this.lblUserName2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName2.Location = new System.Drawing.Point(193, 99);
            this.lblUserName2.Name = "lblUserName2";
            this.lblUserName2.Size = new System.Drawing.Size(127, 28);
            this.lblUserName2.TabIndex = 2;
            this.lblUserName2.Text = "User name: ";
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword1.Location = new System.Drawing.Point(193, 156);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(127, 28);
            this.lblPassword1.TabIndex = 3;
            this.lblPassword1.Text = "User name: ";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword2.Location = new System.Drawing.Point(317, 159);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(38, 21);
            this.lblPassword2.TabIndex = 4;
            this.lblPassword2.Text = "****";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Image = global::Reddit.Properties.Resources.eye;
            this.btnShowPassword.Location = new System.Drawing.Point(375, 154);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(49, 30);
            this.btnShowPassword.TabIndex = 5;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // lblUserPageTitle
            // 
            this.lblUserPageTitle.AutoSize = true;
            this.lblUserPageTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserPageTitle.Location = new System.Drawing.Point(152, 13);
            this.lblUserPageTitle.Name = "lblUserPageTitle";
            this.lblUserPageTitle.Size = new System.Drawing.Size(255, 37);
            this.lblUserPageTitle.TabIndex = 6;
            this.lblUserPageTitle.Text = "User information";
            this.lblUserPageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUserPageTitle);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.lblUserName2);
            this.Controls.Add(this.lblUserNameUserPage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserPage";
            this.Size = new System.Drawing.Size(577, 330);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblUserNameUserPage;
        private Label lblUserName2;
        private Label lblPassword1;
        private Label lblPassword2;
        private Button btnShowPassword;
        private Label lblUserPageTitle;
    }
}
