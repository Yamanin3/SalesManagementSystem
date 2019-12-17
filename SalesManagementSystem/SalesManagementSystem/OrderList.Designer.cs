namespace SalesManagementSystem
{
    partial class OrderListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListForm));
            this.groupBoxOlist = new System.Windows.Forms.GroupBox();
            this.dataGridViewOlist = new System.Windows.Forms.DataGridView();
            this.groupBoxODoperation = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxOquantity = new System.Windows.Forms.ComboBox();
            this.buttonPname = new System.Windows.Forms.Button();
            this.buttonCname = new System.Windows.Forms.Button();
            this.textBoxEname = new System.Windows.Forms.TextBox();
            this.labelEname = new System.Windows.Forms.Label();
            this.dateTimePickerOdate = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxOcurrency = new System.Windows.Forms.TextBox();
            this.textBoxPcurrency = new System.Windows.Forms.TextBox();
            this.labelOcurrency = new System.Windows.Forms.Label();
            this.labelPcurrency = new System.Windows.Forms.Label();
            this.labelOdate = new System.Windows.Forms.Label();
            this.labelOquantity = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelCname = new System.Windows.Forms.Label();
            this.labelOid = new System.Windows.Forms.Label();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.textBoxCname = new System.Windows.Forms.TextBox();
            this.textBoxOID = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.pictureBoxHeader5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxOlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOlist)).BeginInit();
            this.groupBoxODoperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOlist
            // 
            this.groupBoxOlist.Controls.Add(this.dataGridViewOlist);
            this.groupBoxOlist.Location = new System.Drawing.Point(308, 88);
            this.groupBoxOlist.Name = "groupBoxOlist";
            this.groupBoxOlist.Size = new System.Drawing.Size(671, 351);
            this.groupBoxOlist.TabIndex = 2;
            this.groupBoxOlist.TabStop = false;
            this.groupBoxOlist.Text = "注文一覧";
            // 
            // dataGridViewOlist
            // 
            this.dataGridViewOlist.AllowUserToAddRows = false;
            this.dataGridViewOlist.AllowUserToDeleteRows = false;
            this.dataGridViewOlist.AllowUserToOrderColumns = true;
            this.dataGridViewOlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewOlist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOlist.Location = new System.Drawing.Point(3, 15);
            this.dataGridViewOlist.MultiSelect = false;
            this.dataGridViewOlist.Name = "dataGridViewOlist";
            this.dataGridViewOlist.ReadOnly = true;
            this.dataGridViewOlist.RowTemplate.Height = 21;
            this.dataGridViewOlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOlist.Size = new System.Drawing.Size(665, 333);
            this.dataGridViewOlist.TabIndex = 0;
            this.dataGridViewOlist.TabStop = false;
            this.dataGridViewOlist.VirtualMode = true;
            this.dataGridViewOlist.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridViewOlist_CellValueNeeded);
            this.dataGridViewOlist.SelectionChanged += new System.EventHandler(this.dataGridViewOlist_SelectionChanged);
            // 
            // groupBoxODoperation
            // 
            this.groupBoxODoperation.Controls.Add(this.buttonRefresh);
            this.groupBoxODoperation.Controls.Add(this.buttonNew);
            this.groupBoxODoperation.Controls.Add(this.buttonRemove);
            this.groupBoxODoperation.Controls.Add(this.comboBoxOquantity);
            this.groupBoxODoperation.Controls.Add(this.buttonPname);
            this.groupBoxODoperation.Controls.Add(this.buttonCname);
            this.groupBoxODoperation.Controls.Add(this.textBoxEname);
            this.groupBoxODoperation.Controls.Add(this.labelEname);
            this.groupBoxODoperation.Controls.Add(this.dateTimePickerOdate);
            this.groupBoxODoperation.Controls.Add(this.buttonAdd);
            this.groupBoxODoperation.Controls.Add(this.textBoxOcurrency);
            this.groupBoxODoperation.Controls.Add(this.textBoxPcurrency);
            this.groupBoxODoperation.Controls.Add(this.labelOcurrency);
            this.groupBoxODoperation.Controls.Add(this.labelPcurrency);
            this.groupBoxODoperation.Controls.Add(this.labelOdate);
            this.groupBoxODoperation.Controls.Add(this.labelOquantity);
            this.groupBoxODoperation.Controls.Add(this.labelPname);
            this.groupBoxODoperation.Controls.Add(this.labelCname);
            this.groupBoxODoperation.Controls.Add(this.labelOid);
            this.groupBoxODoperation.Controls.Add(this.textBoxPname);
            this.groupBoxODoperation.Controls.Add(this.textBoxCname);
            this.groupBoxODoperation.Controls.Add(this.textBoxOID);
            this.groupBoxODoperation.Location = new System.Drawing.Point(6, 88);
            this.groupBoxODoperation.Name = "groupBoxODoperation";
            this.groupBoxODoperation.Size = new System.Drawing.Size(296, 348);
            this.groupBoxODoperation.TabIndex = 0;
            this.groupBoxODoperation.TabStop = false;
            this.groupBoxODoperation.Text = "注文操作";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRefresh.Image = global::SalesManagementSystem.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(157, 247);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(70, 33);
            this.buttonRefresh.TabIndex = 5;
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
            this.buttonNew.Location = new System.Drawing.Point(68, 247);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 33);
            this.buttonNew.TabIndex = 4;
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
            this.buttonRemove.Location = new System.Drawing.Point(157, 292);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(70, 33);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "削除";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxOquantity
            // 
            this.comboBoxOquantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOquantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOquantity.FormattingEnabled = true;
            this.comboBoxOquantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxOquantity.Location = new System.Drawing.Point(116, 103);
            this.comboBoxOquantity.Name = "comboBoxOquantity";
            this.comboBoxOquantity.Size = new System.Drawing.Size(121, 20);
            this.comboBoxOquantity.TabIndex = 2;
            this.comboBoxOquantity.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // buttonPname
            // 
            this.buttonPname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPname.Location = new System.Drawing.Point(243, 78);
            this.buttonPname.Name = "buttonPname";
            this.buttonPname.Size = new System.Drawing.Size(22, 19);
            this.buttonPname.TabIndex = 1;
            this.buttonPname.Text = "...";
            this.buttonPname.UseVisualStyleBackColor = true;
            this.buttonPname.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCname
            // 
            this.buttonCname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCname.Location = new System.Drawing.Point(243, 53);
            this.buttonCname.Name = "buttonCname";
            this.buttonCname.Size = new System.Drawing.Size(22, 19);
            this.buttonCname.TabIndex = 0;
            this.buttonCname.Text = "...";
            this.buttonCname.UseVisualStyleBackColor = true;
            this.buttonCname.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxEname
            // 
            this.textBoxEname.Enabled = false;
            this.textBoxEname.Location = new System.Drawing.Point(116, 203);
            this.textBoxEname.MaxLength = 20;
            this.textBoxEname.Name = "textBoxEname";
            this.textBoxEname.Size = new System.Drawing.Size(121, 19);
            this.textBoxEname.TabIndex = 7;
            // 
            // labelEname
            // 
            this.labelEname.AutoSize = true;
            this.labelEname.Location = new System.Drawing.Point(41, 206);
            this.labelEname.Name = "labelEname";
            this.labelEname.Size = new System.Drawing.Size(55, 12);
            this.labelEname.TabIndex = 18;
            this.labelEname.Text = "担当者名:";
            // 
            // dateTimePickerOdate
            // 
            this.dateTimePickerOdate.Enabled = false;
            this.dateTimePickerOdate.Location = new System.Drawing.Point(116, 128);
            this.dateTimePickerOdate.Name = "dateTimePickerOdate";
            this.dateTimePickerOdate.Size = new System.Drawing.Size(121, 19);
            this.dateTimePickerOdate.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Image = global::SalesManagementSystem.Properties.Resources.check_mark;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(68, 292);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 33);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxOcurrency
            // 
            this.textBoxOcurrency.Enabled = false;
            this.textBoxOcurrency.Location = new System.Drawing.Point(116, 178);
            this.textBoxOcurrency.MaxLength = 16;
            this.textBoxOcurrency.Name = "textBoxOcurrency";
            this.textBoxOcurrency.Size = new System.Drawing.Size(121, 19);
            this.textBoxOcurrency.TabIndex = 6;
            // 
            // textBoxPcurrency
            // 
            this.textBoxPcurrency.Enabled = false;
            this.textBoxPcurrency.Location = new System.Drawing.Point(116, 153);
            this.textBoxPcurrency.MaxLength = 8;
            this.textBoxPcurrency.Name = "textBoxPcurrency";
            this.textBoxPcurrency.Size = new System.Drawing.Size(121, 19);
            this.textBoxPcurrency.TabIndex = 5;
            // 
            // labelOcurrency
            // 
            this.labelOcurrency.AutoSize = true;
            this.labelOcurrency.Location = new System.Drawing.Point(41, 181);
            this.labelOcurrency.Name = "labelOcurrency";
            this.labelOcurrency.Size = new System.Drawing.Size(43, 12);
            this.labelOcurrency.TabIndex = 16;
            this.labelOcurrency.Text = "合計額:";
            // 
            // labelPcurrency
            // 
            this.labelPcurrency.AutoSize = true;
            this.labelPcurrency.Location = new System.Drawing.Point(41, 156);
            this.labelPcurrency.Name = "labelPcurrency";
            this.labelPcurrency.Size = new System.Drawing.Size(53, 12);
            this.labelPcurrency.TabIndex = 15;
            this.labelPcurrency.Text = "商品価格";
            // 
            // labelOdate
            // 
            this.labelOdate.AutoSize = true;
            this.labelOdate.Location = new System.Drawing.Point(41, 131);
            this.labelOdate.Name = "labelOdate";
            this.labelOdate.Size = new System.Drawing.Size(43, 12);
            this.labelOdate.TabIndex = 14;
            this.labelOdate.Text = "注文日:";
            // 
            // labelOquantity
            // 
            this.labelOquantity.AutoSize = true;
            this.labelOquantity.Location = new System.Drawing.Point(41, 106);
            this.labelOquantity.Name = "labelOquantity";
            this.labelOquantity.Size = new System.Drawing.Size(31, 12);
            this.labelOquantity.TabIndex = 13;
            this.labelOquantity.Text = "数量:";
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Location = new System.Drawing.Point(41, 81);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(43, 12);
            this.labelPname.TabIndex = 10;
            this.labelPname.Text = "商品名:";
            // 
            // labelCname
            // 
            this.labelCname.AutoSize = true;
            this.labelCname.Location = new System.Drawing.Point(41, 56);
            this.labelCname.Name = "labelCname";
            this.labelCname.Size = new System.Drawing.Size(43, 12);
            this.labelCname.TabIndex = 9;
            this.labelCname.Text = "顧客名:";
            // 
            // labelOid
            // 
            this.labelOid.AutoSize = true;
            this.labelOid.Location = new System.Drawing.Point(41, 31);
            this.labelOid.Name = "labelOid";
            this.labelOid.Size = new System.Drawing.Size(42, 12);
            this.labelOid.TabIndex = 8;
            this.labelOid.Text = "注文ID:";
            // 
            // textBoxPname
            // 
            this.textBoxPname.Enabled = false;
            this.textBoxPname.Location = new System.Drawing.Point(116, 78);
            this.textBoxPname.MaxLength = 50;
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(121, 19);
            this.textBoxPname.TabIndex = 2;
            // 
            // textBoxCname
            // 
            this.textBoxCname.Enabled = false;
            this.textBoxCname.Location = new System.Drawing.Point(116, 53);
            this.textBoxCname.MaxLength = 20;
            this.textBoxCname.Name = "textBoxCname";
            this.textBoxCname.Size = new System.Drawing.Size(121, 19);
            this.textBoxCname.TabIndex = 1;
            // 
            // textBoxOID
            // 
            this.textBoxOID.Enabled = false;
            this.textBoxOID.Location = new System.Drawing.Point(116, 28);
            this.textBoxOID.MaxLength = 4;
            this.textBoxOID.Name = "textBoxOID";
            this.textBoxOID.Size = new System.Drawing.Size(121, 19);
            this.textBoxOID.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(857, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "注文済み一覧表示";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(518, 73);
            this.SearchTextbox.MaxLength = 50;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(227, 19);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // pictureBoxHeader5
            // 
            this.pictureBoxHeader5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader5.Image = global::SalesManagementSystem.Properties.Resources.header_Order1;
            this.pictureBoxHeader5.Location = new System.Drawing.Point(778, 0);
            this.pictureBoxHeader5.Name = "pictureBoxHeader5";
            this.pictureBoxHeader5.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader5.TabIndex = 13;
            this.pictureBoxHeader5.TabStop = false;
            // 
            // pictureBoxHeader4
            // 
            this.pictureBoxHeader4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader4.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader4.Location = new System.Drawing.Point(588, 0);
            this.pictureBoxHeader4.Name = "pictureBoxHeader4";
            this.pictureBoxHeader4.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader4.TabIndex = 12;
            this.pictureBoxHeader4.TabStop = false;
            // 
            // pictureBoxHeader3
            // 
            this.pictureBoxHeader3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader3.Location = new System.Drawing.Point(416, 0);
            this.pictureBoxHeader3.Name = "pictureBoxHeader3";
            this.pictureBoxHeader3.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader3.TabIndex = 11;
            this.pictureBoxHeader3.TabStop = false;
            // 
            // pictureBoxHeader2
            // 
            this.pictureBoxHeader2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader2.Location = new System.Drawing.Point(209, 0);
            this.pictureBoxHeader2.Name = "pictureBoxHeader2";
            this.pictureBoxHeader2.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader2.TabIndex = 10;
            this.pictureBoxHeader2.TabStop = false;
            // 
            // pictureBoxHeader1
            // 
            this.pictureBoxHeader1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader1.Image = global::SalesManagementSystem.Properties.Resources.header_OrderText;
            this.pictureBoxHeader1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeader1.Name = "pictureBoxHeader1";
            this.pictureBoxHeader1.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader1.TabIndex = 9;
            this.pictureBoxHeader1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Image = global::SalesManagementSystem.Properties.Resources.magnifying_glass_4_0;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSearch.Location = new System.Drawing.Point(751, 71);
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
            this.buttonClose.Location = new System.Drawing.Point(12, 442);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 31);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 485);
            this.Controls.Add(this.pictureBoxHeader5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBoxHeader4);
            this.Controls.Add(this.pictureBoxHeader3);
            this.Controls.Add(this.pictureBoxHeader2);
            this.Controls.Add(this.pictureBoxHeader1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxODoperation);
            this.Controls.Add(this.groupBoxOlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注文管理";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            this.groupBoxOlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOlist)).EndInit();
            this.groupBoxODoperation.ResumeLayout(false);
            this.groupBoxODoperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOlist;
        private System.Windows.Forms.DataGridView dataGridViewOlist;
        private System.Windows.Forms.GroupBox groupBoxODoperation;
        private System.Windows.Forms.TextBox textBoxOcurrency;
        private System.Windows.Forms.TextBox textBoxPcurrency;
        private System.Windows.Forms.Label labelOcurrency;
        private System.Windows.Forms.Label labelPcurrency;
        private System.Windows.Forms.Label labelOdate;
        private System.Windows.Forms.Label labelOquantity;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelCname;
        private System.Windows.Forms.Label labelOid;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.TextBox textBoxCname;
        private System.Windows.Forms.TextBox textBoxOID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerOdate;
        private System.Windows.Forms.TextBox textBoxEname;
        private System.Windows.Forms.Label labelEname;
        private System.Windows.Forms.Button buttonPname;
        private System.Windows.Forms.Button buttonCname;
        private System.Windows.Forms.ComboBox comboBoxOquantity;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.PictureBox pictureBoxHeader1;
        private System.Windows.Forms.PictureBox pictureBoxHeader2;
        private System.Windows.Forms.PictureBox pictureBoxHeader3;
        private System.Windows.Forms.PictureBox pictureBoxHeader4;
        private System.Windows.Forms.PictureBox pictureBoxHeader5;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonRefresh;
    }
}