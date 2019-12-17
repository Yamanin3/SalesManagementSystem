namespace SalesManagementSystem
{
    partial class Login_Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.textBoxEpass = new System.Windows.Forms.TextBox();
            this.labelEID = new System.Windows.Forms.Label();
            this.labelEpass = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxHeader1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeader2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxKey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEID
            // 
            this.textBoxEID.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxEID.Location = new System.Drawing.Point(230, 85);
            this.textBoxEID.MaxLength = 4;
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(132, 19);
            this.textBoxEID.TabIndex = 3;
            this.textBoxEID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBoxEpass
            // 
            this.textBoxEpass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxEpass.Location = new System.Drawing.Point(230, 125);
            this.textBoxEpass.MaxLength = 30;
            this.textBoxEpass.Name = "textBoxEpass";
            this.textBoxEpass.PasswordChar = '*';
            this.textBoxEpass.Size = new System.Drawing.Size(132, 19);
            this.textBoxEpass.TabIndex = 4;
            this.textBoxEpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.Location = new System.Drawing.Point(155, 88);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(40, 12);
            this.labelEID.TabIndex = 5;
            this.labelEID.Text = "社員ID";
            // 
            // labelEpass
            // 
            this.labelEpass.AutoSize = true;
            this.labelEpass.Location = new System.Drawing.Point(155, 128);
            this.labelEpass.Name = "labelEpass";
            this.labelEpass.Size = new System.Drawing.Size(52, 12);
            this.labelEpass.TabIndex = 6;
            this.labelEpass.Text = "パスワード";
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Image = global::SalesManagementSystem.Properties.Resources.icons8_import_32;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(177, 173);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(77, 35);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "ログイン";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxHeader1
            // 
            this.pictureBoxHeader1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader1.Image = global::SalesManagementSystem.Properties.Resources.Cool_Text___Login_344207030785697;
            this.pictureBoxHeader1.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxHeader1.Name = "pictureBoxHeader1";
            this.pictureBoxHeader1.Size = new System.Drawing.Size(102, 35);
            this.pictureBoxHeader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader1.TabIndex = 10;
            this.pictureBoxHeader1.TabStop = false;
            // 
            // pictureBoxHeader4
            // 
            this.pictureBoxHeader4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader4.Image = global::SalesManagementSystem.Properties.Resources.header_keychain1;
            this.pictureBoxHeader4.Location = new System.Drawing.Point(231, 0);
            this.pictureBoxHeader4.Name = "pictureBoxHeader4";
            this.pictureBoxHeader4.Size = new System.Drawing.Size(160, 48);
            this.pictureBoxHeader4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader4.TabIndex = 9;
            this.pictureBoxHeader4.TabStop = false;
            // 
            // pictureBoxHeader3
            // 
            this.pictureBoxHeader3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader3.Location = new System.Drawing.Point(117, 0);
            this.pictureBoxHeader3.Name = "pictureBoxHeader3";
            this.pictureBoxHeader3.Size = new System.Drawing.Size(160, 48);
            this.pictureBoxHeader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader3.TabIndex = 8;
            this.pictureBoxHeader3.TabStop = false;
            // 
            // pictureBoxHeader2
            // 
            this.pictureBoxHeader2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBoxHeader2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxHeader2.Name = "pictureBoxHeader2";
            this.pictureBoxHeader2.Size = new System.Drawing.Size(160, 48);
            this.pictureBoxHeader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader2.TabIndex = 7;
            this.pictureBoxHeader2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Image = global::SalesManagementSystem.Properties.Resources.Actions_dialog_close_icon;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonExit.Location = new System.Drawing.Point(282, 173);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(77, 35);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "     終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxKey
            // 
            this.pictureBoxKey.Image = global::SalesManagementSystem.Properties.Resources.Lock;
            this.pictureBoxKey.Location = new System.Drawing.Point(-1, 51);
            this.pictureBoxKey.Name = "pictureBoxKey";
            this.pictureBoxKey.Size = new System.Drawing.Size(146, 133);
            this.pictureBoxKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKey.TabIndex = 0;
            this.pictureBoxKey.TabStop = false;
            // 
            // Login_Form
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 226);
            this.Controls.Add(this.pictureBoxHeader1);
            this.Controls.Add(this.pictureBoxHeader4);
            this.Controls.Add(this.pictureBoxHeader3);
            this.Controls.Add(this.pictureBoxHeader2);
            this.Controls.Add(this.labelEpass);
            this.Controls.Add(this.labelEID);
            this.Controls.Add(this.textBoxEpass);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社員ログイン";
            this.Activated += new System.EventHandler(this.Login_Form_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Form_FormClosed);
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.TextBox textBoxEpass;
        private System.Windows.Forms.Label labelEID;
        private System.Windows.Forms.Label labelEpass;
        private System.Windows.Forms.PictureBox pictureBoxKey;
        private System.Windows.Forms.PictureBox pictureBoxHeader2;
        private System.Windows.Forms.PictureBox pictureBoxHeader3;
        private System.Windows.Forms.PictureBox pictureBoxHeader4;
        private System.Windows.Forms.PictureBox pictureBoxHeader1;
    }
}

