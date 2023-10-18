namespace Reddit
{
    partial class MainPage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExitTwo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReddit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.userPage1 = new Reddit.UserPage();
            this.home1 = new Reddit.Home();
            this.createPost1 = new Reddit.CreatePost();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(760, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnExitTwo
            // 
            this.btnExitTwo.FlatAppearance.BorderSize = 0;
            this.btnExitTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitTwo.Location = new System.Drawing.Point(695, 0);
            this.btnExitTwo.Name = "btnExitTwo";
            this.btnExitTwo.Size = new System.Drawing.Size(40, 40);
            this.btnExitTwo.TabIndex = 2;
            this.btnExitTwo.Text = "X";
            this.btnExitTwo.UseVisualStyleBackColor = true;
            this.btnExitTwo.Click += new System.EventHandler(this.btnExitTwo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lblReddit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCreatePost);
            this.panel1.Controls.Add(this.btnUserProfile);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 501);
            this.panel1.TabIndex = 3;
            // 
            // lblReddit
            // 
            this.lblReddit.AutoSize = true;
            this.lblReddit.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblReddit.Location = new System.Drawing.Point(52, 475);
            this.lblReddit.Name = "lblReddit";
            this.lblReddit.Size = new System.Drawing.Size(55, 17);
            this.lblReddit.TabIndex = 9;
            this.lblReddit.Text = "@Reddit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.button1.Location = new System.Drawing.Point(36, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.btnCreatePost.FlatAppearance.BorderSize = 0;
            this.btnCreatePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCreatePost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnCreatePost.Location = new System.Drawing.Point(36, 242);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(96, 40);
            this.btnCreatePost.TabIndex = 7;
            this.btnCreatePost.Text = "New Post ";
            this.btnCreatePost.UseVisualStyleBackColor = false;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.btnUserProfile.FlatAppearance.BorderSize = 0;
            this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnUserProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(143)))), ((int)(((byte)(160)))));
            this.btnUserProfile.Location = new System.Drawing.Point(36, 404);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(96, 40);
            this.btnUserProfile.TabIndex = 5;
            this.btnUserProfile.Text = "Profile ";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // userPage1
            // 
            this.userPage1.Location = new System.Drawing.Point(164, 72);
            this.userPage1.Name = "userPage1";
            this.userPage1.Size = new System.Drawing.Size(571, 345);
            this.userPage1.TabIndex = 4;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(164, 37);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(571, 464);
            this.home1.TabIndex = 5;
            // 
            // createPost1
            // 
            this.createPost1.Location = new System.Drawing.Point(164, 37);
            this.createPost1.Name = "createPost1";
            this.createPost1.Size = new System.Drawing.Size(571, 464);
            this.createPost1.TabIndex = 6;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 501);
            this.ControlBox = false;
            this.Controls.Add(this.createPost1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.userPage1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExitTwo);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private Button btnExitTwo;
        private Panel panel1;
        private Button btnUserProfile;
        private Button btnCreatePost;
        private Label lblReddit;
        private Button button1;
        private UserPage userPage1;
        private Home home1;
        private CreatePost createPost1;
    }
}