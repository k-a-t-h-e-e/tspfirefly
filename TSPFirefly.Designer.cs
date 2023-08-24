namespace TSPFirefly
{
    partial class TSPFirefly
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_File = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.find_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.length_label = new System.Windows.Forms.Label();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.time_label = new System.Windows.Forms.Label();
            this.EditTSPdata = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_File});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // Open_File
            // 
            this.Open_File.Name = "Open_File";
            this.Open_File.Size = new System.Drawing.Size(103, 22);
            this.Open_File.Text = "Open";
            this.Open_File.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "TSP Files|*.tsp";
            // 
            // find_btn
            // 
            this.find_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.find_btn.Location = new System.Drawing.Point(379, 219);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(124, 25);
            this.find_btn.TabIndex = 4;
            this.find_btn.Text = "Calculate an optimal path";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(509, 219);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(124, 25);
            this.del_btn.TabIndex = 5;
            this.del_btn.Text = "Clear Data";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 58);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(621, 155);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // length_label
            // 
            this.length_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.length_label.AutoSize = true;
            this.length_label.Location = new System.Drawing.Point(35, 42);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(64, 13);
            this.length_label.TabIndex = 7;
            this.length_label.Text = "Path length:";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(433, 42);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(36, 13);
            this.time_label.TabIndex = 14;
            this.time_label.Text = "Time: ";
            // 
            // EditTSPdata
            // 
            this.EditTSPdata.Location = new System.Drawing.Point(12, 219);
            this.EditTSPdata.Name = "EditTSPdata";
            this.EditTSPdata.Size = new System.Drawing.Size(123, 25);
            this.EditTSPdata.TabIndex = 21;
            this.EditTSPdata.Text = "Open TSP file";
            this.EditTSPdata.UseVisualStyleBackColor = true;
            this.EditTSPdata.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(141, 219);
            this.progressBar.Maximum = 511;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(213, 25);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 13;
            this.progressBar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Iterations";
            this.label2.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditTSPdata);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.length_label);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.find_btn);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainForm";
            this.Text = "TSP FIREFLY";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.ToolStripMenuItem Open_File;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button EditTSPdata;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
    }
}

