namespace Playlist_Exemplos.Net
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox_Playlist = new System.Windows.Forms.ListBox();
            this.listBox_Favorites = new System.Windows.Forms.ListBox();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.buttonAddFavorites = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox_Playlist
            // 
            this.listBox_Playlist.FormattingEnabled = true;
            this.listBox_Playlist.Location = new System.Drawing.Point(21, 404);
            this.listBox_Playlist.Name = "listBox_Playlist";
            this.listBox_Playlist.Size = new System.Drawing.Size(485, 121);
            this.listBox_Playlist.TabIndex = 2;
            this.listBox_Playlist.SelectedIndexChanged += new System.EventHandler(this.listBox_Playlist_SelectedIndexChanged);
            // 
            // listBox_Favorites
            // 
            this.listBox_Favorites.FormattingEnabled = true;
            this.listBox_Favorites.Location = new System.Drawing.Point(21, 582);
            this.listBox_Favorites.Name = "listBox_Favorites";
            this.listBox_Favorites.Size = new System.Drawing.Size(485, 121);
            this.listBox_Favorites.TabIndex = 3;
            this.listBox_Favorites.SelectedIndexChanged += new System.EventHandler(this.listBox_Favorites_SelectedIndexChanged);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(407, 375);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(99, 23);
            this.buttonAddFiles.TabIndex = 4;
            this.buttonAddFiles.Text = "Add Files";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // buttonAddFavorites
            // 
            this.buttonAddFavorites.Location = new System.Drawing.Point(385, 553);
            this.buttonAddFavorites.Name = "buttonAddFavorites";
            this.buttonAddFavorites.Size = new System.Drawing.Size(121, 23);
            this.buttonAddFavorites.TabIndex = 5;
            this.buttonAddFavorites.Text = "Add Files to Favorites";
            this.buttonAddFavorites.UseVisualStyleBackColor = true;
            this.buttonAddFavorites.Click += new System.EventHandler(this.buttonAddFavorites_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(407, 709);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(99, 23);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load Favorites";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(302, 709);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save Favorites";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(197, 709);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear Favorites";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(21, 46);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(485, 249);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(407, 301);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(99, 23);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(302, 301);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(99, 23);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 740);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonAddFavorites);
            this.Controls.Add(this.buttonAddFiles);
            this.Controls.Add(this.listBox_Favorites);
            this.Controls.Add(this.listBox_Playlist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox_Playlist;
        private System.Windows.Forms.ListBox listBox_Favorites;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.Button buttonAddFavorites;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
    }
}

