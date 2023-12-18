using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ungdunghoctumoi
{
    public partial class Fm_Login : Form
    {
        private User user;
        //private DanhSachCuaUser dsUser;
        private List<User> dsUser = new List<User>();
        private string tenFileText = "DuLieuUser.txt";
        public Fm_Login()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            //if (CheckCredentials(txtNhapEmail.Text, txtNhapMatKhau.Text))
            //{
            //    MessageBox.Show("Đăng nhập thành công!");

            //    //FormLearn a = new FormLearn();
            //    Form1 a = new Form1();
            //    a.ShowDialog();
            //    // an form 1

            //}
            //else
            //{
            //    MessageBox.Show("Sai Thong Tin Dang nhap");
            //}
            //this.Hide();
            fm_DKTK f = new fm_DKTK();      
            f.Show();
            this.Hide();

        }
        private bool CheckCredentials(string username, string password)
        {
            string filePath = "DuLieuUser.txt";

            // Kiểm tra xem tệp tồn tại
            if (File.Exists(filePath))
            {
                // Đọc dòng từ tệp và kiểm tra thông tin đăng nhập
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string storedUsername = parts[0];
                        string storedPassword = parts[1];

                        // So sánh thông tin đăng nhập
                        if (username == storedUsername && password == storedPassword)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {

            if (CheckCredentials(txtNhapEmail.Text, txtNhapMatKhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công!");

                //FormLearn a = new FormLearn();
                Form1 a = new Form1();
                a.Show();
                this.Hide();
                // an form 1 

            }
            else
            {
                MessageBox.Show("Sai Thong Tin Dang nhap");
            }
            txtNhapMatKhau.Focus();
        }

      
    }
}
