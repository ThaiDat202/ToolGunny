using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunLauncher
{
    internal class ToolStripOverride : ToolStripProfessionalRenderer
    {
        public ToolStripOverride() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {

        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected)
            {
                base.OnRenderButtonBackground(e);
            }
            else
            {
                Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(102, 102, 102)), rectangle);
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(102, 102, 102)), rectangle);
            }
        }


    }
}
