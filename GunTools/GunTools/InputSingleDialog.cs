using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunTools
{
    public partial class InputSingleDialog : Form
    {
        public string Result = "";
        public InputSingleDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result = textBox.Text;
            if (Result == "")
            {
                if (MessageBox.Show("", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnCancel_Click(null, null);
                }

            }
            else
            {
                btnCancel_Click(null, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }
    }
}
