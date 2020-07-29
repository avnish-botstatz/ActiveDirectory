namespace ActiveDirectory
{
    partial class frmAD
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
            this.grpSearchUser = new System.Windows.Forms.GroupBox();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.grpUserInformation = new System.Windows.Forms.GroupBox();
            this.pnlBlock = new System.Windows.Forms.Panel();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.grpDomain = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpSearchUser.SuspendLayout();
            this.grpUserInformation.SuspendLayout();
            this.grpDomain.SuspendLayout();
            this.grpForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearchUser
            // 
            this.grpSearchUser.Controls.Add(this.txtSearchUser);
            this.grpSearchUser.Controls.Add(this.label2);
            this.grpSearchUser.Controls.Add(this.btnSearchUserName);
            this.grpSearchUser.Location = new System.Drawing.Point(21, 175);
            this.grpSearchUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSearchUser.Name = "grpSearchUser";
            this.grpSearchUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSearchUser.Size = new System.Drawing.Size(888, 111);
            this.grpSearchUser.TabIndex = 37;
            this.grpSearchUser.TabStop = false;
            this.grpSearchUser.Text = "Search User";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(339, 43);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(250, 26);
            this.txtSearchUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter a Username/Email ID for search :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUserName.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearchUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchUserName.Location = new System.Drawing.Point(732, 40);
            this.btnSearchUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(112, 35);
            this.btnSearchUserName.TabIndex = 4;
            this.btnSearchUserName.Text = "&Search";
            this.btnSearchUserName.UseVisualStyleBackColor = false;
            this.btnSearchUserName.Click += new System.EventHandler(this.btnSearchUserName_Click);
            // 
            // grpUserInformation
            // 
            this.grpUserInformation.Controls.Add(this.pnlBlock);
            this.grpUserInformation.Controls.Add(this.lblUsernameDisplay);
            this.grpUserInformation.Controls.Add(this.lblTelephone);
            this.grpUserInformation.Controls.Add(this.lblPostal);
            this.grpUserInformation.Controls.Add(this.lblCountry);
            this.grpUserInformation.Controls.Add(this.lblState);
            this.grpUserInformation.Controls.Add(this.lblCity);
            this.grpUserInformation.Controls.Add(this.lblCompany);
            this.grpUserInformation.Controls.Add(this.lblTitle);
            this.grpUserInformation.Controls.Add(this.lblEmailId);
            this.grpUserInformation.Controls.Add(this.lblLastName);
            this.grpUserInformation.Controls.Add(this.lblMiddleName);
            this.grpUserInformation.Controls.Add(this.lblFirstname);
            this.grpUserInformation.Location = new System.Drawing.Point(20, 295);
            this.grpUserInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUserInformation.Name = "grpUserInformation";
            this.grpUserInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUserInformation.Size = new System.Drawing.Size(890, 320);
            this.grpUserInformation.TabIndex = 36;
            this.grpUserInformation.TabStop = false;
            this.grpUserInformation.Text = "User Information";
            // 
            // pnlBlock
            // 
            this.pnlBlock.Location = new System.Drawing.Point(9, 25);
            this.pnlBlock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBlock.Name = "pnlBlock";
            this.pnlBlock.Size = new System.Drawing.Size(870, 286);
            this.pnlBlock.TabIndex = 34;
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.AutoSize = true;
            this.lblUsernameDisplay.Location = new System.Drawing.Point(46, 34);
            this.lblUsernameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(91, 20);
            this.lblUsernameDisplay.TabIndex = 32;
            this.lblUsernameDisplay.Text = "Username :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(518, 158);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(120, 20);
            this.lblTelephone.TabIndex = 31;
            this.lblTelephone.Text = "Telephone No. :";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(538, 120);
            this.lblPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(103, 20);
            this.lblPostal.TabIndex = 30;
            this.lblPostal.Text = "Postal Code :";
            this.lblPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(570, 85);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(72, 20);
            this.lblCountry.TabIndex = 29;
            this.lblCountry.Text = "Country :";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(586, 48);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(56, 20);
            this.lblState.TabIndex = 28;
            this.lblState.Text = "State :";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(93, 286);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 20);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "City :";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(52, 251);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(84, 20);
            this.lblCompany.TabIndex = 26;
            this.lblCompany.Text = "Company :";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(88, 214);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Title :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(60, 177);
            this.lblEmailId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(77, 20);
            this.lblEmailId.TabIndex = 24;
            this.lblEmailId.Text = "Email ID :";
            this.lblEmailId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(42, 138);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 20);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name :";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(26, 103);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(109, 20);
            this.lblMiddleName.TabIndex = 22;
            this.lblMiddleName.Text = "Middle Name :";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(44, 66);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(94, 20);
            this.lblFirstname.TabIndex = 21;
            this.lblFirstname.Text = "First Name :";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDomain
            // 
            this.grpDomain.Controls.Add(this.txtAddress);
            this.grpDomain.Controls.Add(this.lblAddress);
            this.grpDomain.Location = new System.Drawing.Point(489, 17);
            this.grpDomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDomain.Name = "grpDomain";
            this.grpDomain.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDomain.Size = new System.Drawing.Size(420, 148);
            this.grpDomain.TabIndex = 35;
            this.grpDomain.TabStop = false;
            this.grpDomain.Text = "Domain";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(26, 85);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(368, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(87, 43);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(244, 20);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Domain / Global Catalog Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.txtPassword);
            this.grpForm.Controls.Add(this.txtUsername);
            this.grpForm.Controls.Add(this.lblPassword);
            this.grpForm.Controls.Add(this.lblUsername);
            this.grpForm.Location = new System.Drawing.Point(20, 17);
            this.grpForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpForm.Name = "grpForm";
            this.grpForm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpForm.Size = new System.Drawing.Size(446, 148);
            this.grpForm.TabIndex = 34;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Credential";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 85);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(142, 43);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(42, 89);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(40, 46);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Username :";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 634);
            this.Controls.Add(this.grpSearchUser);
            this.Controls.Add(this.grpUserInformation);
            this.Controls.Add(this.grpDomain);
            this.Controls.Add(this.grpForm);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Querying Active Directory Test Envirounment";
            this.Load += new System.EventHandler(this.frmAD_Load);
            this.grpSearchUser.ResumeLayout(false);
            this.grpSearchUser.PerformLayout();
            this.grpUserInformation.ResumeLayout(false);
            this.grpUserInformation.PerformLayout();
            this.grpDomain.ResumeLayout(false);
            this.grpDomain.PerformLayout();
            this.grpForm.ResumeLayout(false);
            this.grpForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchUserName;
        private System.Windows.Forms.GroupBox grpUserInformation;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.GroupBox grpDomain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.Panel pnlBlock;


    }
}

