namespace Jubeat_Song_Creator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openSongDialog = new System.Windows.Forms.OpenFileDialog();
            this.bgmDirectory = new System.Windows.Forms.TextBox();
            this.songLabel = new System.Windows.Forms.Label();
            this.openSong = new System.Windows.Forms.Button();
            this.openPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.previewDirectory = new System.Windows.Forms.TextBox();
            this.openBasic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.basicDirectory = new System.Windows.Forms.TextBox();
            this.openAdvance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.advancedDirectory = new System.Windows.Forms.TextBox();
            this.openExtreme = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.extremeDirectory = new System.Windows.Forms.TextBox();
            this.openChartDialog = new System.Windows.Forms.OpenFileDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.saveIFSFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openSongDialog
            // 
            this.openSongDialog.Filter = "wave file|*.wav";
            // 
            // bgmDirectory
            // 
            this.bgmDirectory.Location = new System.Drawing.Point(12, 24);
            this.bgmDirectory.Name = "bgmDirectory";
            this.bgmDirectory.ReadOnly = true;
            this.bgmDirectory.Size = new System.Drawing.Size(195, 20);
            this.bgmDirectory.TabIndex = 0;
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(12, 8);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(62, 13);
            this.songLabel.TabIndex = 1;
            this.songLabel.Text = "BGM Song:";
            // 
            // openSong
            // 
            this.openSong.Location = new System.Drawing.Point(213, 24);
            this.openSong.Name = "openSong";
            this.openSong.Size = new System.Drawing.Size(75, 23);
            this.openSong.TabIndex = 2;
            this.openSong.Text = "Open";
            this.openSong.UseVisualStyleBackColor = true;
            this.openSong.Click += new System.EventHandler(this.OpenSong_Click);
            // 
            // openPreview
            // 
            this.openPreview.Location = new System.Drawing.Point(213, 63);
            this.openPreview.Name = "openPreview";
            this.openPreview.Size = new System.Drawing.Size(75, 23);
            this.openPreview.TabIndex = 5;
            this.openPreview.Text = "Open";
            this.openPreview.UseVisualStyleBackColor = true;
            this.openPreview.Click += new System.EventHandler(this.OpenPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preview Song:";
            // 
            // previewDirectory
            // 
            this.previewDirectory.Location = new System.Drawing.Point(12, 63);
            this.previewDirectory.Name = "previewDirectory";
            this.previewDirectory.ReadOnly = true;
            this.previewDirectory.Size = new System.Drawing.Size(195, 20);
            this.previewDirectory.TabIndex = 3;
            // 
            // openBasic
            // 
            this.openBasic.Location = new System.Drawing.Point(213, 103);
            this.openBasic.Name = "openBasic";
            this.openBasic.Size = new System.Drawing.Size(75, 23);
            this.openBasic.TabIndex = 8;
            this.openBasic.Text = "Open";
            this.openBasic.UseVisualStyleBackColor = true;
            this.openBasic.Click += new System.EventHandler(this.OpenBasic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Basic Chart:";
            // 
            // basicDirectory
            // 
            this.basicDirectory.Location = new System.Drawing.Point(12, 103);
            this.basicDirectory.Name = "basicDirectory";
            this.basicDirectory.ReadOnly = true;
            this.basicDirectory.Size = new System.Drawing.Size(195, 20);
            this.basicDirectory.TabIndex = 6;
            // 
            // openAdvance
            // 
            this.openAdvance.Location = new System.Drawing.Point(213, 143);
            this.openAdvance.Name = "openAdvance";
            this.openAdvance.Size = new System.Drawing.Size(75, 23);
            this.openAdvance.TabIndex = 11;
            this.openAdvance.Text = "Open";
            this.openAdvance.UseVisualStyleBackColor = true;
            this.openAdvance.Click += new System.EventHandler(this.OpenAdvance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Advanced Chart:";
            // 
            // advancedDirectory
            // 
            this.advancedDirectory.Location = new System.Drawing.Point(12, 143);
            this.advancedDirectory.Name = "advancedDirectory";
            this.advancedDirectory.ReadOnly = true;
            this.advancedDirectory.Size = new System.Drawing.Size(195, 20);
            this.advancedDirectory.TabIndex = 9;
            // 
            // openExtreme
            // 
            this.openExtreme.Location = new System.Drawing.Point(213, 185);
            this.openExtreme.Name = "openExtreme";
            this.openExtreme.Size = new System.Drawing.Size(75, 23);
            this.openExtreme.TabIndex = 14;
            this.openExtreme.Text = "Open";
            this.openExtreme.UseVisualStyleBackColor = true;
            this.openExtreme.Click += new System.EventHandler(this.OpenExtreme_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Extreme Chart:";
            // 
            // extremeDirectory
            // 
            this.extremeDirectory.Location = new System.Drawing.Point(12, 185);
            this.extremeDirectory.Name = "extremeDirectory";
            this.extremeDirectory.ReadOnly = true;
            this.extremeDirectory.Size = new System.Drawing.Size(195, 20);
            this.extremeDirectory.TabIndex = 12;
            // 
            // openChartDialog
            // 
            this.openChartDialog.Filter = "memon chart file|*.memon|text file|*.txt|All files|*.*";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(58, 219);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(162, 45);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Convert";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // saveIFSFileDialog
            // 
            this.saveIFSFileDialog.Filter = "ifs file|*.ifs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 276);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.openExtreme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.extremeDirectory);
            this.Controls.Add(this.openAdvance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.advancedDirectory);
            this.Controls.Add(this.openBasic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.basicDirectory);
            this.Controls.Add(this.openPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewDirectory);
            this.Controls.Add(this.openSong);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.bgmDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jubeat Song Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openSongDialog;
        private System.Windows.Forms.TextBox bgmDirectory;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.Button openSong;
        private System.Windows.Forms.Button openPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox previewDirectory;
        private System.Windows.Forms.Button openBasic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox basicDirectory;
        private System.Windows.Forms.Button openAdvance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox advancedDirectory;
        private System.Windows.Forms.Button openExtreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox extremeDirectory;
        private System.Windows.Forms.OpenFileDialog openChartDialog;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.SaveFileDialog saveIFSFileDialog;
    }
}

