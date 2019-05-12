namespace SelectCourse
{
    partial class DialogDelStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogDelStu));
            this.idlb = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.BackColor = System.Drawing.Color.Transparent;
            this.idlb.Location = new System.Drawing.Point(27, 35);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(29, 12);
            this.idlb.TabIndex = 0;
            this.idlb.Text = "学号";
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(57, 30);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(100, 21);
            this.idtb.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(27, 66);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "删除";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnDelClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(97, 66);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "关闭";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnCnlClick);
            // 
            // DialogDelStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SelectCourse.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(184, 111);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.idlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DialogDelStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "删除学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}