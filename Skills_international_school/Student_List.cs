using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_international_school
{
    public partial class Student_List : Form
    {
        Functions Con;
        public Student_List()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet2.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.studentDataSet2.Registration);

            string student_count = "SELECT COUNT(regNo) as countlist FROM Registration";
            DataTable current_student_count = Con.GetData(student_count);
            var currentstudentCount = current_student_count.Rows[0]["countlist"];

            student_count_lbl.Text = currentstudentCount.ToString();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
