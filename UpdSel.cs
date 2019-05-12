using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogUpdSel : Form
    {
        public DialogUpdSel()
        {
            InitializeComponent();
        }
        private void Chk1Changed(object sender, EventArgs e)
        {
            inf2.Enabled = chk1.Checked;
        }
        private void Chk2Changed(object sender, EventArgs e)
        {
            inf3.Enabled = chk2.Checked;
        }
        private void BtnSrhClick(object sender, EventArgs e)
        {
            if (inf0.Text == string.Empty)
            {
                MessageBox.Show("请输入学生学号！");
                return;
            }
            if (inf1.Text == string.Empty)
            {
                MessageBox.Show("请输入课程编号！");
                return;
            }
            string cmd = $"select ryear,score from register where sid='{inf0.Text}' and cid='{inf1.Text}';";
            Dictionary<string, string> dic = DBO.Search(cmd);
            foreach(KeyValuePair<string, string> kv in dic)
            {
                switch (kv.Key)
                {
                    case "ryear":
                        inf2.Text = kv.Value;
                        break;
                    case "score":
                        inf3.Text = kv.Value;
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
            if (inf1.Text == string.Empty)
            {
                MessageBox.Show("请输入课程编号！");
                return;
            }
            if (inf2.Enabled)
            {
                if (inf2.Text == string.Empty)
                {
                    MessageBox.Show("请输入选课的完整信息！");
                    return;
                }
                list.Add($"ryear={inf2.Text}");
            }
            if (inf3.Enabled)
            {
                if (inf3.Text == string.Empty)
                {
                    MessageBox.Show("请输入选课的完整信息！");
                    return;
                }
                list.Add($"score={inf3.Text}");
            }
            if (list.Count > 0)
            {
                string cmd = $"update register set {string.Join(",", list.ToArray())} where sid='{inf0.Text}' and cid='{inf1.Text}';";
                DBO.Update(cmd);
                MessageBox.Show("修改成功！");
            }
        }
        private void BtnCnlClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
