namespace SelectCourse
{
    partial class DialogSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSign));
            this.signOK = new System.Windows.Forms.Button();
            this.signCL = new System.Windows.Forms.Button();
            this.untext = new System.Windows.Forms.TextBox();
            this.pwtext = new System.Windows.Forms.TextBox();
            this.unlable = new System.Windows.Forms.Label();
            this.pwlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signOK
            // 
            this.signOK.Location = new System.Drawing.Point(60, 144);
            this.signOK.Name = "signOK";
            this.signOK.Size = new System.Drawing.Size(75, 23);
            this.signOK.TabIndex = 0;
            this.signOK.Text = "确认";
            this.signOK.UseVisualStyleBackColor = true;
            this.signOK.Click += new System.EventHandler(this.OKClicked);
            // 
            // signCL
            // 
            this.signCL.Location = new System.Drawing.Point(169, 144);
            this.signCL.Name = "signCL";
            this.signCL.Size = new System.Drawing.Size(75, 23);
            this.signCL.TabIndex = 1;
            this.signCL.Text = "取消";
            this.signCL.UseVisualStyleBackColor = true;
            this.signCL.Click += new System.EventHandler(this.CLClicked);
            // 
            // untext
            // 
            this.untext.Location = new System.Drawing.Point(120, 56);
            this.untext.Name = "untext";
            this.untext.Size = new System.Drawing.Size(100, 21);
            this.untext.TabIndex = 2;
            // 
            // pwtext
            // 
            this.pwtext.Location = new System.Drawing.Point(120, 96);
            this.pwtext.Name = "pwtext";
            this.pwtext.PasswordChar = '*';
            this.pwtext.Size = new System.Drawing.Size(100, 21);
            this.pwtext.TabIndex = 3;
            // 
            // unlable
            // 
            this.unlable.AutoSize = true;
            this.unlable.BackColor = System.Drawing.Color.Transparent;
            this.unlable.Location = new System.Drawing.Point(72, 60);
            this.unlable.Name = "unlable";
            this.unlable.Size = new System.Drawing.Size(41, 12);
            this.unlable.TabIndex = 4;
            this.unlable.Text = "用户名";
            // 
            // pwlable
            // 
            this.pwlable.AutoSize = true;
            this.pwlable.BackColor = System.Drawing.Color.Transparent;
            this.pwlable.Location = new System.Drawing.Point(72, 100);
            this.pwlable.Name = "pwlable";
            this.pwlable.Size = new System.Drawing.Size(41, 12);
            this.pwlable.TabIndex = 5;
            this.pwlable.Text = "密　码";
            // 
            // DialogSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SelectCourse.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.pwlable);
            this.Controls.Add(this.unlable);
            this.Controls.Add(this.pwtext);
            this.Controls.Add(this.untext);
            this.Controls.Add(this.signCL);
            this.Controls.Add(this.signOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DialogSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signOK;
        private System.Windows.Forms.TextBox untext;
        private System.Windows.Forms.TextBox pwtext;
        private System.Windows.Forms.Label unlable;
        private System.Windows.Forms.Label pwlable;
        private System.Windows.Forms.Button signCL;
    }
}