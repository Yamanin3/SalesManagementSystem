namespace SalesManagementSystem
{
    partial class LoadedListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadedListForm));
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.groupBoxLoperation = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelOid = new System.Windows.Forms.Label();
            this.textBoxMname = new System.Windows.Forms.TextBox();
            this.buttonOid = new System.Windows.Forms.Button();
            this.labelPid = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelLmaker = new System.Windows.Forms.Label();
            this.labelLquantity = new System.Windows.Forms.Label();
            this.textBoxLquantity = new System.Windows.Forms.TextBox();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelLid = new System.Windows.Forms.Label();
            this.textBoxPID = new System.Windows.Forms.TextBox();
            this.textBoxRID = new System.Windows.Forms.TextBox();
            this.textBoxLID = new System.Windows.Forms.TextBox();
            this.groupBoxLlist = new System.Windows.Forms.GroupBox();
            this.dataGridViewLlist = new System.Windows.Forms.DataGridView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxLoperation.SuspendLayout();
            this.groupBoxLlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(486, 72);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(160, 19);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // groupBoxLoperation
            // 
            this.groupBoxLoperation.Controls.Add(this.buttonRefresh);
            this.groupBoxLoperation.Controls.Add(this.buttonNew);
            this.groupBoxLoperation.Controls.Add(this.labelOid);
            this.groupBoxLoperation.Controls.Add(this.textBoxMname);
            this.groupBoxLoperation.Controls.Add(this.buttonOid);
            this.groupBoxLoperation.Controls.Add(this.labelPid);
            this.groupBoxLoperation.Controls.Add(this.buttonAdd);
            this.groupBoxLoperation.Controls.Add(this.labelLmaker);
            this.groupBoxLoperation.Controls.Add(this.labelLquantity);
            this.groupBoxLoperation.Controls.Add(this.textBoxLquantity);
            this.groupBoxLoperation.Controls.Add(this.textBoxPname);
            this.groupBoxLoperation.Controls.Add(this.labelPname);
            this.groupBoxLoperation.Controls.Add(this.labelLid);
            this.groupBoxLoperation.Controls.Add(this.textBoxPID);
            this.groupBoxLoperation.Controls.Add(this.textBoxRID);
            this.groupBoxLoperation.Controls.Add(this.textBoxLID);
            this.groupBoxLoperation.Location = new System.Drawing.Point(26, 94);
            this.groupBoxLoperation.Name = "groupBoxLoperation";
            this.groupBoxLoperation.Size = new System.Drawing.Size(260, 335);
            this.groupBoxLoperation.TabIndex = 0;
            this.groupBoxLoperation.TabStop = false;
            this.groupBoxLoperation.Text = "入庫操作";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRefresh.Image = global::SalesManagementSystem.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(139, 270);
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
            this.buttonNew.Location = new System.Drawing.Point(94, 222);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 33);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "新規";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // labelOid
            // 
            this.labelOid.AutoSize = true;
            this.labelOid.Location = new System.Drawing.Point(33, 75);
            this.labelOid.Name = "labelOid";
            this.labelOid.Size = new System.Drawing.Size(42, 12);
            this.labelOid.TabIndex = 40;
            this.labelOid.Text = "発注ID:";
            // 
            // textBoxMname
            // 
            this.textBoxMname.Enabled = false;
            this.textBoxMname.Location = new System.Drawing.Point(118, 172);
            this.textBoxMname.MaxLength = 30;
            this.textBoxMname.Name = "textBoxMname";
            this.textBoxMname.Size = new System.Drawing.Size(100, 19);
            this.textBoxMname.TabIndex = 5;
            // 
            // buttonOid
            // 
            this.buttonOid.Location = new System.Drawing.Point(224, 72);
            this.buttonOid.Name = "buttonOid";
            this.buttonOid.Size = new System.Drawing.Size(22, 19);
            this.buttonOid.TabIndex = 0;
            this.buttonOid.Text = "...";
            this.buttonOid.UseVisualStyleBackColor = true;
            this.buttonOid.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPid
            // 
            this.labelPid.AutoSize = true;
            this.labelPid.Location = new System.Drawing.Point(33, 100);
            this.labelPid.Name = "labelPid";
            this.labelPid.Size = new System.Drawing.Size(42, 12);
            this.labelPid.TabIndex = 20;
            this.labelPid.Text = "商品ID:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Image = global::SalesManagementSystem.Properties.Resources.check_mark;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(48, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelLmaker
            // 
            this.labelLmaker.AutoSize = true;
            this.labelLmaker.Location = new System.Drawing.Point(33, 175);
            this.labelLmaker.Name = "labelLmaker";
            this.labelLmaker.Size = new System.Drawing.Size(43, 12);
            this.labelLmaker.TabIndex = 16;
            this.labelLmaker.Text = "製造元:";
            // 
            // labelLquantity
            // 
            this.labelLquantity.AutoSize = true;
            this.labelLquantity.Location = new System.Drawing.Point(33, 150);
            this.labelLquantity.Name = "labelLquantity";
            this.labelLquantity.Size = new System.Drawing.Size(43, 12);
            this.labelLquantity.TabIndex = 14;
            this.labelLquantity.Text = "入庫数:";
            // 
            // textBoxLquantity
            // 
            this.textBoxLquantity.Enabled = false;
            this.textBoxLquantity.Location = new System.Drawing.Point(118, 147);
            this.textBoxLquantity.MaxLength = 2;
            this.textBoxLquantity.Name = "textBoxLquantity";
            this.textBoxLquantity.Size = new System.Drawing.Size(100, 19);
            this.textBoxLquantity.TabIndex = 4;
            // 
            // textBoxPname
            // 
            this.textBoxPname.Enabled = false;
            this.textBoxPname.Location = new System.Drawing.Point(118, 122);
            this.textBoxPname.MaxLength = 50;
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(100, 19);
            this.textBoxPname.TabIndex = 3;
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Location = new System.Drawing.Point(33, 125);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(43, 12);
            this.labelPname.TabIndex = 10;
            this.labelPname.Text = "商品名:";
            // 
            // labelLid
            // 
            this.labelLid.AutoSize = true;
            this.labelLid.Location = new System.Drawing.Point(33, 50);
            this.labelLid.Name = "labelLid";
            this.labelLid.Size = new System.Drawing.Size(42, 12);
            this.labelLid.TabIndex = 8;
            this.labelLid.Text = "入庫ID:";
            // 
            // textBoxPID
            // 
            this.textBoxPID.Enabled = false;
            this.textBoxPID.Location = new System.Drawing.Point(118, 97);
            this.textBoxPID.MaxLength = 4;
            this.textBoxPID.Name = "textBoxPID";
            this.textBoxPID.Size = new System.Drawing.Size(100, 19);
            this.textBoxPID.TabIndex = 2;
            // 
            // textBoxRID
            // 
            this.textBoxRID.Enabled = false;
            this.textBoxRID.Location = new System.Drawing.Point(118, 72);
            this.textBoxRID.MaxLength = 4;
            this.textBoxRID.Name = "textBoxRID";
            this.textBoxRID.Size = new System.Drawing.Size(100, 19);
            this.textBoxRID.TabIndex = 1;
            // 
            // textBoxLID
            // 
            this.textBoxLID.Enabled = false;
            this.textBoxLID.Location = new System.Drawing.Point(118, 47);
            this.textBoxLID.MaxLength = 4;
            this.textBoxLID.Name = "textBoxLID";
            this.textBoxLID.Size = new System.Drawing.Size(100, 19);
            this.textBoxLID.TabIndex = 0;
            // 
            // groupBoxLlist
            // 
            this.groupBoxLlist.Controls.Add(this.dataGridViewLlist);
            this.groupBoxLlist.Location = new System.Drawing.Point(292, 94);
            this.groupBoxLlist.Name = "groupBoxLlist";
            this.groupBoxLlist.Size = new System.Drawing.Size(576, 335);
            this.groupBoxLlist.TabIndex = 54;
            this.groupBoxLlist.TabStop = false;
            this.groupBoxLlist.Text = "入庫済み一覧";
            // 
            // dataGridViewLlist
            // 
            this.dataGridViewLlist.AllowUserToAddRows = false;
            this.dataGridViewLlist.AllowUserToDeleteRows = false;
            this.dataGridViewLlist.AllowUserToOrderColumns = true;
            this.dataGridViewLlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewLlist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewLlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLlist.Location = new System.Drawing.Point(3, 15);
            this.dataGridViewLlist.MultiSelect = false;
            this.dataGridViewLlist.Name = "dataGridViewLlist";
            this.dataGridViewLlist.ReadOnly = true;
            this.dataGridViewLlist.RowTemplate.Height = 21;
            this.dataGridViewLlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLlist.Size = new System.Drawing.Size(570, 317);
            this.dataGridViewLlist.TabIndex = 0;
            this.dataGridViewLlist.SelectionChanged += new System.EventHandler(this.dataGridViewLlist_SelectionChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::SalesManagementSystem.Properties.Resources.header_Load1;
            this.pictureBox5.Location = new System.Drawing.Point(667, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(214, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 59;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox4.Location = new System.Drawing.Point(503, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox3.Location = new System.Drawing.Point(343, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox2.Location = new System.Drawing.Point(146, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SalesManagementSystem.Properties.Resources.header_LoadText;
            this.pictureBox1.Location = new System.Drawing.Point(-61, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Image = global::SalesManagementSystem.Properties.Resources.magnifying_glass_4_0;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSearch.Location = new System.Drawing.Point(652, 70);
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
            this.buttonClose.Location = new System.Drawing.Point(12, 435);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 31);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadedListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 475);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxLlist);
            this.Controls.Add(this.groupBoxLoperation);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadedListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入庫管理";
            this.Load += new System.EventHandler(this.LoadedListForm_Load);
            this.groupBoxLoperation.ResumeLayout(false);
            this.groupBoxLoperation.PerformLayout();
            this.groupBoxLlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxLoperation;
        private System.Windows.Forms.Button buttonOid;
        private System.Windows.Forms.Label labelPid;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelLmaker;
        private System.Windows.Forms.Label labelLquantity;
        private System.Windows.Forms.TextBox textBoxLquantity;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelLid;
        private System.Windows.Forms.TextBox textBoxPID;
        private System.Windows.Forms.TextBox textBoxRID;
        private System.Windows.Forms.TextBox textBoxLID;
        private System.Windows.Forms.GroupBox groupBoxLlist;
        private System.Windows.Forms.DataGridView dataGridViewLlist;
        private System.Windows.Forms.TextBox textBoxMname;
        private System.Windows.Forms.Label labelOid;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonRefresh;
    }
}