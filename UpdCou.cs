using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogUpdCou : Form
    {
        public DialogUpdCou()
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
                MessageBox.Show("请输入课程编号！");
                return;
            }
            string cmd = $"select cname,tname,credit,grade,cyear from courses where cid='{inf0.Text}';";
            Dictionary<string, string> dic = DBO.Search(cmd);
            foreach (KeyValuePair<string, string> kv in dic)
            {
                switch (kv.Key)
                {
                    case "cname":
                        inf1.Text = kv.Value;
                        break;
                    case "tname":
                        inf2.Text = kv.Value;
                        break;
                    case "credit":
                        inf3.Text = kv.Value;
                        break;
                    case "grade":
                        inf4.Text = kv.Value;
                        break;
                    case "cyear":
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
                MessageBox.Show("请输入课程编号！");
                return;
            }
            if (inf1.Enabled)
            {
                if (inf1.Text == string.Empty)
                {
                    MessageBox.Show("请输入课程的完整信息！");
                    return;
                }
                list.Add($"cname='{inf1.Text}'");
            }
            if (inf2.Enabled)
            {
                if (inf2.Text == string.Empty)
                {
                    MessageBox.Show("请输入课程的完整信息！");
                    return;
                }
                list.Add($"tname='{inf2.Text}'");
            }
            if (inf3.Enabled)
            {
                if (inf3.Text == string.Empty)
                {
                    MessageBox.Show("请输入课程的完整信息！");
                    return;
                }
                list.Add($"credit={inf3.Text}");
            }
            if (inf4.Enabled)
            {
                if (inf4.Text == string.Empty)
                {
                    MessageBox.Show("请输入课程的完整信息！");
                    return;
                }
                list.Add($"grade={inf4.Text}");
            }
            if (inf5.Enabled)
            {
                list.Add($"cyear={(inf5.Text == string.Empty ? "null" : inf5.Text)}");
            }
            if (list.Count > 0)
            {
                string cmd = $"update courses set {string.Join(",", list.ToArray())} where cid='{inf0.Text}';";
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
