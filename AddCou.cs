using System;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogAddCou : Form
    {
        public DialogAddCou()
        {
            InitializeComponent();
        }
        private void BtnAddClick(object sender, EventArgs e)
        {
            foreach(Control c in gbox.Controls)
            {
                if(c is TextBox && c != inf6 && c.Text == string.Empty)
                {
                    MessageBox.Show("请输入课程的完整信息！");
                    return;
                }
            }
            string cmd = $"insert into courses(cid,cname,tname,credit,grade,cyear) values('{inf1.Text}','{inf2.Text}','{inf3.Text}',{inf4.Text},{inf5.Text},{(inf6.Text == string.Empty ? "null" : inf6.Text)});";
            DBO.Insert(cmd);
            MessageBox.Show("插入成功！");
        }
        private void BtnClrClick(object sender, EventArgs e)
        {
            inf1.Text = string.Empty;
            inf2.Text = string.Empty;
            inf3.Text = string.Empty;
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
