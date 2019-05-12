using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogUpdStu : Form
    {
        public DialogUpdStu()
        {
            InitializeComponent();
        }
        private void Chk1Changed(object sender, EventArgs e)
        {
            inf1.Enabled = chk1.Checked;
        }
        private void Chk2Changed(object sender, EventArgs e)
        {
            inf2.Enabled = chk2.Checked;
        }
        private void Chk3Changed(object sender, EventArgs e)
        {
            inf3.Enabled = chk3.Checked;
        }
        private void Chk4Changed(object sender, EventArgs e)
        {
            inf4.Enabled = chk4.Checked;
        }
        private void Chk5Changed(object sender, EventArgs e)
        {
            inf5.Enabled = chk5.Checked;
        }
        private void BtnSrhClick(object sender, EventArgs e)
        {
            if (inf0.Text == string.Empty)
            {
                MessageBox.Show("请输入学生学号！");
                return;
            }
            string cmd = $"select sname,gender,enage,grade,class from students where sid='{inf0.Text}';";
            Dictionary<string, string> dic = DBO.Search(cmd);
            foreach(KeyValuePair<string, string> kv in dic)
            {
                switch (kv.Key)
                {
                    case "sname":
                        inf1.Text = kv.Value;
                        break;
                    case "gender":
                        inf2.SelectedIndex = kv.Value == "女" ? 1 : 0;
                        break;
                    case "enage":
                        inf3.Text = kv.Value;
                        break;
                    case "grade":
                        inf4.Text = kv.Value;
                        break;
                    case "class":
                        inf5.Text = kv.Value;
                        break;
                }
            }
        }
        private void BtnUpdClick(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (inf0.Text == string.Empty)
            {
                MessageBox.Show("请输入学生学号！");
                return;
            }
            if (inf1.Enabled)
            {
                if (inf1.Text == string.Empty)
                {
                    MessageBox.Show("请输入学生的完整信息！");
                    return;
                }
                list.Add($"sname='{inf1.Text}'");
            }
            if (inf2.Enabled)
            {
                if (inf2.Text == string.Empty)
                {
                    MessageBox.Show("请输入学生的完整信息！");
                    return;
                }
                list.Add($"gender='{inf2.SelectedItem}'");
            }
            if (inf3.Enabled)
            {
                if (inf3.Text == string.Empty)
                {
                    MessageBox.Show("请输入学生的完整信息！");
                    return;
                }
                if (!int.TryParse(inf3.Text, out int age) || age < 10 || age > 50)
                {
                    MessageBox.Show("学生年龄无效，请重新输入！");
                    inf3.Text = string.Empty;
                    return;
                }
                list.Add($"enage={inf3.Text}");
            }
            if (inf4.Enabled)
            {
                if (inf4.Text == string.Empty)
                {
                    MessageBox.Show("请输入学生的完整信息！");
                    return;
                }
                list.Add($"grade={inf4.Text}");
            }
            if (inf5.Enabled)
            {
                if (inf5.Text == string.Empty)
                {
                    MessageBox.Show("请输入学生的完整信息！");
                    return;
                }
                list.Add($"class='{inf5.Text}'");
            }
            if (list.Count > 0)
            {
                string cmd = $"update students set {string.Join(",", list.ToArray())} where sid='{inf0.Text}';";
                DBO.Update(cmd);
                MessageBox.Show("修改成功");
            }
        }
        private void BtnCnlClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
