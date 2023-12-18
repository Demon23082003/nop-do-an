namespace ungdunghoctumoi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnXuLy = new System.Windows.Forms.Button();
            this.lbldiem = new System.Windows.Forms.Label();
            this.btnXemdapan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXuLy
            // 
            this.btnXuLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.Location = new System.Drawing.Point(204, 506);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(136, 47);
            this.btnXuLy.TabIndex = 0;
            this.btnXuLy.Text = "Kiểm tra";
            this.btnXuLy.UseVisualStyleBackColor = false;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click_1);
            // 
            // lbldiem
            // 
            this.lbldiem.AutoSize = true;
            this.lbldiem.BackColor = System.Drawing.Color.White;
            this.lbldiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiem.Location = new System.Drawing.Point(416, 517);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(178, 25);
            this.lbldiem.TabIndex = 1;
            this.lbldiem.Text = "Điểm của bạn là:....";
            this.lbldiem.Click += new System.EventHandler(this.lbldiem_Click);
            // 
            // btnXemdapan
            // 
            this.btnXemdapan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXemdapan.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemdapan.Location = new System.Drawing.Point(648, 81);
            this.btnXemdapan.Name = "btnXemdapan";
            this.btnXemdapan.Size = new System.Drawing.Size(69, 139);
            this.btnXemdapan.TabIndex = 2;
            this.btnXemdapan.Text = "Xem đáp án";
            this.btnXemdapan.UseVisualStyleBackColor = false;
            this.btnXemdapan.Click += new System.EventHandler(this.btnXemdapan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(12, 509);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 42);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ungdunghoctumoi.Properties.Resources.giai_dap_thac_mac_ve_qua_tang_doanh_nghiep;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 578);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemdapan);
            this.Controls.Add(this.lbldiem);
            this.Controls.Add(this.btnXuLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Label lbldiem;
        private System.Windows.Forms.Button btnXemdapan;
        private System.Windows.Forms.Button btnThoat;
    }
}