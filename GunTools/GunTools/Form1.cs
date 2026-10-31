using GunTools.Tools;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StaticsMgr.CurrentPath = Application.StartupPath;
            StaticsMgr.TempPath = StaticsMgr.CurrentPath + "\\temp\\";
            StaticsMgr.SqlQueryPath = StaticsMgr.CurrentPath + "\\QueryGenarate\\";
            StaticsMgr.DownloadPath = StaticsMgr.CurrentPath + "\\temp/Download\\";
        }
        private void btn_XmlTools_Click(object sender, EventArgs e)
        {

        }
        private void btnReqTools_Click(object sender, EventArgs e)
        {
            panel_Control.Controls.Clear();
            panel_Control.Controls.Add(new UserControl_RequestTools() { Dock = DockStyle.Fill});
        }
        
    }
}
