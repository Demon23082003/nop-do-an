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
using System.Runtime.Serialization.Formatters.Binary;

namespace ungdunghoctumoi
{
    public partial class fm_DKTK : Form
    {
        private User user;
        private List<User> dsUser = new List<User>();
        private string tenFileText = "DuLieuUser.txt";
        public fm_DKTK()
        {
            InitializeComponent();
        }

        private void lblChose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ktr nhap lai mat khau 
        private void ValidatePassword()
        {
            // Lấy giá trị từ TextBox mật khẩu và nhập lại mật khẩu
            string password = txtDangKyMK.Text;
            string confirmPassword = txtDangNhapLaiMK.Text;

            // Kiểm tra xem mật khẩu và nhập lại mật khẩu có khớp nhau không
            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))

            {
                if (password != confirmPassword)
                {

                    MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Xóa nội dung của ô nhập lại mật khẩu

                    txtDangNhapLaiMK.Clear();

                }
            }
        }
        private void btnDkTaiKhoan_Click(object sender, EventArgs e)
        {
            // Kiem tra dang Ky 
            if (string.IsNullOrEmpty(txtDkEmail.Text) ||
                string.IsNullOrEmpty(txtDangKyMK.Text) ||
                string.IsNullOrEmpty(txtDangNhapLaiMK.Text))
            {
                MessageBox.Show("Vui Lòng Đầy Đủ Thông Tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Ham Ghi File
            User user = new User();
            user.Email = txtDkEmail.Text;
            user.Password = txtDangKyMK.Text;
            dsUser.Add(user);
            StreamWriter swt = new StreamWriter(tenFileText, true, Encoding.UTF8);
            foreach (User us in dsUser)
            {
                string Cot = us.Email + ":" + us.Password + "\n";
                swt.WriteLine(Cot);
            }
            swt.Close();
            MessageBox.Show("Đã Ghi Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        // ham doc file 
        private void fm_DKTK_Load(object sender, EventArgs e)
        {
            user = new User();
          
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Fm_Login f = new Fm_Login();
            f.Show();
            this.Hide();
        }

        private void txtDangNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private void txtDangKyMK_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }
    }
}
