using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rehearsal_CS486_Team11
{
    public partial class FormKhoa : Form
    {
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            flpMusicList.AutoScroll = true;
            flpMusicList.FlowDirection = FlowDirection.TopDown;
            flpMusicList.WrapContents = false;
            initMusicList();
        }
        public void initMusicList()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-SMBGUUTC\SQLEXPRESS01;Initial Catalog=CS468_team11_DB;Integrated Security=True");
                cnn.Open();
                string sql = "select * from Category where id = Parentid";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
                DataSet data = new DataSet();
                adapter.Fill(data);
                if (data.Tables.Count > 0)
                {
                    foreach(DataRow row in data.Tables[0].Rows)
                    {
                        int[] catID;
                        string[] childCatName = null;
                        DataSet dataTmp = new DataSet();
                        sql = "select * from Category where id <> Parenid and Parentid = "
                            + row[0].ToString();
                        adapter = new SqlDataAdapter(sql, cnn);
                        if(dataTmp.Tables.Count > 0)
                        {
                            int countUp = 0;
                            catID = new int[dataTmp.Tables[0].Rows.Count];
                            childCatName = new string[dataTmp.Tables[0].Rows.Count];
                            foreach(DataRow rowTmp in dataTmp.Tables[0].Rows)
                            {
                                catID[countUp] = int.Parse(rowTmp[0].ToString());
                                childCatName[countUp] = rowTmp[1].ToString();
                            }
                            addSong(dataTmp.Tables[0].Rows.Count, row[1].ToString(), childCatName, catID);
                        } 
                    }
                }

                cnn.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString());
            }
        }
        private Label _mainCategory;
        private Button[] _childCategory = null;
        public void addSong(int nbCategory, string mainCategory, string[] childCategory, int[] catID)
        {
            if (nbCategory < 1 || nbCategory != childCategory.Length)
                return;
            int width = 0;
            _childCategory = new Button[nbCategory];
            _mainCategory = new Label { Text = mainCategory };
            _mainCategory.Location = new Point(0, 0);
            _mainCategory.Height = 50;
            _mainCategory.FlatStyle = FlatStyle.Flat;
            _mainCategory.ForeColor = Color.Blue;
            _mainCategory.Font = new Font("Georgia", 12);
            width += _mainCategory.Width + 20;

            for (int i = 0; i < nbCategory; i++)
            {
                _childCategory[i] = new Button();
                _childCategory[i].Text = childCategory[i];
                _childCategory[i].Location = new Point(width, 0);
                _childCategory[i].Name = catID[i].ToString();
                _childCategory[i].Click += new EventHandler(button_click);
                width += _childCategory[i].Width + 20;
            }

            FlowLayoutPanel flpTmp = new FlowLayoutPanel();
            flpTmp.Height = _mainCategory.Height;
            flpTmp.Width = width + 20;
            flpTmp.Controls.Add(_mainCategory);
            for (int i = 0; i < nbCategory; i++)
                flpTmp.Controls.Add(_childCategory[i]);

            flpMusicList.Controls.Add(flpTmp);
        }
        public void button_click(object sender, EventArgs s)
        {
            Button button = sender as Button;
            clrHotSongPanel();
            //initHotSongPanel(int.Parse(button.Name));
        }
        public void clrHotSongPanel()
        {
            //hotSongPanel.Controls.Clear();
        }
    }
}
