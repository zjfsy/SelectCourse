namespace SelectCourse
{
    partial class Window
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel0 = new System.Windows.Forms.Panel();
            this.labelCnl = new System.Windows.Forms.Label();
            this.labelAbt = new System.Windows.Forms.Label();
            this.labelSel = new System.Windows.Forms.Label();
            this.labelCou = new System.Windows.Forms.Label();
            this.labelStu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stuBtnDel = new System.Windows.Forms.Button();
            this.stuBtnAdd = new System.Windows.Forms.Button();
            this.stuBtnUpd = new System.Windows.Forms.Button();
            this.stuGbxInf = new System.Windows.Forms.GroupBox();
            this.stuRb3 = new System.Windows.Forms.RadioButton();
            this.stuRb2 = new System.Windows.Forms.RadioButton();
            this.stuRb1 = new System.Windows.Forms.RadioButton();
            this.stuGbxSrh = new System.Windows.Forms.GroupBox();
            this.stuBtnSrh = new System.Windows.Forms.Button();
            this.stuTxtSrh = new System.Windows.Forms.TextBox();
            this.stuLabSrh = new System.Windows.Forms.Label();
            this.stuCbxSrh = new System.Windows.Forms.ComboBox();
            this.stuLtvTab = new System.Windows.Forms.ListView();
            this.stuBtnRet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.couBtnDel = new System.Windows.Forms.Button();
            this.couBtnAdd = new System.Windows.Forms.Button();
            this.couBtnUpd = new System.Windows.Forms.Button();
            this.couGbxInf = new System.Windows.Forms.GroupBox();
            this.couRbInf4 = new System.Windows.Forms.RadioButton();
            this.couRbInf3 = new System.Windows.Forms.RadioButton();
            this.couRbinf2 = new System.Windows.Forms.RadioButton();
            this.couRbinf1 = new System.Windows.Forms.RadioButton();
            this.couGbxSrh = new System.Windows.Forms.GroupBox();
            this.couBtnSrh = new System.Windows.Forms.Button();
            this.couTxtSrh = new System.Windows.Forms.TextBox();
            this.couCbxSrh = new System.Windows.Forms.ComboBox();
            this.couLabSrh = new System.Windows.Forms.Label();
            this.couLtvTab = new System.Windows.Forms.ListView();
            this.couBtnRet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selGbxSel = new System.Windows.Forms.GroupBox();
            this.selBtnDel = new System.Windows.Forms.Button();
            this.selBtnAdd = new System.Windows.Forms.Button();
            this.selBtnUpd = new System.Windows.Forms.Button();
            this.selGbxStu = new System.Windows.Forms.GroupBox();
            this.selLabStu = new System.Windows.Forms.Label();
            this.selCbxSrh = new System.Windows.Forms.ComboBox();
            this.selTbInf2 = new System.Windows.Forms.TextBox();
            this.selBnSrh1 = new System.Windows.Forms.Button();
            this.selTbInf1 = new System.Windows.Forms.TextBox();
            this.selLtvTab = new System.Windows.Forms.ListView();
            this.selGbxCla = new System.Windows.Forms.GroupBox();
            this.selBnSrh0 = new System.Windows.Forms.Button();
            this.selTbInf0 = new System.Windows.Forms.TextBox();
            this.selBtnRet = new System.Windows.Forms.Button();
            this.panel0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.stuGbxInf.SuspendLayout();
            this.stuGbxSrh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.couGbxInf.SuspendLayout();
            this.couGbxSrh.SuspendLayout();
            this.panel3.SuspendLayout();
            this.selGbxSel.SuspendLayout();
            this.selGbxStu.SuspendLayout();
            this.selGbxCla.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.Color.Transparent;
            this.panel0.Controls.Add(this.labelCnl);
            this.panel0.Controls.Add(this.labelAbt);
            this.panel0.Controls.Add(this.labelSel);
            this.panel0.Controls.Add(this.labelCou);
            this.panel0.Controls.Add(this.labelStu);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0.Location = new System.Drawing.Point(0, 0);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(464, 281);
            this.panel0.TabIndex = 0;
            // 
            // labelCnl
            // 
            this.labelCnl.AutoSize = true;
            this.labelCnl.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCnl.Location = new System.Drawing.Point(250, 200);
            this.labelCnl.Name = "labelCnl";
            this.labelCnl.Size = new System.Drawing.Size(154, 24);
            this.labelCnl.TabIndex = 6;
            this.labelCnl.Text = "退出选课系统";
            this.labelCnl.Click += new System.EventHandler(this.CloseWnd);
            // 
            // labelAbt
            // 
            this.labelAbt.AutoSize = true;
            this.labelAbt.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAbt.Location = new System.Drawing.Point(250, 160);
            this.labelAbt.Name = "labelAbt";
            this.labelAbt.Size = new System.Drawing.Size(154, 24);
            this.labelAbt.TabIndex = 5;
            this.labelAbt.Text = "关于选课系统";
            this.labelAbt.Click += new System.EventHandler(this.AboutWnd);
            // 
            // labelSel
            // 
            this.labelSel.AutoSize = true;
            this.labelSel.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSel.Location = new System.Drawing.Point(250, 120);
            this.labelSel.Name = "labelSel";
            this.labelSel.Size = new System.Drawing.Size(154, 24);
            this.labelSel.TabIndex = 4;
            this.labelSel.Text = "选课信息管理";
            this.labelSel.Click += new System.EventHandler(this.ToRegWnd);
            // 
            // labelCou
            // 
            this.labelCou.AutoSize = true;
            this.labelCou.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCou.Location = new System.Drawing.Point(250, 80);
            this.labelCou.Name = "labelCou";
            this.labelCou.Size = new System.Drawing.Size(154, 24);
            this.labelCou.TabIndex = 3;
            this.labelCou.Text = "课程信息管理";
            this.labelCou.Click += new System.EventHandler(this.ToCouWnd);
            // 
            // labelStu
            // 
            this.labelStu.AutoSize = true;
            this.labelStu.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStu.Location = new System.Drawing.Point(250, 40);
            this.labelStu.Name = "labelStu";
            this.labelStu.Size = new System.Drawing.Size(154, 24);
            this.labelStu.TabIndex = 2;
            this.labelStu.Text = "学生信息管理";
            this.labelStu.Click += new System.EventHandler(this.ToStuWnd);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.stuBtnDel);
            this.panel1.Controls.Add(this.stuBtnAdd);
            this.panel1.Controls.Add(this.stuBtnUpd);
            this.panel1.Controls.Add(this.stuGbxInf);
            this.panel1.Controls.Add(this.stuGbxSrh);
            this.panel1.Controls.Add(this.stuLtvTab);
            this.panel1.Controls.Add(this.stuBtnRet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 281);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // stuBtnDel
            // 
            this.stuBtnDel.Location = new System.Drawing.Point(350, 205);
            this.stuBtnDel.Name = "stuBtnDel";
            this.stuBtnDel.Size = new System.Drawing.Size(88, 24);
            this.stuBtnDel.TabIndex = 6;
            this.stuBtnDel.Text = "删除记录";
            this.stuBtnDel.UseVisualStyleBackColor = true;
            this.stuBtnDel.Click += new System.EventHandler(this.StuBnDelClick);
            // 
            // stuBtnAdd
            // 
            this.stuBtnAdd.Location = new System.Drawing.Point(350, 170);
            this.stuBtnAdd.Name = "stuBtnAdd";
            this.stuBtnAdd.Size = new System.Drawing.Size(88, 24);
            this.stuBtnAdd.TabIndex = 5;
            this.stuBtnAdd.Text = "添加记录";
            this.stuBtnAdd.UseVisualStyleBackColor = true;
            this.stuBtnAdd.Click += new System.EventHandler(this.StuBnAddClick);
            // 
            // stuBtnUpd
            // 
            this.stuBtnUpd.Location = new System.Drawing.Point(350, 135);
            this.stuBtnUpd.Name = "stuBtnUpd";
            this.stuBtnUpd.Size = new System.Drawing.Size(88, 24);
            this.stuBtnUpd.TabIndex = 4;
            this.stuBtnUpd.Text = "修改记录";
            this.stuBtnUpd.UseVisualStyleBackColor = true;
            this.stuBtnUpd.Click += new System.EventHandler(this.StuBnUpdClick);
            // 
            // stuGbxInf
            // 
            this.stuGbxInf.Controls.Add(this.stuRb3);
            this.stuGbxInf.Controls.Add(this.stuRb2);
            this.stuGbxInf.Controls.Add(this.stuRb1);
            this.stuGbxInf.Location = new System.Drawing.Point(350, 20);
            this.stuGbxInf.Name = "stuGbxInf";
            this.stuGbxInf.Size = new System.Drawing.Size(88, 100);
            this.stuGbxInf.TabIndex = 3;
            this.stuGbxInf.TabStop = false;
            this.stuGbxInf.Tag = "1";
            this.stuGbxInf.Text = "查询内容";
            // 
            // stuRb3
            // 
            this.stuRb3.AutoSize = true;
            this.stuRb3.Location = new System.Drawing.Point(10, 75);
            this.stuRb3.Name = "stuRb3";
            this.stuRb3.Size = new System.Drawing.Size(71, 16);
            this.stuRb3.TabIndex = 8;
            this.stuRb3.Tag = "3";
            this.stuRb3.Text = "平均成绩";
            this.stuRb3.UseVisualStyleBackColor = true;
            this.stuRb3.Click += new System.EventHandler(this.StuRbnChanged);
            // 
            // stuRb2
            // 
            this.stuRb2.AutoSize = true;
            this.stuRb2.Location = new System.Drawing.Point(10, 50);
            this.stuRb2.Name = "stuRb2";
            this.stuRb2.Size = new System.Drawing.Size(71, 16);
            this.stuRb2.TabIndex = 7;
            this.stuRb2.Tag = "2";
            this.stuRb2.Text = "选课情况";
            this.stuRb2.UseVisualStyleBackColor = true;
            this.stuRb2.Click += new System.EventHandler(this.StuRbnChanged);
            // 
            // stuRb1
            // 
            this.stuRb1.AutoSize = true;
            this.stuRb1.Checked = true;
            this.stuRb1.Location = new System.Drawing.Point(10, 25);
            this.stuRb1.Name = "stuRb1";
            this.stuRb1.Size = new System.Drawing.Size(71, 16);
            this.stuRb1.TabIndex = 6;
            this.stuRb1.TabStop = true;
            this.stuRb1.Tag = "1";
            this.stuRb1.Text = "基本信息";
            this.stuRb1.UseVisualStyleBackColor = true;
            this.stuRb1.Click += new System.EventHandler(this.StuRbnChanged);
            // 
            // stuGbxSrh
            // 
            this.stuGbxSrh.Controls.Add(this.stuBtnSrh);
            this.stuGbxSrh.Controls.Add(this.stuTxtSrh);
            this.stuGbxSrh.Controls.Add(this.stuLabSrh);
            this.stuGbxSrh.Controls.Add(this.stuCbxSrh);
            this.stuGbxSrh.Location = new System.Drawing.Point(24, 210);
            this.stuGbxSrh.Name = "stuGbxSrh";
            this.stuGbxSrh.Size = new System.Drawing.Size(310, 56);
            this.stuGbxSrh.TabIndex = 2;
            this.stuGbxSrh.TabStop = false;
            this.stuGbxSrh.Text = "查询";
            // 
            // stuBtnSrh
            // 
            this.stuBtnSrh.Location = new System.Drawing.Point(215, 23);
            this.stuBtnSrh.Name = "stuBtnSrh";
            this.stuBtnSrh.Size = new System.Drawing.Size(75, 23);
            this.stuBtnSrh.TabIndex = 3;
            this.stuBtnSrh.Text = "查找";
            this.stuBtnSrh.UseVisualStyleBackColor = true;
            this.stuBtnSrh.Click += new System.EventHandler(this.StuBnSrhClick);
            // 
            // stuTxtSrh
            // 
            this.stuTxtSrh.Location = new System.Drawing.Point(125, 24);
            this.stuTxtSrh.Name = "stuTxtSrh";
            this.stuTxtSrh.Size = new System.Drawing.Size(80, 21);
            this.stuTxtSrh.TabIndex = 2;
            // 
            // stuLabSrh
            // 
            this.stuLabSrh.AutoSize = true;
            this.stuLabSrh.Location = new System.Drawing.Point(5, 28);
            this.stuLabSrh.Name = "stuLabSrh";
            this.stuLabSrh.Size = new System.Drawing.Size(29, 12);
            this.stuLabSrh.TabIndex = 1;
            this.stuLabSrh.Text = "方式";
            // 
            // stuCbxSrh
            // 
            this.stuCbxSrh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuCbxSrh.FormattingEnabled = true;
            this.stuCbxSrh.Items.AddRange(new object[] {
            "学号：",
            "姓名："});
            this.stuCbxSrh.Location = new System.Drawing.Point(35, 24);
            this.stuCbxSrh.Name = "stuCbxSrh";
            this.stuCbxSrh.Size = new System.Drawing.Size(80, 20);
            this.stuCbxSrh.TabIndex = 0;
            // 
            // stuLtvTab
            // 
            this.stuLtvTab.Location = new System.Drawing.Point(24, 20);
            this.stuLtvTab.Name = "stuLtvTab";
            this.stuLtvTab.Size = new System.Drawing.Size(310, 180);
            this.stuLtvTab.TabIndex = 1;
            this.stuLtvTab.UseCompatibleStateImageBehavior = false;
            this.stuLtvTab.View = System.Windows.Forms.View.Details;
            // 
            // stuBtnRet
            // 
            this.stuBtnRet.Location = new System.Drawing.Point(350, 240);
            this.stuBtnRet.Name = "stuBtnRet";
            this.stuBtnRet.Size = new System.Drawing.Size(88, 24);
            this.stuBtnRet.TabIndex = 0;
            this.stuBtnRet.Text = "返回主界面";
            this.stuBtnRet.UseVisualStyleBackColor = true;
            this.stuBtnRet.Click += new System.EventHandler(this.StuToMainWnd);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.couBtnDel);
            this.panel2.Controls.Add(this.couBtnAdd);
            this.panel2.Controls.Add(this.couBtnUpd);
            this.panel2.Controls.Add(this.couGbxInf);
            this.panel2.Controls.Add(this.couGbxSrh);
            this.panel2.Controls.Add(this.couLtvTab);
            this.panel2.Controls.Add(this.couBtnRet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 281);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // couBtnDel
            // 
            this.couBtnDel.Location = new System.Drawing.Point(350, 210);
            this.couBtnDel.Name = "couBtnDel";
            this.couBtnDel.Size = new System.Drawing.Size(88, 24);
            this.couBtnDel.TabIndex = 7;
            this.couBtnDel.Text = "删除记录";
            this.couBtnDel.UseVisualStyleBackColor = true;
            this.couBtnDel.Click += new System.EventHandler(this.CouBnDelClick);
            // 
            // couBtnAdd
            // 
            this.couBtnAdd.Location = new System.Drawing.Point(350, 180);
            this.couBtnAdd.Name = "couBtnAdd";
            this.couBtnAdd.Size = new System.Drawing.Size(88, 24);
            this.couBtnAdd.TabIndex = 6;
            this.couBtnAdd.Text = "添加记录";
            this.couBtnAdd.UseVisualStyleBackColor = true;
            this.couBtnAdd.Click += new System.EventHandler(this.CouBnAddClick);
            // 
            // couBtnUpd
            // 
            this.couBtnUpd.Location = new System.Drawing.Point(350, 150);
            this.couBtnUpd.Name = "couBtnUpd";
            this.couBtnUpd.Size = new System.Drawing.Size(88, 24);
            this.couBtnUpd.TabIndex = 5;
            this.couBtnUpd.Text = "修改记录";
            this.couBtnUpd.UseVisualStyleBackColor = true;
            this.couBtnUpd.Click += new System.EventHandler(this.CouBnUpdClick);
            // 
            // couGbxInf
            // 
            this.couGbxInf.Controls.Add(this.couRbInf4);
            this.couGbxInf.Controls.Add(this.couRbInf3);
            this.couGbxInf.Controls.Add(this.couRbinf2);
            this.couGbxInf.Controls.Add(this.couRbinf1);
            this.couGbxInf.Location = new System.Drawing.Point(350, 20);
            this.couGbxInf.Name = "couGbxInf";
            this.couGbxInf.Size = new System.Drawing.Size(88, 115);
            this.couGbxInf.TabIndex = 4;
            this.couGbxInf.TabStop = false;
            this.couGbxInf.Tag = "1";
            this.couGbxInf.Text = "查询内容";
            // 
            // couRbInf4
            // 
            this.couRbInf4.AutoSize = true;
            this.couRbInf4.Location = new System.Drawing.Point(10, 95);
            this.couRbInf4.Name = "couRbInf4";
            this.couRbInf4.Size = new System.Drawing.Size(71, 16);
            this.couRbInf4.TabIndex = 3;
            this.couRbInf4.TabStop = true;
            this.couRbInf4.Tag = "4";
            this.couRbInf4.Text = "平均成绩";
            this.couRbInf4.UseVisualStyleBackColor = true;
            this.couRbInf4.Click += new System.EventHandler(this.CouRbnChanged);
            // 
            // couRbInf3
            // 
            this.couRbInf3.AutoSize = true;
            this.couRbInf3.Location = new System.Drawing.Point(10, 70);
            this.couRbInf3.Name = "couRbInf3";
            this.couRbInf3.Size = new System.Drawing.Size(71, 16);
            this.couRbInf3.TabIndex = 2;
            this.couRbInf3.TabStop = true;
            this.couRbInf3.Tag = "3";
            this.couRbInf3.Text = "成绩分布";
            this.couRbInf3.UseVisualStyleBackColor = true;
            this.couRbInf3.Click += new System.EventHandler(this.CouRbnChanged);
            // 
            // couRbinf2
            // 
            this.couRbinf2.AutoSize = true;
            this.couRbinf2.Location = new System.Drawing.Point(10, 45);
            this.couRbinf2.Name = "couRbinf2";
            this.couRbinf2.Size = new System.Drawing.Size(71, 16);
            this.couRbinf2.TabIndex = 1;
            this.couRbinf2.TabStop = true;
            this.couRbinf2.Tag = "2";
            this.couRbinf2.Text = "选课情况";
            this.couRbinf2.UseVisualStyleBackColor = true;
            this.couRbinf2.Click += new System.EventHandler(this.CouRbnChanged);
            // 
            // couRbinf1
            // 
            this.couRbinf1.AutoSize = true;
            this.couRbinf1.Checked = true;
            this.couRbinf1.Location = new System.Drawing.Point(10, 20);
            this.couRbinf1.Name = "couRbinf1";
            this.couRbinf1.Size = new System.Drawing.Size(71, 16);
            this.couRbinf1.TabIndex = 0;
            this.couRbinf1.TabStop = true;
            this.couRbinf1.Tag = "1";
            this.couRbinf1.Text = "基本信息";
            this.couRbinf1.UseVisualStyleBackColor = true;
            this.couRbinf1.Click += new System.EventHandler(this.CouRbnChanged);
            // 
            // couGbxSrh
            // 
            this.couGbxSrh.Controls.Add(this.couBtnSrh);
            this.couGbxSrh.Controls.Add(this.couTxtSrh);
            this.couGbxSrh.Controls.Add(this.couCbxSrh);
            this.couGbxSrh.Controls.Add(this.couLabSrh);
            this.couGbxSrh.Location = new System.Drawing.Point(24, 210);
            this.couGbxSrh.Name = "couGbxSrh";
            this.couGbxSrh.Size = new System.Drawing.Size(310, 56);
            this.couGbxSrh.TabIndex = 3;
            this.couGbxSrh.TabStop = false;
            this.couGbxSrh.Text = "查询";
            // 
            // couBtnSrh
            // 
            this.couBtnSrh.Location = new System.Drawing.Point(215, 23);
            this.couBtnSrh.Name = "couBtnSrh";
            this.couBtnSrh.Size = new System.Drawing.Size(75, 23);
            this.couBtnSrh.TabIndex = 3;
            this.couBtnSrh.Text = "查找";
            this.couBtnSrh.UseVisualStyleBackColor = true;
            this.couBtnSrh.Click += new System.EventHandler(this.CouBnSrhClick);
            // 
            // couTxtSrh
            // 
            this.couTxtSrh.Location = new System.Drawing.Point(125, 24);
            this.couTxtSrh.Name = "couTxtSrh";
            this.couTxtSrh.Size = new System.Drawing.Size(80, 21);
            this.couTxtSrh.TabIndex = 2;
            // 
            // couCbxSrh
            // 
            this.couCbxSrh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.couCbxSrh.FormattingEnabled = true;
            this.couCbxSrh.Items.AddRange(new object[] {
            "课程编号：",
            "课程名称："});
            this.couCbxSrh.Location = new System.Drawing.Point(35, 24);
            this.couCbxSrh.Name = "couCbxSrh";
            this.couCbxSrh.Size = new System.Drawing.Size(80, 20);
            this.couCbxSrh.TabIndex = 1;
            // 
            // couLabSrh
            // 
            this.couLabSrh.AutoSize = true;
            this.couLabSrh.Location = new System.Drawing.Point(5, 28);
            this.couLabSrh.Name = "couLabSrh";
            this.couLabSrh.Size = new System.Drawing.Size(29, 12);
            this.couLabSrh.TabIndex = 0;
            this.couLabSrh.Text = "方式";
            // 
            // couLtvTab
            // 
            this.couLtvTab.Location = new System.Drawing.Point(24, 20);
            this.couLtvTab.Name = "couLtvTab";
            this.couLtvTab.Size = new System.Drawing.Size(310, 180);
            this.couLtvTab.TabIndex = 2;
            this.couLtvTab.UseCompatibleStateImageBehavior = false;
            this.couLtvTab.View = System.Windows.Forms.View.Details;
            // 
            // couBtnRet
            // 
            this.couBtnRet.Location = new System.Drawing.Point(350, 240);
            this.couBtnRet.Name = "couBtnRet";
            this.couBtnRet.Size = new System.Drawing.Size(88, 24);
            this.couBtnRet.TabIndex = 0;
            this.couBtnRet.Text = "返回主界面";
            this.couBtnRet.UseVisualStyleBackColor = true;
            this.couBtnRet.Click += new System.EventHandler(this.CouToMainWnd);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.selGbxSel);
            this.panel3.Controls.Add(this.selGbxStu);
            this.panel3.Controls.Add(this.selLtvTab);
            this.panel3.Controls.Add(this.selGbxCla);
            this.panel3.Controls.Add(this.selBtnRet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 281);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // selGbxSel
            // 
            this.selGbxSel.Controls.Add(this.selBtnDel);
            this.selGbxSel.Controls.Add(this.selBtnAdd);
            this.selGbxSel.Controls.Add(this.selBtnUpd);
            this.selGbxSel.Location = new System.Drawing.Point(355, 108);
            this.selGbxSel.Name = "selGbxSel";
            this.selGbxSel.Size = new System.Drawing.Size(95, 110);
            this.selGbxSel.TabIndex = 9;
            this.selGbxSel.TabStop = false;
            this.selGbxSel.Text = "选课信息管理";
            // 
            // selBtnDel
            // 
            this.selBtnDel.Location = new System.Drawing.Point(10, 80);
            this.selBtnDel.Name = "selBtnDel";
            this.selBtnDel.Size = new System.Drawing.Size(75, 23);
            this.selBtnDel.TabIndex = 2;
            this.selBtnDel.Text = "删除记录";
            this.selBtnDel.UseVisualStyleBackColor = true;
            this.selBtnDel.Click += new System.EventHandler(this.SelBnDelClick);
            // 
            // selBtnAdd
            // 
            this.selBtnAdd.Location = new System.Drawing.Point(10, 50);
            this.selBtnAdd.Name = "selBtnAdd";
            this.selBtnAdd.Size = new System.Drawing.Size(75, 23);
            this.selBtnAdd.TabIndex = 1;
            this.selBtnAdd.Text = "添加记录";
            this.selBtnAdd.UseVisualStyleBackColor = true;
            this.selBtnAdd.Click += new System.EventHandler(this.SelBnAddClick);
            // 
            // selBtnUpd
            // 
            this.selBtnUpd.Location = new System.Drawing.Point(10, 20);
            this.selBtnUpd.Name = "selBtnUpd";
            this.selBtnUpd.Size = new System.Drawing.Size(75, 23);
            this.selBtnUpd.TabIndex = 0;
            this.selBtnUpd.Text = "修改记录";
            this.selBtnUpd.UseVisualStyleBackColor = true;
            this.selBtnUpd.Click += new System.EventHandler(this.SelBnUpdClick);
            // 
            // selGbxStu
            // 
            this.selGbxStu.Controls.Add(this.selLabStu);
            this.selGbxStu.Controls.Add(this.selCbxSrh);
            this.selGbxStu.Controls.Add(this.selTbInf2);
            this.selGbxStu.Controls.Add(this.selBnSrh1);
            this.selGbxStu.Controls.Add(this.selTbInf1);
            this.selGbxStu.Location = new System.Drawing.Point(20, 220);
            this.selGbxStu.Name = "selGbxStu";
            this.selGbxStu.Size = new System.Drawing.Size(325, 50);
            this.selGbxStu.TabIndex = 8;
            this.selGbxStu.TabStop = false;
            this.selGbxStu.Text = "学生课程成绩";
            // 
            // selLabStu
            // 
            this.selLabStu.AutoSize = true;
            this.selLabStu.Location = new System.Drawing.Point(5, 24);
            this.selLabStu.Name = "selLabStu";
            this.selLabStu.Size = new System.Drawing.Size(29, 12);
            this.selLabStu.TabIndex = 8;
            this.selLabStu.Text = "方式";
            // 
            // selCbxSrh
            // 
            this.selCbxSrh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selCbxSrh.FormattingEnabled = true;
            this.selCbxSrh.Items.AddRange(new object[] {
            "学号,编号",
            "学号,名称",
            "姓名,编号",
            "姓名,名称"});
            this.selCbxSrh.Location = new System.Drawing.Point(35, 20);
            this.selCbxSrh.Name = "selCbxSrh";
            this.selCbxSrh.Size = new System.Drawing.Size(75, 20);
            this.selCbxSrh.TabIndex = 4;
            // 
            // selTbInf2
            // 
            this.selTbInf2.Location = new System.Drawing.Point(185, 20);
            this.selTbInf2.Name = "selTbInf2";
            this.selTbInf2.Size = new System.Drawing.Size(65, 21);
            this.selTbInf2.TabIndex = 6;
            // 
            // selBnSrh1
            // 
            this.selBnSrh1.Location = new System.Drawing.Point(255, 19);
            this.selBnSrh1.Name = "selBnSrh1";
            this.selBnSrh1.Size = new System.Drawing.Size(60, 23);
            this.selBnSrh1.TabIndex = 7;
            this.selBnSrh1.Text = "查找";
            this.selBnSrh1.UseVisualStyleBackColor = true;
            this.selBnSrh1.Click += new System.EventHandler(this.SelBnStuClick);
            // 
            // selTbInf1
            // 
            this.selTbInf1.Location = new System.Drawing.Point(115, 20);
            this.selTbInf1.Name = "selTbInf1";
            this.selTbInf1.Size = new System.Drawing.Size(65, 21);
            this.selTbInf1.TabIndex = 3;
            // 
            // selLtvTab
            // 
            this.selLtvTab.Location = new System.Drawing.Point(20, 20);
            this.selLtvTab.Name = "selLtvTab";
            this.selLtvTab.Size = new System.Drawing.Size(325, 195);
            this.selLtvTab.TabIndex = 2;
            this.selLtvTab.UseCompatibleStateImageBehavior = false;
            this.selLtvTab.View = System.Windows.Forms.View.Details;
            // 
            // selGbxCla
            // 
            this.selGbxCla.Controls.Add(this.selBnSrh0);
            this.selGbxCla.Controls.Add(this.selTbInf0);
            this.selGbxCla.Location = new System.Drawing.Point(355, 20);
            this.selGbxCla.Name = "selGbxCla";
            this.selGbxCla.Size = new System.Drawing.Size(95, 78);
            this.selGbxCla.TabIndex = 1;
            this.selGbxCla.TabStop = false;
            this.selGbxCla.Text = "班级平均成绩";
            // 
            // selBnSrh0
            // 
            this.selBnSrh0.Location = new System.Drawing.Point(10, 50);
            this.selBnSrh0.Name = "selBnSrh0";
            this.selBnSrh0.Size = new System.Drawing.Size(75, 23);
            this.selBnSrh0.TabIndex = 1;
            this.selBnSrh0.Text = "查找";
            this.selBnSrh0.UseVisualStyleBackColor = true;
            this.selBnSrh0.Click += new System.EventHandler(this.SelBnClaClick);
            // 
            // selTbInf0
            // 
            this.selTbInf0.Location = new System.Drawing.Point(10, 20);
            this.selTbInf0.Name = "selTbInf0";
            this.selTbInf0.Size = new System.Drawing.Size(75, 21);
            this.selTbInf0.TabIndex = 0;
            // 
            // selBtnRet
            // 
            this.selBtnRet.Location = new System.Drawing.Point(365, 232);
            this.selBtnRet.Name = "selBtnRet";
            this.selBtnRet.Size = new System.Drawing.Size(75, 32);
            this.selBtnRet.TabIndex = 0;
            this.selBtnRet.Text = "返回主界面";
            this.selBtnRet.UseVisualStyleBackColor = true;
            this.selBtnRet.Click += new System.EventHandler(this.RegToMainWnd);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SelectCourse.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选课系统";
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.stuGbxInf.ResumeLayout(false);
            this.stuGbxInf.PerformLayout();
            this.stuGbxSrh.ResumeLayout(false);
            this.stuGbxSrh.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.couGbxInf.ResumeLayout(false);
            this.couGbxInf.PerformLayout();
            this.couGbxSrh.ResumeLayout(false);
            this.couGbxSrh.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.selGbxSel.ResumeLayout(false);
            this.selGbxStu.ResumeLayout(false);
            this.selGbxStu.PerformLayout();
            this.selGbxCla.ResumeLayout(false);
            this.selGbxCla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStu;
        private System.Windows.Forms.Label labelAbt;
        private System.Windows.Forms.Label labelSel;
        private System.Windows.Forms.Label labelCou;
        private System.Windows.Forms.Button stuBtnRet;
        private System.Windows.Forms.GroupBox stuGbxSrh;
        private System.Windows.Forms.ListView stuLtvTab;
        private System.Windows.Forms.Button stuBtnSrh;
        private System.Windows.Forms.TextBox stuTxtSrh;
        private System.Windows.Forms.Label stuLabSrh;
        private System.Windows.Forms.ComboBox stuCbxSrh;
        private System.Windows.Forms.GroupBox stuGbxInf;
        private System.Windows.Forms.Button stuBtnDel;
        private System.Windows.Forms.Button stuBtnAdd;
        private System.Windows.Forms.Button stuBtnUpd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button couBtnRet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button selBtnRet;
        private System.Windows.Forms.Label labelCnl;
        private System.Windows.Forms.RadioButton stuRb3;
        private System.Windows.Forms.RadioButton stuRb2;
        private System.Windows.Forms.RadioButton stuRb1;
        private System.Windows.Forms.Button couBtnDel;
        private System.Windows.Forms.Button couBtnAdd;
        private System.Windows.Forms.Button couBtnUpd;
        private System.Windows.Forms.GroupBox couGbxInf;
        private System.Windows.Forms.GroupBox couGbxSrh;
        private System.Windows.Forms.ListView couLtvTab;
        private System.Windows.Forms.ComboBox couCbxSrh;
        private System.Windows.Forms.Label couLabSrh;
        private System.Windows.Forms.RadioButton couRbInf4;
        private System.Windows.Forms.RadioButton couRbInf3;
        private System.Windows.Forms.RadioButton couRbinf2;
        private System.Windows.Forms.RadioButton couRbinf1;
        private System.Windows.Forms.Button couBtnSrh;
        private System.Windows.Forms.TextBox couTxtSrh;
        private System.Windows.Forms.GroupBox selGbxCla;
        private System.Windows.Forms.ListView selLtvTab;
        private System.Windows.Forms.GroupBox selGbxSel;
        private System.Windows.Forms.Button selBtnDel;
        private System.Windows.Forms.Button selBtnAdd;
        private System.Windows.Forms.Button selBtnUpd;
        private System.Windows.Forms.GroupBox selGbxStu;
        private System.Windows.Forms.ComboBox selCbxSrh;
        private System.Windows.Forms.TextBox selTbInf2;
        private System.Windows.Forms.Button selBnSrh1;
        private System.Windows.Forms.TextBox selTbInf1;
        private System.Windows.Forms.Button selBnSrh0;
        private System.Windows.Forms.TextBox selTbInf0;
        private System.Windows.Forms.Label selLabStu;
    }
}

