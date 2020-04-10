namespace AITLibrary
{
    partial class MasterMaintainanceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.genreGridView = new System.Windows.Forms.DataGridView();
            this.genreAdd = new System.Windows.Forms.Button();
            this.newGenre = new System.Windows.Forms.TextBox();
            this.selectedView = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.updateGenre = new System.Windows.Forms.TextBox();
            this.updateGen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedLanguage = new System.Windows.Forms.Label();
            this.languageMaintainanceView = new System.Windows.Forms.DataGridView();
            this.directorMaintainanceView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newLanguage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteLanguage = new System.Windows.Forms.Button();
            this.updateLanguageTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.newDirector = new System.Windows.Forms.TextBox();
            this.addDirector = new System.Windows.Forms.Button();
            this.deleteDirector = new System.Windows.Forms.Button();
            this.updateDirector = new System.Windows.Forms.TextBox();
            this.updateDirectorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageMaintainanceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorMaintainanceView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre Maintainance";
            // 
            // genreGridView
            // 
            this.genreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreGridView.Location = new System.Drawing.Point(25, 61);
            this.genreGridView.Margin = new System.Windows.Forms.Padding(2);
            this.genreGridView.Name = "genreGridView";
            this.genreGridView.RowHeadersWidth = 82;
            this.genreGridView.RowTemplate.Height = 33;
            this.genreGridView.Size = new System.Drawing.Size(252, 194);
            this.genreGridView.TabIndex = 1;
            this.genreGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GenreGridView_CellClick);
            // 
            // genreAdd
            // 
            this.genreAdd.Location = new System.Drawing.Point(294, 89);
            this.genreAdd.Margin = new System.Windows.Forms.Padding(2);
            this.genreAdd.Name = "genreAdd";
            this.genreAdd.Size = new System.Drawing.Size(86, 23);
            this.genreAdd.TabIndex = 2;
            this.genreAdd.Text = "Add Genre";
            this.genreAdd.UseVisualStyleBackColor = true;
            this.genreAdd.Click += new System.EventHandler(this.genreAdd_Click);
            // 
            // newGenre
            // 
            this.newGenre.Location = new System.Drawing.Point(294, 61);
            this.newGenre.Margin = new System.Windows.Forms.Padding(2);
            this.newGenre.Name = "newGenre";
            this.newGenre.Size = new System.Drawing.Size(121, 20);
            this.newGenre.TabIndex = 3;
            // 
            // selectedView
            // 
            this.selectedView.AutoSize = true;
            this.selectedView.Location = new System.Drawing.Point(360, 10);
            this.selectedView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedView.Name = "selectedView";
            this.selectedView.Size = new System.Drawing.Size(55, 13);
            this.selectedView.TabIndex = 4;
            this.selectedView.Text = "Selected :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Selected Genre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // updateGenre
            // 
            this.updateGenre.Location = new System.Drawing.Point(294, 163);
            this.updateGenre.Margin = new System.Windows.Forms.Padding(2);
            this.updateGenre.Name = "updateGenre";
            this.updateGenre.Size = new System.Drawing.Size(121, 20);
            this.updateGenre.TabIndex = 6;
            // 
            // updateGen
            // 
            this.updateGen.Location = new System.Drawing.Point(294, 197);
            this.updateGen.Margin = new System.Windows.Forms.Padding(2);
            this.updateGen.Name = "updateGen";
            this.updateGen.Size = new System.Drawing.Size(110, 23);
            this.updateGen.TabIndex = 7;
            this.updateGen.Text = "Update Genre";
            this.updateGen.UseVisualStyleBackColor = true;
            this.updateGen.Click += new System.EventHandler(this.UpdateGen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Language Maintainance :";
            // 
            // selectedLanguage
            // 
            this.selectedLanguage.Location = new System.Drawing.Point(0, 0);
            this.selectedLanguage.Name = "selectedLanguage";
            this.selectedLanguage.Size = new System.Drawing.Size(100, 23);
            this.selectedLanguage.TabIndex = 12;
            // 
            // languageMaintainanceView
            // 
            this.languageMaintainanceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.languageMaintainanceView.Location = new System.Drawing.Point(502, 61);
            this.languageMaintainanceView.Name = "languageMaintainanceView";
            this.languageMaintainanceView.Size = new System.Drawing.Size(233, 194);
            this.languageMaintainanceView.TabIndex = 10;
            this.languageMaintainanceView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LanguageMaintainanceView_CellClick);
            // 
            // directorMaintainanceView
            // 
            this.directorMaintainanceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorMaintainanceView.Location = new System.Drawing.Point(25, 299);
            this.directorMaintainanceView.Name = "directorMaintainanceView";
            this.directorMaintainanceView.Size = new System.Drawing.Size(249, 169);
            this.directorMaintainanceView.TabIndex = 11;
            this.directorMaintainanceView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DirectorMaintainanceView_CellClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Director Maintainance :";
            // 
            // newLanguage
            // 
            this.newLanguage.Location = new System.Drawing.Point(757, 61);
            this.newLanguage.Name = "newLanguage";
            this.newLanguage.Size = new System.Drawing.Size(149, 20);
            this.newLanguage.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add Language";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // deleteLanguage
            // 
            this.deleteLanguage.Location = new System.Drawing.Point(757, 119);
            this.deleteLanguage.Name = "deleteLanguage";
            this.deleteLanguage.Size = new System.Drawing.Size(104, 23);
            this.deleteLanguage.TabIndex = 16;
            this.deleteLanguage.Text = "Delete Language";
            this.deleteLanguage.UseVisualStyleBackColor = true;
            this.deleteLanguage.Click += new System.EventHandler(this.DeleteLanguage_Click);
            // 
            // updateLanguageTB
            // 
            this.updateLanguageTB.Location = new System.Drawing.Point(757, 163);
            this.updateLanguageTB.Name = "updateLanguageTB";
            this.updateLanguageTB.Size = new System.Drawing.Size(149, 20);
            this.updateLanguageTB.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(757, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Update Language";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // newDirector
            // 
            this.newDirector.Location = new System.Drawing.Point(294, 299);
            this.newDirector.Name = "newDirector";
            this.newDirector.Size = new System.Drawing.Size(121, 20);
            this.newDirector.TabIndex = 19;
            // 
            // addDirector
            // 
            this.addDirector.Location = new System.Drawing.Point(294, 326);
            this.addDirector.Name = "addDirector";
            this.addDirector.Size = new System.Drawing.Size(75, 23);
            this.addDirector.TabIndex = 20;
            this.addDirector.Text = "Add Director";
            this.addDirector.UseVisualStyleBackColor = true;
            this.addDirector.Click += new System.EventHandler(this.AddDirector_Click);
            // 
            // deleteDirector
            // 
            this.deleteDirector.Location = new System.Drawing.Point(294, 356);
            this.deleteDirector.Name = "deleteDirector";
            this.deleteDirector.Size = new System.Drawing.Size(110, 23);
            this.deleteDirector.TabIndex = 21;
            this.deleteDirector.Text = "Delete Director";
            this.deleteDirector.UseVisualStyleBackColor = true;
            this.deleteDirector.Click += new System.EventHandler(this.DeleteDirector_Click);
            // 
            // updateDirector
            // 
            this.updateDirector.Location = new System.Drawing.Point(294, 386);
            this.updateDirector.Name = "updateDirector";
            this.updateDirector.Size = new System.Drawing.Size(100, 20);
            this.updateDirector.TabIndex = 22;
            // 
            // updateDirectorButton
            // 
            this.updateDirectorButton.Location = new System.Drawing.Point(294, 413);
            this.updateDirectorButton.Name = "updateDirectorButton";
            this.updateDirectorButton.Size = new System.Drawing.Size(110, 23);
            this.updateDirectorButton.TabIndex = 23;
            this.updateDirectorButton.Text = "Update Director";
            this.updateDirectorButton.UseVisualStyleBackColor = true;
            this.updateDirectorButton.Click += new System.EventHandler(this.UpdateDirectorButton_Click);
            // 
            // MasterMaintainanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.updateDirectorButton);
            this.Controls.Add(this.updateDirector);
            this.Controls.Add(this.deleteDirector);
            this.Controls.Add(this.addDirector);
            this.Controls.Add(this.newDirector);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.updateLanguageTB);
            this.Controls.Add(this.deleteLanguage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newLanguage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.directorMaintainanceView);
            this.Controls.Add(this.languageMaintainanceView);
            this.Controls.Add(this.selectedLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateGen);
            this.Controls.Add(this.updateGenre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectedView);
            this.Controls.Add(this.newGenre);
            this.Controls.Add(this.genreAdd);
            this.Controls.Add(this.genreGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MasterMaintainanceForm";
            this.Text = "MasterMaintainanceForm";
            this.Load += new System.EventHandler(this.MasterMaintainanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageMaintainanceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorMaintainanceView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView genreGridView;
        private System.Windows.Forms.Button genreAdd;
        private System.Windows.Forms.TextBox newGenre;
        private System.Windows.Forms.Label selectedView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox updateGenre;
        private System.Windows.Forms.Button updateGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectedLanguage;
        private System.Windows.Forms.DataGridView languageMaintainanceView;
        private System.Windows.Forms.DataGridView directorMaintainanceView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newLanguage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deleteLanguage;
        private System.Windows.Forms.TextBox updateLanguageTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox newDirector;
        private System.Windows.Forms.Button addDirector;
        private System.Windows.Forms.Button deleteDirector;
        private System.Windows.Forms.TextBox updateDirector;
        private System.Windows.Forms.Button updateDirectorButton;
    }
}