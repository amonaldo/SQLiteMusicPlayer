namespace SQLiteMusicPlayer
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.artist = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.title = new MetroFramework.Controls.MetroTextBox();
            this.browser = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.audio1 = new SQLiteMusicPlayer.Audio();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Name = "metroLabel1";
            // 
            // artist
            // 
            // 
            // 
            // 
            this.artist.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.artist.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.artist.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.artist.CustomButton.Name = "";
            this.artist.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.artist.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.artist.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.artist.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.artist.CustomButton.UseSelectable = true;
            this.artist.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.artist.Lines = new string[0];
            resources.ApplyResources(this.artist, "artist");
            this.artist.MaxLength = 32767;
            this.artist.Name = "artist";
            this.artist.PasswordChar = '\0';
            this.artist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.artist.SelectedText = "";
            this.artist.SelectionLength = 0;
            this.artist.SelectionStart = 0;
            this.artist.ShortcutsEnabled = true;
            this.artist.UseSelectable = true;
            this.artist.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.artist.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Name = "metroLabel2";
            // 
            // title
            // 
            // 
            // 
            // 
            this.title.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.title.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.title.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.title.CustomButton.Name = "";
            this.title.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.title.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.title.CustomButton.UseSelectable = true;
            this.title.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.title.Lines = new string[0];
            resources.ApplyResources(this.title, "title");
            this.title.MaxLength = 32767;
            this.title.Name = "title";
            this.title.PasswordChar = '\0';
            this.title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.title.SelectedText = "";
            this.title.SelectionLength = 0;
            this.title.SelectionStart = 0;
            this.title.ShortcutsEnabled = true;
            this.title.UseSelectable = true;
            this.title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // browser
            // 
            resources.ApplyResources(this.browser, "browser");
            this.browser.Name = "browser";
            this.browser.UseSelectable = true;
            this.browser.Click += new System.EventHandler(this.browser_Click);
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Name = "metroLabel3";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // audio1
            // 
            this.audio1.BackColor = System.Drawing.Color.White;
            this.audio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.audio1, "audio1");
            this.audio1.Name = "audio1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.audio1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.title);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.artist);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox artist;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox title;
        private MetroFramework.Controls.MetroButton browser;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Audio audio1;

    }
}

