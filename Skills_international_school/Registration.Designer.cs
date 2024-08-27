namespace Skills_international_school
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_contactno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_parentname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RegNoBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_homephone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mobilephone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.female_radio = new System.Windows.Forms.RadioButton();
            this.male_radio = new System.Windows.Forms.RadioButton();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.linkexit = new System.Windows.Forms.LinkLabel();
            this.studentDataSet = new Skills_international_school.StudentDataSet();
            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationTableAdapter = new Skills_international_school.StudentDataSetTableAdapters.RegistrationTableAdapter();
            this.studentDataSet1 = new Skills_international_school.StudentDataSet1();
            this.registrationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registrationTableAdapter1 = new Skills_international_school.StudentDataSet1TableAdapters.RegistrationTableAdapter();
            this.dob_datepicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_register);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.RegNoBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 944);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(110, 898);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 32);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(19, 898);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 32);
            this.btn_register.TabIndex = 14;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(453, 898);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 32);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(543, 898);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 32);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_nic);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_contactno);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt_parentname);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(19, 636);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 256);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parent Details";
            // 
            // txt_nic
            // 
            this.txt_nic.Location = new System.Drawing.Point(119, 113);
            this.txt_nic.Multiline = true;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(199, 32);
            this.txt_nic.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "NIC";
            // 
            // txt_contactno
            // 
            this.txt_contactno.Location = new System.Drawing.Point(119, 172);
            this.txt_contactno.Multiline = true;
            this.txt_contactno.Name = "txt_contactno";
            this.txt_contactno.Size = new System.Drawing.Size(200, 32);
            this.txt_contactno.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Contact Number";
            // 
            // txt_parentname
            // 
            this.txt_parentname.Location = new System.Drawing.Point(119, 45);
            this.txt_parentname.Multiline = true;
            this.txt_parentname.Name = "txt_parentname";
            this.txt_parentname.Size = new System.Drawing.Size(467, 32);
            this.txt_parentname.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Parent Name";
            // 
            // RegNoBox
            // 
            this.RegNoBox.DataSource = this.registrationBindingSource1;
            this.RegNoBox.DisplayMember = "regNo";
            this.RegNoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegNoBox.FormattingEnabled = true;
            this.RegNoBox.Location = new System.Drawing.Point(138, 39);
            this.RegNoBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegNoBox.Name = "RegNoBox";
            this.RegNoBox.Size = new System.Drawing.Size(244, 33);
            this.RegNoBox.TabIndex = 1;
            this.RegNoBox.SelectedIndexChanged += new System.EventHandler(this.RegNoBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_homephone);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_mobilephone);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_email);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_address);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(19, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 256);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // txt_homephone
            // 
            this.txt_homephone.Location = new System.Drawing.Point(403, 198);
            this.txt_homephone.Multiline = true;
            this.txt_homephone.Name = "txt_homephone";
            this.txt_homephone.Size = new System.Drawing.Size(183, 32);
            this.txt_homephone.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Home Phone";
            // 
            // txt_mobilephone
            // 
            this.txt_mobilephone.Location = new System.Drawing.Point(119, 198);
            this.txt_mobilephone.Multiline = true;
            this.txt_mobilephone.Name = "txt_mobilephone";
            this.txt_mobilephone.Size = new System.Drawing.Size(173, 32);
            this.txt_mobilephone.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mobile Phone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(119, 132);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(467, 32);
            this.txt_email.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(119, 41);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(467, 72);
            this.txt_address.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dob_datepicker);
            this.groupBox2.Controls.Add(this.female_radio);
            this.groupBox2.Controls.Add(this.male_radio);
            this.groupBox2.Controls.Add(this.lname_txt);
            this.groupBox2.Controls.Add(this.fname_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(19, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 236);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // female_radio
            // 
            this.female_radio.AutoSize = true;
            this.female_radio.Location = new System.Drawing.Point(244, 184);
            this.female_radio.Name = "female_radio";
            this.female_radio.Size = new System.Drawing.Size(74, 20);
            this.female_radio.TabIndex = 6;
            this.female_radio.TabStop = true;
            this.female_radio.Text = "Female";
            this.female_radio.UseVisualStyleBackColor = true;
            // 
            // male_radio
            // 
            this.male_radio.AutoSize = true;
            this.male_radio.Location = new System.Drawing.Point(119, 184);
            this.male_radio.Name = "male_radio";
            this.male_radio.Size = new System.Drawing.Size(58, 20);
            this.male_radio.TabIndex = 5;
            this.male_radio.TabStop = true;
            this.male_radio.Text = "Male";
            this.male_radio.UseVisualStyleBackColor = true;
            // 
            // lname_txt
            // 
            this.lname_txt.Location = new System.Drawing.Point(119, 85);
            this.lname_txt.Multiline = true;
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(467, 32);
            this.lname_txt.TabIndex = 3;
            // 
            // fname_txt
            // 
            this.fname_txt.Location = new System.Drawing.Point(119, 41);
            this.fname_txt.Multiline = true;
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(467, 32);
            this.fname_txt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reg No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skills International";
            // 
            // link_logout
            // 
            this.link_logout.AutoSize = true;
            this.link_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_logout.Location = new System.Drawing.Point(9, 9);
            this.link_logout.Name = "link_logout";
            this.link_logout.Size = new System.Drawing.Size(60, 20);
            this.link_logout.TabIndex = 3;
            this.link_logout.TabStop = true;
            this.link_logout.Text = "Logout";
            this.link_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logout_LinkClicked);
            // 
            // linkexit
            // 
            this.linkexit.AutoSize = true;
            this.linkexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkexit.Location = new System.Drawing.Point(605, 1031);
            this.linkexit.Name = "linkexit";
            this.linkexit.Size = new System.Drawing.Size(37, 20);
            this.linkexit.TabIndex = 18;
            this.linkexit.TabStop = true;
            this.linkexit.Text = "Exit";
            this.linkexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkexit_LinkClicked);
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataSetBindingSource
            // 
            this.studentDataSetBindingSource.DataSource = this.studentDataSet;
            this.studentDataSetBindingSource.Position = 0;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.studentDataSetBindingSource;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationBindingSource1
            // 
            this.registrationBindingSource1.DataMember = "Registration";
            this.registrationBindingSource1.DataSource = this.studentDataSet1;
            // 
            // registrationTableAdapter1
            // 
            this.registrationTableAdapter1.ClearBeforeFill = true;
            // 
            // dob_datepicker
            // 
            this.dob_datepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dob_datepicker.CustomFormat = "dd-MM-yyyy";
            this.dob_datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_datepicker.Location = new System.Drawing.Point(119, 132);
            this.dob_datepicker.Name = "dob_datepicker";
            this.dob_datepicker.Size = new System.Drawing.Size(222, 30);
            this.dob_datepicker.TabIndex = 4;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(656, 1055);
            this.Controls.Add(this.linkexit);
            this.Controls.Add(this.link_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton female_radio;
        private System.Windows.Forms.RadioButton male_radio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_homephone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mobilephone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_contactno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_parentname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox RegNoBox;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.LinkLabel linkexit;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private StudentDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private StudentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource registrationBindingSource1;
        private StudentDataSet1TableAdapters.RegistrationTableAdapter registrationTableAdapter1;
        private System.Windows.Forms.DateTimePicker dob_datepicker;
    }
}