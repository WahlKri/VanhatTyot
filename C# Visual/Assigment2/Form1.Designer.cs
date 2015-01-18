namespace Assigment2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxDirectorInfo = new System.Windows.Forms.GroupBox();
            this.gBoxMovieDetails = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lBoxMovies = new System.Windows.Forms.ListBox();
            this.btnAddNewMovie = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnShowActors = new System.Windows.Forms.Button();
            this.pBoxStar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gBoxMovieDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programInfoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // programInfoToolStripMenuItem
            // 
            this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            this.programInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.programInfoToolStripMenuItem.Text = "Program info";
            this.programInfoToolStripMenuItem.Click += new System.EventHandler(this.programInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // gBoxDirectorInfo
            // 
            this.gBoxDirectorInfo.Location = new System.Drawing.Point(352, 56);
            this.gBoxDirectorInfo.Name = "gBoxDirectorInfo";
            this.gBoxDirectorInfo.Size = new System.Drawing.Size(355, 208);
            this.gBoxDirectorInfo.TabIndex = 1;
            this.gBoxDirectorInfo.TabStop = false;
            this.gBoxDirectorInfo.Text = "Director information";
            // 
            // gBoxMovieDetails
            // 
            this.gBoxMovieDetails.Controls.Add(this.pBoxStar);
            this.gBoxMovieDetails.Location = new System.Drawing.Point(352, 268);
            this.gBoxMovieDetails.Name = "gBoxMovieDetails";
            this.gBoxMovieDetails.Size = new System.Drawing.Size(355, 258);
            this.gBoxMovieDetails.TabIndex = 2;
            this.gBoxMovieDetails.TabStop = false;
            this.gBoxMovieDetails.Text = "Movie details";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(614, 548);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit details";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lBoxMovies
            // 
            this.lBoxMovies.FormattingEnabled = true;
            this.lBoxMovies.Location = new System.Drawing.Point(12, 56);
            this.lBoxMovies.Name = "lBoxMovies";
            this.lBoxMovies.Size = new System.Drawing.Size(333, 433);
            this.lBoxMovies.TabIndex = 4;
            // 
            // btnAddNewMovie
            // 
            this.btnAddNewMovie.Location = new System.Drawing.Point(12, 548);
            this.btnAddNewMovie.Name = "btnAddNewMovie";
            this.btnAddNewMovie.Size = new System.Drawing.Size(115, 23);
            this.btnAddNewMovie.TabIndex = 5;
            this.btnAddNewMovie.Text = "Add new movie";
            this.btnAddNewMovie.UseVisualStyleBackColor = true;
            this.btnAddNewMovie.Click += new System.EventHandler(this.btnAddNewMovie_Click);
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(236, 548);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveMovie.TabIndex = 6;
            this.btnRemoveMovie.Text = "Remove movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(349, 38);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "Details";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(9, 38);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(41, 13);
            this.lblMovies.TabIndex = 8;
            this.lblMovies.Text = "Movies";
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Location = new System.Drawing.Point(133, 495);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(213, 20);
            this.tBoxSearch.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 498);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(121, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search movie by name: ";
            // 
            // btnShowActors
            // 
            this.btnShowActors.Location = new System.Drawing.Point(614, 27);
            this.btnShowActors.Name = "btnShowActors";
            this.btnShowActors.Size = new System.Drawing.Size(93, 23);
            this.btnShowActors.TabIndex = 11;
            this.btnShowActors.Text = "Show actors";
            this.btnShowActors.UseVisualStyleBackColor = true;
            // 
            // pBoxStar
            // 
            this.pBoxStar.Location = new System.Drawing.Point(6, 201);
            this.pBoxStar.Name = "pBoxStar";
            this.pBoxStar.Size = new System.Drawing.Size(65, 51);
            this.pBoxStar.TabIndex = 0;
            this.pBoxStar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 583);
            this.Controls.Add(this.btnShowActors);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tBoxSearch);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.btnAddNewMovie);
            this.Controls.Add(this.lBoxMovies);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gBoxMovieDetails);
            this.Controls.Add(this.gBoxDirectorInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Movie Ratings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxMovieDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxDirectorInfo;
        private System.Windows.Forms.GroupBox gBoxMovieDetails;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox lBoxMovies;
        private System.Windows.Forms.Button btnAddNewMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnShowActors;
        private System.Windows.Forms.PictureBox pBoxStar;
    }
}

