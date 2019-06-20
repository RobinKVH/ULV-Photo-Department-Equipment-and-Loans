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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //getting variables to insert into database
            var equipmentid = Convert.ToInt32(equipmentIDTextBox.Text);
            var equipmenttype = typeTextBox.Text;
            var equipmentserial = serialNoTextBox.Text;
            var equipmentname = nameTextBox.Text;

            //transerfing data into parent form to insert
            Form1 parent = (Form1)this.Owner;
            parent.AddEquipmentReturn(equipmentid, equipmenttype, equipmentserial, equipmentname);

            //clearing textboxes after insert completed
            equipmentIDTextBox.Text = String.Empty;
            typeTextBox.Text = String.Empty;
            serialNoTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
