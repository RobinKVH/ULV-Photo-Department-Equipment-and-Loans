using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD_Loan_Database
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            //getting variables to insert into database
            var studentid = Convert.ToInt32(studentIDTextBox.Text);
            var studentlname = lastNameTextBox.Text;
            var studentfname = firstNameTextBox.Text;
            var studentcontact = contactNoTextBox.Text;
            var studentemail = emailTextBox.Text;

            //transerfing data into parent form to insert
            Form1 parent = (Form1)this.Owner;
            parent.AddStudentReturn(studentid, studentlname, studentfname, studentcontact, studentemail);

            //clearing textboxes after insert completed
            studentIDTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            firstNameTextBox.Text = String.Empty;
            contactNoTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
