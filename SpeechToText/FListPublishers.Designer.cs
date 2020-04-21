namespace SpeechToText
{
    partial class FListPublishers
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
            this.grdPublishers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPublishers
            // 
            this.grdPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPublishers.Location = new System.Drawing.Point(31, 33);
            this.grdPublishers.Name = "grdPublishers";
            this.grdPublishers.RowHeadersWidth = 82;
            this.grdPublishers.RowTemplate.Height = 33;
            this.grdPublishers.Size = new System.Drawing.Size(240, 150);
            this.grdPublishers.TabIndex = 0;
            // 
            // FListPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.grdPublishers);
            this.Name = "FListPublishers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Publishers";
            ((System.ComponentModel.ISupportInitialize)(this.grdPublishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPublishers;
    }
}