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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var equipmentid = Convert.ToInt32(equipmentIDTextBox.Text);
        
            Form1 parent = (Form1)this.Owner;
            parent.DeleteEquipmentReturn(equipmentid);

            equipmentIDTextBox.Text = String.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
