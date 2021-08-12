using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehearsal_CS486_Team11
{
    public partial class MusicList : Form
    {
        public MusicList()
        {
            InitializeComponent();
        }

        public void LoadMusic(int index)
        {
            //Connecting to database

            //Setting up the panel
            flowPanel.Controls.Clear();
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.AutoScroll = true;
            flowPanel.WrapContents = false;
            //
            for(int i = 0; i < 100; i++)
            flowPanel.Controls.Add(new MusicControl("Bacon", "Bacon", true, true, "10213123"));
        }

        private void MusicList_Load(object sender, EventArgs e)
        {
            LoadMusic(0);
        }

        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
