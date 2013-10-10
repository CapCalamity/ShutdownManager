namespace ShutdownTimer.Forms
{
    partial class CancelShutdown
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
            this.components = new System.ComponentModel.Container();
            this.buttonCancelShutdown = new System.Windows.Forms.Button();
            this.labelShutdown = new System.Windows.Forms.Label();
            this.labelShutdownInSeconds = new System.Windows.Forms.Label();
            this.labelShutdownSeconds = new System.Windows.Forms.Label();
            this.timerShutdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonCancelShutdown
            // 
            this.buttonCancelShutdown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCancelShutdown.Location = new System.Drawing.Point(0, 35);
            this.buttonCancelShutdown.Name = "buttonCancelShutdown";
            this.buttonCancelShutdown.Size = new System.Drawing.Size(284, 23);
            this.buttonCancelShutdown.TabIndex = 0;
            this.buttonCancelShutdown.Text = "Cancel Shutdown";
            this.buttonCancelShutdown.UseVisualStyleBackColor = true;
            this.buttonCancelShutdown.Click += new System.EventHandler(this.buttonCancelShutdown_Click);
            // 
            // labelShutdown
            // 
            this.labelShutdown.AutoSize = true;
            this.labelShutdown.Location = new System.Drawing.Point(12, 9);
            this.labelShutdown.Name = "labelShutdown";
            this.labelShutdown.Size = new System.Drawing.Size(66, 13);
            this.labelShutdown.TabIndex = 1;
            this.labelShutdown.Text = "Shutdown in";
            // 
            // labelShutdownInSeconds
            // 
            this.labelShutdownInSeconds.AutoSize = true;
            this.labelShutdownInSeconds.Location = new System.Drawing.Point(85, 9);
            this.labelShutdownInSeconds.Name = "labelShutdownInSeconds";
            this.labelShutdownInSeconds.Size = new System.Drawing.Size(13, 13);
            this.labelShutdownInSeconds.TabIndex = 2;
            this.labelShutdownInSeconds.Text = "0";
            // 
            // labelShutdownSeconds
            // 
            this.labelShutdownSeconds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelShutdownSeconds.AutoSize = true;
            this.labelShutdownSeconds.Location = new System.Drawing.Point(104, 9);
            this.labelShutdownSeconds.Name = "labelShutdownSeconds";
            this.labelShutdownSeconds.Size = new System.Drawing.Size(47, 13);
            this.labelShutdownSeconds.TabIndex = 3;
            this.labelShutdownSeconds.Text = "seconds";
            // 
            // timerShutdown
            // 
            this.timerShutdown.Interval = 1000;
            this.timerShutdown.Tick += new System.EventHandler(this.timerShutdown_Tick);
            // 
            // FormCancelShutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 58);
            this.Controls.Add(this.labelShutdownSeconds);
            this.Controls.Add(this.labelShutdownInSeconds);
            this.Controls.Add(this.labelShutdown);
            this.Controls.Add(this.buttonCancelShutdown);
            this.Name = "FormCancelShutdown";
            this.Text = "FormCancelShutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelShutdown;
        private System.Windows.Forms.Label labelShutdown;
        private System.Windows.Forms.Label labelShutdownInSeconds;
        private System.Windows.Forms.Label labelShutdownSeconds;
        private System.Windows.Forms.Timer timerShutdown;
    }
}