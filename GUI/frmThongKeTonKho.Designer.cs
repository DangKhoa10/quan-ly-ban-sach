
namespace QuanLyMuaBanSach.GUI
{
    partial class frmThongKeTonKho
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
            this.lblThongKeSachDaBan = new System.Windows.Forms.Label();
            this.dgvDSSPTonKho = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdoTatCa = new System.Windows.Forms.RadioButton();
            this.rdoGanHet = new System.Windows.Forms.RadioButton();
            this.rdoDaHet = new System.Windows.Forms.RadioButton();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSPTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongKeSachDaBan
            // 
            this.lblThongKeSachDaBan.BackColor = System.Drawing.Color.Aqua;
            this.lblThongKeSachDaBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongKeSachDaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeSachDaBan.ForeColor = System.Drawing.Color.Red;
            this.lblThongKeSachDaBan.Location = new System.Drawing.Point(0, 0);
            this.lblThongKeSachDaBan.Name = "lblThongKeSachDaBan";
            this.lblThongKeSachDaBan.Size = new System.Drawing.Size(1315, 37);
            this.lblThongKeSachDaBan.TabIndex = 18;
            this.lblThongKeSachDaBan.Text = "Thống Kê Sách Tồn Kho";
            this.lblThongKeSachDaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSSPTonKho
            // 
            this.dgvDSSPTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSPTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSPTonKho.Location = new System.Drawing.Point(127, 142);
            this.dgvDSSPTonKho.Name = "dgvDSSPTonKho";
            this.dgvDSSPTonKho.Size = new System.Drawing.Size(1099, 411);
            this.dgvDSSPTonKho.TabIndex = 19;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Aqua;
            this.btnThongKe.Location = new System.Drawing.Point(1070, 70);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(156, 47);
            this.btnThongKe.TabIndex = 43;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(1070, 559);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 52);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdoTatCa
            // 
            this.rdoTatCa.AutoSize = true;
            this.rdoTatCa.Location = new System.Drawing.Point(591, 79);
            this.rdoTatCa.Name = "rdoTatCa";
            this.rdoTatCa.Size = new System.Drawing.Size(67, 22);
            this.rdoTatCa.TabIndex = 45;
            this.rdoTatCa.TabStop = true;
            this.rdoTatCa.Text = "Tất cả";
            this.rdoTatCa.UseVisualStyleBackColor = true;
            this.rdoTatCa.CheckedChanged += new System.EventHandler(this.rdoTatCa_CheckedChanged);
            // 
            // rdoGanHet
            // 
            this.rdoGanHet.AutoSize = true;
            this.rdoGanHet.Location = new System.Drawing.Point(758, 79);
            this.rdoGanHet.Name = "rdoGanHet";
            this.rdoGanHet.Size = new System.Drawing.Size(78, 22);
            this.rdoGanHet.TabIndex = 45;
            this.rdoGanHet.TabStop = true;
            this.rdoGanHet.Text = "Gần hết";
            this.rdoGanHet.UseVisualStyleBackColor = true;
            this.rdoGanHet.CheckedChanged += new System.EventHandler(this.rdoGanHet_CheckedChanged);
            // 
            // rdoDaHet
            // 
            this.rdoDaHet.AutoSize = true;
            this.rdoDaHet.Location = new System.Drawing.Point(925, 79);
            this.rdoDaHet.Name = "rdoDaHet";
            this.rdoDaHet.Size = new System.Drawing.Size(69, 22);
            this.rdoDaHet.TabIndex = 45;
            this.rdoDaHet.TabStop = true;
            this.rdoDaHet.Text = "Đã hết";
            this.rdoDaHet.UseVisualStyleBackColor = true;
            this.rdoDaHet.CheckedChanged += new System.EventHandler(this.rdoDaHet_CheckedChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(793, 107);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 24);
            this.txtSoLuong.TabIndex = 46;
            this.txtSoLuong.Text = "10";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(680, 110);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(107, 18);
            this.lblSL.TabIndex = 47;
            this.lblSL.Text = "Số lượng ít hơn";
            // 
            // frmThongKeTonKho
            // 
            this.AcceptButton = this.btnThongKe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1315, 623);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.rdoDaHet);
            this.Controls.Add(this.rdoGanHet);
            this.Controls.Add(this.rdoTatCa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dgvDSSPTonKho);
            this.Controls.Add(this.lblThongKeSachDaBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKeTonKho";
            this.Text = "Thống kê sách tồn kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKeTonKho_FormClosing);
            this.Load += new System.EventHandler(this.frmThongKeTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSPTonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongKeSachDaBan;
        private System.Windows.Forms.DataGridView dgvDSSPTonKho;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdoTatCa;
        private System.Windows.Forms.RadioButton rdoGanHet;
        private System.Windows.Forms.RadioButton rdoDaHet;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSL;
    }
}