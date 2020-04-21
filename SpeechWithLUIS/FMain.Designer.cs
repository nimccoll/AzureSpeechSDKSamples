namespace SpeechWithLUIS
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtShowTimes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecognized = new System.Windows.Forms.TextBox();
            this.txtRecognizing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(129, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(337, 35);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 52);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtShowTimes
            // 
            this.txtShowTimes.Location = new System.Drawing.Point(26, 302);
            this.txtShowTimes.Multiline = true;
            this.txtShowTimes.Name = "txtShowTimes";
            this.txtShowTimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowTimes.Size = new System.Drawing.Size(1204, 627);
            this.txtShowTimes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recognized:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recognizing...";
            // 
            // txtRecognized
            // 
            this.txtRecognized.Location = new System.Drawing.Point(282, 196);
            this.txtRecognized.Name = "txtRecognized";
            this.txtRecognized.Size = new System.Drawing.Size(613, 31);
            this.txtRecognized.TabIndex = 7;
            // 
            // txtRecognizing
            // 
            this.txtRecognizing.Location = new System.Drawing.Point(282, 118);
            this.txtRecognizing.Name = "txtRecognizing";
            this.txtRecognizing.Size = new System.Drawing.Size(613, 31);
            this.txtRecognizing.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Show Times";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 953);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecognized);
            this.Controls.Add(this.txtRecognizing);
            this.Controls.Add(this.txtShowTimes);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speech With LUIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtShowTimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecognized;
        private System.Windows.Forms.TextBox txtRecognizing;
        private System.Windows.Forms.Label label3;
    }
}

