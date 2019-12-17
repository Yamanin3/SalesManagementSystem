namespace SalesManagementSystem
{
    partial class ProductListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            this.groupBoxPoperation = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelPID = new System.Windows.Forms.Label();
            this.textBoxPid = new System.Windows.Forms.TextBox();
            this.buttonPmaker = new System.Windows.Forms.Button();
            this.comboBoxPmagazine = new System.Windows.Forms.ComboBox();
            this.textBoxPcurrency = new System.Windows.Forms.TextBox();
            this.textBoxMname = new System.Windows.Forms.TextBox();
            this.textBoxPcapa = new System.Windows.Forms.TextBox();
            this.labelPcurrency = new System.Windows.Forms.Label();
            this.labelPmaker = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPcapa = new System.Windows.Forms.Label();
            this.labelPmagazine = new System.Windows.Forms.Label();
            this.labelPlength = new System.Windows.Forms.Label();
            this.textBoxPlength = new System.Windows.Forms.TextBox();
            this.labelPcaliber = new System.Windows.Forms.Label();
            this.textBoxPcaliber = new System.Windows.Forms.TextBox();
            this.labelPweight = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.textBoxPweight = new System.Windows.Forms.TextBox();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.groupBoxPlist = new System.Windows.Forms.GroupBox();
            this.dataGridViewPlist = new System.Windows.Forms.DataGridView();
            this.sMSdatabaseDataSet = new SalesManagementSystem.SMSdatabaseDataSet();
            this.商品マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品マスタTableAdapter = new SalesManagementSystem.SMSdatabaseDataSetTableAdapters.商品マスタTableAdapter();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.pictureBoxHeader5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxPoperation.SuspendLayout();
            this.groupBoxPlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品マスタBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPoperation
            // 
            this.groupBoxPoperation.Controls.Add(this.buttonRefresh);
            this.groupBoxPoperation.Controls.Add(this.buttonNew);
            this.groupBoxPoperation.Controls.Add(this.buttonRemove);
            this.groupBoxPoperation.Controls.Add(this.labelPID);
            this.groupBoxPoperation.Controls.Add(this.textBoxPid);
            this.groupBoxPoperation.Controls.Add(this.buttonPmaker);
            this.groupBoxPoperation.Controls.Add(this.comboBoxPmagazine);
            this.groupBoxPoperation.Controls.Add(this.textBoxPcurrency);
            this.groupBoxPoperation.Controls.Add(this.textBoxMname);
            this.groupBoxPoperation.Controls.Add(this.textBoxPcapa);
            this.groupBoxPoperation.Controls.Add(this.labelPcurrency);
            this.groupBoxPoperation.Controls.Add(this.labelPmaker);
            this.groupBoxPoperation.Controls.Add(this.buttonAdd);
            this.groupBoxPoperation.Controls.Add(this.labelPcapa);
            this.groupBoxPoperation.Controls.Add(this.labelPmagazine);
            this.groupBoxPoperation.Controls.Add(this.labelPlength);
            this.groupBoxPoperation.Controls.Add(this.textBoxPlength);
            this.groupBoxPoperation.Controls.Add(this.labelPcaliber);
            this.groupBoxPoperation.Controls.Add(this.textBoxPcaliber);
            this.groupBoxPoperation.Controls.Add(this.labelPweight);
            this.groupBoxPoperation.Controls.Add(this.labelPname);
            this.groupBoxPoperation.Controls.Add(this.textBoxPweight);
            this.groupBoxPoperation.Controls.Add(this.textBoxPname);
            this.groupBoxPoperation.Location = new System.Drawing.Point(12, 89);
            this.groupBoxPoperation.Name = "groupBoxPoperation";
            this.groupBoxPoperation.Size = new System.Drawing.Size(260, 348);
            this.groupBoxPoperation.TabIndex = 0;
            this.groupBoxPoperation.TabStop = false;
            this.groupBoxPoperation.Text = "商品操作";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRefresh.Image = global::SalesManagementSystem.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(147, 262);
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
            this.buttonNew.Location = new System.Drawing.Point(59, 262);
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
            this.buttonRemove.Location = new System.Drawing.Point(147, 305);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(70, 33);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "削除";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonrRemove_Click);
            // 
            // labelPID
            // 
            this.labelPID.AutoSize = true;
            this.labelPID.Location = new System.Drawing.Point(27, 31);
            this.labelPID.Name = "labelPID";
            this.labelPID.Size = new System.Drawing.Size(42, 12);
            this.labelPID.TabIndex = 31;
            this.labelPID.Text = "商品ID:";
            // 
            // textBoxPid
            // 
            this.textBoxPid.Enabled = false;
            this.textBoxPid.Location = new System.Drawing.Point(102, 28);
            this.textBoxPid.MaxLength = 4;
            this.textBoxPid.Name = "textBoxPid";
            this.textBoxPid.Size = new System.Drawing.Size(100, 19);
            this.textBoxPid.TabIndex = 0;
            // 
            // buttonPmaker
            // 
            this.buttonPmaker.Location = new System.Drawing.Point(208, 204);
            this.buttonPmaker.Name = "buttonPmaker";
            this.buttonPmaker.Size = new System.Drawing.Size(22, 19);
            this.buttonPmaker.TabIndex = 6;
            this.buttonPmaker.Text = "...";
            this.buttonPmaker.UseVisualStyleBackColor = true;
            this.buttonPmaker.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxPmagazine
            // 
            this.comboBoxPmagazine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPmagazine.FormattingEnabled = true;
            this.comboBoxPmagazine.Items.AddRange(new object[] {
            "ボックスマガジン",
            "ドラムマガジン",
            "パンマガジン",
            "チューブマガジン",
            "シリンダー",
            "ショットシェル",
            "モスカート"});
            this.comboBoxPmagazine.Location = new System.Drawing.Point(102, 153);
            this.comboBoxPmagazine.Name = "comboBoxPmagazine";
            this.comboBoxPmagazine.Size = new System.Drawing.Size(100, 20);
            this.comboBoxPmagazine.TabIndex = 4;
            // 
            // textBoxPcurrency
            // 
            this.textBoxPcurrency.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxPcurrency.Location = new System.Drawing.Point(102, 229);
            this.textBoxPcurrency.MaxLength = 8;
            this.textBoxPcurrency.Name = "textBoxPcurrency";
            this.textBoxPcurrency.Size = new System.Drawing.Size(100, 19);
            this.textBoxPcurrency.TabIndex = 7;
            this.textBoxPcurrency.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBoxMname
            // 
            this.textBoxMname.Enabled = false;
            this.textBoxMname.Location = new System.Drawing.Point(102, 204);
            this.textBoxMname.MaxLength = 30;
            this.textBoxMname.Name = "textBoxMname";
            this.textBoxMname.Size = new System.Drawing.Size(100, 19);
            this.textBoxMname.TabIndex = 8;
            // 
            // textBoxPcapa
            // 
            this.textBoxPcapa.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxPcapa.Location = new System.Drawing.Point(102, 179);
            this.textBoxPcapa.MaxLength = 4;
            this.textBoxPcapa.Name = "textBoxPcapa";
            this.textBoxPcapa.Size = new System.Drawing.Size(100, 19);
            this.textBoxPcapa.TabIndex = 5;
            this.textBoxPcapa.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // labelPcurrency
            // 
            this.labelPcurrency.AutoSize = true;
            this.labelPcurrency.Location = new System.Drawing.Point(27, 232);
            this.labelPcurrency.Name = "labelPcurrency";
            this.labelPcurrency.Size = new System.Drawing.Size(55, 12);
            this.labelPcurrency.TabIndex = 28;
            this.labelPcurrency.Text = "商品価格:";
            // 
            // labelPmaker
            // 
            this.labelPmaker.AutoSize = true;
            this.labelPmaker.Location = new System.Drawing.Point(27, 207);
            this.labelPmaker.Name = "labelPmaker";
            this.labelPmaker.Size = new System.Drawing.Size(56, 12);
            this.labelPmaker.TabIndex = 26;
            this.labelPmaker.Text = "メーカー名:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Image = global::SalesManagementSystem.Properties.Resources.check_mark;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(59, 305);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 33);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPcapa
            // 
            this.labelPcapa.AutoSize = true;
            this.labelPcapa.Location = new System.Drawing.Point(27, 182);
            this.labelPcapa.Name = "labelPcapa";
            this.labelPcapa.Size = new System.Drawing.Size(43, 12);
            this.labelPcapa.TabIndex = 20;
            this.labelPcapa.Text = "装弾数:";
            // 
            // labelPmagazine
            // 
            this.labelPmagazine.AutoSize = true;
            this.labelPmagazine.Location = new System.Drawing.Point(27, 156);
            this.labelPmagazine.Name = "labelPmagazine";
            this.labelPmagazine.Size = new System.Drawing.Size(71, 12);
            this.labelPmagazine.TabIndex = 18;
            this.labelPmagazine.Text = "マガジンタイプ:";
            // 
            // labelPlength
            // 
            this.labelPlength.AutoSize = true;
            this.labelPlength.Location = new System.Drawing.Point(27, 131);
            this.labelPlength.Name = "labelPlength";
            this.labelPlength.Size = new System.Drawing.Size(57, 12);
            this.labelPlength.TabIndex = 14;
            this.labelPlength.Text = "全長(mm):";
            // 
            // textBoxPlength
            // 
            this.textBoxPlength.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxPlength.Location = new System.Drawing.Point(102, 128);
            this.textBoxPlength.MaxLength = 4;
            this.textBoxPlength.Name = "textBoxPlength";
            this.textBoxPlength.Size = new System.Drawing.Size(100, 19);
            this.textBoxPlength.TabIndex = 3;
            this.textBoxPlength.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // labelPcaliber
            // 
            this.labelPcaliber.AutoSize = true;
            this.labelPcaliber.Location = new System.Drawing.Point(27, 106);
            this.labelPcaliber.Name = "labelPcaliber";
            this.labelPcaliber.Size = new System.Drawing.Size(57, 12);
            this.labelPcaliber.TabIndex = 12;
            this.labelPcaliber.Text = "口径(mm):";
            // 
            // textBoxPcaliber
            // 
            this.textBoxPcaliber.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxPcaliber.Location = new System.Drawing.Point(102, 103);
            this.textBoxPcaliber.MaxLength = 6;
            this.textBoxPcaliber.Name = "textBoxPcaliber";
            this.textBoxPcaliber.Size = new System.Drawing.Size(100, 19);
            this.textBoxPcaliber.TabIndex = 2;
            this.textBoxPcaliber.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelPweight
            // 
            this.labelPweight.AutoSize = true;
            this.labelPweight.Location = new System.Drawing.Point(27, 81);
            this.labelPweight.Name = "labelPweight";
            this.labelPweight.Size = new System.Drawing.Size(51, 12);
            this.labelPweight.TabIndex = 10;
            this.labelPweight.Text = "重量(kg):";
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Location = new System.Drawing.Point(27, 56);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(43, 12);
            this.labelPname.TabIndex = 9;
            this.labelPname.Text = "商品名:";
            // 
            // textBoxPweight
            // 
            this.textBoxPweight.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxPweight.Location = new System.Drawing.Point(102, 78);
            this.textBoxPweight.MaxLength = 4;
            this.textBoxPweight.Name = "textBoxPweight";
            this.textBoxPweight.Size = new System.Drawing.Size(100, 19);
            this.textBoxPweight.TabIndex = 1;
            this.textBoxPweight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxPname
            // 
            this.textBoxPname.Location = new System.Drawing.Point(102, 53);
            this.textBoxPname.MaxLength = 50;
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(100, 19);
            this.textBoxPname.TabIndex = 0;
            // 
            // groupBoxPlist
            // 
            this.groupBoxPlist.Controls.Add(this.dataGridViewPlist);
            this.groupBoxPlist.Location = new System.Drawing.Point(278, 89);
            this.groupBoxPlist.Name = "groupBoxPlist";
            this.groupBoxPlist.Size = new System.Drawing.Size(597, 348);
            this.groupBoxPlist.TabIndex = 6;
            this.groupBoxPlist.TabStop = false;
            this.groupBoxPlist.Text = "商品一覧";
            // 
            // dataGridViewPlist
            // 
            this.dataGridViewPlist.AllowUserToAddRows = false;
            this.dataGridViewPlist.AllowUserToDeleteRows = false;
            this.dataGridViewPlist.AllowUserToOrderColumns = true;
            this.dataGridViewPlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewPlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewPlist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlist.Location = new System.Drawing.Point(3, 15);
            this.dataGridViewPlist.MultiSelect = false;
            this.dataGridViewPlist.Name = "dataGridViewPlist";
            this.dataGridViewPlist.ReadOnly = true;
            this.dataGridViewPlist.RowTemplate.Height = 21;
            this.dataGridViewPlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlist.Size = new System.Drawing.Size(591, 330);
            this.dataGridViewPlist.TabIndex = 0;
            this.dataGridViewPlist.TabStop = false;
            this.dataGridViewPlist.SelectionChanged += new System.EventHandler(this.dataGridViewPlist_SelectionChanged);
            // 
            // sMSdatabaseDataSet
            // 
            this.sMSdatabaseDataSet.DataSetName = "SMSdatabaseDataSet";
            this.sMSdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品マスタBindingSource
            // 
            this.商品マスタBindingSource.DataMember = "商品マスタ";
            this.商品マスタBindingSource.DataSource = this.sMSdatabaseDataSet;
            // 
            // 商品マスタTableAdapter
            // 
            this.商品マスタTableAdapter.ClearBeforeFill = true;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(454, 73);
            this.SearchTextbox.MaxLength = 50;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(198, 19);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // pictureBoxHeader5
            // 
            this.pictureBoxHeader5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader5.Image = global::SalesManagementSystem.Properties.Resources.header_product;
            this.pictureBoxHeader5.Location = new System.Drawing.Point(673, 0);
            this.pictureBoxHeader5.Name = "pictureBoxHeader5";
            this.pictureBoxHeader5.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader5.TabIndex = 11;
            this.pictureBoxHeader5.TabStop = false;
            // 
            // pictureBoxHeader4
            // 
            this.pictureBoxHeader4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader4.Image = global::SalesManagementSystem.Properties.Resources.header_back1;
            this.pictureBoxHeader4.Location = new System.Drawing.Point(526, 0);
            this.pictureBoxHeader4.Name = "pictureBoxHeader4";
            this.pictureBoxHeader4.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader4.TabIndex = 10;
            this.pictureBoxHeader4.TabStop = false;
            // 
            // pictureBoxHeader3
            // 
            this.pictureBoxHeader3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader3.Image = global::SalesManagementSystem.Properties.Resources.header_back1;
            this.pictureBoxHeader3.Location = new System.Drawing.Point(426, 0);
            this.pictureBoxHeader3.Name = "pictureBoxHeader3";
            this.pictureBoxHeader3.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader3.TabIndex = 9;
            this.pictureBoxHeader3.TabStop = false;
            // 
            // pictureBoxHeader2
            // 
            this.pictureBoxHeader2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader2.Image = global::SalesManagementSystem.Properties.Resources.header_back1;
            this.pictureBoxHeader2.Location = new System.Drawing.Point(213, 0);
            this.pictureBoxHeader2.Name = "pictureBoxHeader2";
            this.pictureBoxHeader2.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader2.TabIndex = 8;
            this.pictureBoxHeader2.TabStop = false;
            // 
            // pictureBoxHeader1
            // 
            this.pictureBoxHeader1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader1.Image = global::SalesManagementSystem.Properties.Resources.header_ProductText;
            this.pictureBoxHeader1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeader1.Name = "pictureBoxHeader1";
            this.pictureBoxHeader1.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader1.TabIndex = 7;
            this.pictureBoxHeader1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Image = global::SalesManagementSystem.Properties.Resources.magnifying_glass_4_0;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSearch.Location = new System.Drawing.Point(658, 71);
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
            this.buttonClose.Location = new System.Drawing.Point(12, 443);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 31);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 489);
            this.Controls.Add(this.pictureBoxHeader5);
            this.Controls.Add(this.pictureBoxHeader4);
            this.Controls.Add(this.pictureBoxHeader3);
            this.Controls.Add(this.pictureBoxHeader2);
            this.Controls.Add(this.pictureBoxHeader1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxPlist);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.groupBoxPoperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            this.groupBoxPoperation.ResumeLayout(false);
            this.groupBoxPoperation.PerformLayout();
            this.groupBoxPlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品マスタBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxPoperation;
        private System.Windows.Forms.Label labelPweight;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.TextBox textBoxPweight;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.GroupBox groupBoxPlist;
        private System.Windows.Forms.DataGridView dataGridViewPlist;
        private System.Windows.Forms.Label labelPcapa;
        private System.Windows.Forms.Label labelPmagazine;
        private System.Windows.Forms.Label labelPlength;
        private System.Windows.Forms.TextBox textBoxPlength;
        private System.Windows.Forms.Label labelPcaliber;
        private System.Windows.Forms.TextBox textBoxPcaliber;
        private System.Windows.Forms.Button buttonAdd;
        private SMSdatabaseDataSet sMSdatabaseDataSet;
        private System.Windows.Forms.BindingSource 商品マスタBindingSource;
        private SMSdatabaseDataSetTableAdapters.商品マスタTableAdapter 商品マスタTableAdapter;
        private System.Windows.Forms.Label labelPcurrency;
        private System.Windows.Forms.Label labelPmaker;
        private System.Windows.Forms.ComboBox comboBoxPmagazine;
        private System.Windows.Forms.TextBox textBoxPcurrency;
        private System.Windows.Forms.TextBox textBoxPcapa;
        private System.Windows.Forms.Button buttonPmaker;
        private System.Windows.Forms.TextBox textBoxMname;
        private System.Windows.Forms.Label labelPID;
        private System.Windows.Forms.TextBox textBoxPid;
        private System.Windows.Forms.Button buttonClose;
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