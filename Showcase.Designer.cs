namespace Diary
{
    partial class Showcase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Showcase));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Indice = new System.Windows.Forms.Button();
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Button();
            this.Stats = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.SeeArchive = new System.Windows.Forms.Label();
            this.PictureArchive = new System.Windows.Forms.PictureBox();
            this.Archive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IndicePicture = new System.Windows.Forms.PictureBox();
            this.OpenIndice = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.SearchAll = new System.Windows.Forms.Label();
            this.SearchPicture = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout,
            this.Settings,
            this.Help});
            this.Menu.Location = new System.Drawing.Point(16, 9);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(209, 24);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Menu";
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(45, 20);
            this.Logout.Text = "ESCI";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Settings
            // 
            this.Settings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(101, 20);
            this.Settings.Text = "IMPOSTAZIONI";
            // 
            // Help
            // 
            this.Help.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.White;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(54, 20);
            this.Help.Text = "AIUTO";
            // 
            // Indice
            // 
            this.Indice.BackColor = System.Drawing.Color.Gold;
            this.Indice.Font = new System.Drawing.Font("AR CENA", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indice.ForeColor = System.Drawing.Color.Transparent;
            this.Indice.Location = new System.Drawing.Point(283, 47);
            this.Indice.Margin = new System.Windows.Forms.Padding(2);
            this.Indice.Name = "Indice";
            this.Indice.Size = new System.Drawing.Size(250, 145);
            this.Indice.TabIndex = 6;
            this.Indice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Indice.UseVisualStyleBackColor = false;
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ArchiveButton.Font = new System.Drawing.Font("AR CENA", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveButton.ForeColor = System.Drawing.Color.White;
            this.ArchiveButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ArchiveButton.Location = new System.Drawing.Point(16, 47);
            this.ArchiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(249, 145);
            this.ArchiveButton.TabIndex = 7;
            this.ArchiveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ArchiveButton.UseVisualStyleBackColor = false;
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.Color.LimeGreen;
            this.Categories.ForeColor = System.Drawing.Color.Transparent;
            this.Categories.Location = new System.Drawing.Point(283, 294);
            this.Categories.Margin = new System.Windows.Forms.Padding(2);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(243, 87);
            this.Categories.TabIndex = 8;
            this.Categories.Text = "ELENCO CATEGORIE";
            this.Categories.UseVisualStyleBackColor = false;
            // 
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Stats.ForeColor = System.Drawing.Color.Transparent;
            this.Stats.Location = new System.Drawing.Point(276, 207);
            this.Stats.Margin = new System.Windows.Forms.Padding(2);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(250, 87);
            this.Stats.TabIndex = 9;
            this.Stats.Text = "STATISTICHE";
            this.Stats.UseVisualStyleBackColor = false;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.BlueViolet;
            this.Insert.ForeColor = System.Drawing.Color.Transparent;
            this.Insert.Location = new System.Drawing.Point(16, 369);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(250, 88);
            this.Insert.TabIndex = 10;
            this.Insert.Text = "INSERISCI SOGNO";
            this.Insert.UseVisualStyleBackColor = false;
            // 
            // SeeArchive
            // 
            this.SeeArchive.BackColor = System.Drawing.Color.DarkOrange;
            this.SeeArchive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeArchive.ForeColor = System.Drawing.Color.White;
            this.SeeArchive.Location = new System.Drawing.Point(148, 59);
            this.SeeArchive.Name = "SeeArchive";
            this.SeeArchive.Size = new System.Drawing.Size(107, 59);
            this.SeeArchive.TabIndex = 12;
            this.SeeArchive.Text = "Consulta archivio dei sogni vecchi";
            // 
            // PictureArchive
            // 
            this.PictureArchive.BackColor = System.Drawing.Color.DarkOrange;
            this.PictureArchive.Image = ((System.Drawing.Image)(resources.GetObject("PictureArchive.Image")));
            this.PictureArchive.Location = new System.Drawing.Point(35, 59);
            this.PictureArchive.Name = "PictureArchive";
            this.PictureArchive.Size = new System.Drawing.Size(107, 108);
            this.PictureArchive.TabIndex = 13;
            this.PictureArchive.TabStop = false;
            // 
            // Archive
            // 
            this.Archive.AutoSize = true;
            this.Archive.BackColor = System.Drawing.Color.DarkOrange;
            this.Archive.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archive.ForeColor = System.Drawing.Color.White;
            this.Archive.Location = new System.Drawing.Point(32, 170);
            this.Archive.Name = "Archive";
            this.Archive.Size = new System.Drawing.Size(60, 16);
            this.Archive.TabIndex = 14;
            this.Archive.Text = "Archivio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Indice";
            // 
            // IndicePicture
            // 
            this.IndicePicture.BackColor = System.Drawing.Color.Gold;
            this.IndicePicture.Image = ((System.Drawing.Image)(resources.GetObject("IndicePicture.Image")));
            this.IndicePicture.Location = new System.Drawing.Point(300, 56);
            this.IndicePicture.Name = "IndicePicture";
            this.IndicePicture.Size = new System.Drawing.Size(102, 111);
            this.IndicePicture.TabIndex = 16;
            this.IndicePicture.TabStop = false;
            // 
            // OpenIndice
            // 
            this.OpenIndice.BackColor = System.Drawing.Color.Gold;
            this.OpenIndice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenIndice.ForeColor = System.Drawing.Color.White;
            this.OpenIndice.Location = new System.Drawing.Point(408, 56);
            this.OpenIndice.Name = "OpenIndice";
            this.OpenIndice.Size = new System.Drawing.Size(102, 62);
            this.OpenIndice.TabIndex = 17;
            this.OpenIndice.Text = "Consulta il diario dei sogni";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DeepPink;
            this.SearchButton.Font = new System.Drawing.Font("AR CENA", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchButton.Location = new System.Drawing.Point(16, 207);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(249, 145);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.DeepPink;
            this.Search.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(35, 329);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(45, 16);
            this.Search.TabIndex = 19;
            this.Search.Text = "Cerca";
            // 
            // SearchAll
            // 
            this.SearchAll.BackColor = System.Drawing.Color.DeepPink;
            this.SearchAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAll.Location = new System.Drawing.Point(149, 224);
            this.SearchAll.Name = "SearchAll";
            this.SearchAll.Size = new System.Drawing.Size(95, 43);
            this.SearchAll.TabIndex = 20;
            this.SearchAll.Text = "Ricerca specifica";
            // 
            // SearchPicture
            // 
            this.SearchPicture.BackColor = System.Drawing.Color.DeepPink;
            this.SearchPicture.Image = ((System.Drawing.Image)(resources.GetObject("SearchPicture.Image")));
            this.SearchPicture.Location = new System.Drawing.Point(35, 224);
            this.SearchPicture.Name = "SearchPicture";
            this.SearchPicture.Size = new System.Drawing.Size(108, 102);
            this.SearchPicture.TabIndex = 21;
            this.SearchPicture.TabStop = false;
            // 
            // Showcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(551, 499);
            this.Controls.Add(this.SearchPicture);
            this.Controls.Add(this.SearchAll);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OpenIndice);
            this.Controls.Add(this.IndicePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Archive);
            this.Controls.Add(this.PictureArchive);
            this.Controls.Add(this.SeeArchive);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.ArchiveButton);
            this.Controls.Add(this.Indice);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Showcase";
            this.RightToLeftLayout = true;
            this.Text = "Bacheca";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Showcase_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Showcase_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Showcase_MouseUp);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndicePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.Button Indice;
        private System.Windows.Forms.Button ArchiveButton;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.Button Stats;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label SeeArchive;
        private System.Windows.Forms.PictureBox PictureArchive;
        private System.Windows.Forms.Label Archive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox IndicePicture;
        private System.Windows.Forms.Label OpenIndice;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label SearchAll;
        private System.Windows.Forms.PictureBox SearchPicture;
    }
}