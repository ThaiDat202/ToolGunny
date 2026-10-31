using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStrip1.Renderer = new ToolStripOverride();
            InitializeChromium();
        }
        ChromiumWebBrowser chromeBrowser;
        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            string PepPath = Path.Combine(Directory.GetCurrentDirectory(), @"resources\plugins\pepflashplayer32.0.0.371.dll");
            //string PepVer = "29.0.0.171";
            string PepVer = "32.0.0.371";

            settings.CefCommandLineArgs.Add("ppapi-flash-path", PepPath);
            settings.CefCommandLineArgs.Add("ppapi-flash-version", PepVer);
            settings.CefCommandLineArgs["plugin-policy"] = "allow";
            settings.CefCommandLineArgs["-enable-system-flash"] = "true";

            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF\GUNNY";
            settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36 /CefSharp Browser" + Cef.CefSharpVersion;
            settings.PersistSessionCookies = true;

            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
            chromeBrowser = new ChromiumWebBrowser(@"http://127.0.0.1/"); //The game that I'm testing

            panel1.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

        }
        private void toolStripButton_Refesh_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        private void toolStripButton_ClearCahce_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF\GUNNY"))
                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF\GUNNY", true);
        }

        private void toolStripButton_DevTool_Click(object sender, EventArgs e)
        {
            chromeBrowser.ShowDevTools();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
