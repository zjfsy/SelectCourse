using System;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogSign : Form
    {
        public DialogSign(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }
        private void OKClicked(object sender, EventArgs e)
        {
            if (untext.Text == username && pwtext.Text == password)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请输入正确的用户名和密码！");
            }
        }
        private void CLClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private string username;
        private string password;
    }
}
