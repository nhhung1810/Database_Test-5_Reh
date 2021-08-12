using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehearsal_CS486_Team11
{
    public partial class AddSongForm : Form
    {
        public AddSongForm(SqlConnection connect)
        {
            InitializeComponent();
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            string sql = $"";
            this.Close();
        }
    }
}
