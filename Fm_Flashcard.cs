using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ungdunghoctumoi
{
    public partial class Fm_Flagcard : Form
    {
        public Fm_Flagcard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var uc = new UserCDongVat() {Dock = Dock = DockStyle.Fill, };
            panel2.Controls.Add(uc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var uc = new UcTraiCay() { Dock = Dock = DockStyle.Fill, };
            panel2.Controls.Add(uc);
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var uc = new UcMauSac() { Dock = Dock =DockStyle.Fill, };
            panel2.Controls.Add(uc);
        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var uc = new UcNN() { Dock = Dock = DockStyle.Fill, };
            panel2.Controls.Add(uc);
        }

        private void btnCacNuoc_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var uc = new UcCacNuoc() { Dock = Dock = DockStyle.Fill, };
            panel2.Controls.Add(uc);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnNoiThat_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var uc = new UcNoiThat() { Dock = Dock = DockStyle.Fill, };
            panel2.Controls.Add(uc);
        }

        private void btnPTGT_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var uc = new UcPTGT() { Dock = Dock = DockStyle.Fill, };
            panel2.Controls.Add(uc);
        }

        private void Fm_Flagcard_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
