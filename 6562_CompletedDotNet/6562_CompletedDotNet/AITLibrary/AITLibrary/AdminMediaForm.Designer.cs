namespace AITLibrary
{
    partial class AdminMediaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addMedia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addMediaButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.genreCB = new System.Windows.Forms.ComboBox();
            this.languageCB = new System.Windows.Forms.ComboBox();
            this.directorCB = new System.Windows.Forms.ComboBox();
            this.showAll = new System.Windows.Forms.Button();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            this.deleteMedia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(413, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addMedia
            // 
            this.addMedia.AutoSize = true;
            this.addMedia.Location = new System.Drawing.Point(485, 60);
            this.addMedia.Name = "addMedia";
            this.addMedia.Size = new System.Drawing.Size(58, 13);
            this.addMedia.TabIndex = 1;
            this.addMedia.Text = "Add Media";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Director :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Budget :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Year :";
            // 
            // addMediaButton
            // 
            this.addMediaButton.ForeColor = System.Drawing.Color.Green;
            this.addMediaButton.Location = new System.Drawing.Point(549, 292);
            this.addMediaButton.Name = "addMediaButton";
            this.addMediaButton.Size = new System.Drawing.Size(129, 23);
            this.addMediaButton.TabIndex = 8;
            this.addMediaButton.Text = "Add Media";
            this.addMediaButton.UseVisualStyleBackColor = true;
            this.addMediaButton.Click += new System.EventHandler(this.addMediaButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(541, 90);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(137, 20);
            this.titleBox.TabIndex = 9;
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(541, 214);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(137, 20);
            this.BudgetTextBox.TabIndex = 13;
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(539, 242);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(139, 20);
            this.publishYearTextBox.TabIndex = 14;
            // 
            // genreCB
            // 
            this.genreCB.FormattingEnabled = true;
            this.genreCB.Location = new System.Drawing.Point(541, 122);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(137, 21);
            this.genreCB.TabIndex = 15;
            this.genreCB.SelectedIndexChanged += new System.EventHandler(this.genreCB_SelectedIndexChanged);
            // 
            // languageCB
            // 
            this.languageCB.FormattingEnabled = true;
            this.languageCB.Location = new System.Drawing.Point(541, 155);
            this.languageCB.Name = "languageCB";
            this.languageCB.Size = new System.Drawing.Size(137, 21);
            this.languageCB.TabIndex = 16;
            this.languageCB.SelectedIndexChanged += new System.EventHandler(this.languageCB_SelectedIndexChanged);
            // 
            // directorCB
            // 
            this.directorCB.FormattingEnabled = true;
            this.directorCB.Location = new System.Drawing.Point(541, 182);
            this.directorCB.Name = "directorCB";
            this.directorCB.Size = new System.Drawing.Size(137, 21);
            this.directorCB.TabIndex = 17;
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(12, 331);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(75, 23);
            this.showAll.TabIndex = 18;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.Location = new System.Drawing.Point(52, 22);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(87, 13);
            this.selectedMediaLabel.TabIndex = 19;
            this.selectedMediaLabel.Text = "Selected Media :";
            // 
            // deleteMedia
            // 
            this.deleteMedia.ForeColor = System.Drawing.Color.Red;
            this.deleteMedia.Location = new System.Drawing.Point(416, 315);
            this.deleteMedia.Name = "deleteMedia";
            this.deleteMedia.Size = new System.Drawing.Size(127, 23);
            this.deleteMedia.TabIndex = 20;
            this.deleteMedia.Text = "Delete Media";
            this.deleteMedia.UseVisualStyleBackColor = true;
            this.deleteMedia.Click += new System.EventHandler(this.deleteMedia_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(549, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Update Media";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AdminMediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteMedia);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.directorCB);
            this.Controls.Add(this.languageCB);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.publishYearTextBox);
            this.Controls.Add(this.BudgetTextBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.addMediaButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addMedia);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminMediaForm";
            this.Text = "AdminMediaForm";
            this.Load += new System.EventHandler(this.AdminMediaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label addMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMediaButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox BudgetTextBox;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.ComboBox genreCB;
        private System.Windows.Forms.ComboBox languageCB;
        private System.Windows.Forms.ComboBox directorCB;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Label selectedMediaLabel;
        private System.Windows.Forms.Button deleteMedia;
        private System.Windows.Forms.Button button1;
    }
}