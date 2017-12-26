namespace FileSearchUI
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
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(27, 25);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(100, 22);
            this.txtDir.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Now";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 16;
            this.listFiles.Location = new System.Drawing.Point(27, 81);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(1099, 548);
            this.listFiles.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 690);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listFiles;
    }
}

