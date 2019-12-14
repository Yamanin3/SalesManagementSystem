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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.顧客マスタBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sMSdatabaseDataSet1 = new SalesManagementSystem.SMSdatabaseDataSet();
            this.顧客マスタTableAdapter1 = new SalesManagementSystem.SMSdatabaseDataSetTableAdapters.顧客マスタTableAdapter();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonrRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.顧客マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMSdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.buttonrRemove);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "顧客操作";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 19);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "メールアドレス:";
            // 
            // textBox7
            // 
            this.textBox7.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox7.Location = new System.Drawing.Point(116, 238);
            this.textBox7.MaxLength = 60;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(111, 19);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox6.Location = new System.Drawing.Point(116, 213);
            this.textBox6.MaxLength = 12;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 19);
            this.textBox6.TabIndex = 7;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 188);
            this.textBox5.MaxLength = 50;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 19);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox4.Location = new System.Drawing.Point(116, 163);
            this.textBox4.MaxLength = 7;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 19);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "電話番号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "住所:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "郵便番号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "生年月日:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女",
            "不明"});
            this.comboBox1.Location = new System.Drawing.Point(116, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "性別";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "ふりがな:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "顧客名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "顧客ID:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 87);
            this.textBox3.MaxLength = 40;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 19);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 62);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 19);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(116, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 19);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(311, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 371);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "顧客一覧";
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
            this.dataGridView1.Size = new System.Drawing.Size(662, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(241, 19);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRefresh.Image = global::SalesManagementSystem.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(903, 460);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(70, 33);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "更新";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
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
            // button1
            // 
            this.button1.Image = global::SalesManagementSystem.Properties.Resources.media_player_stream_no1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "閉じる";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNew.Image = global::SalesManagementSystem.Properties.Resources.add_icon__1_;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(112, 276);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 33);
            this.buttonNew.TabIndex = 9;
            this.buttonNew.Text = "新規";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonrRemove
            // 
            this.buttonrRemove.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonrRemove.Image = global::SalesManagementSystem.Properties.Resources.Delete;
            this.buttonrRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonrRemove.Location = new System.Drawing.Point(165, 320);
            this.buttonrRemove.Name = "buttonrRemove";
            this.buttonrRemove.Size = new System.Drawing.Size(70, 33);
            this.buttonrRemove.TabIndex = 11;
            this.buttonrRemove.Text = "削除";
            this.buttonrRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonrRemove.UseVisualStyleBackColor = true;
            this.buttonrRemove.Click += new System.EventHandler(this.buttonrRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Image = global::SalesManagementSystem.Properties.Resources.check_mark;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(57, 320);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 33);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顧客管理";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sMSdatabaseDataSetBindingSource;
        private SMSdatabaseDataSet sMSdatabaseDataSet;
        private System.Windows.Forms.BindingSource 顧客マスタBindingSource;
        private SMSdatabaseDataSetTableAdapters.顧客マスタTableAdapter 顧客マスタTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button buttonrRemove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonRefresh;
    }
}