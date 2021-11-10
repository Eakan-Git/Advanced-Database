
namespace PA1
{
    partial class Form1
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
            System.Windows.Forms.Panel panelMenu;
            this.panel1 = new System.Windows.Forms.Panel();
            this.informationBox = new System.Windows.Forms.TextBox();
            this.statisticViewButton = new System.Windows.Forms.Button();
            this.listViewButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            panelMenu = new System.Windows.Forms.Panel();
            panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            panelMenu.Controls.Add(this.panel1);
            panelMenu.Controls.Add(this.statisticViewButton);
            panelMenu.Controls.Add(this.listViewButton);
            panelMenu.Controls.Add(this.addButton);
            panelMenu.Controls.Add(this.panelLogo);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(220, 491);
            panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.informationBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 72);
            this.panel1.TabIndex = 4;
            // 
            // informationBox
            // 
            this.informationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.informationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationBox.Enabled = false;
            this.informationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.informationBox.Location = new System.Drawing.Point(0, 0);
            this.informationBox.Multiline = true;
            this.informationBox.Name = "informationBox";
            this.informationBox.ReadOnly = true;
            this.informationBox.Size = new System.Drawing.Size(220, 72);
            this.informationBox.TabIndex = 0;
            this.informationBox.TabStop = false;
            this.informationBox.Text = "Cơ sơ dữ liệu nâng cao\r\n\r\nNhóm 9";
            this.informationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.informationBox.WordWrap = false;
            this.informationBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // statisticViewButton
            // 
            this.statisticViewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticViewButton.FlatAppearance.BorderSize = 0;
            this.statisticViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(38)))), ((int)(((byte)(145)))));
            this.statisticViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticViewButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.statisticViewButton.Image = global::PA1.Properties.Resources.chart;
            this.statisticViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticViewButton.Location = new System.Drawing.Point(0, 316);
            this.statisticViewButton.Name = "statisticViewButton";
            this.statisticViewButton.Size = new System.Drawing.Size(220, 97);
            this.statisticViewButton.TabIndex = 3;
            this.statisticViewButton.Text = "Thống Kê";
            this.statisticViewButton.UseVisualStyleBackColor = true;
            this.statisticViewButton.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // listViewButton
            // 
            this.listViewButton.AccessibleName = "listViewButton";
            this.listViewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewButton.FlatAppearance.BorderSize = 0;
            this.listViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(38)))), ((int)(((byte)(145)))));
            this.listViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.listViewButton.Image = global::PA1.Properties.Resources.list;
            this.listViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listViewButton.Location = new System.Drawing.Point(0, 219);
            this.listViewButton.Name = "listViewButton";
            this.listViewButton.Size = new System.Drawing.Size(220, 97);
            this.listViewButton.TabIndex = 2;
            this.listViewButton.Text = "Danh Sách";
            this.listViewButton.UseVisualStyleBackColor = true;
            this.listViewButton.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(38)))), ((int)(((byte)(145)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addButton.Image = global::PA1.Properties.Resources.add_21;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(0, 122);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(220, 97);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BackgroundImage = global::PA1.Properties.Resources.logo_3;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelLogo.Size = new System.Drawing.Size(220, 122);
            this.panelLogo.TabIndex = 0;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.childFormPanel.Location = new System.Drawing.Point(220, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(675, 491);
            this.childFormPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(895, 491);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(panelMenu);
            this.MaximumSize = new System.Drawing.Size(911, 530);
            this.MinimumSize = new System.Drawing.Size(911, 530);
            this.Name = "Form1";
            this.Text = "ADB2_9 PA1";
            this.Load += new System.EventHandler(this.Form1_Load);
            panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button statisticViewButton;
        private System.Windows.Forms.Button listViewButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TextBox informationBox;
        private System.Windows.Forms.Panel childFormPanel;
    }
}

