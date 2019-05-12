namespace SelectCourse
{
    partial class DialogAddSel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox = new System.Windows.Forms.GroupBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.inf1 = new System.Windows.Forms.TextBox();
            this.inf2 = new System.Windows.Forms.TextBox();
            this.inf3 = new System.Windows.Forms.TextBox();
            this.inf4 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox
            // 
            this.gbox.BackColor = System.Drawing.Color.Transparent;
            this.gbox.Controls.Add(this.inf4);
            this.gbox.Controls.Add(this.inf3);
            this.gbox.Controls.Add(this.inf2);
            this.gbox.Controls.Add(this.inf1);
            this.gbox.Controls.Add(this.lab4);
            this.gbox.Controls.Add(this.lab3);
            this.gbox.Controls.Add(this.lab2);
            this.gbox.Controls.Add(this.lab1);
            this.gbox.Location = new System.Drawing.Point(20, 15);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(175, 125);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            this.gbox.Text = "选课信息";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(5, 25);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(53, 12);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "学生学号";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(5, 50);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(53, 12);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "课程编号";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(5, 75);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(53, 12);
            this.lab3.TabIndex = 2;
            this.lab3.Text = "选课年份";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(5, 100);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(53, 12);
            this.lab4.TabIndex = 3;
            this.lab4.Text = "成　　绩";
            // 
            // inf1
            // 
            this.inf1.Location = new System.Drawing.Point(64, 20);
            this.inf1.Name = "inf1";
            this.inf1.Size = new System.Drawing.Size(100, 21);
            this.inf1.TabIndex = 4;
            // 
            // inf2
            // 
            this.inf2.Location = new System.Drawing.Point(64, 45);
            this.inf2.Name = "inf2";
            this.inf2.Size = new System.Drawing.Size(100, 21);
            this.inf2.TabIndex = 5;
            // 
            // inf3
            // 
            this.inf3.Location = new System.Drawing.Point(64, 70);
            this.inf3.Name = "inf3";
            this.inf3.Size = new System.Drawing.Size(100, 21);
            this.inf3.TabIndex = 6;
            // 
            // inf4
            // 
            this.inf4.Location = new System.Drawing.Point(64, 95);
            this.inf4.Name = "inf4";
            this.inf4.Size = new System.Drawing.Size(100, 21);
            this.inf4.TabIndex = 7;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(210, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "添加";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(210, 70);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "清空";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnClrClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(210, 110);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "关闭";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnCnlClick);
            // 
            // DialogAddSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SelectCourse.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 153);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.gbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DialogAddSel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加选课信息";
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.TextBox inf4;
        private System.Windows.Forms.TextBox inf3;
        private System.Windows.Forms.TextBox inf2;
        private System.Windows.Forms.TextBox inf1;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}