namespace ShutdownTimer.Forms
{
    partial class AddCPUUsageEvent
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
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.comboBoxComparator = new System.Windows.Forms.ComboBox();
            this.textBoxUsage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Usage for";
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(97, 14);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(40, 20);
            this.textBoxSeconds.TabIndex = 1;
            this.textBoxSeconds.Text = "60";
            // 
            // comboBoxComparator
            // 
            this.comboBoxComparator.FormattingEnabled = true;
            this.comboBoxComparator.Items.AddRange(new object[] {
            "Above",
            "Precisely",
            "Under"});
            this.comboBoxComparator.Location = new System.Drawing.Point(196, 14);
            this.comboBoxComparator.Name = "comboBoxComparator";
            this.comboBoxComparator.Size = new System.Drawing.Size(69, 21);
            this.comboBoxComparator.TabIndex = 2;
            this.comboBoxComparator.Text = "Under";
            // 
            // textBoxUsage
            // 
            this.textBoxUsage.Location = new System.Drawing.Point(271, 15);
            this.textBoxUsage.Name = "textBoxUsage";
            this.textBoxUsage.Size = new System.Drawing.Size(39, 20);
            this.textBoxUsage.TabIndex = 3;
            this.textBoxUsage.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "seconds";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 43);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "Add Event";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // AddCPUUsageEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 74);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsage);
            this.Controls.Add(this.comboBoxComparator);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.label1);
            this.Name = "AddCPUUsageEvent";
            this.Text = "CPU Usage Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.ComboBox comboBoxComparator;
        private System.Windows.Forms.TextBox textBoxUsage;

    }
}