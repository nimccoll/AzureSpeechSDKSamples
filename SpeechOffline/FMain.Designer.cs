namespace SpeechOffline
{
    partial class FMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecognized = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Recognized:";
            // 
            // txtRecognized
            // 
            this.txtRecognized.Location = new System.Drawing.Point(271, 251);
            this.txtRecognized.Name = "txtRecognized";
            this.txtRecognized.Size = new System.Drawing.Size(613, 31);
            this.txtRecognized.TabIndex = 7;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(329, 77);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(151, 48);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(115, 77);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 44);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtRecognized);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speech Offline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecognized;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

