using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Skills_international_school
{
    public partial class Registration : Form
    {
        Functions Con;

        string admin_email, admin_username;
        public Registration(string admin_username, string admin_password)
        {
            InitializeComponent();
            Con = new Functions();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Hide();

        }

        private void linkexit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RegNoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegNoBox.Text != null)
            {
                string RegNo = RegNoBox.Text.ToString();

                string query = $"SELECT * FROM registration WHERE RegNo = '{RegNo}'";

                DataTable dt = Con.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    fname_txt.Text = dt.Rows[0]["firstName"].ToString();
                    lname_txt.Text = dt.Rows[0]["lastName"].ToString();
                    dob_datepicker.Value = Convert.ToDateTime(dt.Rows[0]["dateOfBirth"]);
                    string gender = dt.Rows[0]["gender"].ToString();

                    if (gender == "Male")
                    {
                        male_radio.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        female_radio.Checked = true;
                    }
                    else
                    {
                        male_radio.Checked = false;
                        female_radio.Checked = false;
                    }

                    txt_address.Text = dt.Rows[0]["address"].ToString();
                    txt_email.Text = dt.Rows[0]["email"].ToString();
                    txt_mobilephone.Text = dt.Rows[0]["mobilePhone"].ToString();
                    txt_homephone.Text = dt.Rows[0]["homePhone"].ToString();
                    txt_parentname.Text = dt.Rows[0]["parentName"].ToString();
                    txt_nic.Text = dt.Rows[0]["nic"].ToString();
                    txt_contactno.Text = dt.Rows[0]["contactNo"].ToString();


                }
                else
                {
                    fname_txt.Text = "";
                    lname_txt.Text = "";
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (male_radio.Checked)
            {
                gender = "Male";
            }
            else if (female_radio.Checked)
            {
                gender = "Female";
            }

            string query = @"INSERT INTO registration 
                    (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo)
                    VALUES 
                    ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')";
            query = string.Format(query, fname_txt.Text, lname_txt.Text, dob_datepicker.Value, gender, txt_address.Text, txt_email.Text, txt_mobilephone.Text, txt_homephone.Text, txt_parentname.Text, txt_nic.Text, txt_contactno.Text);
            Con.SetData(query);

            MessageBox.Show("Record Added Succesfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (male_radio.Checked)
            {
                gender = "Male";
            }
            else if (female_radio.Checked)
            {
                gender = "Female";
            }
            string query = @"UPDATE registration SET firstName = '{0}', lastName = '{1}', dateOfBirth = '{2}', gender = '{3}', address = '{4}', email = '{5}', mobilePhone = '{6}', homePhone = '{7}', parentName = '{8}', contactNo = '{9}', nic = '{10}' WHERE regNo = '{11}'";

            query = string.Format(query, fname_txt.Text, lname_txt.Text, dob_datepicker.Value.ToString("yyyy-MM-dd"), gender, txt_address.Text, txt_email.Text, txt_mobilephone.Text, txt_homephone.Text, txt_parentname.Text, txt_contactno.Text, txt_nic.Text, RegNoBox.Text);

            Con.SetData(query);

            MessageBox.Show("Record Updated Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string regNo = RegNoBox.Text;
                string query = $"DELETE FROM registration WHERE RegNo = '{regNo}'";
                Con.SetData(query);

                MessageBox.Show("Record Deleted Successfully");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            RegNoBox.Text = "";
            fname_txt.Text = "";
            lname_txt.Text = "";
            txt_address.Text = "";
            txt_email.Text = "";
            txt_mobilephone.Text = "";
            txt_homephone.Text = "";
            txt_parentname.Text = "";
            txt_nic.Text = "";
            txt_contactno.Text = "";
            dob_datepicker.Value = DateTime.Today;
            male_radio.Checked = false;
            female_radio.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_List studentlis = new Student_List();
            studentlis.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.registrationTableAdapter1.Fill(this.studentDataSet1.Registration);
            RegNoBox.Text = "";
        }
    }
}
