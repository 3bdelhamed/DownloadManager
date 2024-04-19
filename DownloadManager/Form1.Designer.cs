namespace DownloadManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            settingToolStripMenuItem = new ToolStripMenuItem();
            DownloadBtn = new Button();
            FolderBtn = new Button();
            TxtUrl = new TextBox();
            dataGridView1 = new DataGridView();
            progressBar1 = new ProgressBar();
            TextLoc = new Label();
            AddListBtn = new Button();
            NameTb = new TextBox();
            ExTB = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(133, 118, 255);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(70, 24);
            settingToolStripMenuItem.Text = "Setting";
            settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;
            // 
            // DownloadBtn
            // 
            DownloadBtn.BackColor = Color.FromArgb(131, 111, 255);
            DownloadBtn.FlatStyle = FlatStyle.Popup;
            DownloadBtn.ForeColor = SystemColors.ButtonFace;
            DownloadBtn.Location = new Point(682, 123);
            DownloadBtn.Name = "DownloadBtn";
            DownloadBtn.Size = new Size(94, 29);
            DownloadBtn.TabIndex = 1;
            DownloadBtn.Text = "Download";
            DownloadBtn.UseVisualStyleBackColor = false;
            DownloadBtn.Click += DownloadBtn_Click;
            // 
            // FolderBtn
            // 
            FolderBtn.BackColor = Color.FromArgb(131, 111, 255);
            FolderBtn.FlatStyle = FlatStyle.Popup;
            FolderBtn.ForeColor = SystemColors.ButtonFace;
            FolderBtn.Location = new Point(682, 187);
            FolderBtn.Name = "FolderBtn";
            FolderBtn.Size = new Size(94, 29);
            FolderBtn.TabIndex = 2;
            FolderBtn.Text = "Folder";
            FolderBtn.UseVisualStyleBackColor = false;
            FolderBtn.Click += FolderBtn_Click;
            // 
            // TxtUrl
            // 
            TxtUrl.BackColor = Color.FromArgb(133, 118, 255);
            TxtUrl.BorderStyle = BorderStyle.FixedSingle;
            TxtUrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUrl.Location = new Point(81, 71);
            TxtUrl.Name = "TxtUrl";
            TxtUrl.Size = new Size(280, 34);
            TxtUrl.TabIndex = 3;
            TxtUrl.Text = "enter url";
            TxtUrl.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(133, 118, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(748, 366);
            dataGridView1.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(28, 247);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(748, 29);
            progressBar1.TabIndex = 5;
            // 
            // TextLoc
            // 
            TextLoc.AutoSize = true;
            TextLoc.ForeColor = Color.FromArgb(123, 201, 255);
            TextLoc.Location = new Point(84, 127);
            TextLoc.Name = "TextLoc";
            TextLoc.Size = new Size(0, 20);
            TextLoc.TabIndex = 6;
            // 
            // AddListBtn
            // 
            AddListBtn.BackColor = Color.FromArgb(131, 111, 255);
            AddListBtn.FlatStyle = FlatStyle.Popup;
            AddListBtn.ForeColor = SystemColors.ButtonFace;
            AddListBtn.Location = new Point(682, 71);
            AddListBtn.Name = "AddListBtn";
            AddListBtn.Size = new Size(94, 29);
            AddListBtn.TabIndex = 7;
            AddListBtn.Text = "Add";
            AddListBtn.UseVisualStyleBackColor = false;
            AddListBtn.Click += AddListBtn_Click;
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.FromArgb(133, 118, 255);
            NameTb.BorderStyle = BorderStyle.FixedSingle;
            NameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTb.Location = new Point(378, 71);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(112, 34);
            NameTb.TabIndex = 8;
            NameTb.Text = "enter Name";
            NameTb.TextAlign = HorizontalAlignment.Center;
            // 
            // ExTB
            // 
            ExTB.BackColor = Color.FromArgb(133, 118, 255);
            ExTB.BorderStyle = BorderStyle.FixedSingle;
            ExTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExTB.Location = new Point(510, 71);
            ExTB.Name = "ExTB";
            ExTB.Size = new Size(112, 34);
            ExTB.TabIndex = 9;
            ExTB.Text = " extension";
            ExTB.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 25, 81);
            ClientSize = new Size(800, 684);
            Controls.Add(ExTB);
            Controls.Add(NameTb);
            Controls.Add(AddListBtn);
            Controls.Add(TextLoc);
            Controls.Add(progressBar1);
            Controls.Add(dataGridView1);
            Controls.Add(TxtUrl);
            Controls.Add(FolderBtn);
            Controls.Add(DownloadBtn);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Katakana;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Button DownloadBtn;
        private Button FolderBtn;
        private TextBox TxtUrl;
        private DataGridView dataGridView1;
        private ProgressBar progressBar1;
        private Label TextLoc;
        private ToolStripMenuItem settingToolStripMenuItem;
        private Button AddListBtn;
        private TextBox NameTb;
        private TextBox ExTB;
    }
}
