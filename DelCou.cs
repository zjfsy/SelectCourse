using System;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogDelCou : Form
    {
        public DialogDelCou()
        {
            InitializeComponent();
        }
        private void BtnDelClick(object sender, EventArgs e)
        {
            if (idtb.Text == string.Empty)
            {
                MessageBox.Show("请输入课程编号！");
                return;
            }
            string cmd = $"delete from courses where cid='{idtb.Text}';";
            DBO.Delete(cmd);
            MessageBox.Show("删除成功！");
        }
        private void BtnCnlClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
