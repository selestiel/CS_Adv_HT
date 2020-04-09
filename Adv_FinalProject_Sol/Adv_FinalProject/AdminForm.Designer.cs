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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UpdTable_Btn = new System.Windows.Forms.Button();
            this.Admins_DataGridV = new System.Windows.Forms.DataGridView();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminRegistrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminLoginNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminLoginPassNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminLoginLoginIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet();
            this.Clients_DataGridV = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientRegistrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLoginNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLoginPassNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLoginLoginIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsAdminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet1 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet1();
            this.Orders_DataGridV = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet2 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet2();
            this.Products_DataGrid_V = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FinalProjectDBContext_MyDbContextModelDataSet3 = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet3();
            this.adminsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSetTableAdapters.AdminsTableAdapter();
            this.finalProjectDBContextMyDbContextModelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet1TableAdapters.ClientsTableAdapter();
            this.ordersTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet2TableAdapters.OrdersTableAdapter();
            this.productsTableAdapter = new Adv_FinalProject._FinalProjectDBContext_MyDbContextModelDataSet3TableAdapters.ProductsTableAdapter();
            this.GoBack_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Admins_DataGridV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_DataGridV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_DataGridV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products_DataGrid_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet3)).BeginInit();
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
            // Admins_DataGridV
            // 
            this.Admins_DataGridV.AllowUserToAddRows = false;
            this.Admins_DataGridV.AllowUserToDeleteRows = false;
            this.Admins_DataGridV.AutoGenerateColumns = false;
            this.Admins_DataGridV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Admins_DataGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admins_DataGridV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIDDataGridViewTextBoxColumn,
            this.adminFirstNameDataGridViewTextBoxColumn,
            this.adminLastNameDataGridViewTextBoxColumn,
            this.adminEmailDataGridViewTextBoxColumn,
            this.adminPhoneNumberDataGridViewTextBoxColumn,
            this.adminMoneyDataGridViewTextBoxColumn,
            this.adminBirthDateDataGridViewTextBoxColumn,
            this.adminRegistrationDateDataGridViewTextBoxColumn,
            this.adminLoginNameDataGridViewTextBoxColumn,
            this.adminLoginPassNameDataGridViewTextBoxColumn,
            this.adminLoginLoginIDDataGridViewTextBoxColumn});
            this.Admins_DataGridV.DataSource = this.adminsBindingSource;
            this.Admins_DataGridV.Location = new System.Drawing.Point(12, 22);
            this.Admins_DataGridV.Name = "Admins_DataGridV";
            this.Admins_DataGridV.RowHeadersWidth = 51;
            this.Admins_DataGridV.RowTemplate.Height = 24;
            this.Admins_DataGridV.Size = new System.Drawing.Size(1078, 180);
            this.Admins_DataGridV.TabIndex = 11;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminFirstNameDataGridViewTextBoxColumn
            // 
            this.adminFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Admin_First_Name";
            this.adminFirstNameDataGridViewTextBoxColumn.HeaderText = "Admin_First_Name";
            this.adminFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminFirstNameDataGridViewTextBoxColumn.Name = "adminFirstNameDataGridViewTextBoxColumn";
            // 
            // adminLastNameDataGridViewTextBoxColumn
            // 
            this.adminLastNameDataGridViewTextBoxColumn.DataPropertyName = "Admin_Last_Name";
            this.adminLastNameDataGridViewTextBoxColumn.HeaderText = "Admin_Last_Name";
            this.adminLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminLastNameDataGridViewTextBoxColumn.Name = "adminLastNameDataGridViewTextBoxColumn";
            // 
            // adminEmailDataGridViewTextBoxColumn
            // 
            this.adminEmailDataGridViewTextBoxColumn.DataPropertyName = "Admin_Email";
            this.adminEmailDataGridViewTextBoxColumn.HeaderText = "Admin_Email";
            this.adminEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminEmailDataGridViewTextBoxColumn.Name = "adminEmailDataGridViewTextBoxColumn";
            // 
            // adminPhoneNumberDataGridViewTextBoxColumn
            // 
            this.adminPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Admin_Phone_Number";
            this.adminPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Admin_Phone_Number";
            this.adminPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminPhoneNumberDataGridViewTextBoxColumn.Name = "adminPhoneNumberDataGridViewTextBoxColumn";
            // 
            // adminMoneyDataGridViewTextBoxColumn
            // 
            this.adminMoneyDataGridViewTextBoxColumn.DataPropertyName = "Admin_Money";
            this.adminMoneyDataGridViewTextBoxColumn.HeaderText = "Admin_Money";
            this.adminMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminMoneyDataGridViewTextBoxColumn.Name = "adminMoneyDataGridViewTextBoxColumn";
            // 
            // adminBirthDateDataGridViewTextBoxColumn
            // 
            this.adminBirthDateDataGridViewTextBoxColumn.DataPropertyName = "Admin_Birth_Date";
            this.adminBirthDateDataGridViewTextBoxColumn.HeaderText = "Admin_Birth_Date";
            this.adminBirthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminBirthDateDataGridViewTextBoxColumn.Name = "adminBirthDateDataGridViewTextBoxColumn";
            // 
            // adminRegistrationDateDataGridViewTextBoxColumn
            // 
            this.adminRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "Admin_Registration_Date";
            this.adminRegistrationDateDataGridViewTextBoxColumn.HeaderText = "Admin_Registration_Date";
            this.adminRegistrationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminRegistrationDateDataGridViewTextBoxColumn.Name = "adminRegistrationDateDataGridViewTextBoxColumn";
            // 
            // adminLoginNameDataGridViewTextBoxColumn
            // 
            this.adminLoginNameDataGridViewTextBoxColumn.DataPropertyName = "Admin_Login_Name";
            this.adminLoginNameDataGridViewTextBoxColumn.HeaderText = "Admin_Login_Name";
            this.adminLoginNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminLoginNameDataGridViewTextBoxColumn.Name = "adminLoginNameDataGridViewTextBoxColumn";
            // 
            // adminLoginPassNameDataGridViewTextBoxColumn
            // 
            this.adminLoginPassNameDataGridViewTextBoxColumn.DataPropertyName = "Admin_Login_Pass_Name";
            this.adminLoginPassNameDataGridViewTextBoxColumn.HeaderText = "Admin_Login_Pass_Name";
            this.adminLoginPassNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminLoginPassNameDataGridViewTextBoxColumn.Name = "adminLoginPassNameDataGridViewTextBoxColumn";
            // 
            // adminLoginLoginIDDataGridViewTextBoxColumn
            // 
            this.adminLoginLoginIDDataGridViewTextBoxColumn.DataPropertyName = "Admin_Login_Login_ID";
            this.adminLoginLoginIDDataGridViewTextBoxColumn.HeaderText = "Admin_Login_Login_ID";
            this.adminLoginLoginIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminLoginLoginIDDataGridViewTextBoxColumn.Name = "adminLoginLoginIDDataGridViewTextBoxColumn";
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet";
            this._FinalProjectDBContext_MyDbContextModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Clients_DataGridV
            // 
            this.Clients_DataGridV.AllowUserToAddRows = false;
            this.Clients_DataGridV.AllowUserToDeleteRows = false;
            this.Clients_DataGridV.AutoGenerateColumns = false;
            this.Clients_DataGridV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Clients_DataGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients_DataGridV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientFirstNameDataGridViewTextBoxColumn,
            this.clientLastNameDataGridViewTextBoxColumn,
            this.clientEmailDataGridViewTextBoxColumn,
            this.clientPhoneNumberDataGridViewTextBoxColumn,
            this.clientMoneyDataGridViewTextBoxColumn,
            this.clientBirthDateDataGridViewTextBoxColumn,
            this.clientRegistrationDateDataGridViewTextBoxColumn,
            this.clientLoginNameDataGridViewTextBoxColumn,
            this.clientLoginPassNameDataGridViewTextBoxColumn,
            this.clientLoginLoginIDDataGridViewTextBoxColumn,
            this.adminsAdminIDDataGridViewTextBoxColumn});
            this.Clients_DataGridV.DataSource = this.clientsBindingSource;
            this.Clients_DataGridV.Location = new System.Drawing.Point(12, 208);
            this.Clients_DataGridV.Name = "Clients_DataGridV";
            this.Clients_DataGridV.RowHeadersWidth = 51;
            this.Clients_DataGridV.RowTemplate.Height = 24;
            this.Clients_DataGridV.Size = new System.Drawing.Size(1078, 180);
            this.Clients_DataGridV.TabIndex = 12;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientFirstNameDataGridViewTextBoxColumn
            // 
            this.clientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Client_First_Name";
            this.clientFirstNameDataGridViewTextBoxColumn.HeaderText = "Client_First_Name";
            this.clientFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientFirstNameDataGridViewTextBoxColumn.Name = "clientFirstNameDataGridViewTextBoxColumn";
            // 
            // clientLastNameDataGridViewTextBoxColumn
            // 
            this.clientLastNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Last_Name";
            this.clientLastNameDataGridViewTextBoxColumn.HeaderText = "Client_Last_Name";
            this.clientLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientLastNameDataGridViewTextBoxColumn.Name = "clientLastNameDataGridViewTextBoxColumn";
            // 
            // clientEmailDataGridViewTextBoxColumn
            // 
            this.clientEmailDataGridViewTextBoxColumn.DataPropertyName = "Client_Email";
            this.clientEmailDataGridViewTextBoxColumn.HeaderText = "Client_Email";
            this.clientEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientEmailDataGridViewTextBoxColumn.Name = "clientEmailDataGridViewTextBoxColumn";
            // 
            // clientPhoneNumberDataGridViewTextBoxColumn
            // 
            this.clientPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Client_Phone_Number";
            this.clientPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Client_Phone_Number";
            this.clientPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPhoneNumberDataGridViewTextBoxColumn.Name = "clientPhoneNumberDataGridViewTextBoxColumn";
            // 
            // clientMoneyDataGridViewTextBoxColumn
            // 
            this.clientMoneyDataGridViewTextBoxColumn.DataPropertyName = "Client_Money";
            this.clientMoneyDataGridViewTextBoxColumn.HeaderText = "Client_Money";
            this.clientMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientMoneyDataGridViewTextBoxColumn.Name = "clientMoneyDataGridViewTextBoxColumn";
            // 
            // clientBirthDateDataGridViewTextBoxColumn
            // 
            this.clientBirthDateDataGridViewTextBoxColumn.DataPropertyName = "Client_Birth_Date";
            this.clientBirthDateDataGridViewTextBoxColumn.HeaderText = "Client_Birth_Date";
            this.clientBirthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientBirthDateDataGridViewTextBoxColumn.Name = "clientBirthDateDataGridViewTextBoxColumn";
            // 
            // clientRegistrationDateDataGridViewTextBoxColumn
            // 
            this.clientRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "Client_Registration_Date";
            this.clientRegistrationDateDataGridViewTextBoxColumn.HeaderText = "Client_Registration_Date";
            this.clientRegistrationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientRegistrationDateDataGridViewTextBoxColumn.Name = "clientRegistrationDateDataGridViewTextBoxColumn";
            // 
            // clientLoginNameDataGridViewTextBoxColumn
            // 
            this.clientLoginNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Login_Name";
            this.clientLoginNameDataGridViewTextBoxColumn.HeaderText = "Client_Login_Name";
            this.clientLoginNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientLoginNameDataGridViewTextBoxColumn.Name = "clientLoginNameDataGridViewTextBoxColumn";
            // 
            // clientLoginPassNameDataGridViewTextBoxColumn
            // 
            this.clientLoginPassNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Login_Pass_Name";
            this.clientLoginPassNameDataGridViewTextBoxColumn.HeaderText = "Client_Login_Pass_Name";
            this.clientLoginPassNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientLoginPassNameDataGridViewTextBoxColumn.Name = "clientLoginPassNameDataGridViewTextBoxColumn";
            // 
            // clientLoginLoginIDDataGridViewTextBoxColumn
            // 
            this.clientLoginLoginIDDataGridViewTextBoxColumn.DataPropertyName = "Client_Login_Login_ID";
            this.clientLoginLoginIDDataGridViewTextBoxColumn.HeaderText = "Client_Login_Login_ID";
            this.clientLoginLoginIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientLoginLoginIDDataGridViewTextBoxColumn.Name = "clientLoginLoginIDDataGridViewTextBoxColumn";
            // 
            // adminsAdminIDDataGridViewTextBoxColumn
            // 
            this.adminsAdminIDDataGridViewTextBoxColumn.DataPropertyName = "Admins_Admin_ID";
            this.adminsAdminIDDataGridViewTextBoxColumn.HeaderText = "Admins_Admin_ID";
            this.adminsAdminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminsAdminIDDataGridViewTextBoxColumn.Name = "adminsAdminIDDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet1;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet1
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet1.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet1";
            this._FinalProjectDBContext_MyDbContextModelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Orders_DataGridV
            // 
            this.Orders_DataGridV.AllowUserToAddRows = false;
            this.Orders_DataGridV.AllowUserToDeleteRows = false;
            this.Orders_DataGridV.AutoGenerateColumns = false;
            this.Orders_DataGridV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Orders_DataGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders_DataGridV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderNameDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.adminIDDataGridViewTextBoxColumn1,
            this.clientIDDataGridViewTextBoxColumn1});
            this.Orders_DataGridV.DataSource = this.ordersBindingSource;
            this.Orders_DataGridV.Location = new System.Drawing.Point(12, 394);
            this.Orders_DataGridV.Name = "Orders_DataGridV";
            this.Orders_DataGridV.RowHeadersWidth = 51;
            this.Orders_DataGridV.RowTemplate.Height = 24;
            this.Orders_DataGridV.Size = new System.Drawing.Size(1078, 180);
            this.Orders_DataGridV.TabIndex = 13;
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
            this.ordersBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet2;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet2
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet2.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet2";
            this._FinalProjectDBContext_MyDbContextModelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Products_DataGrid_V
            // 
            this.Products_DataGrid_V.AllowUserToAddRows = false;
            this.Products_DataGrid_V.AllowUserToDeleteRows = false;
            this.Products_DataGrid_V.AutoGenerateColumns = false;
            this.Products_DataGrid_V.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Products_DataGrid_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products_DataGrid_V.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn});
            this.Products_DataGrid_V.DataSource = this.productsBindingSource;
            this.Products_DataGrid_V.Location = new System.Drawing.Point(12, 580);
            this.Products_DataGrid_V.Name = "Products_DataGrid_V";
            this.Products_DataGrid_V.RowHeadersWidth = 51;
            this.Products_DataGrid_V.RowTemplate.Height = 24;
            this.Products_DataGrid_V.Size = new System.Drawing.Size(1078, 180);
            this.Products_DataGrid_V.TabIndex = 14;
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
            this.productsBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet3;
            // 
            // _FinalProjectDBContext_MyDbContextModelDataSet3
            // 
            this._FinalProjectDBContext_MyDbContextModelDataSet3.DataSetName = "_FinalProjectDBContext_MyDbContextModelDataSet3";
            this._FinalProjectDBContext_MyDbContextModelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // finalProjectDBContextMyDbContextModelDataSetBindingSource
            // 
            this.finalProjectDBContextMyDbContextModelDataSetBindingSource.DataSource = this._FinalProjectDBContext_MyDbContextModelDataSet;
            this.finalProjectDBContextMyDbContextModelDataSetBindingSource.Position = 0;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // GoBack_Btn
            // 
            this.GoBack_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBack_Btn.Location = new System.Drawing.Point(1100, 325);
            this.GoBack_Btn.Name = "GoBack_Btn";
            this.GoBack_Btn.Size = new System.Drawing.Size(109, 37);
            this.GoBack_Btn.TabIndex = 15;
            this.GoBack_Btn.Text = "Go Back";
            this.GoBack_Btn.UseVisualStyleBackColor = true;
            this.GoBack_Btn.Click += new System.EventHandler(this.GoBack_Btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 769);
            this.Controls.Add(this.GoBack_Btn);
            this.Controls.Add(this.Products_DataGrid_V);
            this.Controls.Add(this.Orders_DataGridV);
            this.Controls.Add(this.Clients_DataGridV);
            this.Controls.Add(this.Admins_DataGridV);
            this.Controls.Add(this.UpdTable_Btn);
            this.Controls.Add(this.CreateAdmin_Btn);
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
            ((System.ComponentModel.ISupportInitialize)(this.Admins_DataGridV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_DataGridV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_DataGridV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products_DataGrid_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FinalProjectDBContext_MyDbContextModelDataSet3)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button UpdTable_Btn;
        private System.Windows.Forms.DataGridView Admins_DataGridV;
        private System.Windows.Forms.DataGridView Clients_DataGridV;
        private System.Windows.Forms.DataGridView Orders_DataGridV;
        private System.Windows.Forms.DataGridView Products_DataGrid_V;
        private _FinalProjectDBContext_MyDbContextModelDataSet _FinalProjectDBContext_MyDbContextModelDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminRegistrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminLoginNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminLoginPassNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminLoginLoginIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource finalProjectDBContextMyDbContextModelDataSetBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet1 _FinalProjectDBContext_MyDbContextModelDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientRegistrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLoginNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLoginPassNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLoginLoginIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminsAdminIDDataGridViewTextBoxColumn;
        private _FinalProjectDBContext_MyDbContextModelDataSet2 _FinalProjectDBContext_MyDbContextModelDataSet2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private _FinalProjectDBContext_MyDbContextModelDataSet3 _FinalProjectDBContext_MyDbContextModelDataSet3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _FinalProjectDBContext_MyDbContextModelDataSet3TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button GoBack_Btn;
    }
}