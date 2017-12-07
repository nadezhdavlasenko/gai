namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label positionCodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label resumeLinkLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label fullNameLabel1;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label positionCodeLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label numberOfVacanciesLabel;
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.CandidateTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            this.candidateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.candidateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.candidateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.positionCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.resumeLinkTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hiringContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hiringContractTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.HiringContractTableAdapter();
            this.hiringContractDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.PositionTableAdapter();
            this.positionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox1 = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.positionCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.numberOfVacanciesTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.candidateTableAdapter1 = new WindowsFormsApp1.DataSet1TableAdapters.CandidateTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MoveFirst = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.MovePrevious = new System.Windows.Forms.Button();
            this.MoveLast = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            positionCodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            resumeLinkLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            fullNameLabel1 = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            positionCodeLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            numberOfVacanciesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingNavigator)).BeginInit();
            this.candidateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiringContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiringContractDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "Candidate";
            this.candidateBindingSource.DataSource = this.dataSet1;
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CandidateTableAdapter = this.candidateTableAdapter;
            this.tableAdapterManager.HiringContractTableAdapter = this.hiringContractTableAdapter;
            this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // candidateBindingNavigator
            // 
            this.candidateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.candidateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.candidateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.candidateBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.candidateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.candidateBindingNavigatorSaveItem});
            this.candidateBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.candidateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.candidateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.candidateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.candidateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.candidateBindingNavigator.Name = "candidateBindingNavigator";
            this.candidateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.candidateBindingNavigator.Size = new System.Drawing.Size(2203, 39);
            this.candidateBindingNavigator.TabIndex = 0;
            this.candidateBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // candidateBindingNavigatorSaveItem
            // 
            this.candidateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.candidateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("candidateBindingNavigatorSaveItem.Image")));
            this.candidateBindingNavigatorSaveItem.Name = "candidateBindingNavigatorSaveItem";
            this.candidateBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.candidateBindingNavigatorSaveItem.Text = "Save Data";
            this.candidateBindingNavigatorSaveItem.Click += new System.EventHandler(this.candidateBindingNavigatorSaveItem_Click);
            // 
            // candidateDataGridView
            // 
            this.candidateDataGridView.AutoGenerateColumns = false;
            this.candidateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.candidateDataGridView.DataSource = this.candidateBindingSource;
            this.candidateDataGridView.Location = new System.Drawing.Point(30, 257);
            this.candidateDataGridView.Name = "candidateDataGridView";
            this.candidateDataGridView.RowTemplate.Height = 33;
            this.candidateDataGridView.Size = new System.Drawing.Size(1084, 390);
            this.candidateDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "positionCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "positionCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "phone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fullName";
            this.dataGridViewTextBoxColumn4.HeaderText = "fullName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "resumeLink";
            this.dataGridViewTextBoxColumn5.HeaderText = "resumeLink";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(25, 28);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(35, 25);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(181, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 31);
            this.idTextBox.TabIndex = 3;
            // 
            // positionCodeLabel
            // 
            positionCodeLabel.AutoSize = true;
            positionCodeLabel.Location = new System.Drawing.Point(25, 65);
            positionCodeLabel.Name = "positionCodeLabel";
            positionCodeLabel.Size = new System.Drawing.Size(150, 25);
            positionCodeLabel.TabIndex = 4;
            positionCodeLabel.Text = "position Code:";
            // 
            // positionCodeTextBox
            // 
            this.positionCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "positionCode", true));
            this.positionCodeTextBox.Location = new System.Drawing.Point(181, 62);
            this.positionCodeTextBox.Name = "positionCodeTextBox";
            this.positionCodeTextBox.Size = new System.Drawing.Size(100, 31);
            this.positionCodeTextBox.TabIndex = 5;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(25, 102);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(78, 25);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(181, 99);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 31);
            this.phoneTextBox.TabIndex = 7;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(25, 139);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(108, 25);
            fullNameLabel.TabIndex = 8;
            fullNameLabel.Text = "full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "fullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(181, 136);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 31);
            this.fullNameTextBox.TabIndex = 9;
            // 
            // resumeLinkLabel
            // 
            resumeLinkLabel.AutoSize = true;
            resumeLinkLabel.Location = new System.Drawing.Point(25, 175);
            resumeLinkLabel.Name = "resumeLinkLabel";
            resumeLinkLabel.Size = new System.Drawing.Size(135, 25);
            resumeLinkLabel.TabIndex = 10;
            resumeLinkLabel.Text = "resume Link:";
            // 
            // resumeLinkTextBox
            // 
            this.resumeLinkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "resumeLink", true));
            this.resumeLinkTextBox.Location = new System.Drawing.Point(181, 175);
            this.resumeLinkTextBox.Name = "resumeLinkTextBox";
            this.resumeLinkTextBox.Size = new System.Drawing.Size(100, 31);
            this.resumeLinkTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hiringContractBindingSource
            // 
            this.hiringContractBindingSource.DataMember = "HiringContract";
            this.hiringContractBindingSource.DataSource = this.dataSet1;
            // 
            // hiringContractTableAdapter
            // 
            this.hiringContractTableAdapter.ClearBeforeFill = true;
            // 
            // hiringContractDataGridView
            // 
            this.hiringContractDataGridView.AutoGenerateColumns = false;
            this.hiringContractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hiringContractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.hiringContractDataGridView.DataSource = this.hiringContractBindingSource;
            this.hiringContractDataGridView.Location = new System.Drawing.Point(27, 247);
            this.hiringContractDataGridView.Name = "hiringContractDataGridView";
            this.hiringContractDataGridView.RowTemplate.Height = 33;
            this.hiringContractDataGridView.Size = new System.Drawing.Size(1129, 391);
            this.hiringContractDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn6.HeaderText = "code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fullName";
            this.dataGridViewTextBoxColumn7.HeaderText = "fullName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn8.HeaderText = "position";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn9.HeaderText = "date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this.dataSet1;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // positionDataGridView
            // 
            this.positionDataGridView.AutoGenerateColumns = false;
            this.positionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.positionDataGridView.DataSource = this.positionBindingSource;
            this.positionDataGridView.Location = new System.Drawing.Point(6, 267);
            this.positionDataGridView.Name = "positionDataGridView";
            this.positionDataGridView.RowTemplate.Height = 33;
            this.positionDataGridView.Size = new System.Drawing.Size(1141, 380);
            this.positionDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "positionCode";
            this.dataGridViewTextBoxColumn10.HeaderText = "positionCode";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn11.HeaderText = "name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn12.HeaderText = "description";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "numberOfVacancies";
            this.dataGridViewTextBoxColumn13.HeaderText = "numberOfVacancies";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(22, 37);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(65, 25);
            codeLabel.TabIndex = 16;
            codeLabel.Text = "code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiringContractBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(136, 34);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(200, 31);
            this.codeTextBox.TabIndex = 17;
            // 
            // fullNameLabel1
            // 
            fullNameLabel1.AutoSize = true;
            fullNameLabel1.Location = new System.Drawing.Point(22, 74);
            fullNameLabel1.Name = "fullNameLabel1";
            fullNameLabel1.Size = new System.Drawing.Size(108, 25);
            fullNameLabel1.TabIndex = 18;
            fullNameLabel1.Text = "full Name:";
            // 
            // fullNameTextBox1
            // 
            this.fullNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiringContractBindingSource, "fullName", true));
            this.fullNameTextBox1.Location = new System.Drawing.Point(136, 71);
            this.fullNameTextBox1.Name = "fullNameTextBox1";
            this.fullNameTextBox1.Size = new System.Drawing.Size(200, 31);
            this.fullNameTextBox1.TabIndex = 19;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(22, 111);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(93, 25);
            positionLabel.TabIndex = 20;
            positionLabel.Text = "position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiringContractBindingSource, "position", true));
            this.positionTextBox.Location = new System.Drawing.Point(136, 108);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(200, 31);
            this.positionTextBox.TabIndex = 21;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(22, 149);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(60, 25);
            dateLabel.TabIndex = 22;
            dateLabel.Text = "date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hiringContractBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(136, 145);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.dateDateTimePicker.TabIndex = 23;
            // 
            // positionCodeLabel1
            // 
            positionCodeLabel1.AutoSize = true;
            positionCodeLabel1.Location = new System.Drawing.Point(17, 35);
            positionCodeLabel1.Name = "positionCodeLabel1";
            positionCodeLabel1.Size = new System.Drawing.Size(150, 25);
            positionCodeLabel1.TabIndex = 24;
            positionCodeLabel1.Text = "position Code:";
            // 
            // positionCodeTextBox1
            // 
            this.positionCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "positionCode", true));
            this.positionCodeTextBox1.Location = new System.Drawing.Point(247, 32);
            this.positionCodeTextBox1.Name = "positionCodeTextBox1";
            this.positionCodeTextBox1.Size = new System.Drawing.Size(100, 31);
            this.positionCodeTextBox1.TabIndex = 25;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 72);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(71, 25);
            nameLabel.TabIndex = 26;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(247, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 31);
            this.nameTextBox.TabIndex = 27;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(17, 109);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(123, 25);
            descriptionLabel.TabIndex = 28;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(247, 106);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 31);
            this.descriptionTextBox.TabIndex = 29;
            // 
            // numberOfVacanciesLabel
            // 
            numberOfVacanciesLabel.AutoSize = true;
            numberOfVacanciesLabel.Location = new System.Drawing.Point(17, 146);
            numberOfVacanciesLabel.Name = "numberOfVacanciesLabel";
            numberOfVacanciesLabel.Size = new System.Drawing.Size(224, 25);
            numberOfVacanciesLabel.TabIndex = 30;
            numberOfVacanciesLabel.Text = "number Of Vacancies:";
            // 
            // numberOfVacanciesTextBox
            // 
            this.numberOfVacanciesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "numberOfVacancies", true));
            this.numberOfVacanciesTextBox.Location = new System.Drawing.Point(247, 143);
            this.numberOfVacanciesTextBox.Name = "numberOfVacanciesTextBox";
            this.numberOfVacanciesTextBox.Size = new System.Drawing.Size(100, 31);
            this.numberOfVacanciesTextBox.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 40);
            this.button3.TabIndex = 32;
            this.button3.Text = "new record";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(389, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 40);
            this.button4.TabIndex = 33;
            this.button4.Text = "new record";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 40);
            this.button5.TabIndex = 34;
            this.button5.Text = "save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(389, 78);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 40);
            this.button6.TabIndex = 35;
            this.button6.Text = "save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(343, 119);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(157, 45);
            this.delete.TabIndex = 36;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(388, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 45);
            this.button7.TabIndex = 37;
            this.button7.Text = "delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(358, 127);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(157, 45);
            this.button8.TabIndex = 38;
            this.button8.Text = "delete";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // candidateTableAdapter1
            // 
            this.candidateTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2191, 700);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MoveLast);
            this.tabPage1.Controls.Add(this.MovePrevious);
            this.tabPage1.Controls.Add(this.MoveNext);
            this.tabPage1.Controls.Add(this.MoveFirst);
            this.tabPage1.Controls.Add(this.candidateDataGridView);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.resumeLinkTextBox);
            this.tabPage1.Controls.Add(this.delete);
            this.tabPage1.Controls.Add(resumeLinkLabel);
            this.tabPage1.Controls.Add(this.fullNameTextBox);
            this.tabPage1.Controls.Add(fullNameLabel);
            this.tabPage1.Controls.Add(this.phoneTextBox);
            this.tabPage1.Controls.Add(phoneLabel);
            this.tabPage1.Controls.Add(this.positionCodeTextBox);
            this.tabPage1.Controls.Add(positionCodeLabel);
            this.tabPage1.Controls.Add(this.idTextBox);
            this.tabPage1.Controls.Add(idLabel);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2175, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Candidate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.codeTextBox);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.hiringContractDataGridView);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dateDateTimePicker);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(dateLabel);
            this.tabPage2.Controls.Add(codeLabel);
            this.tabPage2.Controls.Add(this.positionTextBox);
            this.tabPage2.Controls.Add(positionLabel);
            this.tabPage2.Controls.Add(fullNameLabel1);
            this.tabPage2.Controls.Add(this.fullNameTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2175, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hiring contract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button13);
            this.tabPage3.Controls.Add(this.button14);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.button16);
            this.tabPage3.Controls.Add(this.positionDataGridView);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.numberOfVacanciesTextBox);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(numberOfVacanciesLabel);
            this.tabPage3.Controls.Add(this.descriptionTextBox);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(descriptionLabel);
            this.tabPage3.Controls.Add(this.nameTextBox);
            this.tabPage3.Controls.Add(positionCodeLabel1);
            this.tabPage3.Controls.Add(nameLabel);
            this.tabPage3.Controls.Add(this.positionCodeTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(2175, 653);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Position";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MoveFirst
            // 
            this.MoveFirst.Location = new System.Drawing.Point(566, 62);
            this.MoveFirst.Name = "MoveFirst";
            this.MoveFirst.Size = new System.Drawing.Size(130, 46);
            this.MoveFirst.TabIndex = 37;
            this.MoveFirst.Text = "MoveFirst";
            this.MoveFirst.UseVisualStyleBackColor = true;
            this.MoveFirst.Click += new System.EventHandler(this.MoveFirst_Click);
            // 
            // MoveNext
            // 
            this.MoveNext.Location = new System.Drawing.Point(737, 118);
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.Size = new System.Drawing.Size(170, 46);
            this.MoveNext.TabIndex = 39;
            this.MoveNext.Text = "MoveNext";
            this.MoveNext.UseVisualStyleBackColor = true;
            this.MoveNext.Click += new System.EventHandler(this.MoveNext_Click);
            // 
            // MovePrevious
            // 
            this.MovePrevious.Location = new System.Drawing.Point(737, 62);
            this.MovePrevious.Name = "MovePrevious";
            this.MovePrevious.Size = new System.Drawing.Size(170, 46);
            this.MovePrevious.TabIndex = 40;
            this.MovePrevious.Text = "MovePrevious";
            this.MovePrevious.UseVisualStyleBackColor = true;
            this.MovePrevious.Click += new System.EventHandler(this.button11_Click);
            // 
            // MoveLast
            // 
            this.MoveLast.Location = new System.Drawing.Point(566, 118);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(130, 46);
            this.MoveLast.TabIndex = 41;
            this.MoveLast.Text = "MoveLast";
            this.MoveLast.UseVisualStyleBackColor = true;
            this.MoveLast.Click += new System.EventHandler(this.MoveLast_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(595, 127);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 46);
            this.button9.TabIndex = 45;
            this.button9.Text = "MoveLast";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(766, 71);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(170, 46);
            this.button10.TabIndex = 44;
            this.button10.Text = "MovePrevious";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(766, 127);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(170, 46);
            this.button11.TabIndex = 43;
            this.button11.Text = "MoveNext";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(595, 71);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(130, 46);
            this.button12.TabIndex = 42;
            this.button12.Text = "MoveFirst";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(652, 134);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(130, 46);
            this.button13.TabIndex = 45;
            this.button13.Text = "MoveLast";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(823, 78);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(170, 46);
            this.button14.TabIndex = 44;
            this.button14.Text = "MovePrevious";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(823, 134);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(170, 46);
            this.button15.TabIndex = 43;
            this.button15.Text = "MoveNext";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(652, 78);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(130, 46);
            this.button16.TabIndex = 42;
            this.button16.Text = "MoveFirst";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2203, 784);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.candidateBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingNavigator)).EndInit();
            this.candidateBindingNavigator.ResumeLayout(false);
            this.candidateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiringContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiringContractDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private DataSet1TableAdapters.CandidateTableAdapter candidateTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator candidateBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton candidateBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView candidateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox positionCodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox resumeLinkTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataSet1TableAdapters.HiringContractTableAdapter hiringContractTableAdapter;
        private System.Windows.Forms.BindingSource hiringContractBindingSource;
        private DataSet1TableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.DataGridView hiringContractDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private System.Windows.Forms.DataGridView positionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox1;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox positionCodeTextBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox numberOfVacanciesTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private DataSet1TableAdapters.CandidateTableAdapter candidateTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button MoveFirst;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button MovePrevious;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

