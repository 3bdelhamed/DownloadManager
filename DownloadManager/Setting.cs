using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            DialogResult = Fbd.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                textBox1.Text = Fbd.SelectedPath;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["PathLocation"] = textBox1.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
