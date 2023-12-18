using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ungdunghoctumoi
{
    public partial class Form1 : Form
    {
        HieuUng hieuung = new HieuUng();
        List<Label> lblTiengAnh = new List<Label>();//trên panel 1
        List<Label> lblTiengViet = new List<Label>();//trên panel 1
        Timer timer1 = new Timer();
        int phut = 0, giay = 0, tongthoigian;
        public Form1()
        {
            InitializeComponent();
            hieuung.LoadNewWord();
            timer1.Tick += Timer1_Tick;

        }
        Label TaoLabel(int x, int y, string text, string name)// tạo 1 label
        {
            Label lable = new Label();
            lable.AutoSize = true;
            lable.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lable.Location = new System.Drawing.Point(x, y);
            lable.Size = new System.Drawing.Size(218, 27);
            lable.Name = name;
            lable.Text = text;
            return lable;
        }
        void TaoLabelTiengViet()//tạo label nghĩa tiếng việt
        {

            int x = 200, y = 160;
            for (int i = 0; i < hieuung.SoLuongTuMoi; i++)
            {
                Label xxx = TaoLabel(x, y, hieuung.taketv(i), "lbltv" + i.ToString());
                lblTiengViet.Add(xxx);
                y += 20;
            }
        }
        void TaoLabelTiengAnh()//tạo label nghĩa tiếng anh
        {
            int x = 100, y = 160;
            for (int i = 0; i < hieuung.SoLuongTuMoi; i++)
            {
                Label label = TaoLabel(x, y, hieuung.taketa(i), "lblta" + i.ToString());
                lblTiengAnh.Add(label);
                y += 20;
            }
        }
        void Add()// add các label lên 
        {
            for (int i = 0; i < hieuung.SoLuongTuMoi; i++)
            {
                groupBox1.Controls.Add(lblTiengViet[i]);
                groupBox1.Controls.Add(lblTiengAnh[i]);
            }
        }    

        //control sử dụng
        private void btnStart_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtSoLuongTu.Text);
            if (x > 9 || x < 4)
            {
                MessageBox.Show("Nhập sai quy định!!!", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongTu.Focus();
            }
            else
            {
                hieuung.SoLuongTuMoi = x;
                hieuung.TakeRandomNewWord();
                TaoLabelTiengAnh();
                TaoLabelTiengViet();
                Add();
                gantumoi();
                tongthoigian = x * 35;
                timer1.Enabled = true;
            }
        }
        private void txtSoLuongTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
        // so luong them tu vung 
        private void btnCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtSoLuongTu.Text);
            if (x > 8)
            {
                MessageBox.Show("Không khuyến khích học nhiều nhé!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                x++;
                txtSoLuongTu.Text = x.ToString();
            }
        }
        // so luong giam tu vung 
        private void btnTru_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtSoLuongTu.Text);
            if (x < 5)
            {
                MessageBox.Show("Học ít thế, thêm đi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                x--;
                txtSoLuongTu.Text = x.ToString();
            }
        }
        List<string> tumoita = new List<string>();
        List<string> tumoitv = new List<string>();
        void gantumoi()
        {
            for(int i=0;i<hieuung.SoLuongTuMoi;i++)
            {
                tumoita.Add(hieuung.taketa(i));
                tumoitv.Add(hieuung.taketv(i));

            }
        }
        public delegate void NhanDuLieu(HieuUng x);

        private void btnThem_Click(object sender, EventArgs e)
        {
            hieuung.ThemTu(txtthemtuta.Text, txtthemtutv.Text);
            txtthemtutv.Clear();
            txtthemtuta.Clear();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void themTuVungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //From FlagCard
        private void flagCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fm_Flagcard f = new Fm_Flagcard();
            f.Show();
            this.Hide();
        }

        private void lblgiay_Click(object sender, EventArgs e)
        {

        }

        public NhanDuLieu Sender;
        // thoi gian de chay de nguoi hc va mo thoi gian mo form moi 
        private void Timer1_Tick(object sender, EventArgs e)
        {
            {
                if (tongthoigian == phut * 60 + giay) //mở sang form kiểm tra
                {
                    timer1.Enabled = false;
                    Form2 f2 = new Form2();
                    NhanDuLieu nhandulieu = new NhanDuLieu(f2.GetData);
                    nhandulieu(hieuung);
                    this.Hide();
                    f2.ShowDialog();
       
                }
                else
                {
                    giay++;
                    if (giay == 60)
                    {
                        phut += 1;
                        giay = 0;
                        if (phut < 10)
                            lblphut.Text = "0" + phut.ToString();
                        else
                            lblphut.Text = phut.ToString();
                        lblgiay.Text = ": " + giay.ToString();
                    }
                    else
                    {
                        if (giay < 10)
                            lblgiay.Text = ": 0" + giay.ToString();
                        else
                            lblgiay.Text = ": " + giay.ToString();
                    }
                }
            }
        }
    }
}
    

