
namespace MedicareProject
{
    partial class Registration
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
            this.registrationgroupbox = new System.Windows.Forms.GroupBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.bloodgroupcombobox = new System.Windows.Forms.ComboBox();
            this.termscheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.femaleradiobutton = new System.Windows.Forms.RadioButton();
            this.maleradiobutton = new System.Windows.Forms.RadioButton();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.confirmpasswordtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.comfirmpassword = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.registrationgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationgroupbox
            // 
            this.registrationgroupbox.Controls.Add(this.button1);
            this.registrationgroupbox.Controls.Add(this.submitbutton);
            this.registrationgroupbox.Controls.Add(this.bloodgroupcombobox);
            this.registrationgroupbox.Controls.Add(this.termscheckbox);
            this.registrationgroupbox.Controls.Add(this.label2);
            this.registrationgroupbox.Controls.Add(this.femaleradiobutton);
            this.registrationgroupbox.Controls.Add(this.maleradiobutton);
            this.registrationgroupbox.Controls.Add(this.emailtextbox);
            this.registrationgroupbox.Controls.Add(this.confirmpasswordtextbox);
            this.registrationgroupbox.Controls.Add(this.passwordtextbox);
            this.registrationgroupbox.Controls.Add(this.usernametextbox);
            this.registrationgroupbox.Controls.Add(this.label1);
            this.registrationgroupbox.Controls.Add(this.nametextbox);
            this.registrationgroupbox.Controls.Add(this.email);
            this.registrationgroupbox.Controls.Add(this.comfirmpassword);
            this.registrationgroupbox.Controls.Add(this.password);
            this.registrationgroupbox.Controls.Add(this.username);
            this.registrationgroupbox.Controls.Add(this.name);
            this.registrationgroupbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationgroupbox.Location = new System.Drawing.Point(36, 52);
            this.registrationgroupbox.Margin = new System.Windows.Forms.Padding(4);
            this.registrationgroupbox.Name = "registrationgroupbox";
            this.registrationgroupbox.Padding = new System.Windows.Forms.Padding(4);
            this.registrationgroupbox.Size = new System.Drawing.Size(572, 552);
            this.registrationgroupbox.TabIndex = 0;
            this.registrationgroupbox.TabStop = false;
            this.registrationgroupbox.Text = "Registration";
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.submitbutton.Location = new System.Drawing.Point(117, 473);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(144, 44);
            this.submitbutton.TabIndex = 18;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // bloodgroupcombobox
            // 
            this.bloodgroupcombobox.FormattingEnabled = true;
            this.bloodgroupcombobox.Items.AddRange(new object[] {
            "A+ve",
            "A -ve",
            "B +ve",
            "B -ve",
            "AB +ve",
            "AB -ve",
            "O +ve",
            "O -ve"});
            this.bloodgroupcombobox.Location = new System.Drawing.Point(265, 341);
            this.bloodgroupcombobox.Margin = new System.Windows.Forms.Padding(4);
            this.bloodgroupcombobox.Name = "bloodgroupcombobox";
            this.bloodgroupcombobox.Size = new System.Drawing.Size(257, 26);
            this.bloodgroupcombobox.TabIndex = 17;
            // 
            // termscheckbox
            // 
            this.termscheckbox.AutoSize = true;
            this.termscheckbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termscheckbox.Location = new System.Drawing.Point(117, 412);
            this.termscheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.termscheckbox.Name = "termscheckbox";
            this.termscheckbox.Size = new System.Drawing.Size(352, 26);
            this.termscheckbox.TabIndex = 16;
            this.termscheckbox.Text = "I agree all the terms and conditions";
            this.termscheckbox.UseVisualStyleBackColor = true;
            this.termscheckbox.CheckedChanged += new System.EventHandler(this.termscheckbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Blood Group :";
            // 
            // femaleradiobutton
            // 
            this.femaleradiobutton.AutoSize = true;
            this.femaleradiobutton.Location = new System.Drawing.Point(379, 299);
            this.femaleradiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.femaleradiobutton.Name = "femaleradiobutton";
            this.femaleradiobutton.Size = new System.Drawing.Size(90, 24);
            this.femaleradiobutton.TabIndex = 14;
            this.femaleradiobutton.TabStop = true;
            this.femaleradiobutton.Text = "Female";
            this.femaleradiobutton.UseVisualStyleBackColor = true;
            // 
            // maleradiobutton
            // 
            this.maleradiobutton.AutoSize = true;
            this.maleradiobutton.Location = new System.Drawing.Point(265, 299);
            this.maleradiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.maleradiobutton.Name = "maleradiobutton";
            this.maleradiobutton.Size = new System.Drawing.Size(69, 24);
            this.maleradiobutton.TabIndex = 12;
            this.maleradiobutton.TabStop = true;
            this.maleradiobutton.Text = "Male";
            this.maleradiobutton.UseVisualStyleBackColor = true;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(265, 244);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(257, 26);
            this.emailtextbox.TabIndex = 11;
            // 
            // confirmpasswordtextbox
            // 
            this.confirmpasswordtextbox.Location = new System.Drawing.Point(265, 192);
            this.confirmpasswordtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmpasswordtextbox.Name = "confirmpasswordtextbox";
            this.confirmpasswordtextbox.Size = new System.Drawing.Size(257, 26);
            this.confirmpasswordtextbox.TabIndex = 10;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(265, 143);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(257, 26);
            this.passwordtextbox.TabIndex = 9;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(265, 89);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(257, 26);
            this.usernametextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gender :";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(265, 38);
            this.nametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(257, 26);
            this.nametextbox.TabIndex = 6;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(28, 245);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(72, 22);
            this.email.TabIndex = 4;
            this.email.Text = "Email :";
            // 
            // comfirmpassword
            // 
            this.comfirmpassword.AutoSize = true;
            this.comfirmpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirmpassword.Location = new System.Drawing.Point(28, 199);
            this.comfirmpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comfirmpassword.Name = "comfirmpassword";
            this.comfirmpassword.Size = new System.Drawing.Size(188, 22);
            this.comfirmpassword.TabIndex = 3;
            this.comfirmpassword.Text = "Confirm Password :";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(28, 150);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(111, 22);
            this.password.TabIndex = 2;
            this.password.Text = "Password :";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(28, 95);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(122, 23);
            this.username.TabIndex = 1;
            this.username.Text = "Username :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(28, 44);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(78, 23);
            this.name.TabIndex = 0;
            this.name.Text = "Name :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(329, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(651, 645);
            this.Controls.Add(this.registrationgroupbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.registrationgroupbox.ResumeLayout(false);
            this.registrationgroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registrationgroupbox;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.ComboBox bloodgroupcombobox;
        private System.Windows.Forms.CheckBox termscheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton femaleradiobutton;
        private System.Windows.Forms.RadioButton maleradiobutton;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox confirmpasswordtextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label comfirmpassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button button1;
    }
}