﻿
namespace HoaYeuThuong
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.navMenu = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreateAccout = new System.Windows.Forms.Button();
            this.btnOrderForCustomer = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Controls.Add(this.userAvatar);
            this.panel1.Controls.Add(this.greetingLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 68);
            this.panel1.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.logoLabel);
            this.panelLogo.Controls.Add(this.logoPic);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(247, 68);
            this.panelLogo.TabIndex = 2;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.logoLabel.Location = new System.Drawing.Point(116, 20);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(112, 29);
            this.logoLabel.TabIndex = 4;
            this.logoLabel.Text = "NHÓM 9";
            // 
            // greetingLabel
            // 
            this.greetingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.greetingLabel.Location = new System.Drawing.Point(724, 20);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(244, 29);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = "Xin chào, username";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 583);
            this.panel2.TabIndex = 3;
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.btnCreateAccout);
            this.menuPanel.Controls.Add(this.btnOrderForCustomer);
            this.menuPanel.Controls.Add(this.btnMoney);
            this.menuPanel.Controls.Add(this.btnStaff);
            this.menuPanel.Controls.Add(this.btnCustomer);
            this.menuPanel.Controls.Add(this.btnOrder);
            this.menuPanel.Controls.Add(this.btnProduct);
            this.menuPanel.Controls.Add(this.btnCart);
            this.menuPanel.Controls.Add(this.navMenu);
            this.menuPanel.Controls.Add(this.btnProfile);
            this.menuPanel.Controls.Add(this.btnLogout);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 68);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(265, 583);
            this.menuPanel.TabIndex = 4;
            // 
            // navMenu
            // 
            this.navMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Size = new System.Drawing.Size(10, 70);
            this.navMenu.TabIndex = 27;
            this.navMenu.Visible = false;
            // 
            // childFormPanel
            // 
            this.childFormPanel.Controls.Add(this.label11);
            this.childFormPanel.Controls.Add(this.label12);
            this.childFormPanel.Controls.Add(this.label1);
            this.childFormPanel.Controls.Add(this.label2);
            this.childFormPanel.Controls.Add(this.label10);
            this.childFormPanel.Controls.Add(this.label9);
            this.childFormPanel.Controls.Add(this.label8);
            this.childFormPanel.Controls.Add(this.label7);
            this.childFormPanel.Controls.Add(this.label6);
            this.childFormPanel.Controls.Add(this.label5);
            this.childFormPanel.Controls.Add(this.label4);
            this.childFormPanel.Controls.Add(this.label3);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(265, 68);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(790, 583);
            this.childFormPanel.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = "Lương Kiếm Minh";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(191, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "19127471";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phan Tường Duy";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "19127380";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(322, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Trần Hải Đăng";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bùi Nguyễn Minh Châu";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(322, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nguyễn Quang Trường";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(191, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "18127074";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "18127068";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "19127608";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "MSSV";
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaff.Location = new System.Drawing.Point(0, 350);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(246, 70);
            this.btnStaff.TabIndex = 43;
            this.btnStaff.Text = "  Nhân Viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.Location = new System.Drawing.Point(0, 280);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(246, 70);
            this.btnCustomer.TabIndex = 42;
            this.btnCustomer.Text = "  Khách Hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.Location = new System.Drawing.Point(0, 210);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(246, 70);
            this.btnOrder.TabIndex = 41;
            this.btnOrder.Text = "  Đơn Hàng";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = global::HoaYeuThuong.Properties.Resources.flower_product;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.Location = new System.Drawing.Point(0, 140);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(246, 70);
            this.btnProduct.TabIndex = 40;
            this.btnProduct.Text = "  Sản Phẩm";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCart
            // 
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Image = global::HoaYeuThuong.Properties.Resources.cart;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCart.Location = new System.Drawing.Point(0, 70);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(246, 70);
            this.btnCart.TabIndex = 39;
            this.btnCart.Text = "  Giỏ Hàng";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(246, 70);
            this.btnProfile.TabIndex = 21;
            this.btnProfile.Text = "  Hồ Sơ";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // logoPic
            // 
            this.logoPic.BackColor = System.Drawing.Color.Transparent;
            this.logoPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPic.Image = global::HoaYeuThuong.Properties.Resources.logo;
            this.logoPic.Location = new System.Drawing.Point(0, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(95, 68);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPic.TabIndex = 3;
            this.logoPic.TabStop = false;
            this.logoPic.Click += new System.EventHandler(this.logoPic_Click);
            // 
            // userAvatar
            // 
            this.userAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userAvatar.Image = ((System.Drawing.Image)(resources.GetObject("userAvatar.Image")));
            this.userAvatar.Location = new System.Drawing.Point(974, 9);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(81, 50);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAvatar.TabIndex = 3;
            this.userAvatar.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 630);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(246, 70);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "  Đăng Xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateAccout
            // 
            this.btnCreateAccout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateAccout.FlatAppearance.BorderSize = 0;
            this.btnCreateAccout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccout.Image = global::HoaYeuThuong.Properties.Resources.createAccount;
            this.btnCreateAccout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAccout.Location = new System.Drawing.Point(0, 560);
            this.btnCreateAccout.Name = "btnCreateAccout";
            this.btnCreateAccout.Size = new System.Drawing.Size(246, 70);
            this.btnCreateAccout.TabIndex = 55;
            this.btnCreateAccout.Text = "  Tài Khoản";
            this.btnCreateAccout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAccout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCreateAccout.UseVisualStyleBackColor = true;
            this.btnCreateAccout.Click += new System.EventHandler(this.btnCreateAccout_Click);
            // 
            // btnOrderForCustomer
            // 
            this.btnOrderForCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderForCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderForCustomer.FlatAppearance.BorderSize = 0;
            this.btnOrderForCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderForCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderForCustomer.Image = global::HoaYeuThuong.Properties.Resources.createOrder;
            this.btnOrderForCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderForCustomer.Location = new System.Drawing.Point(0, 490);
            this.btnOrderForCustomer.Name = "btnOrderForCustomer";
            this.btnOrderForCustomer.Size = new System.Drawing.Size(246, 70);
            this.btnOrderForCustomer.TabIndex = 54;
            this.btnOrderForCustomer.Text = "  Tạo Đơn";
            this.btnOrderForCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderForCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrderForCustomer.UseVisualStyleBackColor = true;
            this.btnOrderForCustomer.Click += new System.EventHandler(this.btnOrderForCustomer_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoney.FlatAppearance.BorderSize = 0;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoney.Image = ((System.Drawing.Image)(resources.GetObject("btnMoney.Image")));
            this.btnMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoney.Location = new System.Drawing.Point(0, 420);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(246, 70);
            this.btnMoney.TabIndex = 53;
            this.btnMoney.Text = "  Thu Nhập";
            this.btnMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 651);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1071, 690);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoa Yêu Thương";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel navMenu;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnCreateAccout;
        private System.Windows.Forms.Button btnOrderForCustomer;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnLogout;
    }
}