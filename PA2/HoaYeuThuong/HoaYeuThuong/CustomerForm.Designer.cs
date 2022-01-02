
namespace HoaYeuThuong
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelNavigator = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelCMND = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.labelTilte = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelNavigator.SuspendLayout();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUnlock);
            this.panel1.Controls.Add(this.btnLock);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(736, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 583);
            this.panel1.TabIndex = 0;
            // 
            // btnUnlock
            // 
            this.btnUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnlock.FlatAppearance.BorderSize = 0;
            this.btnUnlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUnlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.Image = global::HoaYeuThuong.Properties.Resources.unlock;
            this.btnUnlock.Location = new System.Drawing.Point(0, 388);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(72, 195);
            this.btnUnlock.TabIndex = 28;
            this.btnUnlock.Text = "Mở Khóa";
            this.btnUnlock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnLock
            // 
            this.btnLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.Image = global::HoaYeuThuong.Properties.Resources._lock;
            this.btnLock.Location = new System.Drawing.Point(0, 194);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(72, 194);
            this.btnLock.TabIndex = 27;
            this.btnLock.Text = "Khóa";
            this.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 194);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelNavigator
            // 
            this.panelNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(138)))));
            this.panelNavigator.Controls.Add(this.searchBtn);
            this.panelNavigator.Controls.Add(this.searchBox);
            this.panelNavigator.Controls.Add(this.btnNext);
            this.panelNavigator.Controls.Add(this.btnPrevious);
            this.panelNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigator.Location = new System.Drawing.Point(0, 513);
            this.panelNavigator.Name = "panelNavigator";
            this.panelNavigator.Size = new System.Drawing.Size(736, 70);
            this.panelNavigator.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.Location = new System.Drawing.Point(334, 37);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Tìm";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBox.Location = new System.Drawing.Point(293, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(152, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(522, 11);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 50);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(114, 10);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 50);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDetails.Controls.Add(this.labelCMND);
            this.panelDetails.Controls.Add(this.tbCMND);
            this.panelDetails.Controls.Add(this.labelID);
            this.panelDetails.Controls.Add(this.tbID);
            this.panelDetails.Controls.Add(this.emailLabel);
            this.panelDetails.Controls.Add(this.tbEmail);
            this.panelDetails.Controls.Add(this.btnReload);
            this.panelDetails.Controls.Add(this.phoneLabel);
            this.panelDetails.Controls.Add(this.addressLabel);
            this.panelDetails.Controls.Add(this.nameLabel);
            this.panelDetails.Controls.Add(this.labelTilte);
            this.panelDetails.Controls.Add(this.tbPhone);
            this.panelDetails.Controls.Add(this.tbAddress);
            this.panelDetails.Controls.Add(this.tbName);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(736, 190);
            this.panelDetails.TabIndex = 15;
            // 
            // labelCMND
            // 
            this.labelCMND.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCMND.AutoSize = true;
            this.labelCMND.Location = new System.Drawing.Point(284, 100);
            this.labelCMND.Name = "labelCMND";
            this.labelCMND.Size = new System.Drawing.Size(39, 13);
            this.labelCMND.TabIndex = 23;
            this.labelCMND.Text = "CMND";
            // 
            // tbCMND
            // 
            this.tbCMND.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCMND.Location = new System.Drawing.Point(284, 119);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(161, 20);
            this.tbCMND.TabIndex = 22;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(53, 100);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(38, 13);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "Mã Số";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(53, 119);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(161, 20);
            this.tbID.TabIndex = 17;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(507, 151);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(507, 170);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(161, 20);
            this.tbEmail.TabIndex = 15;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Image = global::HoaYeuThuong.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(707, 166);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(29, 24);
            this.btnReload.TabIndex = 12;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(284, 151);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(75, 13);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Số Điện Thoại";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(507, 100);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(41, 13);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Địa Chỉ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(53, 150);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Họ Và Tên";
            // 
            // labelTilte
            // 
            this.labelTilte.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTilte.Location = new System.Drawing.Point(0, 0);
            this.labelTilte.Name = "labelTilte";
            this.labelTilte.Size = new System.Drawing.Size(736, 58);
            this.labelTilte.TabIndex = 5;
            this.labelTilte.Text = "THÔNG TIN KHÁCH HÀNG";
            this.labelTilte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPhone.Location = new System.Drawing.Point(284, 170);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(161, 20);
            this.tbPhone.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(507, 119);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(161, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 169);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(161, 20);
            this.tbName.TabIndex = 1;
            // 
            // customerDGV
            // 
            this.customerDGV.AllowUserToAddRows = false;
            this.customerDGV.AllowUserToDeleteRows = false;
            this.customerDGV.AllowUserToResizeColumns = false;
            this.customerDGV.AllowUserToResizeRows = false;
            this.customerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Không xác định";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerDGV.GridColor = System.Drawing.Color.Gainsboro;
            this.customerDGV.Location = new System.Drawing.Point(0, 190);
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.ReadOnly = true;
            this.customerDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.customerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDGV.Size = new System.Drawing.Size(736, 323);
            this.customerDGV.TabIndex = 14;
            this.customerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDGV_CellClick);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 583);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.customerDGV);
            this.Controls.Add(this.panelNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelNavigator.ResumeLayout(false);
            this.panelNavigator.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelNavigator;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label labelCMND;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label labelTilte;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView customerDGV;
    }
}