namespace SelectCourse
{
    partial class DialogDelSel
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
            this.labs = new System.Windows.Forms.Label();
            this.labc = new System.Windows.Forms.Label();
            this.tbxs = new System.Windows.Forms.TextBox();
            this.tbxc = new System.Windows.Forms.TextBox();
            this.btnd = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labs
            // 
            this.labs.AutoSize = true;
            this.labs.BackColor = System.Drawing.Color.Transparent;
            this.labs.Location = new System.Drawing.Point(25, 25);
            this.labs.Name = "labs";
            this.labs.Size = new System.Drawing.Size(53, 12);
            this.labs.TabIndex = 0;
            this.labs.Text = "学生学号";
            // 
            // labc
            // 
            this.labc.AutoSize = true;
            this.labc.BackColor = System.Drawing.Color.Transparent;
            this.labc.Location = new System.Drawing.Point(25, 55);
            this.labc.Name = "labc";
            this.labc.Size = new System.Drawing.Size(53, 12);
            this.labc.TabIndex = 1;
            this.labc.Text = "课程编号";
            // 
            // tbxs
            // 
            this.tbxs.Location = new System.Drawing.Point(80, 20);
            this.tbxs.Name = "tbxs";
            this.tbxs.Size = new System.Drawing.Size(100, 21);
            this.tbxs.TabIndex = 2;
            // 
            // tbxc
            // 
            this.tbxc.Location = new System.Drawing.Point(80, 50);
            this.tbxc.Name = "tbxc";
            this.tbxc.Size = new System.Drawing.Size(100, 21);
            this.tbxc.TabIndex = 3;
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(20, 80);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(75, 23);
            this.btnd.TabIndex = 4;
            this.btnd.Text = "删除";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.BtnDelClick);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(110, 80);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 5;
            this.btnc.Text = "关闭";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.BtnCnlClick);
            // 
            // DialogDelSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SelectCourse.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(204, 121);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.tbxc);
            this.Controls.Add(this.tbxs);
            this.Controls.Add(this.labc);
            this.Controls.Add(this.labs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DialogDelSel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "删除选课记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labs;
        private System.Windows.Forms.Label labc;
        private System.Windows.Forms.TextBox tbxs;
        private System.Windows.Forms.TextBox tbxc;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btnc;
    }
}