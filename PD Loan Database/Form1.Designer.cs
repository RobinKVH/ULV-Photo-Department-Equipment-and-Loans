namespace PD_Loan_Database
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label loanedDateLabel;
            System.Windows.Forms.Label studentidLabel1;
            System.Windows.Forms.Label equipmentidLabel1;
            System.Windows.Forms.Label serialNoLabel1;
            System.Windows.Forms.Label lastNameLabel1;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label serialNoLabel;
            System.Windows.Forms.Label studentIDLabel2;
            System.Windows.Forms.Label lastNameLabel2;
            System.Windows.Forms.Label firstNameLabel2;
            System.Windows.Forms.Label contantNoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label equipmentIDLabel2;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label serialNoLabel2;
            System.Windows.Forms.Label nameLabel2;
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.returnTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.loansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoDepartmentDataSet = new PD_Loan_Database.PhotoDepartmentDataSet();
            this.loansDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameTextBox1 = new System.Windows.Forms.TextBox();
            this.lastNameTextBox1 = new System.Windows.Forms.TextBox();
            this.serialNoTextBox1 = new System.Windows.Forms.TextBox();
            this.equipmentidTextBox1 = new System.Windows.Forms.TextBox();
            this.studentidTextBox1 = new System.Windows.Forms.TextBox();
            this.loanedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnButton = new System.Windows.Forms.Button();
            this.loanNoTextBox = new System.Windows.Forms.TextBox();
            this.loanTabPage = new System.Windows.Forms.TabPage();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.photoDepartmentDataSet1 = new PD_Loan_Database.PhotoDepartmentDataSet1();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.equipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.equipmentDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contantNoTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox2 = new System.Windows.Forms.TextBox();
            this.lastNameTextBox2 = new System.Windows.Forms.TextBox();
            this.studentIDTextBox2 = new System.Windows.Forms.TextBox();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.equipmentTabPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialNoTextBox2 = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.equipmentIDTextBox2 = new System.Windows.Forms.TextBox();
            this.equipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeEquipmentButton = new System.Windows.Forms.Button();
            this.addEquipmentButton = new System.Windows.Forms.Button();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loanedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loansTableAdapter = new PD_Loan_Database.PhotoDepartmentDataSetTableAdapters.LoansTableAdapter();
            this.tableAdapterManager = new PD_Loan_Database.PhotoDepartmentDataSetTableAdapters.TableAdapterManager();
            this.equipmentTableAdapter = new PD_Loan_Database.PhotoDepartmentDataSetTableAdapters.EquipmentTableAdapter();
            this.studentsTableAdapter = new PD_Loan_Database.PhotoDepartmentDataSetTableAdapters.StudentsTableAdapter();
            this.historyTableAdapter = new PD_Loan_Database.PhotoDepartmentDataSetTableAdapters.HistoryTableAdapter();
            this.equipmentTableAdapter1 = new PD_Loan_Database.PhotoDepartmentDataSet1TableAdapters.EquipmentTableAdapter();
            this.tableAdapterManager1 = new PD_Loan_Database.PhotoDepartmentDataSet1TableAdapters.TableAdapterManager();
            loanedDateLabel = new System.Windows.Forms.Label();
            studentidLabel1 = new System.Windows.Forms.Label();
            equipmentidLabel1 = new System.Windows.Forms.Label();
            serialNoLabel1 = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            firstNameLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            equipmentIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            serialNoLabel = new System.Windows.Forms.Label();
            studentIDLabel2 = new System.Windows.Forms.Label();
            lastNameLabel2 = new System.Windows.Forms.Label();
            firstNameLabel2 = new System.Windows.Forms.Label();
            contantNoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            equipmentIDLabel2 = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            serialNoLabel2 = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.returnTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).BeginInit();
            this.loanTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoDepartmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView1)).BeginInit();
            this.studentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.equipmentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).BeginInit();
            this.historyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // loanedDateLabel
            // 
            loanedDateLabel.AutoSize = true;
            loanedDateLabel.Location = new System.Drawing.Point(548, 481);
            loanedDateLabel.Name = "loanedDateLabel";
            loanedDateLabel.Size = new System.Drawing.Size(72, 13);
            loanedDateLabel.TabIndex = 2;
            loanedDateLabel.Text = "Loaned Date:";
            // 
            // studentidLabel1
            // 
            studentidLabel1.AutoSize = true;
            studentidLabel1.Location = new System.Drawing.Point(700, 388);
            studentidLabel1.Name = "studentidLabel1";
            studentidLabel1.Size = new System.Drawing.Size(61, 13);
            studentidLabel1.TabIndex = 4;
            studentidLabel1.Text = "Student ID:";
            // 
            // equipmentidLabel1
            // 
            equipmentidLabel1.AutoSize = true;
            equipmentidLabel1.Location = new System.Drawing.Point(383, 388);
            equipmentidLabel1.Name = "equipmentidLabel1";
            equipmentidLabel1.Size = new System.Drawing.Size(77, 13);
            equipmentidLabel1.TabIndex = 6;
            equipmentidLabel1.Text = "Equipment ID: ";
            // 
            // serialNoLabel1
            // 
            serialNoLabel1.AutoSize = true;
            serialNoLabel1.Location = new System.Drawing.Point(402, 440);
            serialNoLabel1.Name = "serialNoLabel1";
            serialNoLabel1.Size = new System.Drawing.Size(53, 13);
            serialNoLabel1.TabIndex = 8;
            serialNoLabel1.Text = "Serial No:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(700, 414);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(61, 13);
            lastNameLabel1.TabIndex = 10;
            lastNameLabel1.Text = "Last Name:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(701, 440);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(60, 13);
            firstNameLabel1.TabIndex = 12;
            firstNameLabel1.Text = "First Name:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(364, 414);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(91, 13);
            nameLabel1.TabIndex = 14;
            nameLabel1.Text = "Equipment Name:";
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(611, 456);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(74, 13);
            equipmentIDLabel.TabIndex = 16;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(647, 482);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Name:";
            // 
            // serialNoLabel
            // 
            serialNoLabel.AutoSize = true;
            serialNoLabel.Location = new System.Drawing.Point(632, 508);
            serialNoLabel.Name = "serialNoLabel";
            serialNoLabel.Size = new System.Drawing.Size(53, 13);
            serialNoLabel.TabIndex = 18;
            serialNoLabel.Text = "Serial No:";
            // 
            // studentIDLabel2
            // 
            studentIDLabel2.AutoSize = true;
            studentIDLabel2.Location = new System.Drawing.Point(663, 133);
            studentIDLabel2.Name = "studentIDLabel2";
            studentIDLabel2.Size = new System.Drawing.Size(61, 13);
            studentIDLabel2.TabIndex = 3;
            studentIDLabel2.Text = "Student ID:";
            // 
            // lastNameLabel2
            // 
            lastNameLabel2.AutoSize = true;
            lastNameLabel2.Location = new System.Drawing.Point(663, 159);
            lastNameLabel2.Name = "lastNameLabel2";
            lastNameLabel2.Size = new System.Drawing.Size(61, 13);
            lastNameLabel2.TabIndex = 5;
            lastNameLabel2.Text = "Last Name:";
            // 
            // firstNameLabel2
            // 
            firstNameLabel2.AutoSize = true;
            firstNameLabel2.Location = new System.Drawing.Point(665, 185);
            firstNameLabel2.Name = "firstNameLabel2";
            firstNameLabel2.Size = new System.Drawing.Size(60, 13);
            firstNameLabel2.TabIndex = 7;
            firstNameLabel2.Text = "First Name:";
            // 
            // contantNoLabel
            // 
            contantNoLabel.AutoSize = true;
            contantNoLabel.Location = new System.Drawing.Point(661, 211);
            contantNoLabel.Name = "contantNoLabel";
            contantNoLabel.Size = new System.Drawing.Size(64, 13);
            contantNoLabel.TabIndex = 9;
            contantNoLabel.Text = "Contant No:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(690, 237);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // equipmentIDLabel2
            // 
            equipmentIDLabel2.AutoSize = true;
            equipmentIDLabel2.Location = new System.Drawing.Point(562, 135);
            equipmentIDLabel2.Name = "equipmentIDLabel2";
            equipmentIDLabel2.Size = new System.Drawing.Size(74, 13);
            equipmentIDLabel2.TabIndex = 3;
            equipmentIDLabel2.Text = "Equipment ID:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(602, 187);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "Type:";
            // 
            // serialNoLabel2
            // 
            serialNoLabel2.AutoSize = true;
            serialNoLabel2.Location = new System.Drawing.Point(583, 213);
            serialNoLabel2.Name = "serialNoLabel2";
            serialNoLabel2.Size = new System.Drawing.Size(53, 13);
            serialNoLabel2.TabIndex = 7;
            serialNoLabel2.Text = "Serial No:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(598, 161);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(38, 13);
            nameLabel2.TabIndex = 9;
            nameLabel2.Text = "Name:";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(21, 452);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(61, 13);
            this.studentIDLabel.TabIndex = 2;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(21, 478);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(22, 504);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.returnTabPage);
            this.tabControl1.Controls.Add(this.loanTabPage);
            this.tabControl1.Controls.Add(this.studentTabPage);
            this.tabControl1.Controls.Add(this.equipmentTabPage);
            this.tabControl1.Controls.Add(this.historyTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // returnTabPage
            // 
            this.returnTabPage.AutoScroll = true;
            this.returnTabPage.Controls.Add(this.label3);
            this.returnTabPage.Controls.Add(nameLabel1);
            this.returnTabPage.Controls.Add(this.nameTextBox1);
            this.returnTabPage.Controls.Add(this.loansDataGridView);
            this.returnTabPage.Controls.Add(firstNameLabel1);
            this.returnTabPage.Controls.Add(this.firstNameTextBox1);
            this.returnTabPage.Controls.Add(lastNameLabel1);
            this.returnTabPage.Controls.Add(this.lastNameTextBox1);
            this.returnTabPage.Controls.Add(serialNoLabel1);
            this.returnTabPage.Controls.Add(this.serialNoTextBox1);
            this.returnTabPage.Controls.Add(equipmentidLabel1);
            this.returnTabPage.Controls.Add(this.equipmentidTextBox1);
            this.returnTabPage.Controls.Add(studentidLabel1);
            this.returnTabPage.Controls.Add(this.studentidTextBox1);
            this.returnTabPage.Controls.Add(loanedDateLabel);
            this.returnTabPage.Controls.Add(this.loanedDateDateTimePicker);
            this.returnTabPage.Controls.Add(this.returnButton);
            this.returnTabPage.Controls.Add(this.loanNoTextBox);
            this.returnTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTabPage.Location = new System.Drawing.Point(4, 29);
            this.returnTabPage.Name = "returnTabPage";
            this.returnTabPage.Size = new System.Drawing.Size(1002, 537);
            this.returnTabPage.TabIndex = 3;
            this.returnTabPage.Text = "| Return |";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(641, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Selected Loan";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(461, 411);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.ReadOnly = true;
            this.nameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox1.TabIndex = 15;
            // 
            // loansBindingSource
            // 
            this.loansBindingSource.DataMember = "Loans";
            this.loansBindingSource.DataSource = this.photoDepartmentDataSet;
            // 
            // photoDepartmentDataSet
            // 
            this.photoDepartmentDataSet.DataSetName = "PhotoDepartmentDataSet";
            this.photoDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loansDataGridView
            // 
            this.loansDataGridView.AutoGenerateColumns = false;
            this.loansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn15});
            this.loansDataGridView.DataSource = this.loansBindingSource;
            this.loansDataGridView.Location = new System.Drawing.Point(0, 0);
            this.loansDataGridView.Name = "loansDataGridView";
            this.loansDataGridView.ReadOnly = true;
            this.loansDataGridView.Size = new System.Drawing.Size(806, 287);
            this.loansDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn21.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn22.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "studentid";
            this.dataGridViewTextBoxColumn16.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn24.HeaderText = "Equipment Name";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 120;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "equipmentid";
            this.dataGridViewTextBoxColumn17.HeaderText = "Equipment ID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "SerialNo";
            this.dataGridViewTextBoxColumn18.HeaderText = "Serial #";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "LoanNo";
            this.dataGridViewTextBoxColumn23.HeaderText = "LoanNo";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "LoanedDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "Loaned Date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 140;
            // 
            // firstNameTextBox1
            // 
            this.firstNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "FirstName", true));
            this.firstNameTextBox1.Location = new System.Drawing.Point(767, 437);
            this.firstNameTextBox1.Name = "firstNameTextBox1";
            this.firstNameTextBox1.ReadOnly = true;
            this.firstNameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox1.TabIndex = 13;
            // 
            // lastNameTextBox1
            // 
            this.lastNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "LastName", true));
            this.lastNameTextBox1.Location = new System.Drawing.Point(767, 411);
            this.lastNameTextBox1.Name = "lastNameTextBox1";
            this.lastNameTextBox1.ReadOnly = true;
            this.lastNameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox1.TabIndex = 11;
            // 
            // serialNoTextBox1
            // 
            this.serialNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "SerialNo", true));
            this.serialNoTextBox1.Location = new System.Drawing.Point(461, 437);
            this.serialNoTextBox1.Name = "serialNoTextBox1";
            this.serialNoTextBox1.ReadOnly = true;
            this.serialNoTextBox1.Size = new System.Drawing.Size(200, 20);
            this.serialNoTextBox1.TabIndex = 9;
            // 
            // equipmentidTextBox1
            // 
            this.equipmentidTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "equipmentid", true));
            this.equipmentidTextBox1.Location = new System.Drawing.Point(461, 385);
            this.equipmentidTextBox1.Name = "equipmentidTextBox1";
            this.equipmentidTextBox1.ReadOnly = true;
            this.equipmentidTextBox1.Size = new System.Drawing.Size(200, 20);
            this.equipmentidTextBox1.TabIndex = 7;
            // 
            // studentidTextBox1
            // 
            this.studentidTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "studentid", true));
            this.studentidTextBox1.Location = new System.Drawing.Point(767, 385);
            this.studentidTextBox1.Name = "studentidTextBox1";
            this.studentidTextBox1.ReadOnly = true;
            this.studentidTextBox1.Size = new System.Drawing.Size(200, 20);
            this.studentidTextBox1.TabIndex = 5;
            // 
            // loanedDateDateTimePicker
            // 
            this.loanedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loansBindingSource, "LoanedDate", true));
            this.loanedDateDateTimePicker.Location = new System.Drawing.Point(626, 477);
            this.loanedDateDateTimePicker.Name = "loanedDateDateTimePicker";
            this.loanedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.loanedDateDateTimePicker.TabIndex = 3;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(84, 388);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(247, 72);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return Equipment";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // loanNoTextBox
            // 
            this.loanNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "LoanNo", true));
            this.loanNoTextBox.Location = new System.Drawing.Point(116, 413);
            this.loanNoTextBox.Name = "loanNoTextBox";
            this.loanNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.loanNoTextBox.TabIndex = 17;
            // 
            // loanTabPage
            // 
            this.loanTabPage.AutoScroll = true;
            this.loanTabPage.Controls.Add(serialNoLabel);
            this.loanTabPage.Controls.Add(this.serialNoTextBox);
            this.loanTabPage.Controls.Add(nameLabel);
            this.loanTabPage.Controls.Add(this.nameTextBox);
            this.loanTabPage.Controls.Add(equipmentIDLabel);
            this.loanTabPage.Controls.Add(this.equipmentIDTextBox);
            this.loanTabPage.Controls.Add(this.equipmentDataGridView1);
            this.loanTabPage.Controls.Add(this.checkOutButton);
            this.loanTabPage.Controls.Add(this.label2);
            this.loanTabPage.Controls.Add(this.label1);
            this.loanTabPage.Controls.Add(this.firstNameLabel);
            this.loanTabPage.Controls.Add(this.firstNameTextBox);
            this.loanTabPage.Controls.Add(this.lastNameLabel);
            this.loanTabPage.Controls.Add(this.lastNameTextBox);
            this.loanTabPage.Controls.Add(this.studentIDLabel);
            this.loanTabPage.Controls.Add(this.studentIDTextBox);
            this.loanTabPage.Controls.Add(this.studentsDataGridView1);
            this.loanTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTabPage.Location = new System.Drawing.Point(4, 29);
            this.loanTabPage.Name = "loanTabPage";
            this.loanTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loanTabPage.Size = new System.Drawing.Size(1002, 537);
            this.loanTabPage.TabIndex = 0;
            this.loanTabPage.Text = "| Loan |";
            this.loanTabPage.UseVisualStyleBackColor = true;
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource2, "SerialNo", true));
            this.serialNoTextBox.Location = new System.Drawing.Point(691, 505);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.ReadOnly = true;
            this.serialNoTextBox.Size = new System.Drawing.Size(181, 20);
            this.serialNoTextBox.TabIndex = 19;
            // 
            // equipmentBindingSource2
            // 
            this.equipmentBindingSource2.DataMember = "Equipment";
            this.equipmentBindingSource2.DataSource = this.photoDepartmentDataSet1;
            // 
            // photoDepartmentDataSet1
            // 
            this.photoDepartmentDataSet1.DataSetName = "PhotoDepartmentDataSet1";
            this.photoDepartmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource2, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(691, 479);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(181, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // equipmentIDTextBox
            // 
            this.equipmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource2, "EquipmentID", true));
            this.equipmentIDTextBox.Location = new System.Drawing.Point(691, 453);
            this.equipmentIDTextBox.Name = "equipmentIDTextBox";
            this.equipmentIDTextBox.ReadOnly = true;
            this.equipmentIDTextBox.Size = new System.Drawing.Size(181, 20);
            this.equipmentIDTextBox.TabIndex = 17;
            // 
            // equipmentDataGridView1
            // 
            this.equipmentDataGridView1.AutoGenerateColumns = false;
            this.equipmentDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.equipmentDataGridView1.DataSource = this.equipmentBindingSource2;
            this.equipmentDataGridView1.Location = new System.Drawing.Point(517, 0);
            this.equipmentDataGridView1.Name = "equipmentDataGridView1";
            this.equipmentDataGridView1.ReadOnly = true;
            this.equipmentDataGridView1.Size = new System.Drawing.Size(485, 400);
            this.equipmentDataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Equipment Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EquipmentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Equipment ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SerialNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serial #";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutButton.Location = new System.Drawing.Point(325, 449);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(212, 51);
            this.checkOutButton.TabIndex = 16;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selected Equipment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selected Student";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(88, 501);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.photoDepartmentDataSet;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(88, 475);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(88, 449);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(181, 20);
            this.studentIDTextBox.TabIndex = 3;
            // 
            // studentsDataGridView1
            // 
            this.studentsDataGridView1.AutoGenerateColumns = false;
            this.studentsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.studentsDataGridView1.DataSource = this.studentsBindingSource;
            this.studentsDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.studentsDataGridView1.Name = "studentsDataGridView1";
            this.studentsDataGridView1.ReadOnly = true;
            this.studentsDataGridView1.Size = new System.Drawing.Size(344, 401);
            this.studentsDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn12.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn13.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn14.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // studentTabPage
            // 
            this.studentTabPage.AutoScroll = true;
            this.studentTabPage.Controls.Add(this.label4);
            this.studentTabPage.Controls.Add(emailLabel);
            this.studentTabPage.Controls.Add(this.emailTextBox);
            this.studentTabPage.Controls.Add(contantNoLabel);
            this.studentTabPage.Controls.Add(this.contantNoTextBox);
            this.studentTabPage.Controls.Add(firstNameLabel2);
            this.studentTabPage.Controls.Add(this.firstNameTextBox2);
            this.studentTabPage.Controls.Add(lastNameLabel2);
            this.studentTabPage.Controls.Add(this.lastNameTextBox2);
            this.studentTabPage.Controls.Add(studentIDLabel2);
            this.studentTabPage.Controls.Add(this.studentIDTextBox2);
            this.studentTabPage.Controls.Add(this.studentsDataGridView);
            this.studentTabPage.Controls.Add(this.removeStudentButton);
            this.studentTabPage.Controls.Add(this.addStudentButton);
            this.studentTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTabPage.Location = new System.Drawing.Point(4, 29);
            this.studentTabPage.Name = "studentTabPage";
            this.studentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentTabPage.Size = new System.Drawing.Size(1002, 537);
            this.studentTabPage.TabIndex = 1;
            this.studentTabPage.Text = "| Students |";
            this.studentTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(708, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Selected Student";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(731, 234);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(173, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // contantNoTextBox
            // 
            this.contantNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "ContantNo", true));
            this.contantNoTextBox.Location = new System.Drawing.Point(731, 208);
            this.contantNoTextBox.Name = "contantNoTextBox";
            this.contantNoTextBox.ReadOnly = true;
            this.contantNoTextBox.Size = new System.Drawing.Size(173, 20);
            this.contantNoTextBox.TabIndex = 10;
            // 
            // firstNameTextBox2
            // 
            this.firstNameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FirstName", true));
            this.firstNameTextBox2.Location = new System.Drawing.Point(731, 182);
            this.firstNameTextBox2.Name = "firstNameTextBox2";
            this.firstNameTextBox2.ReadOnly = true;
            this.firstNameTextBox2.Size = new System.Drawing.Size(173, 20);
            this.firstNameTextBox2.TabIndex = 8;
            // 
            // lastNameTextBox2
            // 
            this.lastNameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "LastName", true));
            this.lastNameTextBox2.Location = new System.Drawing.Point(730, 156);
            this.lastNameTextBox2.Name = "lastNameTextBox2";
            this.lastNameTextBox2.ReadOnly = true;
            this.lastNameTextBox2.Size = new System.Drawing.Size(174, 20);
            this.lastNameTextBox2.TabIndex = 6;
            // 
            // studentIDTextBox2
            // 
            this.studentIDTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentID", true));
            this.studentIDTextBox2.Location = new System.Drawing.Point(730, 130);
            this.studentIDTextBox2.Name = "studentIDTextBox2";
            this.studentIDTextBox2.ReadOnly = true;
            this.studentIDTextBox2.Size = new System.Drawing.Size(174, 20);
            this.studentIDTextBox2.TabIndex = 4;
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.Size = new System.Drawing.Size(604, 537);
            this.studentsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn7.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ContantNo";
            this.dataGridViewTextBoxColumn19.HeaderText = "Contant #";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn20.HeaderText = "Email";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 160;
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStudentButton.Location = new System.Drawing.Point(684, 440);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(253, 61);
            this.removeStudentButton.TabIndex = 2;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(684, 348);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(253, 61);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // equipmentTabPage
            // 
            this.equipmentTabPage.Controls.Add(this.label5);
            this.equipmentTabPage.Controls.Add(nameLabel2);
            this.equipmentTabPage.Controls.Add(this.nameTextBox2);
            this.equipmentTabPage.Controls.Add(serialNoLabel2);
            this.equipmentTabPage.Controls.Add(this.serialNoTextBox2);
            this.equipmentTabPage.Controls.Add(typeLabel);
            this.equipmentTabPage.Controls.Add(this.typeTextBox);
            this.equipmentTabPage.Controls.Add(equipmentIDLabel2);
            this.equipmentTabPage.Controls.Add(this.equipmentIDTextBox2);
            this.equipmentTabPage.Controls.Add(this.equipmentDataGridView);
            this.equipmentTabPage.Controls.Add(this.removeEquipmentButton);
            this.equipmentTabPage.Controls.Add(this.addEquipmentButton);
            this.equipmentTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentTabPage.Location = new System.Drawing.Point(4, 29);
            this.equipmentTabPage.Name = "equipmentTabPage";
            this.equipmentTabPage.Size = new System.Drawing.Size(1002, 537);
            this.equipmentTabPage.TabIndex = 2;
            this.equipmentTabPage.Text = "| Equipment |";
            this.equipmentTabPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(618, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selected Equipment";
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Name", true));
            this.nameTextBox2.Location = new System.Drawing.Point(642, 158);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.ReadOnly = true;
            this.nameTextBox2.Size = new System.Drawing.Size(182, 20);
            this.nameTextBox2.TabIndex = 10;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.photoDepartmentDataSet;
            // 
            // serialNoTextBox2
            // 
            this.serialNoTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "SerialNo", true));
            this.serialNoTextBox2.Location = new System.Drawing.Point(642, 210);
            this.serialNoTextBox2.Name = "serialNoTextBox2";
            this.serialNoTextBox2.ReadOnly = true;
            this.serialNoTextBox2.Size = new System.Drawing.Size(182, 20);
            this.serialNoTextBox2.TabIndex = 8;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(642, 184);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(182, 20);
            this.typeTextBox.TabIndex = 6;
            // 
            // equipmentIDTextBox2
            // 
            this.equipmentIDTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentID", true));
            this.equipmentIDTextBox2.Location = new System.Drawing.Point(642, 132);
            this.equipmentIDTextBox2.Name = "equipmentIDTextBox2";
            this.equipmentIDTextBox2.ReadOnly = true;
            this.equipmentIDTextBox2.Size = new System.Drawing.Size(182, 20);
            this.equipmentIDTextBox2.TabIndex = 4;
            // 
            // equipmentDataGridView
            // 
            this.equipmentDataGridView.AutoGenerateColumns = false;
            this.equipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.equipmentDataGridView.DataSource = this.equipmentBindingSource;
            this.equipmentDataGridView.Location = new System.Drawing.Point(0, 3);
            this.equipmentDataGridView.Name = "equipmentDataGridView";
            this.equipmentDataGridView.ReadOnly = true;
            this.equipmentDataGridView.Size = new System.Drawing.Size(444, 534);
            this.equipmentDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Equipment";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EquipmentID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Equipment ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn9.HeaderText = "Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SerialNo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Serial #";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // removeEquipmentButton
            // 
            this.removeEquipmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEquipmentButton.Location = new System.Drawing.Point(565, 410);
            this.removeEquipmentButton.Name = "removeEquipmentButton";
            this.removeEquipmentButton.Size = new System.Drawing.Size(310, 68);
            this.removeEquipmentButton.TabIndex = 2;
            this.removeEquipmentButton.Text = "Remove Equipment";
            this.removeEquipmentButton.UseVisualStyleBackColor = true;
            this.removeEquipmentButton.Click += new System.EventHandler(this.removeEquipmentButton_Click);
            // 
            // addEquipmentButton
            // 
            this.addEquipmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEquipmentButton.Location = new System.Drawing.Point(565, 317);
            this.addEquipmentButton.Name = "addEquipmentButton";
            this.addEquipmentButton.Size = new System.Drawing.Size(310, 68);
            this.addEquipmentButton.TabIndex = 1;
            this.addEquipmentButton.Text = "Add Equipment";
            this.addEquipmentButton.UseVisualStyleBackColor = true;
            this.addEquipmentButton.Click += new System.EventHandler(this.addEquipmentButton_Click);
            // 
            // historyTabPage
            // 
            this.historyTabPage.Controls.Add(this.historyDataGridView);
            this.historyTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyTabPage.Location = new System.Drawing.Point(4, 29);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(1002, 537);
            this.historyTabPage.TabIndex = 4;
            this.historyTabPage.Text = "| Past Loans |";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AutoGenerateColumns = false;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn25});
            this.historyDataGridView.DataSource = this.historyBindingSource;
            this.historyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.ReadOnly = true;
            this.historyDataGridView.Size = new System.Drawing.Size(999, 519);
            this.historyDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn33.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 120;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn32.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 120;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn28.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 120;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "EquipmentId";
            this.dataGridViewTextBoxColumn29.HeaderText = "Equipment ID";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "SerialNo";
            this.dataGridViewTextBoxColumn34.HeaderText = "Serial #";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "LoanedDate";
            this.dataGridViewTextBoxColumn30.HeaderText = "Loaned Date";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 130;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "ReturnDate";
            this.dataGridViewTextBoxColumn31.HeaderText = "Return Date";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 130;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "LoanHistoryNo";
            this.dataGridViewTextBoxColumn25.HeaderText = "LoanHistoryNo";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.photoDepartmentDataSet;
            // 
            // loanedDateDataGridViewTextBoxColumn
            // 
            this.loanedDateDataGridViewTextBoxColumn.DataPropertyName = "LoanedDate";
            this.loanedDateDataGridViewTextBoxColumn.HeaderText = "LoanedDate";
            this.loanedDateDataGridViewTextBoxColumn.Name = "loanedDateDataGridViewTextBoxColumn";
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "studentid";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "studentid";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // equipmentidDataGridViewTextBoxColumn
            // 
            this.equipmentidDataGridViewTextBoxColumn.DataPropertyName = "equipmentid";
            this.equipmentidDataGridViewTextBoxColumn.HeaderText = "equipmentid";
            this.equipmentidDataGridViewTextBoxColumn.Name = "equipmentidDataGridViewTextBoxColumn";
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // loansTableAdapter
            // 
            this.loansTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = this.equipmentTableAdapter;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PD_Loan_Database.PhotoDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter1
            // 
            this.equipmentTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EquipmentTableAdapter = this.equipmentTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = PD_Loan_Database.PhotoDepartmentDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 572);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ULV Photo Department Equipment and Loans";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.returnTabPage.ResumeLayout(false);
            this.returnTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).EndInit();
            this.loanTabPage.ResumeLayout(false);
            this.loanTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoDepartmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView1)).EndInit();
            this.studentTabPage.ResumeLayout(false);
            this.studentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.equipmentTabPage.ResumeLayout(false);
            this.equipmentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).EndInit();
            this.historyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loanTabPage;
        private System.Windows.Forms.TabPage studentTabPage;
        private System.Windows.Forms.TabPage equipmentTabPage;
        private PhotoDepartmentDataSet photoDepartmentDataSet;
        private System.Windows.Forms.BindingSource loansBindingSource;
        private PhotoDepartmentDataSetTableAdapters.LoansTableAdapter loansTableAdapter;
        private PhotoDepartmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PhotoDepartmentDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private PhotoDepartmentDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button removeEquipmentButton;
        private System.Windows.Forms.Button addEquipmentButton;
        private System.Windows.Forms.DataGridView equipmentDataGridView;
        private System.Windows.Forms.TabPage returnTabPage;
        private System.Windows.Forms.DataGridView studentsDataGridView1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.BindingSource equipmentBindingSource1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.TabPage historyTabPage;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox1;
        private System.Windows.Forms.TextBox lastNameTextBox1;
        private System.Windows.Forms.TextBox serialNoTextBox1;
        private System.Windows.Forms.TextBox equipmentidTextBox1;
        private System.Windows.Forms.TextBox studentidTextBox1;
        private System.Windows.Forms.DateTimePicker loanedDateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox loanNoTextBox;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.DataGridView loansDataGridView;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private PhotoDepartmentDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private PhotoDepartmentDataSet1 photoDepartmentDataSet1;
        private System.Windows.Forms.BindingSource equipmentBindingSource2;
        private PhotoDepartmentDataSet1TableAdapters.EquipmentTableAdapter equipmentTableAdapter1;
        private PhotoDepartmentDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView equipmentDataGridView1;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox equipmentIDTextBox;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contantNoTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox2;
        private System.Windows.Forms.TextBox lastNameTextBox2;
        private System.Windows.Forms.TextBox studentIDTextBox2;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.TextBox serialNoTextBox2;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox equipmentIDTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
    }
}

