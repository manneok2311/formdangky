using System.Text.RegularExpressions;

namespace Form_Đăng_Ký_Tài_Khoản
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu phải tối thiểu 8 ký tự và chứa ít nhất 1 ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;

            string specialCharPattern = @"[!@#$%^&*(),.?\:{ }|<>]";
            return Regex.IsMatch(password, specialCharPattern);
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
