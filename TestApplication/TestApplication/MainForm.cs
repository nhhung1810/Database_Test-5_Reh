using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TestApplication.Get.ViewForm;

namespace TestApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Set connection string
            //Note: you only need to set this 1 time, in bellow
            //If you want to change, just replace the current "name" by your name. 
            //Code suggestion will help you with this
            Misc.setConnection(Misc.connectBy.Hung);

            //From now on, you can use the following function to get the connection string, for example:
            string connectionString = Misc.getConnectionString();
            MessageBox.Show(connectionString);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            Get.ViewForm vf = new Get.ViewForm();
            vf.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Set.EditForm ef = new Set.EditForm();
            ef.Show();
        }
    }
}
