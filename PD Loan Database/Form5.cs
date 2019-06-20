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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var studentid = Convert.ToInt32(studentIDTextBox.Text);

            Form1 parent = (Form1)this.Owner;
            parent.DeleteStudentReturn(studentid);

            studentIDTextBox.Text = String.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
