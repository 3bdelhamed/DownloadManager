using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net;

namespace DownloadManager
{
    public partial class Form1 : Form
    {
        Core.DownloadMan dm = new Core.DownloadMan();
        Core.DownloadFile downloadFile;
        DataTable DataTable;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextLoc.Text = Properties.Settings.Default.PathLocation;
            DataTable = new DataTable();
            CreateLinksTable(DataTable);

        }

        private void CreateLinksTable(DataTable dt)
        {
            dt.Columns.Add("FileName");
            dt.Columns.Add("Url");
            dt.Columns.Add("FileSize");
            dt.Columns.Add("Statues");
            dt.Columns.Add("ProgressValue");

        }
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting Obj = new Setting();
            Obj.Show();
            Obj.Closed += (s, arg) => this.ReloadForm();
        }
        public void ReloadForm()
        {
            TextLoc.Text = Properties.Settings.Default.PathLocation;

        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Task t = DownloadLinks(i);
                t.Wait();
            }
        }

        private async Task DownloadLinks(int i)
        {

            string url = dataGridView1.Rows[i].Cells[1].Value.ToString();
            string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (!File.Exists(name))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri(url), TextLoc.Text + '\\' + name);
                webClient.DownloadProgressChanged += (o, e) => { dataGridView1.Rows[i].Cells[4].Value = e.ProgressPercentage.ToString(); };
                webClient.DownloadFileCompleted += (o, e) => { dataGridView1.Rows[i].Cells[3].Value = "Finsish"; };
            }



        }





        private void FolderBtn_Click(object sender, EventArgs e)
        {
            string directoryPath = TextLoc.Text;


            if (!string.IsNullOrEmpty(directoryPath))
            {

                Process.Start("explorer.exe", directoryPath);
            }
            else
            {

                MessageBox.Show("Directory path is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddListBtn_Click(object sender, EventArgs e)
        {
            if (TxtUrl.Text == "" && NameTb.Text == "" && ExTB.Text == "")
            {
                MessageBox.Show("missing value");
            }
            else
            {
                WebClient webClient = new WebClient();
                string name = NameTb.Text + "." + ExTB.Text;
                downloadFile = new Core.DownloadFile(
                    name,
                    TxtUrl.Text,
                    dm.GetSize(webClient, TxtUrl.Text),
                    "Statues",
                    " 0");

                DataRow dataRow = DataTable.NewRow();
                dataRow["FileName"] = downloadFile.FileName;
                dataRow["Url"] = downloadFile.Url;
                dataRow["FileSize"] = downloadFile.FileSize;
                dataRow["Statues"] = downloadFile.Statues;
                dataRow["ProgressValue"] = downloadFile.ProgressValue;
                DataTable.Rows.Add(dataRow);
                dataGridView1.DataSource = DataTable;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                
                if (dataGridView1.Rows[selectedIndex].Cells["ProgressValue"].Value != null)
                {
                    int progressValue;
                    if (int.TryParse(dataGridView1.Rows[selectedIndex].Cells["ProgressValue"].Value.ToString(), out progressValue))
                    {
                        progressBar1.Value = progressValue;
                    }
                }
            }
        }
    }
}
