namespace Diary
{
    partial class Diario
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diario));
            this.Title = new System.Windows.Forms.RichTextBox();
            this.AddDiaryPage = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TellYourDream = new System.Windows.Forms.RichTextBox();
            this.B = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.titleError = new System.Windows.Forms.Label();
            this.categoryError = new System.Windows.Forms.Label();
            this.tellYourDreamError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.CausesValidation = false;
            this.Title.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Title.Location = new System.Drawing.Point(14, 77);
            this.Title.Margin = new System.Windows.Forms.Padding(2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(323, 27);
            this.Title.TabIndex = 2;
            this.Title.Text = "";
            this.Title.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Title_MouseClick);
            // 
            // AddDiaryPage
            // 
            this.AddDiaryPage.BackColor = System.Drawing.Color.Transparent;
            this.AddDiaryPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDiaryPage.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDiaryPage.Location = new System.Drawing.Point(17, 521);
            this.AddDiaryPage.Margin = new System.Windows.Forms.Padding(2);
            this.AddDiaryPage.Name = "AddDiaryPage";
            this.AddDiaryPage.Size = new System.Drawing.Size(320, 28);
            this.AddDiaryPage.TabIndex = 3;
            this.AddDiaryPage.Text = "Aggiungi Pagina di Diario";
            this.AddDiaryPage.UseVisualStyleBackColor = false;
            this.AddDiaryPage.Click += new System.EventHandler(this.AddDiaryPage_Click);
            // 
            // Category
            // 
            this.Category.AllowDrop = true;
            this.Category.BackColor = System.Drawing.Color.White;
            this.Category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Category.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "incubo"});
            this.Category.Location = new System.Drawing.Point(17, 180);
            this.Category.Margin = new System.Windows.Forms.Padding(2);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(320, 22);
            this.Category.Sorted = true;
            this.Category.TabIndex = 5;
            this.Category.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Category_MouseClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titolo del Sogno:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Racconta il Tuo Sogno:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TellYourDream
            // 
            this.TellYourDream.BackColor = System.Drawing.Color.White;
            this.TellYourDream.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TellYourDream.Location = new System.Drawing.Point(17, 281);
            this.TellYourDream.Margin = new System.Windows.Forms.Padding(2);
            this.TellYourDream.Name = "TellYourDream";
            this.TellYourDream.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TellYourDream.Size = new System.Drawing.Size(320, 227);
            this.TellYourDream.TabIndex = 9;
            this.TellYourDream.Text = "";
            this.TellYourDream.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TellYourDream_MouseClick);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Transparent;
            this.B.ForeColor = System.Drawing.Color.BlueViolet;
            this.B.Image = ((System.Drawing.Image)(resources.GetObject("B.Image")));
            this.B.Location = new System.Drawing.Point(266, 253);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(25, 23);
            this.B.TabIndex = 10;
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // I
            // 
            this.I.Image = ((System.Drawing.Image)(resources.GetObject("I.Image")));
            this.I.Location = new System.Drawing.Point(297, 253);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(25, 23);
            this.I.TabIndex = 11;
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.I_Click);
            // 
            // titleError
            // 
            this.titleError.AutoSize = true;
            this.titleError.BackColor = System.Drawing.Color.Transparent;
            this.titleError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleError.ForeColor = System.Drawing.Color.Red;
            this.titleError.Location = new System.Drawing.Point(82, 61);
            this.titleError.Name = "titleError";
            this.titleError.Size = new System.Drawing.Size(0, 14);
            this.titleError.TabIndex = 12;
            // 
            // categoryError
            // 
            this.categoryError.AutoSize = true;
            this.categoryError.BackColor = System.Drawing.Color.Transparent;
            this.categoryError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryError.ForeColor = System.Drawing.Color.Red;
            this.categoryError.Location = new System.Drawing.Point(91, 164);
            this.categoryError.Name = "categoryError";
            this.categoryError.Size = new System.Drawing.Size(0, 14);
            this.categoryError.TabIndex = 13;
            // 
            // tellYourDreamError
            // 
            this.tellYourDreamError.AutoSize = true;
            this.tellYourDreamError.BackColor = System.Drawing.Color.Transparent;
            this.tellYourDreamError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellYourDreamError.ForeColor = System.Drawing.Color.Red;
            this.tellYourDreamError.Location = new System.Drawing.Point(58, 262);
            this.tellYourDreamError.Name = "tellYourDreamError";
            this.tellYourDreamError.Size = new System.Drawing.Size(0, 14);
            this.tellYourDreamError.TabIndex = 14;
            // 
            // Diario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(349, 559);
            this.ControlBox = false;
            this.Controls.Add(this.tellYourDreamError);
            this.Controls.Add(this.categoryError);
            this.Controls.Add(this.titleError);
            this.Controls.Add(this.I);
            this.Controls.Add(this.B);
            this.Controls.Add(this.TellYourDream);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.AddDiaryPage);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Diario";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = " ";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox Title;
        private System.Windows.Forms.Button AddDiaryPage;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox TellYourDream;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Label titleError;
        private System.Windows.Forms.Label categoryError;
        private System.Windows.Forms.Label tellYourDreamError;
    }
}

