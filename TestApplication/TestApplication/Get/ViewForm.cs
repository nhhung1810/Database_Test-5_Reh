using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication.Get
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from song";
            DataSet ds = Misc.getData(sql);
            if(ds != null && ds.Tables.Count > 0)
            {
                dataGrid.DataSource = ds.Tables[0];
            }
        }
    }
}
