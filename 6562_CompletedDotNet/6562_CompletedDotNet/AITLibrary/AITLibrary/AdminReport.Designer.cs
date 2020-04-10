namespace AITLibrary
{
    partial class AdminReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnMediaButton = new System.Windows.Forms.Button();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Of Borrowed Media:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(736, 237);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // returnMediaButton
            // 
            this.returnMediaButton.Location = new System.Drawing.Point(610, 318);
            this.returnMediaButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnMediaButton.Name = "returnMediaButton";
            this.returnMediaButton.Size = new System.Drawing.Size(132, 38);
            this.returnMediaButton.TabIndex = 2;
            this.returnMediaButton.Text = "Return Selected Media";
            this.returnMediaButton.UseVisualStyleBackColor = true;
            this.returnMediaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.Location = new System.Drawing.Point(361, 7);
            this.selectedMediaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(87, 13);
            this.selectedMediaLabel.TabIndex = 3;
            this.selectedMediaLabel.Text = "Selected Media :";
            // 
            // AdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 389);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.returnMediaButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminReport";
            this.Text = "AdminReport";
            this.Load += new System.EventHandler(this.AdminReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button returnMediaButton;
        private System.Windows.Forms.Label selectedMediaLabel;
    }
}