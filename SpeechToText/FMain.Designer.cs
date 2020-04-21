namespace SpeechToText
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
            this.txtRecognizing = new System.Windows.Forms.TextBox();
            this.txtRecognized = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecognizing
            // 
            this.txtRecognizing.Location = new System.Drawing.Point(224, 158);
            this.txtRecognizing.Name = "txtRecognizing";
            this.txtRecognizing.Size = new System.Drawing.Size(613, 31);
            this.txtRecognizing.TabIndex = 0;
            // 
            // txtRecognized
            // 
            this.txtRecognized.Location = new System.Drawing.Point(224, 236);
            this.txtRecognized.Name = "txtRecognized";
            this.txtRecognized.Size = new System.Drawing.Size(613, 31);
            this.txtRecognized.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(68, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 44);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(282, 62);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(151, 48);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recognizing...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recognized:";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtRecognized);
            this.Controls.Add(this.txtRecognizing);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speech To Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecognizing;
        private System.Windows.Forms.TextBox txtRecognized;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

