namespace Adv_FinalProject
{
    partial class AdminForm
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
            this.CreateClient_Btn = new System.Windows.Forms.Button();
            this.CreateAdmin_Btn = new System.Windows.Forms.Button();
            this.Override2_Btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.AddMoney_tbox = new System.Windows.Forms.TextBox();
            this.AddMoney_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminRegistrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminLoginLoginIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPasswordPasswordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet2 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientRegistrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLoginLoginIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPasswordPasswordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsAdminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet3 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet3();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet1 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet1();
            this.adminsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet2TableAdapters.AdminsTableAdapter();
            this.clientsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet3TableAdapters.ClientsTableAdapter();
            this.finalProjectDBContextMyDbContextModelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSetTableAdapters.OrdersTableAdapter();
            this.productsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet1TableAdapters.ProductsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UpdTable_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDBContextMyDbContextModelDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateClient_Btn
            // 
            this.CreateClient_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateClient_Btn.Location = new System.Drawing.Point(1100, 179);
            this.CreateClient_Btn.Name = "CreateClient_Btn";
            this.CreateClient_Btn.Size = new System.Drawing.Size(109, 38);
            this.CreateClient_Btn.TabIndex = 1;
            this.CreateClient_Btn.Text = "Create Client";
            this.CreateClient_Btn.UseVisualStyleBackColor = true;
            this.CreateClient_Btn.Click += new System.EventHandler(this.CreateClient_Btn_Click);
            // 
            // CreateAdmin_Btn
            // 
            this.CreateAdmin_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateAdmin_Btn.Location = new System.Drawing.Point(1100, 135);
            this.CreateAdmin_Btn.Name = "CreateAdmin_Btn";
            this.CreateAdmin_Btn.Size = new System.Drawing.Size(109, 38);
            this.CreateAdmin_Btn.TabIndex = 2;
            this.CreateAdmin_Btn.Text = "Create Admin";
            this.CreateAdmin_Btn.UseVisualStyleBackColor = true;
            this.CreateAdmin_Btn.Click += new System.EventHandler(this.CreateAdmin_Btn_Click);
            // 
            // Override2_Btn
            // 
            this.Override2_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Override2_Btn.Location = new System.Drawing.Point(1100, 267);
            this.Override2_Btn.Name = "Override2_Btn";
            this.Override2_Btn.Size = new System.Drawing.Size(109, 51);
            this.Override2_Btn.TabIndex = 3;
            this.Override2_Btn.Text = "Override2";
            this.Override2_Btn.UseVisualStyleBackColor = true;
            this.Override2_Btn.Click += new System.EventHandler(this.Override2_Btn_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(1097, 44);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(73, 17);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Username";
            // 
            // AddMoney_tbox
            // 
            this.AddMoney_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMoney_tbox.Location = new System.Drawing.Point(1100, 64);
            this.AddMoney_tbox.Name = "AddMoney_tbox";
            this.AddMoney_tbox.Size = new System.Drawing.Size(109, 22);
            this.AddMoney_tbox.TabIndex = 5;
            // 
            // AddMoney_Btn
            // 
            this.AddMoney_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMoney_Btn.Location = new System.Drawing.Point(1100, 92);
            this.AddMoney_Btn.Name = "AddMoney_Btn";
            this.AddMoney_Btn.Size = new System.Drawing.Size(109, 37);
            this.AddMoney_Btn.TabIndex = 6;
            this.AddMoney_Btn.Text = "Add Money";
            this.AddMoney_Btn.UseVisualStyleBackColor = true;
            this.AddMoney_Btn.Click += new System.EventHandler(this.AddMoney_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIDDataGridViewTextBoxColumn,
            this.adminFirstNameDataGridViewTextBoxColumn,
            this.adminLastNameDataGridViewTextBoxColumn,
            this.adminEmailDataGridViewTextBoxColumn,
            this.adminPhoneNumberDataGridViewTextBoxColumn,
            this.adminMoneyDataGridViewTextBoxColumn,
            this.adminBirthDateDataGridViewTextBoxColumn,
            this.adminRegistrationDateDataGridViewTextBoxColumn,
            this.adminLoginLoginIDDataGridViewTextBoxColumn,
            this.adminPasswordPasswordIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminIDDataGridViewTextBoxColumn.Width = 97;
            // 
            // adminFirstNameDataGridViewTextBoxColumn
            // 
            this.adminFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Admin_First_Name";
            this.adminFirstNameDataGridViewTextBoxColumn.HeaderText = "Admin_First_Name";
            this.adminFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminFirstNameDataGridViewTextBoxColumn.Name = "adminFirstNameDataGridViewTextBoxColumn";
            this.adminFirstNameDataGridViewTextBoxColumn.Width = 156;
            // 
            // adminLastNameDataGridViewTextBoxColumn
            // 
            this.adminLastNameDataGridViewTextBoxColumn.DataPropertyName = "Admin_Last_Name";
            this.adminLastNameDataGridViewTextBoxColumn.HeaderText = "Admin_Last_Name";
            this.adminLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminLastNameDataGridViewTextBoxColumn.Name = "adminLastNameDataGridViewTextBoxColumn";
            this.adminLastNameDataGridViewTextBoxColumn.Width = 156;
            // 
            // adminEmailDataGridViewTextBoxColumn
            // 
            this.adminEmailDataGridViewTextBoxColumn.DataPropertyName = "Admin_Email";
            this.adminEmailDataGridViewTextBoxColumn.HeaderText = "Admin_Email";
            this.adminEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminEmailDataGridViewTextBoxColumn.Name = "adminEmailDataGridViewTextBoxColumn";
            this.adminEmailDataGridViewTextBoxColumn.Width = 118;
            // 
            // adminPhoneNumberDataGridViewTextBoxColumn
            // 
            this.adminPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Admin_Phone_Number";
            this.adminPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Admin_Phone_Number";
            this.adminPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminPhoneNumberDataGridViewTextBoxColumn.Name = "adminPhoneNumberDataGridViewTextBoxColumn";
            this.adminPhoneNumberDataGridViewTextBoxColumn.Width = 183;
            // 
            // adminMoneyDataGridViewTextBoxColumn
            // 
            this.adminMoneyDataGridViewTextBoxColumn.DataPropertyName = "Admin_Money";
            this.adminMoneyDataGridViewTextBoxColumn.HeaderText = "Admin_Money";
            this.adminMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminMoneyDataGridViewTextBoxColumn.Name = "adminMoneyDataGridViewTextBoxColumn";
            this.adminMoneyDataGridViewTextBoxColumn.Width = 126;
            // 
            // adminBirthDateDataGridViewTextBoxColumn
            // 
            this.adminBirthDateDataGridViewTextBoxColumn.DataPropertyName = "Admin_Birth_Date";
            this.adminBirthDateDataGridViewTextBoxColumn.HeaderText = "Admin_Birth_Date";
            this.adminBirthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminBirthDateDataGridViewTextBoxColumn.Name = "adminBirthDateDataGridViewTextBoxColumn";
            this.adminBirthDateDataGridViewTextBoxColumn.Width = 151;
            // 
            // adminRegistrationDateDataGridViewTextBoxColumn
            // 
            this.adminRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "Admin_Registration_Date";
            this.adminRegistrationDateDataGridViewTextBoxColumn.HeaderText = "Admin_Registration_Date";
            this.adminRegistrationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminRegistrationDateDataGridViewTextBoxColumn.Name = "adminRegistrationDateDataGridViewTextBoxColumn";
            this.adminRegistrationDateDataGridViewTextBoxColumn.Width = 198;
            // 
            // adminLoginLoginIDDataGridViewTextBoxColumn
            // 
            this.adminLoginLoginIDDataGridViewTextBoxColumn.DataPropertyName = "Admin_Login_Login_ID";
            this.adminLoginLoginIDDataGridViewTextBoxColumn.HeaderText = "Admin_Login_Login_ID";
            this.adminLoginLoginIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminLoginLoginIDDataGridViewTextBoxColumn.Name = "adminLoginLoginIDDataGridViewTextBoxColumn";
            this.adminLoginLoginIDDataGridViewTextBoxColumn.Width = 183;
            // 
            // adminPasswordPasswordIDDataGridViewTextBoxColumn
            // 
            this.adminPasswordPasswordIDDataGridViewTextBoxColumn.DataPropertyName = "Admin_Password_Password_ID";
            this.adminPasswordPasswordIDDataGridViewTextBoxColumn.HeaderText = "Admin_Password_Password_ID";
            this.adminPasswordPasswordIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminPasswordPasswordIDDataGridViewTextBoxColumn.Name = "adminPasswordPasswordIDDataGridViewTextBoxColumn";
            this.adminPasswordPasswordIDDataGridViewTextBoxColumn.Width = 235;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet2;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet2
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet2.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet2";
            this._FinalProjectDBContext_MyDbContextModelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientFirstNameDataGridViewTextBoxColumn,
            this.clientLastNameDataGridViewTextBoxColumn,
            this.clientEmailDataGridViewTextBoxColumn,
            this.clientPhoneNumberDataGridViewTextBoxColumn,
            this.clientMoneyDataGridViewTextBoxColumn,
            this.clientBirthDateDataGridViewTextBoxColumn,
            this.clientRegistrationDateDataGridViewTextBoxColumn,
            this.clientLoginLoginIDDataGridViewTextBoxColumn,
            this.clientPasswordPasswordIDDataGridViewTextBoxColumn,
            this.adminsAdminIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clientsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1048, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 93;
            // 
            // clientFirstNameDataGridViewTextBoxColumn
            // 
            this.clientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Client_First_Name";
            this.clientFirstNameDataGridViewTextBoxColumn.HeaderText = "Client_First_Name";
            this.clientFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientFirstNameDataGridViewTextBoxColumn.Name = "clientFirstNameDataGridViewTextBoxColumn";
            this.clientFirstNameDataGridViewTextBoxColumn.Width = 152;
            // 
            // clientLastNameDataGridViewTextBoxColumn
            // 
            this.clientLastNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Last_Name";
            this.clientLastNameDataGridViewTextBoxColumn.HeaderText = "Client_Last_Name";
            this.clientLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientLastNameDataGridViewTextBoxColumn.Name = "clientLastNameDataGridViewTextBoxColumn";
            this.clientLastNameDataGridViewTextBoxColumn.Width = 152;
            // 
            // clientEmailDataGridViewTextBoxColumn
            // 
            this.clientEmailDataGridViewTextBoxColumn.DataPropertyName = "Client_Email";
            this.clientEmailDataGridViewTextBoxColumn.HeaderText = "Client_Email";
            this.clientEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientEmailDataGridViewTextBoxColumn.Name = "clientEmailDataGridViewTextBoxColumn";
            this.clientEmailDataGridViewTextBoxColumn.Width = 114;
            // 
            // clientPhoneNumberDataGridViewTextBoxColumn
            // 
            this.clientPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Client_Phone_Number";
            this.clientPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Client_Phone_Number";
            this.clientPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPhoneNumberDataGridViewTextBoxColumn.Name = "clientPhoneNumberDataGridViewTextBoxColumn";
            this.clientPhoneNumberDataGridViewTextBoxColumn.Width = 179;
            // 
            // clientMoneyDataGridViewTextBoxColumn
            // 
            this.clientMoneyDataGridViewTextBoxColumn.DataPropertyName = "Client_Money";
            this.clientMoneyDataGridViewTextBoxColumn.HeaderText = "Client_Money";
            this.clientMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientMoneyDataGridViewTextBoxColumn.Name = "clientMoneyDataGridViewTextBoxColumn";
            this.clientMoneyDataGridViewTextBoxColumn.Width = 122;
            // 
            // clientBirthDateDataGridViewTextBoxColumn
            // 
            this.clientBirthDateDataGridViewTextBoxColumn.DataPropertyName = "Client_Birth_Date";
            this.clientBirthDateDataGridViewTextBoxColumn.HeaderText = "Client_Birth_Date";
            this.clientBirthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientBirthDateDataGridViewTextBoxColumn.Name = "clientBirthDateDataGridViewTextBoxColumn";
            this.clientBirthDateDataGridViewTextBoxColumn.Width = 147;
            // 
            // clientRegistrationDateDataGridViewTextBoxColumn
            // 
            this.clientRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "Client_Registration_Date";
            this.clientRegistrationDateDataGridViewTextBoxColumn.HeaderText = "Client_Registration_Date";
            this.clientRegistrationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientRegistrationDateDataGridViewTextBoxColumn.Name = "clientRegistrationDateDataGridViewTextBoxColumn";
            this.clientRegistrationDateDataGridViewTextBoxColumn.Width = 194;
            // 
            // clientLoginLoginIDDataGridViewTextBoxColumn
            // 
            this.clientLoginLoginIDDataGridViewTextBoxColumn.DataPropertyName = "Client_Login_Login_ID";
            this.clientLoginLoginIDDataGridViewTextBoxColumn.HeaderText = "Client_Login_Login_ID";
            this.clientLoginLoginIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientLoginLoginIDDataGridViewTextBoxColumn.Name = "clientLoginLoginIDDataGridViewTextBoxColumn";
            this.clientLoginLoginIDDataGridViewTextBoxColumn.Width = 179;
            // 
            // clientPasswordPasswordIDDataGridViewTextBoxColumn
            // 
            this.clientPasswordPasswordIDDataGridViewTextBoxColumn.DataPropertyName = "Client_Password_Password_ID";
            this.clientPasswordPasswordIDDataGridViewTextBoxColumn.HeaderText = "Client_Password_Password_ID";
            this.clientPasswordPasswordIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPasswordPasswordIDDataGridViewTextBoxColumn.Name = "clientPasswordPasswordIDDataGridViewTextBoxColumn";
            this.clientPasswordPasswordIDDataGridViewTextBoxColumn.Width = 231;
            // 
            // adminsAdminIDDataGridViewTextBoxColumn
            // 
            this.adminsAdminIDDataGridViewTextBoxColumn.DataPropertyName = "Admins_Admin_ID";
            this.adminsAdminIDDataGridViewTextBoxColumn.HeaderText = "Admins_Admin_ID";
            this.adminsAdminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminsAdminIDDataGridViewTextBoxColumn.Name = "adminsAdminIDDataGridViewTextBoxColumn";
            this.adminsAdminIDDataGridViewTextBoxColumn.Width = 151;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet3;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet3
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet3.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet3";
            this._FinalProjectDBContext_MyDbContextModelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderNameDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.adminIDDataGridViewTextBoxColumn1,
            this.clientIDDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.ordersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 324);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1048, 150);
            this.dataGridView3.TabIndex = 8;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNameDataGridViewTextBoxColumn
            // 
            this.orderNameDataGridViewTextBoxColumn.DataPropertyName = "Order_Name";
            this.orderNameDataGridViewTextBoxColumn.HeaderText = "Order_Name";
            this.orderNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "Order_Price";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "Order_Price";
            this.orderPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // adminIDDataGridViewTextBoxColumn1
            // 
            this.adminIDDataGridViewTextBoxColumn1.DataPropertyName = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn1.HeaderText = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adminIDDataGridViewTextBoxColumn1.Name = "adminIDDataGridViewTextBoxColumn1";
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet";
            this._FinalProjectDBContext_MyDbContextModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeight = 29;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.productsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(12, 480);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(1048, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Product_Manufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "Product_Manufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Price";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Product_Price";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "Product_Amount";
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "Product_Amount";
            this.productAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet1;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet1
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet1.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet1";
            this._FinalProjectDBContext_MyDbContextModelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // finalProjectDBContextMyDbContextModelDataSetBindingSource
            // 
            this.finalProjectDBContextMyDbContextModelDataSetBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet;
            this.finalProjectDBContextMyDbContextModelDataSetBindingSource.Position = 0;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UpdTable_Btn
            // 
            this.UpdTable_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdTable_Btn.Location = new System.Drawing.Point(1100, 223);
            this.UpdTable_Btn.Name = "UpdTable_Btn";
            this.UpdTable_Btn.Size = new System.Drawing.Size(109, 34);
            this.UpdTable_Btn.TabIndex = 10;
            this.UpdTable_Btn.Text = "Update Table";
            this.UpdTable_Btn.UseVisualStyleBackColor = true;
            this.UpdTable_Btn.Click += new System.EventHandler(this.UpdTable_Btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 750);
            this.Controls.Add(this.UpdTable_Btn);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CreateAdmin_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateClient_Btn);
            this.Controls.Add(this.Override2_Btn);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.AddMoney_Btn);
            this.Controls.Add(this.AddMoney_tbox);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDBContextMyDbContextModelDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateClient_Btn;
        private System.Windows.Forms.Button CreateAdmin_Btn;

        private System.Windows.Forms.Button Override2_Btn;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.TextBox AddMoney_tbox;
        private System.Windows.Forms.Button AddMoney_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private _FinalProjectDBContext_MyDbContextModelDataSet2 _FinalProjectDBContext_MyDbContextModelDataSet2;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet2TableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminRegistrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminLoginLoginIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPasswordPasswordIDDataGridViewTextBoxColumn;
        private _FinalProjectDBContext_MyDbContextModelDataSet3 _FinalProjectDBContext_MyDbContextModelDataSet3;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet3TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientRegistrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLoginLoginIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPasswordPasswordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminsAdminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource finalProjectDBContextMyDbContextModelDataSetBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet _FinalProjectDBContext_MyDbContextModelDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private _FinalProjectDBContext_MyDbContextModelDataSet1 _FinalProjectDBContext_MyDbContextModelDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button UpdTable_Btn;
    }
}