using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunTools.Tools
{
    public partial class UserControl_RequestTools : UserControl
    {
        List<string> xmlName = new List<string>();
        public UserControl_RequestTools()
        {
            InitializeComponent();
            txtLinkRequest.Text = ConfigurationManager.AppSettings["LinkRequest"];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (var item in xmlName)
            {
                string file = txtLinkRequest.Text + "/" + item + ".xml";
                Log("Download: " + file, Color.Gray);
                file = new NetWorkFunc().DownLoadFile(file);
                Log("Download Complete: " + file, Color.Green);

                Log("Download: " + file, Color.Gray);
                csFunction.GenarateSqlQuery(file, this, textBox1.Text, checkBox4.Checked, checkBox3.Checked);

                Log("Create SQL complete: " + item, Color.Gray);
            }
            Process.Start(StaticsMgr.SqlQueryPath);
        }
        InputSingleDialog dialog = new InputSingleDialog();
        private void btnInputName_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            if(dialog.Result != "")
            {
                xmlName.Add(dialog.Result);
                flowLayoutPanel1.Controls.Add(new Label() { Text = xmlName.Last() });
                Log("Input: " + xmlName.Last(), null);
            }
        }

        public void Log(string text, Color? color)
        {
            if(color == null)
            {
                color = Color.Black;
            }
            richTextBox1.SelectionColor = (Color)color;
            richTextBox1.SelectedText += text + "\r\n";
            richTextBox1.SelectionColor = Color.Black;
            if(richTextBox1.TextLength > richTextBox1.MaxLength)
            {
                richTextBox1.ResetText();
            }
            richTextBox1.ScrollToCaret();
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                csFunction.GenarateSqlQuery(path, this, textBox1.Text, checkBox4.Checked, checkBox3.Checked, false);
                Process.Start(StaticsMgr.SqlQueryPath);
            }
        }
    }
}
