namespace DQ9MapTool {
    partial class MapForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FloorMapPictureBox = new System.Windows.Forms.PictureBox();
            this.FloorLevelListBox = new System.Windows.Forms.ListBox();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewMapButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ChestTimerTable = new System.Windows.Forms.DataGridView();
            this.StopwatchToolStrip = new System.Windows.Forms.ToolStrip();
            this.PlayButton = new System.Windows.Forms.ToolStripButton();
            this.PauseButton = new System.Windows.Forms.ToolStripButton();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.StopwatchDisplayLabel = new System.Windows.Forms.ToolStripLabel();
            this.StopwatchUpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FloorMapPictureBox)).BeginInit();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChestTimerTable)).BeginInit();
            this.StopwatchToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FloorMapPictureBox
            // 
            this.FloorMapPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FloorMapPictureBox.Location = new System.Drawing.Point(20, 25);
            this.FloorMapPictureBox.Name = "FloorMapPictureBox";
            this.FloorMapPictureBox.Size = new System.Drawing.Size(672, 672);
            this.FloorMapPictureBox.TabIndex = 3;
            this.FloorMapPictureBox.TabStop = false;
            // 
            // FloorLevelListBox
            // 
            this.FloorLevelListBox.DisplayMember = "Name";
            this.FloorLevelListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FloorLevelListBox.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FloorLevelListBox.FormattingEnabled = true;
            this.FloorLevelListBox.ItemHeight = 14;
            this.FloorLevelListBox.Location = new System.Drawing.Point(0, 25);
            this.FloorLevelListBox.Name = "FloorLevelListBox";
            this.FloorLevelListBox.Size = new System.Drawing.Size(20, 672);
            this.FloorLevelListBox.TabIndex = 4;
            this.FloorLevelListBox.ValueMember = "Index";
            this.FloorLevelListBox.SelectedValueChanged += new System.EventHandler(this.FloorLevelListBox_SelectedValueChanged);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMapButton,
            this.openToolStripButton,
            this.saveToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1008, 25);
            this.MainToolStrip.TabIndex = 5;
            this.MainToolStrip.Text = "ToolStrip1";
            // 
            // NewMapButton
            // 
            this.NewMapButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewMapButton.Image = ((System.Drawing.Image)(resources.GetObject("NewMapButton.Image")));
            this.NewMapButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewMapButton.Name = "NewMapButton";
            this.NewMapButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMapButton.Size = new System.Drawing.Size(28, 25);
            this.NewMapButton.Text = "&New";
            this.NewMapButton.Click += new System.EventHandler(this.NewMap_Clicked);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripButton.Size = new System.Drawing.Size(28, 25);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripButton.Size = new System.Drawing.Size(28, 25);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // ChestTimerTable
            // 
            this.ChestTimerTable.AllowUserToAddRows = false;
            this.ChestTimerTable.AllowUserToDeleteRows = false;
            this.ChestTimerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ChestTimerTable.CausesValidation = false;
            this.ChestTimerTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ChestTimerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ChestTimerTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ChestTimerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChestTimerTable.Location = new System.Drawing.Point(692, 50);
            this.ChestTimerTable.MultiSelect = false;
            this.ChestTimerTable.Name = "ChestTimerTable";
            this.ChestTimerTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChestTimerTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ChestTimerTable.RowHeadersWidth = 58;
            this.ChestTimerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ChestTimerTable.ShowEditingIcon = false;
            this.ChestTimerTable.ShowRowErrors = false;
            this.ChestTimerTable.Size = new System.Drawing.Size(316, 647);
            this.ChestTimerTable.TabIndex = 6;
            this.ChestTimerTable.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ChestTimerTable_CellPainting);
            // 
            // StopwatchToolStrip
            // 
            this.StopwatchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayButton,
            this.PauseButton,
            this.StopButton,
            this.StopwatchDisplayLabel});
            this.StopwatchToolStrip.Location = new System.Drawing.Point(692, 25);
            this.StopwatchToolStrip.Name = "StopwatchToolStrip";
            this.StopwatchToolStrip.Size = new System.Drawing.Size(316, 25);
            this.StopwatchToolStrip.TabIndex = 7;
            this.StopwatchToolStrip.Text = "toolStrip1";
            // 
            // PlayButton
            // 
            this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(23, 22);
            this.PlayButton.Text = "toolStripButton1";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(23, 22);
            this.PauseButton.Text = "toolStripButton2";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopButton.Enabled = false;
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(23, 22);
            this.StopButton.Text = "toolStripButton3";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StopwatchDisplayLabel
            // 
            this.StopwatchDisplayLabel.Name = "StopwatchDisplayLabel";
            this.StopwatchDisplayLabel.Size = new System.Drawing.Size(49, 22);
            this.StopwatchDisplayLabel.Text = "00:00:00";
            // 
            // StopwatchUpdateTimer
            // 
            this.StopwatchUpdateTimer.Interval = 250;
            this.StopwatchUpdateTimer.Tick += new System.EventHandler(this.StopwatchUpdateTimer_Tick);
            // 
            // MapForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.ChestTimerTable);
            this.Controls.Add(this.StopwatchToolStrip);
            this.Controls.Add(this.FloorMapPictureBox);
            this.Controls.Add(this.FloorLevelListBox);
            this.Controls.Add(this.MainToolStrip);
            this.Name = "MapForm";
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.FloorMapPictureBox)).EndInit();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChestTimerTable)).EndInit();
            this.StopwatchToolStrip.ResumeLayout(false);
            this.StopwatchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox FloorMapPictureBox;
        internal System.Windows.Forms.ListBox FloorLevelListBox;
        internal System.Windows.Forms.ToolStrip MainToolStrip;
        internal System.Windows.Forms.ToolStripMenuItem NewMapButton;
        private System.Windows.Forms.DataGridView ChestTimerTable;
        private System.Windows.Forms.ToolStripMenuItem openToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripButton;
        private System.Windows.Forms.ToolStrip StopwatchToolStrip;
        private System.Windows.Forms.ToolStripButton PlayButton;
        private System.Windows.Forms.ToolStripButton PauseButton;
        private System.Windows.Forms.ToolStripButton StopButton;
        private System.Windows.Forms.ToolStripLabel StopwatchDisplayLabel;
        private System.Windows.Forms.Timer StopwatchUpdateTimer;
    }
}

