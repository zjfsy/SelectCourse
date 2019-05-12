using System;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class DialogAbout : Form
    {
        public DialogAbout()
        {
            InitializeComponent();
        }
        private void OKClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
