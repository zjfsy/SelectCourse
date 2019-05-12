using System;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            stuCbxSrh.SelectedIndex = 0;
            couCbxSrh.SelectedIndex = 0;
            selCbxSrh.SelectedIndex = 0;
        }
        private void ToStuWnd(object sender, EventArgs e)
        {
            panel0.Visible = false;
            panel1.Visible = true;
            Text = "学生信息管理";
        }
        private void ToCouWnd(object sender, EventArgs e)
        {
            panel0.Visible = false;
            panel2.Visible = true;
            Text = "课程信息管理";
        }
        private void ToRegWnd(object sender, EventArgs e)
        {
            panel0.Visible = false;
            panel3.Visible = true;
            Text = "选课信息管理";
        }
        private void CloseWnd(object sender, EventArgs e)
        {
            Close();
        }
        private void AboutWnd(object sender, EventArgs e)
        {
            new DialogAbout().ShowDialog();
        }
        private void StuToMainWnd(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel0.Visible = true;
            Text = "选课系统";
        }
        private void CouToMainWnd(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel0.Visible = true;
            Text = "选课系统";
        }
        private void RegToMainWnd(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel0.Visible = true;
            Text = "选课系统";
        }
        private void StuRbnChanged(object sender, EventArgs e)
        {
            stuGbxInf.Tag = ((RadioButton)sender).Tag;
        }
        private void StuBnSrhClick(object sender, EventArgs e)
        {
            if (stuTxtSrh.Text == string.Empty)
            {
                MessageBox.Show("请输入学生学号或姓名！");
                return;
            }
            string cmd;
            switch (int.Parse((string)stuGbxInf.Tag))
            {
                case 1:
                    cmd = stuCbxSrh.SelectedIndex == 0
                        ? $"select * from students where sid='{stuTxtSrh.Text}';"
                        : $"select * from students where sname='{stuTxtSrh.Text}';";
                    DBO.Search(cmd, stuLtvTab);
                    break;
                case 2:
                    cmd = stuCbxSrh.SelectedIndex == 0
                        ? $"select * from register where sid='{stuTxtSrh.Text}';"
                        : $"select * from register where sid in(select sid from students where sname='{stuTxtSrh.Text}');";
                    DBO.Search(cmd, stuLtvTab);
                    break;
                case 3:
                    cmd = stuCbxSrh.SelectedIndex == 0
                        ? $"select avg(score) as avgScore from register where sid='{stuTxtSrh.Text}';"
                        : $"select avg(score) as avgScore from register where sid in(select sid from students where sname='{stuTxtSrh.Text}');";
                    DBO.Search(cmd, stuLtvTab);
                    break;
            }
        }
        private void StuBnAddClick(object sender, EventArgs e)
        {
            new DialogAddStu().ShowDialog();
        }
        private void StuBnDelClick(object sender, EventArgs e)
        {
            new DialogDelStu().ShowDialog();
        }
        private void StuBnUpdClick(object sender, EventArgs e)
        {
            new DialogUpdStu().ShowDialog();
        }
        private void CouRbnChanged(object sender, EventArgs e)
        {
            couGbxInf.Tag = ((RadioButton)sender).Tag;
        }
        private void CouBnSrhClick(object sender, EventArgs e)
        {
            if (couTxtSrh.Text == string.Empty)
            {
                MessageBox.Show("请输入课程编号或名称！");
                return;
            }
            string cmd;
            switch (int.Parse((string)couGbxInf.Tag))
            {
                case 1:
                    cmd = couCbxSrh.SelectedIndex == 0
                        ? $"select * from courses where cid='{couTxtSrh.Text}';"
                        : $"select * from courses where cname='{couTxtSrh.Text}';";
                    DBO.Search(cmd, couLtvTab);
                    break;
                case 2:
                    cmd = couCbxSrh.SelectedIndex == 0
                        ? $"select * from register where cid='{couTxtSrh.Text}';"
                        : $"select * from register where cid in(select cid from courses where cname='{couTxtSrh.Text}');";
                    DBO.Search(cmd, couLtvTab);
                    break;
                case 3:
                    cmd = couCbxSrh.SelectedIndex == 0
                        ? $"select elt(interval(score,0,60,70,80,90,100),'fail','60-69','70-79','80-89','90-99','full') as level,count(*) as count from register where cid='{couTxtSrh.Text}' group by interval(score, 0, 60, 70, 80, 90, 100) order by interval(score, 0, 60, 70, 80, 90, 100) desc; "
                        : $"select elt(interval(score,0,60,70,80,90,100),'fail','60-69','70-79','80-89','90-99','full') as level,count(*) as count from register where cid in(select cid from courses where cname='{couTxtSrh.Text}') group by interval(score, 0, 60, 70, 80, 90, 100) order by interval(score, 0, 60, 70, 80, 90, 100) desc; ";
                    DBO.Search(cmd, couLtvTab);
                    break;
                case 4:
                    cmd = couCbxSrh.SelectedIndex == 0
                        ? $"select avg(score) as avgScore from register where cid='{couTxtSrh.Text}';"
                        : $"select avg(score) as avgScore from register where cid in(select cid from courses where cname='{couTxtSrh.Text}');";
                    DBO.Search(cmd, couLtvTab);
                    break;
            }
        }
        private void CouBnAddClick(object sender, EventArgs e)
        {
            new DialogAddCou().ShowDialog();
        }
        private void CouBnDelClick(object sender, EventArgs e)
        {
            new DialogDelCou().ShowDialog();
        }
        private void CouBnUpdClick(object sender, EventArgs e)
        {
            new DialogUpdCou().ShowDialog();
        }
        private void SelBnStuClick(object sender, EventArgs e)
        {
            if (selTbInf1.Text == string.Empty)
            {
                MessageBox.Show("请输入学生学号或姓名！");
                return;
            }
            if (selTbInf2.Text == string.Empty)
            {
                MessageBox.Show("请输入课程编号或名称！");
                return;
            }
            string cmd;
            switch (selCbxSrh.SelectedIndex)
            {
                case 0:
                    cmd = $"select score from register where sid='{selTbInf1.Text}' and cid='{selTbInf2.Text}';";
                    DBO.Search(cmd, selLtvTab);
                    break;
                case 1:
                    cmd = $"select score from register where sid='{selTbInf1.Text}' and cid in(select cid from courses where cname='{selTbInf2.Text}');";
                    DBO.Search(cmd, selLtvTab);
                    break;
                case 2:
                    cmd = $"select score from register where sid in(select sid from students where sname='{selTbInf1.Text}') and cid='{selTbInf2.Text}';";
                    DBO.Search(cmd, selLtvTab);
                    break;
                case 3:
                    cmd= $"select score from register where sid in(select sid from students where sname='{selTbInf1.Text}') and cid in(select cid from courses where cname='{selTbInf2.Text}');";
                    DBO.Search(cmd, selLtvTab);
                    break;
            }
        }
        private void SelBnClaClick(object sender, EventArgs e)
        {
            if (selTbInf0.Text == string.Empty)
            {
                MessageBox.Show("请输入班级！");
                return;
            }
            string cmd = $"select avg(score) as avgScore from register where sid in(select sid from students where class='{selTbInf0.Text}')";
            DBO.Search(cmd, selLtvTab);
        }
        private void SelBnAddClick(object sender, EventArgs e)
        {
            new DialogAddSel().ShowDialog();
        }
        private void SelBnDelClick(object sender, EventArgs e)
        {
            new DialogDelSel().ShowDialog();
        }
        private void SelBnUpdClick(object sender, EventArgs e)
        {
            new DialogUpdSel().ShowDialog();
        }
    }
}
