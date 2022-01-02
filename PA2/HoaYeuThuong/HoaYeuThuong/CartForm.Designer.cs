
namespace HoaYeuThuong
{
    partial class CartForm
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
            this.panelTilte = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.panelSalePrice = new System.Windows.Forms.Panel();
            this.labelSalePrice = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.panelTilte.SuspendLayout();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelPrice.SuspendLayout();
            this.panelSalePrice.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTilte
            // 
            this.panelTilte.Controls.Add(this.labelTitle);
            this.panelTilte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTilte.Location = new System.Drawing.Point(0, 0);
            this.panelTilte.Name = "panelTilte";
            this.panelTilte.Size = new System.Drawing.Size(790, 58);
            this.panelTilte.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(790, 58);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "GIỎ HÀNG";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.productDGV);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDGV.Location = new System.Drawing.Point(0, 272);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(790, 311);
            this.panelDGV.TabIndex = 1;
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToAddRows = false;
            this.productDGV.AllowUserToDeleteRows = false;
            this.productDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDGV.Location = new System.Drawing.Point(0, 0);
            this.productDGV.Name = "productDGV";
            this.productDGV.ReadOnly = true;
            this.productDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDGV.Size = new System.Drawing.Size(790, 311);
            this.productDGV.TabIndex = 0;
            this.productDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellClick);
            this.productDGV.SelectionChanged += new System.EventHandler(this.productDGV_SelectionChanged);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelPrice);
            this.panelControl.Controls.Add(this.panelTotal);
            this.panelControl.Controls.Add(this.panelName);
            this.panelControl.Controls.Add(this.btnPurchase);
            this.panelControl.Controls.Add(this.quantityLabel);
            this.panelControl.Controls.Add(this.quantity);
            this.panelControl.Controls.Add(this.btnDeleteProduct);
            this.panelControl.Controls.Add(this.btnEditQuantity);
            this.panelControl.Controls.Add(this.productImage);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 58);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(790, 214);
            this.panelControl.TabIndex = 2;
            // 
            // panelPrice
            // 
            this.panelPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPrice.Controls.Add(this.panelSalePrice);
            this.panelPrice.Location = new System.Drawing.Point(198, 137);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(391, 55);
            this.panelPrice.TabIndex = 15;
            // 
            // panelSalePrice
            // 
            this.panelSalePrice.Controls.Add(this.labelSalePrice);
            this.panelSalePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSalePrice.Location = new System.Drawing.Point(0, 0);
            this.panelSalePrice.Name = "panelSalePrice";
            this.panelSalePrice.Size = new System.Drawing.Size(391, 55);
            this.panelSalePrice.TabIndex = 1;
            // 
            // labelSalePrice
            // 
            this.labelSalePrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalePrice.ForeColor = System.Drawing.Color.Green;
            this.labelSalePrice.Location = new System.Drawing.Point(0, 0);
            this.labelSalePrice.Name = "labelSalePrice";
            this.labelSalePrice.Size = new System.Drawing.Size(391, 55);
            this.labelSalePrice.TabIndex = 16;
            this.labelSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSalePrice.Visible = false;
            // 
            // panelTotal
            // 
            this.panelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(193, 55);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(404, 54);
            this.panelTotal.TabIndex = 14;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(404, 54);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.Visible = false;
            // 
            // panelName
            // 
            this.panelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelName.Controls.Add(this.nameLabel);
            this.panelName.Location = new System.Drawing.Point(237, 6);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(317, 43);
            this.panelName.TabIndex = 13;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(317, 43);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "HOA YÊU THƯƠNG";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Image = global::HoaYeuThuong.Properties.Resources.purchase;
            this.btnPurchase.Location = new System.Drawing.Point(651, 23);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(136, 108);
            this.btnPurchase.TabIndex = 12;
            this.btnPurchase.Text = "Đặt Hàng";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(592, 137);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 13);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Số Lượng";
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.Location = new System.Drawing.Point(595, 154);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(50, 20);
            this.quantity.TabIndex = 10;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_ValueChanged);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Image = global::HoaYeuThuong.Properties.Resources.delete_32;
            this.btnDeleteProduct.Location = new System.Drawing.Point(722, 137);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(65, 55);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuantity.Image = global::HoaYeuThuong.Properties.Resources.save_32;
            this.btnEditQuantity.Location = new System.Drawing.Point(651, 137);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(65, 55);
            this.btnEditQuantity.TabIndex = 8;
            this.btnEditQuantity.Text = "Lưu";
            this.btnEditQuantity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditQuantity.UseVisualStyleBackColor = true;
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(27, 23);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(123, 169);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 583);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelTilte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.panelTilte.ResumeLayout(false);
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelSalePrice.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTilte;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditQuantity;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.DataGridView productDGV;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.Panel panelSalePrice;
        private System.Windows.Forms.Label labelSalePrice;
    }
}