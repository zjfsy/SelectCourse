using System;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogAddStu : Form
    {
        public DialogAddStu()
        {
            InitializeComponent();
        }
        private void BtnAddClick(object sender, EventArgs e)
        {
            foreach (Control c in gbox.Controls)
            {
                if (c is TextBox && c.Text == string.Empty)
                {
                    MessageBox.Show("请输入学生的完整信息！");
                    return;
                }
                if (c == inf3 && ((ComboBox)c).SelectedIndex == -1)
                {
                    MessageBox.Show("请输入学生的完整信息！");
                    return;
                }
                if (c == inf4 && (!int.TryParse(c.Text, out int age) || age < 10 || age > 50))
                {
                    MessageBox.Show("学生年龄无效，请重新输入！");
                    c.Text = string.Empty;
                    return;
                }
            }
            string cmd = $"insert into students(sid,sname,gender,enage,grade,class) values('{inf1.Text}','{inf2.Text}','{inf3.SelectedItem}',{inf4.Text},{inf5.Text},'{inf6.Text}');";
            DBO.Insert(cmd);
            MessageBox.Show("插入成功！");
        }
        private void BtnClrClick(object sender, EventArgs e)
        {
            inf1.Text = string.Empty;
            inf2.Text = string.Empty;
            inf3.SelectedIndex = -1;
            inf4.Text = string.Empty;
            inf5.Text = string.Empty;
            inf6.Text = string.Empty;
        }
        private void BtnCnlClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
