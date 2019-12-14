namespace SalesManagementSystem
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonOrdering = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonShip = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonMember = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SalesManagementSystem.Properties.Resources.header_Menuuu;
            this.pictureBox4.Location = new System.Drawing.Point(504, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox3.Location = new System.Drawing.Point(296, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SalesManagementSystem.Properties.Resources.header_back;
            this.pictureBox2.Location = new System.Drawing.Point(153, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SalesManagementSystem.Properties.Resources.header_MenuuuText;
            this.pictureBox1.Location = new System.Drawing.Point(-60, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Image = global::SalesManagementSystem.Properties.Resources.exit;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(39, 342);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(103, 41);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Image = global::SalesManagementSystem.Properties.Resources.msagent_3;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLoad.Location = new System.Drawing.Point(288, 257);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(138, 47);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "入庫管理";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.Image = global::SalesManagementSystem.Properties.Resources.search_computer_0;
            this.buttonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStock.Location = new System.Drawing.Point(466, 183);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(138, 47);
            this.buttonStock.TabIndex = 7;
            this.buttonStock.Text = "在庫確認";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonOrdering
            // 
            this.buttonOrdering.Image = global::SalesManagementSystem.Properties.Resources.write_card_phone;
            this.buttonOrdering.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOrdering.Location = new System.Drawing.Point(466, 109);
            this.buttonOrdering.Name = "buttonOrdering";
            this.buttonOrdering.Size = new System.Drawing.Size(138, 47);
            this.buttonOrdering.TabIndex = 6;
            this.buttonOrdering.Text = "発注確認";
            this.buttonOrdering.UseVisualStyleBackColor = true;
            this.buttonOrdering.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Image = global::SalesManagementSystem.Properties.Resources.Exit__3_;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.Location = new System.Drawing.Point(586, 341);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 41);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "  Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Image = global::SalesManagementSystem.Properties.Resources.address_book_0;
            this.buttonProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProduct.Location = new System.Drawing.Point(104, 257);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(138, 47);
            this.buttonProduct.TabIndex = 2;
            this.buttonProduct.Text = "商品管理";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonShip
            // 
            this.buttonShip.Image = global::SalesManagementSystem.Properties.Resources.address_book_home;
            this.buttonShip.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShip.Location = new System.Drawing.Point(288, 183);
            this.buttonShip.Name = "buttonShip";
            this.buttonShip.Size = new System.Drawing.Size(138, 47);
            this.buttonShip.TabIndex = 4;
            this.buttonShip.Text = "出荷管理";
            this.buttonShip.UseVisualStyleBackColor = true;
            this.buttonShip.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Image = global::SalesManagementSystem.Properties.Resources.winrep_1;
            this.buttonOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOrder.Location = new System.Drawing.Point(288, 109);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(138, 47);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "注文管理";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMember
            // 
            this.buttonMember.Image = global::SalesManagementSystem.Properties.Resources._220;
            this.buttonMember.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMember.Location = new System.Drawing.Point(104, 183);
            this.buttonMember.Name = "buttonMember";
            this.buttonMember.Size = new System.Drawing.Size(138, 47);
            this.buttonMember.TabIndex = 1;
            this.buttonMember.Text = "社員管理";
            this.buttonMember.UseVisualStyleBackColor = true;
            this.buttonMember.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Image = global::SalesManagementSystem.Properties.Resources.write_yellow_1;
            this.buttonSales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSales.Location = new System.Drawing.Point(466, 257);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(138, 47);
            this.buttonSales.TabIndex = 8;
            this.buttonSales.Text = "売上確認";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Image = global::SalesManagementSystem.Properties.Resources.user_card;
            this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCustomer.Location = new System.Drawing.Point(104, 109);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(138, 47);
            this.buttonCustomer.TabIndex = 0;
            this.buttonCustomer.Text = "顧客管理";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 408);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonOrdering);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonShip);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonMember);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メインメニュー";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonMember;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonOrdering;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonShip;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}