namespace SalesManagementSystem
{
    partial class StockListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockListForm));
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.groupBoxSTlist = new System.Windows.Forms.GroupBox();
            this.dataGridViewSTlist = new System.Windows.Forms.DataGridView();
            this.groupBoxSToperation = new System.Windows.Forms.GroupBox();
            this.labelStpoint = new System.Windows.Forms.Label();
            this.textBoxStpoint = new System.Windows.Forms.TextBox();
            this.labelStstock = new System.Windows.Forms.Label();
            this.textBoxStstock = new System.Windows.Forms.TextBox();
            this.labelPname = new System.Windows.Forms.Label();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelPid = new System.Windows.Forms.Label();
            this.textBoxPID = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.pictureBoxHeader5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxSTlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSTlist)).BeginInit();
            this.groupBoxSToperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(425, 76);
            this.SearchTextbox.MaxLength = 50;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(205, 19);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // groupBoxSTlist
            // 
            this.groupBoxSTlist.Controls.Add(this.dataGridViewSTlist);
            this.groupBoxSTlist.Location = new System.Drawing.Point(277, 100);
            this.groupBoxSTlist.Name = "groupBoxSTlist";
            this.groupBoxSTlist.Size = new System.Drawing.Size(597, 348);
            this.groupBoxSTlist.TabIndex = 42;
            this.groupBoxSTlist.TabStop = false;
            this.groupBoxSTlist.Text = "在庫一覧";
            // 
            // dataGridViewSTlist
            // 
            this.dataGridViewSTlist.AllowUserToAddRows = false;
            this.dataGridViewSTlist.AllowUserToDeleteRows = false;
            this.dataGridViewSTlist.AllowUserToOrderColumns = true;
            this.dataGridViewSTlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSTlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSTlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewSTlist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSTlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSTlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSTlist.Location = new System.Drawing.Point(3, 15);
            this.dataGridViewSTlist.MultiSelect = false;
            this.dataGridViewSTlist.Name = "dataGridViewSTlist";
            this.dataGridViewSTlist.ReadOnly = true;
            this.dataGridViewSTlist.RowTemplate.Height = 21;
            this.dataGridViewSTlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSTlist.Size = new System.Drawing.Size(591, 330);
            this.dataGridViewSTlist.TabIndex = 0;
            this.dataGridViewSTlist.TabStop = false;
            this.dataGridViewSTlist.VirtualMode = true;
            this.dataGridViewSTlist.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridViewSTlist_CellValueNeeded);
            this.dataGridViewSTlist.SelectionChanged += new System.EventHandler(this.dataGridViewSTlist_SelectionChanged);
            // 
            // groupBoxSToperation
            // 
            this.groupBoxSToperation.Controls.Add(this.labelStpoint);
            this.groupBoxSToperation.Controls.Add(this.textBoxStpoint);
            this.groupBoxSToperation.Controls.Add(this.labelStstock);
            this.groupBoxSToperation.Controls.Add(this.textBoxStstock);
            this.groupBoxSToperation.Controls.Add(this.labelPname);
            this.groupBoxSToperation.Controls.Add(this.textBoxPname);
            this.groupBoxSToperation.Controls.Add(this.buttonRefresh);
            this.groupBoxSToperation.Controls.Add(this.labelPid);
            this.groupBoxSToperation.Controls.Add(this.textBoxPID);
            this.groupBoxSToperation.Controls.Add(this.buttonSet);
            this.groupBoxSToperation.Location = new System.Drawing.Point(12, 100);
            this.groupBoxSToperation.Name = "groupBoxSToperation";
            this.groupBoxSToperation.Size = new System.Drawing.Size(238, 268);
            this.groupBoxSToperation.TabIndex = 0;
            this.groupBoxSToperation.TabStop = false;
            this.groupBoxSToperation.Text = "発注点操作";
            // 
            // labelStpoint
            // 
            this.labelStpoint.AutoSize = true;
            this.labelStpoint.Location = new System.Drawing.Point(32, 123);
            this.labelStpoint.Name = "labelStpoint";
            this.labelStpoint.Size = new System.Drawing.Size(43, 12);
            this.labelStpoint.TabIndex = 37;
            this.labelStpoint.Text = "発注点:";
            // 
            // textBoxStpoint
            // 
            this.textBoxStpoint.Location = new System.Drawing.Point(107, 120);
            this.textBoxStpoint.MaxLength = 4;
            this.textBoxStpoint.Name = "textBoxStpoint";
            this.textBoxStpoint.Size = new System.Drawing.Size(100, 19);
            this.textBoxStpoint.TabIndex = 3;
            this.textBoxStpoint.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelStstock
            // 
            this.labelStstock.AutoSize = true;
            this.labelStstock.Location = new System.Drawing.Point(32, 98);
            this.labelStstock.Name = "labelStstock";
            this.labelStstock.Size = new System.Drawing.Size(43, 12);
            this.labelStstock.TabIndex = 35;
            this.labelStstock.Text = "在庫数:";
            // 
            // textBoxStstock
            // 
            this.textBoxStstock.Enabled = false;
            this.textBoxStstock.Location = new System.Drawing.Point(107, 95);
            this.textBoxStstock.MaxLength = 4;
            this.textBoxStstock.Name = "textBoxStstock";
            this.textBoxStstock.Size = new System.Drawing.Size(100, 19);
            this.textBoxStstock.TabIndex = 2;
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Location = new System.Drawing.Point(32, 73);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(43, 12);
            this.labelPname.TabIndex = 33;
            this.labelPname.Text = "商品名:";
            // 
            // textBoxPname
            // 
            this.textBoxPname.Enabled = false;
            this.textBoxPname.Location = new System.Drawing.Point(107, 70);
            this.textBoxPname.MaxLength = 50;
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(100, 19);
            this.textBoxPname.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRefresh.Image = global::SalesManagementSystem.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(128, 191);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(79, 39);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "更新";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPid
            // 
            this.labelPid.AutoSize = true;
            this.labelPid.Location = new System.Drawing.Point(32, 48);
            this.labelPid.Name = "labelPid";
            this.labelPid.Size = new System.Drawing.Size(42, 12);
            this.labelPid.TabIndex = 31;
            this.labelPid.Text = "商品ID:";
            // 
            // textBoxPID
            // 
            this.textBoxPID.Enabled = false;
            this.textBoxPID.Location = new System.Drawing.Point(107, 45);
            this.textBoxPID.MaxLength = 4;
            this.textBoxPID.Name = "textBoxPID";
            this.textBoxPID.Size = new System.Drawing.Size(100, 19);
            this.textBoxPID.TabIndex = 0;
            // 
            // buttonSet
            // 
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSet.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSet.Image = global::SalesManagementSystem.Properties.Resources.gears_tweakui_a_1;
            this.buttonSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSet.Location = new System.Drawing.Point(34, 191);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(79, 39);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "設定";
            this.buttonSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBoxHeader5
            // 
            this.pictureBoxHeader5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader5.Image = global::SalesManagementSystem.Properties.Resources.header_Stock2;
            this.pictureBoxHeader5.Location = new System.Drawing.Point(673, 0);
            this.pictureBoxHeader5.Name = "pictureBoxHeader5";
            this.pictureBoxHeader5.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader5.TabIndex = 47;
            this.pictureBoxHeader5.TabStop = false;
            // 
            // pictureBoxHeader4
            // 
            this.pictureBoxHeader4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader4.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader4.Location = new System.Drawing.Point(509, 0);
            this.pictureBoxHeader4.Name = "pictureBoxHeader4";
            this.pictureBoxHeader4.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader4.TabIndex = 46;
            this.pictureBoxHeader4.TabStop = false;
            // 
            // pictureBoxHeader3
            // 
            this.pictureBoxHeader3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader3.Location = new System.Drawing.Point(392, 0);
            this.pictureBoxHeader3.Name = "pictureBoxHeader3";
            this.pictureBoxHeader3.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader3.TabIndex = 45;
            this.pictureBoxHeader3.TabStop = false;
            // 
            // pictureBoxHeader2
            // 
            this.pictureBoxHeader2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader2.Location = new System.Drawing.Point(213, 0);
            this.pictureBoxHeader2.Name = "pictureBoxHeader2";
            this.pictureBoxHeader2.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader2.TabIndex = 44;
            this.pictureBoxHeader2.TabStop = false;
            // 
            // pictureBoxHeader1
            // 
            this.pictureBoxHeader1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader1.Image = global::SalesManagementSystem.Properties.Resources.header_StockText;
            this.pictureBoxHeader1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeader1.Name = "pictureBoxHeader1";
            this.pictureBoxHeader1.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader1.TabIndex = 43;
            this.pictureBoxHeader1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Image = global::SalesManagementSystem.Properties.Resources.magnifying_glass_4_0;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSearch.Location = new System.Drawing.Point(636, 74);
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
            this.buttonClose.Location = new System.Drawing.Point(12, 451);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 31);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StockListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 499);
            this.Controls.Add(this.pictureBoxHeader5);
            this.Controls.Add(this.pictureBoxHeader4);
            this.Controls.Add(this.pictureBoxHeader3);
            this.Controls.Add(this.pictureBoxHeader2);
            this.Controls.Add(this.pictureBoxHeader1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxSToperation);
            this.Controls.Add(this.groupBoxSTlist);
            this.Controls.Add(this.SearchTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在庫一覧";
            this.Load += new System.EventHandler(this.StockListForm_Load);
            this.groupBoxSTlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSTlist)).EndInit();
            this.groupBoxSToperation.ResumeLayout(false);
            this.groupBoxSToperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.GroupBox groupBoxSTlist;
        private System.Windows.Forms.DataGridView dataGridViewSTlist;
        private System.Windows.Forms.GroupBox groupBoxSToperation;
        private System.Windows.Forms.Label labelPid;
        private System.Windows.Forms.TextBox textBoxPID;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label labelStstock;
        private System.Windows.Forms.TextBox textBoxStstock;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.Label labelStpoint;
        private System.Windows.Forms.TextBox textBoxStpoint;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxHeader1;
        private System.Windows.Forms.PictureBox pictureBoxHeader2;
        private System.Windows.Forms.PictureBox pictureBoxHeader3;
        private System.Windows.Forms.PictureBox pictureBoxHeader4;
        private System.Windows.Forms.PictureBox pictureBoxHeader5;
    }
}