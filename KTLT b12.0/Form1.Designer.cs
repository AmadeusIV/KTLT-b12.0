namespace KTLT_b12._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.listBoxDanSachSanPham = new System.Windows.Forms.ListBox();
            this.buttonDatHang = new System.Windows.Forms.Button();
            this.listBoxTTDH = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form dat hang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khach hang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dien thoai";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(429, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sach san pham";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(178, 92);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(216, 22);
            this.txtBox1.TabIndex = 4;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(178, 130);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(216, 22);
            this.txtBox2.TabIndex = 5;
            // 
            // listBoxDanSachSanPham
            // 
            this.listBoxDanSachSanPham.FormattingEnabled = true;
            this.listBoxDanSachSanPham.ItemHeight = 16;
            this.listBoxDanSachSanPham.Items.AddRange(new object[] {
            "San Pham A",
            "San Pham B",
            "San Pham C",
            "San Pham D"});
            this.listBoxDanSachSanPham.Location = new System.Drawing.Point(433, 130);
            this.listBoxDanSachSanPham.Name = "listBoxDanSachSanPham";
            this.listBoxDanSachSanPham.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDanSachSanPham.Size = new System.Drawing.Size(355, 292);
            this.listBoxDanSachSanPham.TabIndex = 6;
            this.listBoxDanSachSanPham.SelectedIndexChanged += new System.EventHandler(this.listBoxDanhSach_SelectedIndexChanged);
            // 
            // buttonDatHang
            // 
            this.buttonDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatHang.Location = new System.Drawing.Point(47, 193);
            this.buttonDatHang.Name = "buttonDatHang";
            this.buttonDatHang.Size = new System.Drawing.Size(121, 28);
            this.buttonDatHang.TabIndex = 7;
            this.buttonDatHang.Text = "Dat hang";
            this.buttonDatHang.UseVisualStyleBackColor = true;
            this.buttonDatHang.Click += new System.EventHandler(this.buttonDatHang_Click);
            // 
            // listBoxTTDH
            // 
            this.listBoxTTDH.FormattingEnabled = true;
            this.listBoxTTDH.ItemHeight = 16;
            this.listBoxTTDH.Location = new System.Drawing.Point(47, 274);
            this.listBoxTTDH.Name = "listBoxTTDH";
            this.listBoxTTDH.Size = new System.Drawing.Size(333, 148);
            this.listBoxTTDH.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(42, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thong tin dat hang";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxTTDH);
            this.Controls.Add(this.buttonDatHang);
            this.Controls.Add(this.listBoxDanSachSanPham);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.ListBox listBoxDanSachSanPham;
        private System.Windows.Forms.Button buttonDatHang;
        private System.Windows.Forms.ListBox listBoxTTDH;
        private System.Windows.Forms.Label label5;
    }
}

