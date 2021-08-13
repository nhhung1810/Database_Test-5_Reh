using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehearsal_CS486_Team11
{
    class MusicControl : Control
    {
        private int width = 0;
        private int height = 0;
        public MusicControl(string name, string author, bool official, bool sq, string view)
        {
            addControl(new Label { Text = name }, 0, 0, 80);
            addControl(new Label { Text = author }, 20, 0, 40);
            addControl(new Label
            {
                Text = official ? "OFFICIAL" : "",
                AutoSize = true
            }, 20, 0,40);
            addControl(new Label
            {
                ForeColor = sq ? Color.Red : Color.Cyan,
                Text = sq ? "SQ" : "HQ",
                AutoSize = true,
            }, 20, 0);
            addControl(new Label { Text = view }, 20, 0);
            addControl(new Button { Text = "Play" }, 20, 0);
            addControl(new Button { Text = "Like" }, 20, 0);
            addControl(new Button { Text = "Copy" }, 20, 0);

            Width = width;
            Height = 50;
        }

        private void addControl(Control control, int paddingWidth, int paddingHeight, int maxPadding = -1)
        {
            control.Location = new Point(width + paddingWidth, paddingHeight);
            control.Width = control.PreferredSize.Width;
            if (maxPadding != -1) control.Width = maxPadding;
            width += control.Width + paddingWidth;
            height = Math.Max(height,control.Height);
            Controls.Add(control);
        }
    }
}
