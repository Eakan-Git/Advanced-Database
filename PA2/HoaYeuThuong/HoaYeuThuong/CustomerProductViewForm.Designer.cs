
namespace HoaYeuThuong
{
    partial class CustomerProductViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNavigator = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.labelVAT = new System.Windows.Forms.Label();
            this.labelSalePrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panelDes = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.panelList = new System.Windows.Forms.Panel();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnTrending = new System.Windows.Forms.RadioButton();
            this.panelAddToCart = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.panelNavigator.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panelPrice.SuspendLayout();
            this.panelDes.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelPicture.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelAddToCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
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
            this.panelNavigator.Size = new System.Drawing.Size(790, 70);
            this.panelNavigator.TabIndex = 10;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.Location = new System.Drawing.Point(361, 37);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Tìm";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBox.Location = new System.Drawing.Point(320, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(150, 20);
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
            this.btnNext.Location = new System.Drawing.Point(576, 11);
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
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.panelPrice);
            this.panelDetail.Controls.Add(this.panelDes);
            this.panelDetail.Controls.Add(this.panelName);
            this.panelDetail.Controls.Add(this.panelPicture);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(790, 201);
            this.panelDetail.TabIndex = 12;
            // 
            // panelPrice
            // 
            this.panelPrice.Controls.Add(this.labelVAT);
            this.panelPrice.Controls.Add(this.labelSalePrice);
            this.panelPrice.Controls.Add(this.labelPrice);
            this.panelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrice.Location = new System.Drawing.Point(208, 105);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(582, 96);
            this.panelPrice.TabIndex = 5;
            // 
            // labelVAT
            // 
            this.labelVAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVAT.AutoSize = true;
            this.labelVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVAT.Location = new System.Drawing.Point(386, 3);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(196, 16);
            this.labelVAT.TabIndex = 3;
            this.labelVAT.Text = "(Giá đã bao gồm 10% VAT)";
            // 
            // labelSalePrice
            // 
            this.labelSalePrice.AutoSize = true;
            this.labelSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalePrice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelSalePrice.Location = new System.Drawing.Point(304, 40);
            this.labelSalePrice.Name = "labelSalePrice";
            this.labelSalePrice.Size = new System.Drawing.Size(72, 20);
            this.labelSalePrice.TabIndex = 2;
            this.labelSalePrice.Text = "Giá bán";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelPrice.ForeColor = System.Drawing.Color.Red;
            this.labelPrice.Location = new System.Drawing.Point(6, 40);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(71, 20);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Giá gốc";
            // 
            // panelDes
            // 
            this.panelDes.Controls.Add(this.labelDescription);
            this.panelDes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDes.Location = new System.Drawing.Point(208, 51);
            this.panelDes.Name = "panelDes";
            this.panelDes.Size = new System.Drawing.Size(582, 54);
            this.panelDes.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelDescription.Location = new System.Drawing.Point(0, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(582, 54);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Mô tả: ";
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(208, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(582, 51);
            this.panelName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(582, 51);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "HOA YÊU THƯƠNG";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPicture.Controls.Add(this.productImage);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(208, 201);
            this.panelPicture.TabIndex = 0;
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.panelDGV);
            this.panelList.Controls.Add(this.panelControl);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 201);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(790, 312);
            this.panelList.TabIndex = 13;
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.productDGV);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 42);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(790, 270);
            this.panelDGV.TabIndex = 1;
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToAddRows = false;
            this.productDGV.AllowUserToDeleteRows = false;
            this.productDGV.AllowUserToResizeColumns = false;
            this.productDGV.AllowUserToResizeRows = false;
            this.productDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = "Không xác định";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.productDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDGV.GridColor = System.Drawing.Color.Gainsboro;
            this.productDGV.Location = new System.Drawing.Point(0, 0);
            this.productDGV.Name = "productDGV";
            this.productDGV.ReadOnly = true;
            this.productDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.productDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDGV.Size = new System.Drawing.Size(790, 270);
            this.productDGV.TabIndex = 13;
            this.productDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellClick);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelAddToCart);
            this.panelControl.Controls.Add(this.btnTrending);
            this.panelControl.Controls.Add(this.btnReload);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(790, 42);
            this.panelControl.TabIndex = 0;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // btnTrending
            // 
            this.btnTrending.AutoSize = true;
            this.btnTrending.Location = new System.Drawing.Point(218, 13);
            this.btnTrending.Name = "btnTrending";
            this.btnTrending.Size = new System.Drawing.Size(123, 17);
            this.btnTrending.TabIndex = 15;
            this.btnTrending.TabStop = true;
            this.btnTrending.Text = "Sản Phẩm Bán Chạy";
            this.btnTrending.UseVisualStyleBackColor = true;
            this.btnTrending.CheckedChanged += new System.EventHandler(this.btnTrending_CheckedChanged);
            this.btnTrending.Click += new System.EventHandler(this.btnTrending_Click);
            // 
            // panelAddToCart
            // 
            this.panelAddToCart.Controls.Add(this.btnAddToCart);
            this.panelAddToCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddToCart.Location = new System.Drawing.Point(0, 0);
            this.panelAddToCart.Name = "panelAddToCart";
            this.panelAddToCart.Size = new System.Drawing.Size(208, 42);
            this.panelAddToCart.TabIndex = 16;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddToCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddToCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddToCart.Image = global::HoaYeuThuong.Properties.Resources.add_to_cart32;
            this.btnAddToCart.Location = new System.Drawing.Point(0, 0);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(208, 42);
            this.btnAddToCart.TabIndex = 17;
            this.btnAddToCart.Text = "Thêm";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Image = global::HoaYeuThuong.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(761, 18);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(29, 24);
            this.btnReload.TabIndex = 14;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // productImage
            // 
            this.productImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productImage.Location = new System.Drawing.Point(0, 0);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(208, 201);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // CustomerProductViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 583);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerProductViewForm";
            this.Text = "CustomerProductViewForm";
            this.Load += new System.EventHandler(this.CustomerProductViewForm_Load);
            this.panelNavigator.ResumeLayout(false);
            this.panelNavigator.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            this.panelDes.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelPicture.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelAddToCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigator;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Label labelSalePrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panelDes;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.RadioButton btnTrending;
        private System.Windows.Forms.DataGridView productDGV;
        private System.Windows.Forms.Panel panelAddToCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.PictureBox productImage;
    }
}