namespace SalesManagementSystem
{
    partial class EmployeeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dateTimePickerEjoin = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEpass = new System.Windows.Forms.TextBox();
            this.dateTimePickerEbirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxEphone = new System.Windows.Forms.TextBox();
            this.textBoxEaddress = new System.Windows.Forms.TextBox();
            this.textBoxEpost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEsex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEhurigana = new System.Windows.Forms.TextBox();
            this.textBoxEname = new System.Windows.Forms.TextBox();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.社員マスタBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sMSdatabaseDataSet = new SalesManagementSystem.SMSdatabaseDataSet();
            this.社員マスタTableAdapter = new SalesManagementSystem.SMSdatabaseDataSetTableAdapters.社員マスタTableAdapter();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.社員マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員マスタBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員マスタBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.dateTimePickerEjoin);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxEpass);
            this.groupBox1.Controls.Add(this.dateTimePickerEbirth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxEphone);
            this.groupBox1.Controls.Add(this.textBoxEaddress);
            this.groupBox1.Controls.Add(this.textBoxEpost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxEsex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxEhurigana);
            this.groupBox1.Controls.Add(this.textBoxEname);
            this.groupBox1.Controls.Add(this.textBoxEID);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "社員操作";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRefresh.Image = global::SalesManagementSystem.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(151, 318);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(70, 33);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "更新";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNew.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNew.Image = global::SalesManagementSystem.Properties.Resources.add_icon__1_;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(63, 318);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 33);
            this.buttonNew.TabIndex = 10;
            this.buttonNew.Text = "新規";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemove.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRemove.Image = global::SalesManagementSystem.Properties.Resources.Delete;
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.Location = new System.Drawing.Point(151, 364);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(70, 33);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "削除";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonrRemove_Click);
            // 
            // dateTimePickerEjoin
            // 
            this.dateTimePickerEjoin.Enabled = false;
            this.dateTimePickerEjoin.Location = new System.Drawing.Point(116, 257);
            this.dateTimePickerEjoin.Name = "dateTimePickerEjoin";
            this.dateTimePickerEjoin.Size = new System.Drawing.Size(124, 19);
            this.dateTimePickerEjoin.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Image = global::SalesManagementSystem.Properties.Resources.check_mark;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(63, 364);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 33);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "パスワード:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "入社日:";
            // 
            // textBoxEpass
            // 
            this.textBoxEpass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxEpass.Location = new System.Drawing.Point(116, 282);
            this.textBoxEpass.MaxLength = 30;
            this.textBoxEpass.Name = "textBoxEpass";
            this.textBoxEpass.PasswordChar = '*';
            this.textBoxEpass.Size = new System.Drawing.Size(124, 19);
            this.textBoxEpass.TabIndex = 9;
            // 
            // dateTimePickerEbirth
            // 
            this.dateTimePickerEbirth.Location = new System.Drawing.Point(116, 132);
            this.dateTimePickerEbirth.Name = "dateTimePickerEbirth";
            this.dateTimePickerEbirth.Size = new System.Drawing.Size(124, 19);
            this.dateTimePickerEbirth.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "メールアドレス:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxEmail.Location = new System.Drawing.Point(116, 232);
            this.textBoxEmail.MaxLength = 60;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(124, 19);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxEphone
            // 
            this.textBoxEphone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxEphone.Location = new System.Drawing.Point(116, 207);
            this.textBoxEphone.MaxLength = 12;
            this.textBoxEphone.Name = "textBoxEphone";
            this.textBoxEphone.Size = new System.Drawing.Size(124, 19);
            this.textBoxEphone.TabIndex = 6;
            this.textBoxEphone.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxEaddress
            // 
            this.textBoxEaddress.Location = new System.Drawing.Point(116, 182);
            this.textBoxEaddress.MaxLength = 50;
            this.textBoxEaddress.Name = "textBoxEaddress";
            this.textBoxEaddress.Size = new System.Drawing.Size(124, 19);
            this.textBoxEaddress.TabIndex = 5;
            // 
            // textBoxEpost
            // 
            this.textBoxEpost.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxEpost.Location = new System.Drawing.Point(116, 157);
            this.textBoxEpost.MaxLength = 7;
            this.textBoxEpost.Name = "textBoxEpost";
            this.textBoxEpost.Size = new System.Drawing.Size(124, 19);
            this.textBoxEpost.TabIndex = 4;
            this.textBoxEpost.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "電話番号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "住所:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "郵便番号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "生年月日:";
            // 
            // comboBoxEsex
            // 
            this.comboBoxEsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEsex.FormattingEnabled = true;
            this.comboBoxEsex.Items.AddRange(new object[] {
            "---",
            "男",
            "女",
            "不明"});
            this.comboBoxEsex.Location = new System.Drawing.Point(116, 106);
            this.comboBoxEsex.Name = "comboBoxEsex";
            this.comboBoxEsex.Size = new System.Drawing.Size(124, 20);
            this.comboBoxEsex.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "性別";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "ふりがな:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "社員名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "社員ID:";
            // 
            // textBoxEhurigana
            // 
            this.textBoxEhurigana.Location = new System.Drawing.Point(116, 81);
            this.textBoxEhurigana.MaxLength = 40;
            this.textBoxEhurigana.Name = "textBoxEhurigana";
            this.textBoxEhurigana.Size = new System.Drawing.Size(124, 19);
            this.textBoxEhurigana.TabIndex = 1;
            // 
            // textBoxEname
            // 
            this.textBoxEname.Location = new System.Drawing.Point(116, 56);
            this.textBoxEname.MaxLength = 20;
            this.textBoxEname.Name = "textBoxEname";
            this.textBoxEname.Size = new System.Drawing.Size(124, 19);
            this.textBoxEname.TabIndex = 0;
            // 
            // textBoxEID
            // 
            this.textBoxEID.Enabled = false;
            this.textBoxEID.Location = new System.Drawing.Point(116, 31);
            this.textBoxEID.MaxLength = 4;
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(124, 19);
            this.textBoxEID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(297, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 417);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "社員一覧";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 15);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // 社員マスタBindingSource1
            // 
            this.社員マスタBindingSource1.DataMember = "社員マスタ";
            this.社員マスタBindingSource1.DataSource = this.sMSdatabaseDataSet;
            // 
            // sMSdatabaseDataSet
            // 
            this.sMSdatabaseDataSet.DataSetName = "SMSdatabaseDataSet";
            this.sMSdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 社員マスタTableAdapter
            // 
            this.社員マスタTableAdapter.ClearBeforeFill = true;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(508, 73);
            this.SearchTextbox.MaxLength = 50;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(211, 19);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::SalesManagementSystem.Properties.Resources.header_Employee1;
            this.pictureBox5.Location = new System.Drawing.Point(778, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(214, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox4.Location = new System.Drawing.Point(615, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox3.Location = new System.Drawing.Point(411, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox2.Location = new System.Drawing.Point(211, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SalesManagementSystem.Properties.Resources.header_Employee;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Image = global::SalesManagementSystem.Properties.Resources.magnifying_glass_4_0;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSearch.Location = new System.Drawing.Point(725, 71);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(51, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Image = global::SalesManagementSystem.Properties.Resources.media_player_stream_no1;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(12, 519);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 31);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // 社員マスタBindingSource
            // 
            this.社員マスタBindingSource.DataMember = "社員マスタ";
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 562);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社員管理";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員マスタBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員マスタBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxEphone;
        private System.Windows.Forms.TextBox textBoxEaddress;
        private System.Windows.Forms.TextBox textBoxEpost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEsex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEhurigana;
        private System.Windows.Forms.TextBox textBoxEname;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEpass;
        private System.Windows.Forms.DateTimePicker dateTimePickerEbirth;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource 社員マスタBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社員IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社員番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社員名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ふりがなDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生年月日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 郵便番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住所DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn メールアドレスDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入社日DataGridViewTextBoxColumn;
        private SMSdatabaseDataSet sMSdatabaseDataSet;
        private System.Windows.Forms.BindingSource 社員マスタBindingSource1;
        private SMSdatabaseDataSetTableAdapters.社員マスタTableAdapter 社員マスタTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerEjoin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonRefresh;
    }
}