using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_FormaFlix
{
    public partial class FormAjoutUser : Form
    {
        public FormAjoutUser()
        {
            InitializeComponent();
        }

        private void FormAjoutSuperUser_Load(object sender, EventArgs e)
        {

        }

        private void help_MouseHover(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {
            lblHelpMessage.Visible = true;
        }
    }
}
