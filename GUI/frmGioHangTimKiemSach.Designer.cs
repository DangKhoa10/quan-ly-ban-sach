
namespace QuanLyMuaBanSach.GUI
{
    partial class frmGioHangTimKiemSach
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnMuaSach = new System.Windows.Forms.Button();
            this.btnDatSach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwDSSach = new System.Windows.Forms.ListView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Aqua;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(910, 61);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Giỏ Hàng";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMuaSach
            // 
            this.btnMuaSach.BackColor = System.Drawing.Color.Aqua;
            this.btnMuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaSach.Location = new System.Drawing.Point(221, 409);
            this.btnMuaSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuaSach.Name = "btnMuaSach";
            this.btnMuaSach.Size = new System.Drawing.Size(220, 58);
            this.btnMuaSach.TabIndex = 9;
            this.btnMuaSach.Text = "Mua Sách";
            this.btnMuaSach.UseVisualStyleBackColor = false;
            this.btnMuaSach.Click += new System.EventHandler(this.btnMuaSach_Click);
            // 
            // btnDatSach
            // 
            this.btnDatSach.BackColor = System.Drawing.Color.Aqua;
            this.btnDatSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatSach.Location = new System.Drawing.Point(449, 409);
            this.btnDatSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatSach.Name = "btnDatSach";
            this.btnDatSach.Size = new System.Drawing.Size(220, 58);
            this.btnDatSach.TabIndex = 10;
            this.btnDatSach.Text = "Đặt Sách";
            this.btnDatSach.UseVisualStyleBackColor = false;
            this.btnDatSach.Click += new System.EventHandler(this.btnDatSach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thông tin giỏ hàng";
            // 
            // lvwDSSach
            // 
            this.lvwDSSach.HideSelection = false;
            this.lvwDSSach.Location = new System.Drawing.Point(4, 111);
            this.lvwDSSach.Name = "lvwDSSach";
            this.lvwDSSach.Size = new System.Drawing.Size(906, 281);
            this.lvwDSSach.TabIndex = 12;
            this.lvwDSSach.UseCompatibleStateImageBehavior = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Aqua;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(677, 409);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 58);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Thoát";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Aqua;
            this.btnXoa.Location = new System.Drawing.Point(767, 67);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 38);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmGioHangTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(910, 480);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lvwDSSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDatSach);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMuaSach);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGioHangTimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGioHangTimKiemSach_FormClosing);
            this.Load += new System.EventHandler(this.frmGioHangTimKiemSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnMuaSach;
        private System.Windows.Forms.Button btnDatSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwDSSach;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
    }
}