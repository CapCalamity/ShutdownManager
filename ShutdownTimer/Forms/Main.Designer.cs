namespace ShutdownTimer.Forms
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.EventTable = new System.Windows.Forms.DataGridView();
            this.ButtonStopTimer = new System.Windows.Forms.Button();
            this.ButtonStartTimer = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.comboBoxEvents = new System.Windows.Forms.ComboBox();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.textBoxEvents = new System.Windows.Forms.TextBox();
            this.EventTimer = new System.Windows.Forms.Timer(this.components);
            this.ColObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).BeginInit();
            this.tabEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOverview);
            this.tabControl1.Controls.Add(this.tabEvents);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.EventTable);
            this.tabOverview.Controls.Add(this.ButtonStopTimer);
            this.tabOverview.Controls.Add(this.ButtonStartTimer);
            this.tabOverview.Location = new System.Drawing.Point(4, 22);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(376, 321);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // EventTable
            // 
            this.EventTable.AllowUserToAddRows = false;
            this.EventTable.AllowUserToDeleteRows = false;
            this.EventTable.AllowUserToOrderColumns = true;
            this.EventTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColObject,
            this.ColName,
            this.ColDescription,
            this.ColDelete});
            this.EventTable.Location = new System.Drawing.Point(9, 36);
            this.EventTable.Name = "EventTable";
            this.EventTable.ReadOnly = true;
            this.EventTable.Size = new System.Drawing.Size(359, 277);
            this.EventTable.TabIndex = 2;
            this.EventTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventTable_CellContentClick);
            // 
            // ButtonStopTimer
            // 
            this.ButtonStopTimer.Location = new System.Drawing.Point(9, 7);
            this.ButtonStopTimer.Name = "ButtonStopTimer";
            this.ButtonStopTimer.Size = new System.Drawing.Size(359, 23);
            this.ButtonStopTimer.TabIndex = 1;
            this.ButtonStopTimer.Text = "Stop Timer";
            this.ButtonStopTimer.UseVisualStyleBackColor = true;
            this.ButtonStopTimer.Visible = false;
            this.ButtonStopTimer.Click += new System.EventHandler(this.buttonStopTimer_Click);
            // 
            // ButtonStartTimer
            // 
            this.ButtonStartTimer.Location = new System.Drawing.Point(9, 7);
            this.ButtonStartTimer.Name = "ButtonStartTimer";
            this.ButtonStartTimer.Size = new System.Drawing.Size(359, 23);
            this.ButtonStartTimer.TabIndex = 0;
            this.ButtonStartTimer.Text = "Start Timer";
            this.ButtonStartTimer.UseVisualStyleBackColor = true;
            this.ButtonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.comboBoxEvents);
            this.tabEvents.Controls.Add(this.buttonAddEvent);
            this.tabEvents.Controls.Add(this.textBoxEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(376, 321);
            this.tabEvents.TabIndex = 2;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // comboBoxEvents
            // 
            this.comboBoxEvents.FormattingEnabled = true;
            this.comboBoxEvents.Items.AddRange(new object[] {
            "Timed",
            "CPU Usage",
            "HDD Usage",
            "Download Speed",
            "Upload Speed",
            "Process Finished"});
            this.comboBoxEvents.Location = new System.Drawing.Point(9, 5);
            this.comboBoxEvents.Name = "comboBoxEvents";
            this.comboBoxEvents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEvents.TabIndex = 2;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEvent.Location = new System.Drawing.Point(293, 3);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEvent.TabIndex = 1;
            this.buttonAddEvent.Text = "Add Event";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // textBoxEvents
            // 
            this.textBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEvents.Location = new System.Drawing.Point(8, 32);
            this.textBoxEvents.Multiline = true;
            this.textBoxEvents.Name = "textBoxEvents";
            this.textBoxEvents.Size = new System.Drawing.Size(360, 281);
            this.textBoxEvents.TabIndex = 0;
            // 
            // EventTimer
            // 
            this.EventTimer.Interval = 1000;
            this.EventTimer.Tick += new System.EventHandler(this.EventTimer_Tick);
            // 
            // ColObject
            // 
            this.ColObject.HeaderText = "Object";
            this.ColObject.Name = "ColObject";
            this.ColObject.ReadOnly = true;
            this.ColObject.Visible = false;
            // 
            // ColName
            // 
            this.ColName.FillWeight = 48.26755F;
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColDescription
            // 
            this.ColDescription.FillWeight = 190.8188F;
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            // 
            // ColDelete
            // 
            this.ColDelete.FillWeight = 60.9137F;
            this.ColDelete.HeaderText = "Delete";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 347);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).EndInit();
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.TextBox textBoxEvents;
        private System.Windows.Forms.ComboBox comboBoxEvents;
        private System.Windows.Forms.Timer EventTimer;
        private System.Windows.Forms.Button ButtonStopTimer;
        private System.Windows.Forms.Button ButtonStartTimer;
        private System.Windows.Forms.DataGridView EventTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
    }
}