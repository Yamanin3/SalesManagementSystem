namespace SalesManagementSystem
{
    partial class CustomerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListForm));
            this.groupBoxCoperation = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dateTimePickerCbirth = new System.Windows.Forms.DateTimePicker();
            this.labelCmail = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCmail = new System.Windows.Forms.TextBox();
            this.textBoxCphone = new System.Windows.Forms.TextBox();
            this.textBoxCaddress = new System.Windows.Forms.TextBox();
            this.textBoxCpost = new System.Windows.Forms.TextBox();
            this.labelCphone = new System.Windows.Forms.Label();
            this.labelCaddress = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelCbirth = new System.Windows.Forms.Label();
            this.comboBoxCsex = new System.Windows.Forms.ComboBox();
            this.labelCsex = new System.Windows.Forms.Label();
            this.labelChurigana = new System.Windows.Forms.Label();
            this.labelCname = new System.Windows.Forms.Label();
            this.labelCid = new System.Windows.Forms.Label();
            this.textBoxChurigana = new System.Windows.Forms.TextBox();
            this.textBoxCname = new System.Windows.Forms.TextBox();
            this.textBoxCID = new System.Windows.Forms.TextBox();
            this.groupBoxClist = new System.Windows.Forms.GroupBox();
            this.dataGridViewClist = new System.Windows.Forms.DataGridView();
            this.顧客マスタBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sMSdatabaseDataSet1 = new SalesManagementSystem.SMSdatabaseDataSet();
            this.顧客マスタTableAdapter1 = new SalesManagementSystem.SMSdatabaseDataSetTableAdapters.顧客マスタTableAdapter();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.顧客マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMSdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxCoperation.SuspendLayout();
            this.groupBoxClist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.顧客マスタBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSdatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.顧客マスタBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSdatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCoperation
            // 
            this.groupBoxCoperation.Controls.Add(this.buttonRefresh);
            this.groupBoxCoperation.Controls.Add(this.buttonNew);
            this.groupBoxCoperation.Controls.Add(this.buttonRemove);
            this.groupBoxCoperation.Controls.Add(this.dateTimePickerCbirth);
            this.groupBoxCoperation.Controls.Add(this.labelCmail);
            this.groupBoxCoperation.Controls.Add(this.buttonAdd);
            this.groupBoxCoperation.Controls.Add(this.textBoxCmail);
            this.groupBoxCoperation.Controls.Add(this.textBoxCphone);
            this.groupBoxCoperation.Controls.Add(this.textBoxCaddress);
            this.groupBoxCoperation.Controls.Add(this.textBoxCpost);
            this.groupBoxCoperation.Controls.Add(this.labelCphone);
            this.groupBoxCoperation.Controls.Add(this.labelCaddress);
            this.groupBoxCoperation.Controls.Add(this.labelPost);
            this.groupBoxCoperation.Controls.Add(this.labelCbirth);
            this.groupBoxCoperation.Controls.Add(this.comboBoxCsex);
            this.groupBoxCoperation.Controls.Add(this.labelCsex);
            this.groupBoxCoperation.Controls.Add(this.labelChurigana);
            this.groupBoxCoperation.Controls.Add(this.labelCname);
            this.groupBoxCoperation.Controls.Add(this.labelCid);
            this.groupBoxCoperation.Controls.Add(this.textBoxChurigana);
            this.groupBoxCoperation.Controls.Add(this.textBoxCname);
            this.groupBoxCoperation.Controls.Add(this.textBoxCID);
            this.groupBoxCoperation.Location = new System.Drawing.Point(12, 86);
            this.groupBoxCoperation.Name = "groupBoxCoperation";
            this.groupBoxCoperation.Size = new System.Drawing.Size(293, 371);
            this.groupBoxCoperation.TabIndex = 0;
            this.groupBoxCoperation.TabStop = false;
            this.groupBoxCoperation.Text = "顧客操作";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRefresh.Image = global::SalesManagementSystem.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(157, 277);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(70, 33);
            this.buttonRefresh.TabIndex = 9;
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
            this.buttonNew.Location = new System.Drawing.Point(65, 277);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 33);
            this.buttonNew.TabIndex = 8;
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
            this.buttonRemove.Location = new System.Drawing.Point(157, 320);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(70, 33);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "削除";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonrRemove_Click);
            // 
            // dateTimePickerCbirth
            // 
            this.dateTimePickerCbirth.Location = new System.Drawing.Point(116, 138);
            this.dateTimePickerCbirth.Name = "dateTimePickerCbirth";
            this.dateTimePickerCbirth.Size = new System.Drawing.Size(111, 19);
            this.dateTimePickerCbirth.TabIndex = 3;
            // 
            // labelCmail
            // 
            this.labelCmail.AutoSize = true;
            this.labelCmail.Location = new System.Drawing.Point(41, 241);
            this.labelCmail.Name = "labelCmail";
            this.labelCmail.Size = new System.Drawing.Size(71, 12);
            this.labelCmail.TabIndex = 24;
            this.labelCmail.Text = "メールアドレス:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Image = global::SalesManagementSystem.Properties.Resources.check_mark;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(65, 320);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 33);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxCmail
            // 
            this.textBoxCmail.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxCmail.Location = new System.Drawing.Point(116, 238);
            this.textBoxCmail.MaxLength = 60;
            this.textBoxCmail.Name = "textBoxCmail";
            this.textBoxCmail.Size = new System.Drawing.Size(111, 19);
            this.textBoxCmail.TabIndex = 7;
            // 
            // textBoxCphone
            // 
            this.textBoxCphone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxCphone.Location = new System.Drawing.Point(116, 213);
            this.textBoxCphone.MaxLength = 12;
            this.textBoxCphone.Name = "textBoxCphone";
            this.textBoxCphone.Size = new System.Drawing.Size(111, 19);
            this.textBoxCphone.TabIndex = 6;
            this.textBoxCphone.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxCaddress
            // 
            this.textBoxCaddress.Location = new System.Drawing.Point(116, 188);
            this.textBoxCaddress.MaxLength = 50;
            this.textBoxCaddress.Name = "textBoxCaddress";
            this.textBoxCaddress.Size = new System.Drawing.Size(111, 19);
            this.textBoxCaddress.TabIndex = 5;
            // 
            // textBoxCpost
            // 
            this.textBoxCpost.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxCpost.Location = new System.Drawing.Point(116, 163);
            this.textBoxCpost.MaxLength = 7;
            this.textBoxCpost.Name = "textBoxCpost";
            this.textBoxCpost.Size = new System.Drawing.Size(111, 19);
            this.textBoxCpost.TabIndex = 4;
            this.textBoxCpost.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelCphone
            // 
            this.labelCphone.AutoSize = true;
            this.labelCphone.Location = new System.Drawing.Point(41, 216);
            this.labelCphone.Name = "labelCphone";
            this.labelCphone.Size = new System.Drawing.Size(55, 12);
            this.labelCphone.TabIndex = 16;
            this.labelCphone.Text = "電話番号:";
            // 
            // labelCaddress
            // 
            this.labelCaddress.AutoSize = true;
            this.labelCaddress.Location = new System.Drawing.Point(41, 191);
            this.labelCaddress.Name = "labelCaddress";
            this.labelCaddress.Size = new System.Drawing.Size(31, 12);
            this.labelCaddress.TabIndex = 15;
            this.labelCaddress.Text = "住所:";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(41, 166);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(55, 12);
            this.labelPost.TabIndex = 14;
            this.labelPost.Text = "郵便番号:";
            // 
            // labelCbirth
            // 
            this.labelCbirth.AutoSize = true;
            this.labelCbirth.Location = new System.Drawing.Point(41, 141);
            this.labelCbirth.Name = "labelCbirth";
            this.labelCbirth.Size = new System.Drawing.Size(55, 12);
            this.labelCbirth.TabIndex = 13;
            this.labelCbirth.Text = "生年月日:";
            // 
            // comboBoxCsex
            // 
            this.comboBoxCsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCsex.FormattingEnabled = true;
            this.comboBoxCsex.Items.AddRange(new object[] {
            "男",
            "女",
            "不明"});
            this.comboBoxCsex.Location = new System.Drawing.Point(116, 112);
            this.comboBoxCsex.Name = "comboBoxCsex";
            this.comboBoxCsex.Size = new System.Drawing.Size(111, 20);
            this.comboBoxCsex.TabIndex = 2;
            // 
            // labelCsex
            // 
            this.labelCsex.AutoSize = true;
            this.labelCsex.Location = new System.Drawing.Point(41, 115);
            this.labelCsex.Name = "labelCsex";
            this.labelCsex.Size = new System.Drawing.Size(29, 12);
            this.labelCsex.TabIndex = 11;
            this.labelCsex.Text = "性別";
            // 
            // labelChurigana
            // 
            this.labelChurigana.AutoSize = true;
            this.labelChurigana.Location = new System.Drawing.Point(41, 90);
            this.labelChurigana.Name = "labelChurigana";
            this.labelChurigana.Size = new System.Drawing.Size(45, 12);
            this.labelChurigana.TabIndex = 10;
            this.labelChurigana.Text = "ふりがな:";
            // 
            // labelCname
            // 
            this.labelCname.AutoSize = true;
            this.labelCname.Location = new System.Drawing.Point(41, 65);
            this.labelCname.Name = "labelCname";
            this.labelCname.Size = new System.Drawing.Size(43, 12);
            this.labelCname.TabIndex = 9;
            this.labelCname.Text = "顧客名:";
            // 
            // labelCid
            // 
            this.labelCid.AutoSize = true;
            this.labelCid.Location = new System.Drawing.Point(41, 40);
            this.labelCid.Name = "labelCid";
            this.labelCid.Size = new System.Drawing.Size(42, 12);
            this.labelCid.TabIndex = 8;
            this.labelCid.Text = "顧客ID:";
            // 
            // textBoxChurigana
            // 
            this.textBoxChurigana.Location = new System.Drawing.Point(116, 87);
            this.textBoxChurigana.MaxLength = 40;
            this.textBoxChurigana.Name = "textBoxChurigana";
            this.textBoxChurigana.Size = new System.Drawing.Size(111, 19);
            this.textBoxChurigana.TabIndex = 1;
            // 
            // textBoxCname
            // 
            this.textBoxCname.Location = new System.Drawing.Point(116, 62);
            this.textBoxCname.MaxLength = 20;
            this.textBoxCname.Name = "textBoxCname";
            this.textBoxCname.Size = new System.Drawing.Size(111, 19);
            this.textBoxCname.TabIndex = 0;
            // 
            // textBoxCID
            // 
            this.textBoxCID.Enabled = false;
            this.textBoxCID.Location = new System.Drawing.Point(116, 37);
            this.textBoxCID.MaxLength = 4;
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new System.Drawing.Size(111, 19);
            this.textBoxCID.TabIndex = 0;
            // 
            // groupBoxClist
            // 
            this.groupBoxClist.Controls.Add(this.dataGridViewClist);
            this.groupBoxClist.Location = new System.Drawing.Point(311, 86);
            this.groupBoxClist.Name = "groupBoxClist";
            this.groupBoxClist.Size = new System.Drawing.Size(668, 371);
            this.groupBoxClist.TabIndex = 1;
            this.groupBoxClist.TabStop = false;
            this.groupBoxClist.Text = "顧客一覧";
            // 
            // dataGridViewClist
            // 
            this.dataGridViewClist.AllowUserToAddRows = false;
            this.dataGridViewClist.AllowUserToDeleteRows = false;
            this.dataGridViewClist.AllowUserToOrderColumns = true;
            this.dataGridViewClist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewClist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewClist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClist.Location = new System.Drawing.Point(3, 15);
            this.dataGridViewClist.MultiSelect = false;
            this.dataGridViewClist.Name = "dataGridViewClist";
            this.dataGridViewClist.ReadOnly = true;
            this.dataGridViewClist.RowTemplate.Height = 21;
            this.dataGridViewClist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClist.Size = new System.Drawing.Size(662, 353);
            this.dataGridViewClist.TabIndex = 0;
            this.dataGridViewClist.TabStop = false;
            this.dataGridViewClist.SelectionChanged += new System.EventHandler(this.dataGridViewClist_SelectionChanged);
            // 
            // 顧客マスタBindingSource1
            // 
            this.顧客マスタBindingSource1.DataMember = "顧客マスタ";
            this.顧客マスタBindingSource1.DataSource = this.sMSdatabaseDataSet1;
            // 
            // sMSdatabaseDataSet1
            // 
            this.sMSdatabaseDataSet1.DataSetName = "SMSdatabaseDataSet";
            this.sMSdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 顧客マスタTableAdapter1
            // 
            this.顧客マスタTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(492, 72);
            this.SearchTextbox.MaxLength = 50;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(241, 19);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::SalesManagementSystem.Properties.Resources.header_Customer;
            this.pictureBox5.Location = new System.Drawing.Point(783, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(214, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox4.Location = new System.Drawing.Point(611, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox3.Location = new System.Drawing.Point(420, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox2.Location = new System.Drawing.Point(212, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SalesManagementSystem.Properties.Resources.header_CustomerText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Image = global::SalesManagementSystem.Properties.Resources.magnifying_glass_4_0;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSearch.Location = new System.Drawing.Point(739, 70);
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
            this.buttonClose.Location = new System.Drawing.Point(12, 463);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 31);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // 顧客マスタBindingSource
            // 
            this.顧客マスタBindingSource.DataMember = "顧客マスタ";
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 505);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxClist);
            this.Controls.Add(this.groupBoxCoperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顧客管理";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            this.groupBoxCoperation.ResumeLayout(false);
            this.groupBoxCoperation.PerformLayout();
            this.groupBoxClist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.顧客マスタBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSdatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.顧客マスタBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSdatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCoperation;
        private System.Windows.Forms.Label labelChurigana;
        private System.Windows.Forms.Label labelCname;
        private System.Windows.Forms.Label labelCid;
        private System.Windows.Forms.TextBox textBoxChurigana;
        private System.Windows.Forms.TextBox textBoxCname;
        private System.Windows.Forms.TextBox textBoxCID;
        private System.Windows.Forms.GroupBox groupBoxClist;
        private System.Windows.Forms.TextBox textBoxCaddress;
        private System.Windows.Forms.TextBox textBoxCpost;
        private System.Windows.Forms.Label labelCphone;
        private System.Windows.Forms.Label labelCaddress;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelCbirth;
        private System.Windows.Forms.ComboBox comboBoxCsex;
        private System.Windows.Forms.Label labelCsex;
        private System.Windows.Forms.TextBox textBoxCphone;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCmail;
        private System.Windows.Forms.DataGridView dataGridViewClist;
        private System.Windows.Forms.BindingSource sMSdatabaseDataSetBindingSource;
        private SMSdatabaseDataSet sMSdatabaseDataSet;
        private System.Windows.Forms.BindingSource 顧客マスタBindingSource;
        private SMSdatabaseDataSetTableAdapters.顧客マスタTableAdapter 顧客マスタTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerCbirth;
        private System.Windows.Forms.Label labelCmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ふりがなDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生年月日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 郵便番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住所DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn メールアドレスDataGridViewTextBoxColumn;
        private SMSdatabaseDataSet sMSdatabaseDataSet1;
        private SMSdatabaseDataSetTableAdapters.顧客マスタTableAdapter 顧客マスタTableAdapter1;
        private System.Windows.Forms.BindingSource 顧客マスタBindingSource1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox SearchTextbox;
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