namespace SalesManagementSystem
{
    partial class ShipListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipListForm));
            this.groupBoxSlist = new System.Windows.Forms.GroupBox();
            this.dataGridViewSlist = new System.Windows.Forms.DataGridView();
            this.groupBoxSoperation = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonOid = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCphone = new System.Windows.Forms.Label();
            this.labelCaddress = new System.Windows.Forms.Label();
            this.textBoxCphone = new System.Windows.Forms.TextBox();
            this.labelCpost = new System.Windows.Forms.Label();
            this.textBoxCaddress = new System.Windows.Forms.TextBox();
            this.labelChurigana = new System.Windows.Forms.Label();
            this.textBoxCpost = new System.Windows.Forms.TextBox();
            this.labelCname = new System.Windows.Forms.Label();
            this.textBoxChurigana = new System.Windows.Forms.TextBox();
            this.textBoxCname = new System.Windows.Forms.TextBox();
            this.labelOcurrency = new System.Windows.Forms.Label();
            this.textBoxOcurrency = new System.Windows.Forms.TextBox();
            this.labelOquantity = new System.Windows.Forms.Label();
            this.textBoxSquantity = new System.Windows.Forms.TextBox();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelOid = new System.Windows.Forms.Label();
            this.labelSid = new System.Windows.Forms.Label();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.textBoxOID = new System.Windows.Forms.TextBox();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxSlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlist)).BeginInit();
            this.groupBoxSoperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSlist
            // 
            this.groupBoxSlist.Controls.Add(this.dataGridViewSlist);
            this.groupBoxSlist.Location = new System.Drawing.Point(277, 88);
            this.groupBoxSlist.Name = "groupBoxSlist";
            this.groupBoxSlist.Size = new System.Drawing.Size(597, 408);
            this.groupBoxSlist.TabIndex = 40;
            this.groupBoxSlist.TabStop = false;
            this.groupBoxSlist.Text = "出荷済み一覧";
            // 
            // dataGridViewSlist
            // 
            this.dataGridViewSlist.AllowUserToAddRows = false;
            this.dataGridViewSlist.AllowUserToDeleteRows = false;
            this.dataGridViewSlist.AllowUserToOrderColumns = true;
            this.dataGridViewSlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewSlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewSlist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSlist.Location = new System.Drawing.Point(3, 15);
            this.dataGridViewSlist.MultiSelect = false;
            this.dataGridViewSlist.Name = "dataGridViewSlist";
            this.dataGridViewSlist.ReadOnly = true;
            this.dataGridViewSlist.RowTemplate.Height = 21;
            this.dataGridViewSlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSlist.Size = new System.Drawing.Size(591, 390);
            this.dataGridViewSlist.TabIndex = 0;
            this.dataGridViewSlist.TabStop = false;
            this.dataGridViewSlist.SelectionChanged += new System.EventHandler(this.dataGridViewSlist_SelectionChanged);
            // 
            // groupBoxSoperation
            // 
            this.groupBoxSoperation.Controls.Add(this.buttonRefresh);
            this.groupBoxSoperation.Controls.Add(this.buttonNew);
            this.groupBoxSoperation.Controls.Add(this.buttonOid);
            this.groupBoxSoperation.Controls.Add(this.buttonAdd);
            this.groupBoxSoperation.Controls.Add(this.labelCphone);
            this.groupBoxSoperation.Controls.Add(this.labelCaddress);
            this.groupBoxSoperation.Controls.Add(this.textBoxCphone);
            this.groupBoxSoperation.Controls.Add(this.labelCpost);
            this.groupBoxSoperation.Controls.Add(this.textBoxCaddress);
            this.groupBoxSoperation.Controls.Add(this.labelChurigana);
            this.groupBoxSoperation.Controls.Add(this.textBoxCpost);
            this.groupBoxSoperation.Controls.Add(this.labelCname);
            this.groupBoxSoperation.Controls.Add(this.textBoxChurigana);
            this.groupBoxSoperation.Controls.Add(this.textBoxCname);
            this.groupBoxSoperation.Controls.Add(this.labelOcurrency);
            this.groupBoxSoperation.Controls.Add(this.textBoxOcurrency);
            this.groupBoxSoperation.Controls.Add(this.labelOquantity);
            this.groupBoxSoperation.Controls.Add(this.textBoxSquantity);
            this.groupBoxSoperation.Controls.Add(this.labelPname);
            this.groupBoxSoperation.Controls.Add(this.labelOid);
            this.groupBoxSoperation.Controls.Add(this.labelSid);
            this.groupBoxSoperation.Controls.Add(this.textBoxPname);
            this.groupBoxSoperation.Controls.Add(this.textBoxOID);
            this.groupBoxSoperation.Controls.Add(this.textBoxSID);
            this.groupBoxSoperation.Location = new System.Drawing.Point(12, 88);
            this.groupBoxSoperation.Name = "groupBoxSoperation";
            this.groupBoxSoperation.Size = new System.Drawing.Size(260, 408);
            this.groupBoxSoperation.TabIndex = 0;
            this.groupBoxSoperation.TabStop = false;
            this.groupBoxSoperation.Text = "出荷操作";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRefresh.Image = global::SalesManagementSystem.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(148, 356);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(70, 33);
            this.buttonRefresh.TabIndex = 3;
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
            this.buttonNew.Location = new System.Drawing.Point(97, 308);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 33);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "新規";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonOid
            // 
            this.buttonOid.Location = new System.Drawing.Point(224, 57);
            this.buttonOid.Name = "buttonOid";
            this.buttonOid.Size = new System.Drawing.Size(22, 19);
            this.buttonOid.TabIndex = 0;
            this.buttonOid.Text = "...";
            this.buttonOid.UseVisualStyleBackColor = true;
            this.buttonOid.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Image = global::SalesManagementSystem.Properties.Resources.check_mark;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(45, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCphone
            // 
            this.labelCphone.AutoSize = true;
            this.labelCphone.Location = new System.Drawing.Point(33, 260);
            this.labelCphone.Name = "labelCphone";
            this.labelCphone.Size = new System.Drawing.Size(55, 12);
            this.labelCphone.TabIndex = 26;
            this.labelCphone.Text = "電話番号:";
            // 
            // labelCaddress
            // 
            this.labelCaddress.AutoSize = true;
            this.labelCaddress.Location = new System.Drawing.Point(33, 235);
            this.labelCaddress.Name = "labelCaddress";
            this.labelCaddress.Size = new System.Drawing.Size(31, 12);
            this.labelCaddress.TabIndex = 24;
            this.labelCaddress.Text = "住所:";
            // 
            // textBoxCphone
            // 
            this.textBoxCphone.Enabled = false;
            this.textBoxCphone.Location = new System.Drawing.Point(118, 257);
            this.textBoxCphone.MaxLength = 12;
            this.textBoxCphone.Name = "textBoxCphone";
            this.textBoxCphone.Size = new System.Drawing.Size(100, 19);
            this.textBoxCphone.TabIndex = 9;
            // 
            // labelCpost
            // 
            this.labelCpost.AutoSize = true;
            this.labelCpost.Location = new System.Drawing.Point(33, 210);
            this.labelCpost.Name = "labelCpost";
            this.labelCpost.Size = new System.Drawing.Size(55, 12);
            this.labelCpost.TabIndex = 22;
            this.labelCpost.Text = "郵便番号:";
            // 
            // textBoxCaddress
            // 
            this.textBoxCaddress.Enabled = false;
            this.textBoxCaddress.Location = new System.Drawing.Point(118, 232);
            this.textBoxCaddress.MaxLength = 50;
            this.textBoxCaddress.Name = "textBoxCaddress";
            this.textBoxCaddress.Size = new System.Drawing.Size(100, 19);
            this.textBoxCaddress.TabIndex = 8;
            // 
            // labelChurigana
            // 
            this.labelChurigana.AutoSize = true;
            this.labelChurigana.Location = new System.Drawing.Point(33, 185);
            this.labelChurigana.Name = "labelChurigana";
            this.labelChurigana.Size = new System.Drawing.Size(45, 12);
            this.labelChurigana.TabIndex = 20;
            this.labelChurigana.Text = "ふりがな:";
            // 
            // textBoxCpost
            // 
            this.textBoxCpost.Enabled = false;
            this.textBoxCpost.Location = new System.Drawing.Point(118, 207);
            this.textBoxCpost.MaxLength = 7;
            this.textBoxCpost.Name = "textBoxCpost";
            this.textBoxCpost.Size = new System.Drawing.Size(100, 19);
            this.textBoxCpost.TabIndex = 7;
            // 
            // labelCname
            // 
            this.labelCname.AutoSize = true;
            this.labelCname.Location = new System.Drawing.Point(33, 160);
            this.labelCname.Name = "labelCname";
            this.labelCname.Size = new System.Drawing.Size(43, 12);
            this.labelCname.TabIndex = 18;
            this.labelCname.Text = "顧客名:";
            // 
            // textBoxChurigana
            // 
            this.textBoxChurigana.Enabled = false;
            this.textBoxChurigana.Location = new System.Drawing.Point(118, 182);
            this.textBoxChurigana.MaxLength = 50;
            this.textBoxChurigana.Name = "textBoxChurigana";
            this.textBoxChurigana.Size = new System.Drawing.Size(100, 19);
            this.textBoxChurigana.TabIndex = 6;
            // 
            // textBoxCname
            // 
            this.textBoxCname.Enabled = false;
            this.textBoxCname.Location = new System.Drawing.Point(118, 157);
            this.textBoxCname.MaxLength = 20;
            this.textBoxCname.Name = "textBoxCname";
            this.textBoxCname.Size = new System.Drawing.Size(100, 19);
            this.textBoxCname.TabIndex = 5;
            // 
            // labelOcurrency
            // 
            this.labelOcurrency.AutoSize = true;
            this.labelOcurrency.Location = new System.Drawing.Point(33, 135);
            this.labelOcurrency.Name = "labelOcurrency";
            this.labelOcurrency.Size = new System.Drawing.Size(55, 12);
            this.labelOcurrency.TabIndex = 14;
            this.labelOcurrency.Text = "合計価格:";
            // 
            // textBoxOcurrency
            // 
            this.textBoxOcurrency.Enabled = false;
            this.textBoxOcurrency.Location = new System.Drawing.Point(118, 132);
            this.textBoxOcurrency.MaxLength = 8;
            this.textBoxOcurrency.Name = "textBoxOcurrency";
            this.textBoxOcurrency.Size = new System.Drawing.Size(100, 19);
            this.textBoxOcurrency.TabIndex = 4;
            // 
            // labelOquantity
            // 
            this.labelOquantity.AutoSize = true;
            this.labelOquantity.Location = new System.Drawing.Point(33, 110);
            this.labelOquantity.Name = "labelOquantity";
            this.labelOquantity.Size = new System.Drawing.Size(31, 12);
            this.labelOquantity.TabIndex = 12;
            this.labelOquantity.Text = "数量:";
            // 
            // textBoxSquantity
            // 
            this.textBoxSquantity.Enabled = false;
            this.textBoxSquantity.Location = new System.Drawing.Point(118, 107);
            this.textBoxSquantity.MaxLength = 2;
            this.textBoxSquantity.Name = "textBoxSquantity";
            this.textBoxSquantity.Size = new System.Drawing.Size(100, 19);
            this.textBoxSquantity.TabIndex = 3;
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Location = new System.Drawing.Point(33, 85);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(43, 12);
            this.labelPname.TabIndex = 10;
            this.labelPname.Text = "商品名:";
            // 
            // labelOid
            // 
            this.labelOid.AutoSize = true;
            this.labelOid.Location = new System.Drawing.Point(33, 60);
            this.labelOid.Name = "labelOid";
            this.labelOid.Size = new System.Drawing.Size(42, 12);
            this.labelOid.TabIndex = 9;
            this.labelOid.Text = "注文ID:";
            // 
            // labelSid
            // 
            this.labelSid.AutoSize = true;
            this.labelSid.Location = new System.Drawing.Point(33, 35);
            this.labelSid.Name = "labelSid";
            this.labelSid.Size = new System.Drawing.Size(42, 12);
            this.labelSid.TabIndex = 8;
            this.labelSid.Text = "出荷ID:";
            // 
            // textBoxPname
            // 
            this.textBoxPname.Enabled = false;
            this.textBoxPname.Location = new System.Drawing.Point(118, 82);
            this.textBoxPname.MaxLength = 50;
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(100, 19);
            this.textBoxPname.TabIndex = 2;
            // 
            // textBoxOID
            // 
            this.textBoxOID.Enabled = false;
            this.textBoxOID.Location = new System.Drawing.Point(118, 57);
            this.textBoxOID.MaxLength = 4;
            this.textBoxOID.Name = "textBoxOID";
            this.textBoxOID.Size = new System.Drawing.Size(100, 19);
            this.textBoxOID.TabIndex = 1;
            // 
            // textBoxSID
            // 
            this.textBoxSID.Enabled = false;
            this.textBoxSID.Location = new System.Drawing.Point(118, 32);
            this.textBoxSID.MaxLength = 4;
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(100, 19);
            this.textBoxSID.TabIndex = 0;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(499, 71);
            this.SearchTextbox.MaxLength = 50;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(160, 19);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::SalesManagementSystem.Properties.Resources.header_ship1;
            this.pictureBox5.Location = new System.Drawing.Point(673, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(214, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox4.Location = new System.Drawing.Point(518, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox3.Location = new System.Drawing.Point(422, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox2.Location = new System.Drawing.Point(213, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SalesManagementSystem.Properties.Resources.header_ShipText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Image = global::SalesManagementSystem.Properties.Resources.magnifying_glass_4_0;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSearch.Location = new System.Drawing.Point(665, 69);
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
            this.buttonClose.Location = new System.Drawing.Point(12, 508);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 31);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ShipListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 548);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxSlist);
            this.Controls.Add(this.groupBoxSoperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShipListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出荷管理";
            this.Load += new System.EventHandler(this.ShipListForm_Load);
            this.groupBoxSlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlist)).EndInit();
            this.groupBoxSoperation.ResumeLayout(false);
            this.groupBoxSoperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSlist;
        private System.Windows.Forms.DataGridView dataGridViewSlist;
        private System.Windows.Forms.GroupBox groupBoxSoperation;
        private System.Windows.Forms.Label labelCname;
        private System.Windows.Forms.TextBox textBoxChurigana;
        private System.Windows.Forms.TextBox textBoxCname;
        private System.Windows.Forms.Label labelOcurrency;
        private System.Windows.Forms.TextBox textBoxOcurrency;
        private System.Windows.Forms.Label labelOquantity;
        private System.Windows.Forms.TextBox textBoxSquantity;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelOid;
        private System.Windows.Forms.Label labelSid;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.TextBox textBoxOID;
        private System.Windows.Forms.TextBox textBoxSID;
        private System.Windows.Forms.Label labelCphone;
        private System.Windows.Forms.Label labelCaddress;
        private System.Windows.Forms.TextBox textBoxCphone;
        private System.Windows.Forms.Label labelCpost;
        private System.Windows.Forms.TextBox textBoxCaddress;
        private System.Windows.Forms.Label labelChurigana;
        private System.Windows.Forms.TextBox textBoxCpost;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOid;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonNew;
    }
}