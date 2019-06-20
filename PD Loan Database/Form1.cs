using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace PD_Loan_Database
{
    public partial class Form1 : Form
    {
        public void AddStudentReturn(int sid, string lname, string fname, string contact, string email)
        {
            studentsTableAdapter.InsertStudentQuery(sid, lname, fname, contact, email);
            studentsDataGridView.Refresh();
            studentsBindingSource.DataSource = studentsTableAdapter.GetData();
            studentsBindingSource.ResetBindings(false);
        }
        public void DeleteStudentReturn(int sid)
        {
            studentsTableAdapter.DeleteStudentQuery(sid);
            studentsDataGridView.Refresh();
            studentsBindingSource.DataSource = studentsTableAdapter.GetData();
            studentsBindingSource.ResetBindings(false);

            loansTableAdapter.DeleteLoanbyStudentQuery(sid);
            loansDataGridView.Refresh();
            loansBindingSource.DataSource = loansTableAdapter.GetData();
            loansBindingSource.ResetBindings(false);
        }

        public void AddEquipmentReturn(int eid, string type, string serial, string name)
        {
            equipmentTableAdapter.InsertEquipmentQuery(eid, type, serial, name);
            equipmentDataGridView.Refresh();
            equipmentBindingSource.DataSource = equipmentTableAdapter.GetData();
            equipmentBindingSource.ResetBindings(false);

            //updating available equipment table
            equipmentDataGridView1.Refresh();
            equipmentBindingSource2.DataSource = equipmentTableAdapter1.GetData();
            equipmentBindingSource2.ResetBindings(false);
        }
        public void DeleteEquipmentReturn(int eid)
        {
            equipmentTableAdapter.DeleteEquipmentQuery(eid);
            equipmentDataGridView.Refresh();
            equipmentBindingSource.DataSource = equipmentTableAdapter.GetData();
            equipmentBindingSource.ResetBindings(false);

            loansTableAdapter.DeleteLoanbyEquipmentQuery(eid);
            loansDataGridView.Refresh();
            loansBindingSource.DataSource = loansTableAdapter.GetData();
            loansBindingSource.ResetBindings(false);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void loansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.photoDepartmentDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'photoDepartmentDataSet1.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter1.Fill(this.photoDepartmentDataSet1.Equipment);
            //displaying table grid views
            this.historyTableAdapter.Fill(this.photoDepartmentDataSet.History);
            this.equipmentTableAdapter.Fill(this.photoDepartmentDataSet.Equipment);
            this.studentsTableAdapter.Fill(this.photoDepartmentDataSet.Students);
            this.loansTableAdapter.Fill(this.photoDepartmentDataSet.Loans);

        }
        //student tab buttons
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            using (Form2 addStudentForm = new Form2())
            {
                addStudentForm.ShowDialog(this);
            }
        }
        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            using (Form5 deleteStudentForm = new Form5())
            {
                deleteStudentForm.ShowDialog(this);
            }
        }

        //equipment tab buttons
        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            using (Form3 addEquipmentForm = new Form3())
            {
                addEquipmentForm.ShowDialog(this);
            }
        }
        private void removeEquipmentButton_Click(object sender, EventArgs e)
        {
            using (Form4 deleteEquipmentForm = new Form4())
            {
                deleteEquipmentForm.ShowDialog(this);
            }
        }

        //loan tab button
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            var eid = Convert.ToInt32(equipmentIDTextBox.Text);
            var sid = Convert.ToInt32(studentIDTextBox.Text);

            loansTableAdapter.CheckOutQuery(eid, sid);
            loansDataGridView.Refresh();
            loansBindingSource.DataSource = loansTableAdapter.GetData();
            loansBindingSource.ResetBindings(false);

            //updating available equipment table
            equipmentDataGridView1.Refresh();
            equipmentBindingSource2.DataSource = equipmentTableAdapter1.GetData();
            equipmentBindingSource2.ResetBindings(false);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {

            //insterting loan into history
            var firstname = firstNameTextBox1.Text;
            var lastname = lastNameTextBox1.Text;
            var serialno = serialNoTextBox1.Text;
            var equipmentname = nameTextBox1.Text;
            DateTime checkoutdate = loanedDateDateTimePicker.Value;
            int studentid = Convert.ToInt32(studentidTextBox1.Text);
            int equipmentid = Convert.ToInt32(equipmentidTextBox1.Text);

            historyTableAdapter.InsertHistoryQuery(studentid, equipmentid, checkoutdate, firstname, lastname,
                serialno, equipmentname);
            historyDataGridView.Refresh();
            historyBindingSource.DataSource = historyTableAdapter.GetData();
            historyBindingSource.ResetBindings(false);

            //deleting the loan
            int loanNO = Convert.ToInt32(loanNoTextBox.Text);
            loansTableAdapter.ReturnLoanQuery(loanNO);
            loansDataGridView.Refresh();
            loansBindingSource.DataSource = loansTableAdapter.GetData();
            loansBindingSource.ResetBindings(false);

            //updating available equipment table
            equipmentDataGridView1.Refresh();
            equipmentBindingSource2.DataSource = equipmentTableAdapter1.GetData();
            equipmentBindingSource2.ResetBindings(false);
        }
    }
}
