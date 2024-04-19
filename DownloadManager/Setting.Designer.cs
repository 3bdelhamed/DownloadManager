namespace DownloadManager
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChooseBtn = new Button();
            textBox1 = new TextBox();
            SaveBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ChooseBtn
            // 
            ChooseBtn.Location = new Point(35, 146);
            ChooseBtn.Name = "ChooseBtn";
            ChooseBtn.Size = new Size(94, 29);
            ChooseBtn.TabIndex = 0;
            ChooseBtn.Text = "Choose";
            ChooseBtn.UseVisualStyleBackColor = true;
            ChooseBtn.Click += ChooseBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 1;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(35, 362);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(217, 81);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Choose location";
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 3, 59);
            ClientSize = new Size(390, 450);
            Controls.Add(label1);
            Controls.Add(SaveBtn);
            Controls.Add(textBox1);
            Controls.Add(ChooseBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Setting";
            Text = "Setting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChooseBtn;
        private TextBox textBox1;
        private Button SaveBtn;
        private Label label1;
    }
}