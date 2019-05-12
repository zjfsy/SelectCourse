using System;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogDelStu : Form
    {
        public DialogDelStu()
        {
            InitializeComponent();
        }
        private void BtnDelClick(object sender, EventArgs e)
        {
            if (idtb.Text == string.Empty)
            {
                MessageBox.Show("请输入学生学号！");
                return;
            }
            string cmd = $"delete from students where sid='{idtb.Text}';";
            DBO.Delete(cmd);
            MessageBox.Show("删除成功！");
        }
        private void BtnCnlClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
