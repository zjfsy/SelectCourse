﻿namespace SelectCourse
{
    partial class DialogUpdSel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogUpdSel));
            this.gbox = new System.Windows.Forms.GroupBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.inf3 = new System.Windows.Forms.TextBox();
            this.inf2 = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.inf1 = new System.Windows.Forms.TextBox();
            this.inf0 = new System.Windows.Forms.TextBox();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab0 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox
            // 
            this.gbox.BackColor = System.Drawing.Color.Transparent;
            this.gbox.Controls.Add(this.chk2);
            this.gbox.Controls.Add(this.chk1);
            this.gbox.Controls.Add(this.inf3);
            this.gbox.Controls.Add(this.inf2);
            this.gbox.Controls.Add(this.btn0);
            this.gbox.Controls.Add(this.inf1);
            this.gbox.Controls.Add(this.inf0);
            this.gbox.Controls.Add(this.lab3);
            this.gbox.Controls.Add(this.lab2);
            this.gbox.Controls.Add(this.lab1);
            this.gbox.Controls.Add(this.lab0);
            this.gbox.Location = new System.Drawing.Point(20, 15);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(220, 125);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            this.gbox.Text = "选课信息";
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(165, 98);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(48, 16);
            this.chk2.TabIndex = 10;
            this.chk2.Text = "更改";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.Chk2Changed);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(165, 73);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(48, 16);
            this.chk1.TabIndex = 9;
            this.chk1.Text = "更改";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.Chk1Changed);
            // 
            // inf3
            // 
            this.inf3.Enabled = false;
            this.inf3.Location = new System.Drawing.Point(60, 95);
            this.inf3.Name = "inf3";
            this.inf3.Size = new System.Drawing.Size(100, 21);
            this.inf3.TabIndex = 8;
            // 
            // inf2
            // 
            this.inf2.Enabled = false;
            this.inf2.Location = new System.Drawing.Point(60, 70);
            this.inf2.Name = "inf2";
            this.inf2.Size = new System.Drawing.Size(100, 21);
            this.inf2.TabIndex = 7;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(165, 28);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 30);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "查找";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.BtnSrhClick);
            // 
            // inf1
            // 
            this.inf1.Location = new System.Drawing.Point(60, 45);
            this.inf1.Name = "inf1";
            this.inf1.Size = new System.Drawing.Size(100, 21);
            this.inf1.TabIndex = 5;
            // 
            // inf0
            // 
            this.inf0.Location = new System.Drawing.Point(60, 20);
            this.inf0.Name = "inf0";
            this.inf0.Size = new System.Drawing.Size(100, 21);
            this.inf0.TabIndex = 4;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(5, 100);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(53, 12);
            this.lab3.TabIndex = 3;
            this.lab3.Text = "成　　绩";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(5, 75);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(53, 12);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "选课年份";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(5, 50);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(53, 12);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "课程编号";
            // 
            // lab0
            // 
            this.lab0.AutoSize = true;
            this.lab0.Location = new System.Drawing.Point(5, 25);
            this.lab0.Name = "lab0";
            this.lab0.Size = new System.Drawing.Size(53, 12);
            this.lab0.TabIndex = 0;
            this.lab0.Text = "学生学号";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(250, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "修改";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnUpdClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(250, 70);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "还原";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnSrhClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(250, 110);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "关闭";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnCnlClick);
            // 
            // DialogUpdSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SelectCourse.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 153);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.gbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DialogUpdSel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改选课信息";
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.TextBox inf3;
        private System.Windows.Forms.TextBox inf2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox inf1;
        private System.Windows.Forms.TextBox inf0;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}