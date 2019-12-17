namespace SalesManagementSystem
{
    partial class OrderingListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderingListForm));
            this.dataGridViewOrderinglist = new System.Windows.Forms.DataGridView();
            this.buttonToOrdered = new System.Windows.Forms.Button();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.pictureBoxHeader4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderinglist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrderinglist
            // 
            this.dataGridViewOrderinglist.AllowUserToAddRows = false;
            this.dataGridViewOrderinglist.AllowUserToDeleteRows = false;
            this.dataGridViewOrderinglist.AllowUserToOrderColumns = true;
            this.dataGridViewOrderinglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderinglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewOrderinglist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderinglist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOrderinglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderinglist.Location = new System.Drawing.Point(14, 105);
            this.dataGridViewOrderinglist.MultiSelect = false;
            this.dataGridViewOrderinglist.Name = "dataGridViewOrderinglist";
            this.dataGridViewOrderinglist.ReadOnly = true;
            this.dataGridViewOrderinglist.RowTemplate.Height = 21;
            this.dataGridViewOrderinglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderinglist.Size = new System.Drawing.Size(668, 224);
            this.dataGridViewOrderinglist.TabIndex = 32;
            this.dataGridViewOrderinglist.TabStop = false;
            // 
            // buttonToOrdered
            // 
            this.buttonToOrdered.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonToOrdered.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonToOrdered.Location = new System.Drawing.Point(548, 337);
            this.buttonToOrdered.Name = "buttonToOrdered";
            this.buttonToOrdered.Size = new System.Drawing.Size(134, 32);
            this.buttonToOrdered.TabIndex = 2;
            this.buttonToOrdered.Text = "発注済み一覧を表示";
            this.buttonToOrdered.UseVisualStyleBackColor = true;
            this.buttonToOrdered.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(222, 74);
            this.SearchTextbox.MaxLength = 50;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(200, 19);
            this.SearchTextbox.TabIndex = 0;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // pictureBoxHeader4
            // 
            this.pictureBoxHeader4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader4.Image = global::SalesManagementSystem.Properties.Resources.header_Ordering;
            this.pictureBoxHeader4.Location = new System.Drawing.Point(477, 0);
            this.pictureBoxHeader4.Name = "pictureBoxHeader4";
            this.pictureBoxHeader4.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader4.TabIndex = 36;
            this.pictureBoxHeader4.TabStop = false;
            // 
            // pictureBoxHeader3
            // 
            this.pictureBoxHeader3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader3.Location = new System.Drawing.Point(307, 0);
            this.pictureBoxHeader3.Name = "pictureBoxHeader3";
            this.pictureBoxHeader3.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader3.TabIndex = 35;
            this.pictureBoxHeader3.TabStop = false;
            // 
            // pictureBoxHeader2
            // 
            this.pictureBoxHeader2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader2.Location = new System.Drawing.Point(208, 0);
            this.pictureBoxHeader2.Name = "pictureBoxHeader2";
            this.pictureBoxHeader2.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader2.TabIndex = 34;
            this.pictureBoxHeader2.TabStop = false;
            // 
            // pictureBoxHeader1
            // 
            this.pictureBoxHeader1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader1.Image = global::SalesManagementSystem.Properties.Resources.header_OrderingText;
            this.pictureBoxHeader1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeader1.Name = "pictureBoxHeader1";
            this.pictureBoxHeader1.Size = new System.Drawing.Size(214, 64);
            this.pictureBoxHeader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader1.TabIndex = 33;
            this.pictureBoxHeader1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Image = global::SalesManagementSystem.Properties.Resources.magnifying_glass_4_0;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSearch.Location = new System.Drawing.Point(428, 72);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(51, 23);
            this.buttonSearch.TabIndex = 1;
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
            this.buttonClose.Location = new System.Drawing.Point(14, 337);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 31);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OrderingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 380);
            this.Controls.Add(this.pictureBoxHeader4);
            this.Controls.Add(this.pictureBoxHeader3);
            this.Controls.Add(this.pictureBoxHeader2);
            this.Controls.Add(this.pictureBoxHeader1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonToOrdered);
            this.Controls.Add(this.dataGridViewOrderinglist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderingListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "発注リスト";
            this.Load += new System.EventHandler(this.OrderingListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderinglist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewOrderinglist;
        private System.Windows.Forms.Button buttonToOrdered;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxHeader1;
        private System.Windows.Forms.PictureBox pictureBoxHeader2;
        private System.Windows.Forms.PictureBox pictureBoxHeader3;
        private System.Windows.Forms.PictureBox pictureBoxHeader4;
    }
}