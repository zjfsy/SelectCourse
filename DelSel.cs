using System;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogDelSel : Form
    {
        public DialogDelSel()
        {
            InitializeComponent();
        }

        private void BtnDelClick(object sender, EventArgs e)
        {
            if (tbxs.Text == string.Empty)
            {
                MessageBox.Show("请输入学生学号！");
                return;
            }
            if (tbxc.Text == string.Empty)
            {
                MessageBox.Show("请输入课程编号！");
                return;
            }
            string cmd = $"delete from register where sid='{tbxs.Text}' and cid='{tbxc.Text}';";
            DBO.Delete(cmd);
            MessageBox.Show("删除成功");
        }
        private void BtnCnlClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
