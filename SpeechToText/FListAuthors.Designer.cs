namespace SpeechToText
{
    partial class FListAuthors
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
            this.grdAuthors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAuthors
            // 
            this.grdAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAuthors.Location = new System.Drawing.Point(30, 38);
            this.grdAuthors.Name = "grdAuthors";
            this.grdAuthors.RowHeadersWidth = 82;
            this.grdAuthors.RowTemplate.Height = 33;
            this.grdAuthors.Size = new System.Drawing.Size(240, 150);
            this.grdAuthors.TabIndex = 0;
            // 
            // FListAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.grdAuthors);
            this.Name = "FListAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Authors";
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAuthors;
    }
}