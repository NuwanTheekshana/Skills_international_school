using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Skills_international_school
{
    public partial class login_form : Form
    {
        Functions Con;
        public login_form()
        {
            InitializeComponent();
            InitializePasswordTextBox();
            Con = new Functions();
        }

        public static string admin_username = "";
        public static string admin_password = "";

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string Query = "select * from Logins where username = '{0}' and password = '{1}'";
            Query = string.Format(Query, username, password);
            DataTable dt = Con.GetData(Query);

            if (dt.Rows.Count > 0)
            {
                string db_username = dt.Rows[0]["username"].ToString();
                string db_password = dt.Rows[0]["password"].ToString();

                if (username == db_username && password == db_password)
                {
                    admin_username = dt.Rows[0]["username"].ToString();
                    admin_password = dt.Rows[0]["password"].ToString();
                    Registration adminReg = new Registration(admin_username, admin_password);
                    adminReg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again..!");
                txt_username.Text = "";
                txt_password.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {
          
        }

        private void InitializePasswordTextBox()
        {
            txt_password.UseSystemPasswordChar = true;
        }
    }
}
