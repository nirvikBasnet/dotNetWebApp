namespace AITLibrary
{
    partial class MediaForm
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
            this.mediaDataGridView = new System.Windows.Forms.DataGridView();
            this.showAll = new System.Windows.Forms.Button();
            this.publishYearText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.ByPublishYear = new System.Windows.Forms.Button();
            this.ByGenre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.burrowButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            this.borrowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.searchByTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaDataGridView
            // 
            this.mediaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaDataGridView.Location = new System.Drawing.Point(19, 151);
            this.mediaDataGridView.Name = "mediaDataGridView";
            this.mediaDataGridView.RowHeadersWidth = 82;
            this.mediaDataGridView.Size = new System.Drawing.Size(752, 192);
            this.mediaDataGridView.TabIndex = 1;
            this.mediaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaDataGridView_CellClick_1);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(696, 120);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(75, 23);
            this.showAll.TabIndex = 2;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // publishYearText
            // 
            this.publishYearText.Location = new System.Drawing.Point(527, 14);
            this.publishYearText.Name = "publishYearText";
            this.publishYearText.Size = new System.Drawing.Size(100, 20);
            this.publishYearText.TabIndex = 3;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(527, 51);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(100, 20);
            this.genreText.TabIndex = 6;
            this.genreText.TextChanged += new System.EventHandler(this.genreText_TextChanged);
            // 
            // ByPublishYear
            // 
            this.ByPublishYear.Location = new System.Drawing.Point(648, 14);
            this.ByPublishYear.Name = "ByPublishYear";
            this.ByPublishYear.Size = new System.Drawing.Size(171, 23);
            this.ByPublishYear.TabIndex = 7;
            this.ByPublishYear.Text = "Search By Published Year";
            this.ByPublishYear.UseVisualStyleBackColor = true;
            this.ByPublishYear.Click += new System.EventHandler(this.ByPublishYear_Click);
            // 
            // ByGenre
            // 
            this.ByGenre.Location = new System.Drawing.Point(667, 47);
            this.ByGenre.Name = "ByGenre";
            this.ByGenre.Size = new System.Drawing.Size(135, 23);
            this.ByGenre.TabIndex = 8;
            this.ByGenre.Text = "Search By Genre";
            this.ByGenre.UseVisualStyleBackColor = true;
            this.ByGenre.Click += new System.EventHandler(this.ByGenre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome To The Prototype USER !!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "OR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // burrowButton
            // 
            this.burrowButton.Location = new System.Drawing.Point(236, 108);
            this.burrowButton.Name = "burrowButton";
            this.burrowButton.Size = new System.Drawing.Size(111, 23);
            this.burrowButton.TabIndex = 11;
            this.burrowButton.Text = "Borrow Media";
            this.burrowButton.UseVisualStyleBackColor = true;
            this.burrowButton.Click += new System.EventHandler(this.burrowButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(366, 108);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(111, 23);
            this.reserveButton.TabIndex = 12;
            this.reserveButton.Text = "Reserve Media";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.Location = new System.Drawing.Point(16, 23);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(81, 13);
            this.selectedMediaLabel.TabIndex = 13;
            this.selectedMediaLabel.Text = "Selected Media";
            this.selectedMediaLabel.Click += new System.EventHandler(this.selectedMediaLabel_Click);
            // 
            // borrowDateTimePicker
            // 
            this.borrowDateTimePicker.Location = new System.Drawing.Point(19, 73);
            this.borrowDateTimePicker.Name = "borrowDateTimePicker";
            this.borrowDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.borrowDateTimePicker.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Expected Date Of Return :";
            // 
            // searchByTitle
            // 
            this.searchByTitle.Location = new System.Drawing.Point(527, 88);
            this.searchByTitle.Margin = new System.Windows.Forms.Padding(2);
            this.searchByTitle.Name = "searchByTitle";
            this.searchByTitle.Size = new System.Drawing.Size(100, 20);
            this.searchByTitle.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Search By Title";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchByTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borrowDateTimePicker);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.burrowButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ByGenre);
            this.Controls.Add(this.ByPublishYear);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.publishYearText);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.mediaDataGridView);
            this.Name = "MediaForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MediaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView mediaDataGridView;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.TextBox publishYearText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Button ByPublishYear;
        private System.Windows.Forms.Button ByGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button burrowButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Label selectedMediaLabel;
        private System.Windows.Forms.DateTimePicker borrowDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchByTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}