
namespace HoaYeuThuong
{
    partial class CustomerOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDetailRight = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.Label();
            this.voucher = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.deliveryTime = new System.Windows.Forms.Label();
            this.placedTime = new System.Windows.Forms.Label();
            this.extraCost = new System.Windows.Forms.Label();
            this.GTGT = new System.Windows.Forms.Label();
            this.panelDetailLeft = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.anonymous = new System.Windows.Forms.Label();
            this.addressTo = new System.Windows.Forms.Label();
            this.phoneTo = new System.Windows.Forms.Label();
            this.nameTo = new System.Windows.Forms.Label();
            this.addressFrom = new System.Windows.Forms.Label();
            this.phoneFrom = new System.Windows.Forms.Label();
            this.nameFrom = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.panelDGV.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDetailRight.SuspendLayout();
            this.panelDetailLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelName);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(808, 51);
            this.panelTitle.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(808, 51);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "DANH SÁCH ĐƠN HÀNG";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnPay);
            this.panelBtn.Controls.Add(this.btnCancel);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtn.Location = new System.Drawing.Point(736, 51);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(72, 532);
            this.panelBtn.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = global::HoaYeuThuong.Properties.Resources.pay;
            this.btnPay.Location = new System.Drawing.Point(0, 266);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(72, 266);
            this.btnPay.TabIndex = 23;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::HoaYeuThuong.Properties.Resources.delete;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 266);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.orderDGV);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDGV.Location = new System.Drawing.Point(0, 333);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(718, 187);
            this.panelDGV.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.AutoSize = true;
            this.panelData.BackColor = System.Drawing.Color.Gainsboro;
            this.panelData.Controls.Add(this.panelDetail);
            this.panelData.Controls.Add(this.panelDGV);
            this.panelData.Location = new System.Drawing.Point(12, 51);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(718, 520);
            this.panelData.TabIndex = 2;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.panelDetailRight);
            this.panelDetail.Controls.Add(this.panelDetailLeft);
            this.panelDetail.Controls.Add(this.panel1);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(718, 333);
            this.panelDetail.TabIndex = 2;
            // 
            // orderDGV
            // 
            this.orderDGV.AllowUserToAddRows = false;
            this.orderDGV.AllowUserToDeleteRows = false;
            this.orderDGV.AllowUserToResizeColumns = false;
            this.orderDGV.AllowUserToResizeRows = false;
            this.orderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "Không xác định";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.orderDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDGV.GridColor = System.Drawing.Color.Gainsboro;
            this.orderDGV.Location = new System.Drawing.Point(0, 0);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.ReadOnly = true;
            this.orderDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.orderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDGV.Size = new System.Drawing.Size(718, 187);
            this.orderDGV.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.note);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 31);
            this.panel1.TabIndex = 0;
            // 
            // panelDetailRight
            // 
            this.panelDetailRight.Controls.Add(this.total);
            this.panelDetailRight.Controls.Add(this.voucher);
            this.panelDetailRight.Controls.Add(this.status);
            this.panelDetailRight.Controls.Add(this.deliveryTime);
            this.panelDetailRight.Controls.Add(this.placedTime);
            this.panelDetailRight.Controls.Add(this.extraCost);
            this.panelDetailRight.Controls.Add(this.GTGT);
            this.panelDetailRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetailRight.Location = new System.Drawing.Point(307, 0);
            this.panelDetailRight.Name = "panelDetailRight";
            this.panelDetailRight.Size = new System.Drawing.Size(411, 302);
            this.panelDetailRight.TabIndex = 5;
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(6, 233);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(40, 20);
            this.total.TabIndex = 12;
            this.total.Text = "total";
            // 
            // voucher
            // 
            this.voucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.voucher.AutoSize = true;
            this.voucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher.Location = new System.Drawing.Point(6, 200);
            this.voucher.Name = "voucher";
            this.voucher.Size = new System.Drawing.Size(65, 20);
            this.voucher.TabIndex = 11;
            this.voucher.Text = "voucher";
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(6, 162);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(53, 20);
            this.status.TabIndex = 10;
            this.status.Text = "status";
            // 
            // deliveryTime
            // 
            this.deliveryTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deliveryTime.AutoSize = true;
            this.deliveryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTime.Location = new System.Drawing.Point(6, 124);
            this.deliveryTime.Name = "deliveryTime";
            this.deliveryTime.Size = new System.Drawing.Size(95, 20);
            this.deliveryTime.TabIndex = 9;
            this.deliveryTime.Text = "deliveryTime";
            // 
            // placedTime
            // 
            this.placedTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.placedTime.AutoSize = true;
            this.placedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placedTime.Location = new System.Drawing.Point(6, 86);
            this.placedTime.Name = "placedTime";
            this.placedTime.Size = new System.Drawing.Size(90, 20);
            this.placedTime.TabIndex = 8;
            this.placedTime.Text = "placedTime";
            // 
            // extraCost
            // 
            this.extraCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.extraCost.AutoSize = true;
            this.extraCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraCost.Location = new System.Drawing.Point(6, 48);
            this.extraCost.Name = "extraCost";
            this.extraCost.Size = new System.Drawing.Size(77, 20);
            this.extraCost.TabIndex = 7;
            this.extraCost.Text = "extraCost";
            // 
            // GTGT
            // 
            this.GTGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GTGT.AutoSize = true;
            this.GTGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTGT.Location = new System.Drawing.Point(6, 10);
            this.GTGT.Name = "GTGT";
            this.GTGT.Size = new System.Drawing.Size(53, 20);
            this.GTGT.TabIndex = 6;
            this.GTGT.Text = "GTGT";
            // 
            // panelDetailLeft
            // 
            this.panelDetailLeft.Controls.Add(this.message);
            this.panelDetailLeft.Controls.Add(this.anonymous);
            this.panelDetailLeft.Controls.Add(this.addressTo);
            this.panelDetailLeft.Controls.Add(this.phoneTo);
            this.panelDetailLeft.Controls.Add(this.nameTo);
            this.panelDetailLeft.Controls.Add(this.addressFrom);
            this.panelDetailLeft.Controls.Add(this.phoneFrom);
            this.panelDetailLeft.Controls.Add(this.nameFrom);
            this.panelDetailLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDetailLeft.Location = new System.Drawing.Point(0, 0);
            this.panelDetailLeft.Name = "panelDetailLeft";
            this.panelDetailLeft.Size = new System.Drawing.Size(307, 302);
            this.panelDetailLeft.TabIndex = 4;
            // 
            // message
            // 
            this.message.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(0, 263);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(74, 20);
            this.message.TabIndex = 15;
            this.message.Text = "message";
            // 
            // anonymous
            // 
            this.anonymous.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.anonymous.AutoSize = true;
            this.anonymous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anonymous.Location = new System.Drawing.Point(0, 233);
            this.anonymous.Name = "anonymous";
            this.anonymous.Size = new System.Drawing.Size(91, 20);
            this.anonymous.TabIndex = 14;
            this.anonymous.Text = "anonymous";
            // 
            // addressTo
            // 
            this.addressTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressTo.AutoSize = true;
            this.addressTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTo.Location = new System.Drawing.Point(0, 200);
            this.addressTo.Name = "addressTo";
            this.addressTo.Size = new System.Drawing.Size(84, 20);
            this.addressTo.TabIndex = 5;
            this.addressTo.Text = "addressTo";
            // 
            // phoneTo
            // 
            this.phoneTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneTo.AutoSize = true;
            this.phoneTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTo.Location = new System.Drawing.Point(0, 162);
            this.phoneTo.Name = "phoneTo";
            this.phoneTo.Size = new System.Drawing.Size(72, 20);
            this.phoneTo.TabIndex = 4;
            this.phoneTo.Text = "phoneTo";
            // 
            // nameTo
            // 
            this.nameTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTo.AutoSize = true;
            this.nameTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTo.Location = new System.Drawing.Point(0, 124);
            this.nameTo.Name = "nameTo";
            this.nameTo.Size = new System.Drawing.Size(67, 20);
            this.nameTo.TabIndex = 3;
            this.nameTo.Text = "nameTo";
            // 
            // addressFrom
            // 
            this.addressFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressFrom.AutoSize = true;
            this.addressFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressFrom.Location = new System.Drawing.Point(0, 86);
            this.addressFrom.Name = "addressFrom";
            this.addressFrom.Size = new System.Drawing.Size(103, 20);
            this.addressFrom.TabIndex = 2;
            this.addressFrom.Text = "addressFrom";
            // 
            // phoneFrom
            // 
            this.phoneFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneFrom.AutoSize = true;
            this.phoneFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneFrom.Location = new System.Drawing.Point(0, 48);
            this.phoneFrom.Name = "phoneFrom";
            this.phoneFrom.Size = new System.Drawing.Size(91, 20);
            this.phoneFrom.TabIndex = 1;
            this.phoneFrom.Text = "phoneFrom";
            // 
            // nameFrom
            // 
            this.nameFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameFrom.AutoSize = true;
            this.nameFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFrom.Location = new System.Drawing.Point(0, 10);
            this.nameFrom.Name = "nameFrom";
            this.nameFrom.Size = new System.Drawing.Size(86, 20);
            this.nameFrom.TabIndex = 0;
            this.nameFrom.Text = "nameFrom";
            // 
            // note
            // 
            this.note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ForeColor = System.Drawing.Color.Red;
            this.note.Location = new System.Drawing.Point(0, 0);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(718, 31);
            this.note.TabIndex = 14;
            this.note.Text = "note";
            this.note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 583);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.Load += new System.EventHandler(this.CustomerOrderForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelBtn.ResumeLayout(false);
            this.panelDGV.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelDetailRight.ResumeLayout(false);
            this.panelDetailRight.PerformLayout();
            this.panelDetailLeft.ResumeLayout(false);
            this.panelDetailLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DataGridView orderDGV;
        private System.Windows.Forms.Panel panelDetailRight;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label voucher;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label deliveryTime;
        private System.Windows.Forms.Label placedTime;
        private System.Windows.Forms.Label extraCost;
        private System.Windows.Forms.Label GTGT;
        private System.Windows.Forms.Panel panelDetailLeft;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label anonymous;
        private System.Windows.Forms.Label addressTo;
        private System.Windows.Forms.Label phoneTo;
        private System.Windows.Forms.Label nameTo;
        private System.Windows.Forms.Label addressFrom;
        private System.Windows.Forms.Label phoneFrom;
        private System.Windows.Forms.Label nameFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label note;
    }
}