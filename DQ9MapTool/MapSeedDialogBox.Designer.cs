namespace DQ9MapTool {
    partial class MapSeedDialogBox {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapSeedDialogBox));
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mapLocationListView = new System.Windows.Forms.ListView();
            this.locationMaps = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialTypeCombo = new System.Windows.Forms.ComboBox();
            this.dungeonTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyTypeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.buttonPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.AutoSize = true;
            this.buttonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPanel.ColumnCount = 2;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonPanel.Controls.Add(this.confirmButton, 0, 0);
            this.buttonPanel.Controls.Add(this.cancelButton, 1, 0);
            this.buttonPanel.Location = new System.Drawing.Point(593, 405);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonPanel.Size = new System.Drawing.Size(162, 29);
            this.buttonPanel.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(3, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(84, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // mapLocationListView
            // 
            this.mapLocationListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapLocationListView.LargeImageList = this.locationMaps;
            this.mapLocationListView.Location = new System.Drawing.Point(12, 47);
            this.mapLocationListView.Name = "mapLocationListView";
            this.mapLocationListView.ShowGroups = false;
            this.mapLocationListView.Size = new System.Drawing.Size(743, 352);
            this.mapLocationListView.TabIndex = 1;
            this.mapLocationListView.UseCompatibleStateImageBehavior = false;
            this.mapLocationListView.SelectedIndexChanged += new System.EventHandler(this.mapLocationListView_SelectedIndexChanged);
            this.mapLocationListView.DoubleClick += new System.EventHandler(this.mapLocationListView_DoubleClick);
            // 
            // locationMaps
            // 
            this.locationMaps.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("locationMaps.ImageStream")));
            this.locationMaps.TransparentColor = System.Drawing.Color.Transparent;
            this.locationMaps.Images.SetKeyName(0, "001.jpg");
            this.locationMaps.Images.SetKeyName(1, "002.jpg");
            this.locationMaps.Images.SetKeyName(2, "003.jpg");
            this.locationMaps.Images.SetKeyName(3, "004.jpg");
            this.locationMaps.Images.SetKeyName(4, "005.jpg");
            this.locationMaps.Images.SetKeyName(5, "006.jpg");
            this.locationMaps.Images.SetKeyName(6, "007.jpg");
            this.locationMaps.Images.SetKeyName(7, "008.jpg");
            this.locationMaps.Images.SetKeyName(8, "009.jpg");
            this.locationMaps.Images.SetKeyName(9, "010.jpg");
            this.locationMaps.Images.SetKeyName(10, "011.jpg");
            this.locationMaps.Images.SetKeyName(11, "012.jpg");
            this.locationMaps.Images.SetKeyName(12, "013.jpg");
            this.locationMaps.Images.SetKeyName(13, "014.jpg");
            this.locationMaps.Images.SetKeyName(14, "015.jpg");
            this.locationMaps.Images.SetKeyName(15, "016.jpg");
            this.locationMaps.Images.SetKeyName(16, "017.jpg");
            this.locationMaps.Images.SetKeyName(17, "018.jpg");
            this.locationMaps.Images.SetKeyName(18, "019.jpg");
            this.locationMaps.Images.SetKeyName(19, "020.jpg");
            this.locationMaps.Images.SetKeyName(20, "021.jpg");
            this.locationMaps.Images.SetKeyName(21, "022.jpg");
            this.locationMaps.Images.SetKeyName(22, "023.jpg");
            this.locationMaps.Images.SetKeyName(23, "024.jpg");
            this.locationMaps.Images.SetKeyName(24, "025.jpg");
            this.locationMaps.Images.SetKeyName(25, "026.jpg");
            this.locationMaps.Images.SetKeyName(26, "027.jpg");
            this.locationMaps.Images.SetKeyName(27, "028.jpg");
            this.locationMaps.Images.SetKeyName(28, "029.jpg");
            this.locationMaps.Images.SetKeyName(29, "030.jpg");
            this.locationMaps.Images.SetKeyName(30, "031.jpg");
            this.locationMaps.Images.SetKeyName(31, "032.jpg");
            this.locationMaps.Images.SetKeyName(32, "033.jpg");
            this.locationMaps.Images.SetKeyName(33, "034.jpg");
            this.locationMaps.Images.SetKeyName(34, "035.jpg");
            this.locationMaps.Images.SetKeyName(35, "036.jpg");
            this.locationMaps.Images.SetKeyName(36, "037.jpg");
            this.locationMaps.Images.SetKeyName(37, "038.jpg");
            this.locationMaps.Images.SetKeyName(38, "039.jpg");
            this.locationMaps.Images.SetKeyName(39, "040.jpg");
            this.locationMaps.Images.SetKeyName(40, "041.jpg");
            this.locationMaps.Images.SetKeyName(41, "042.jpg");
            this.locationMaps.Images.SetKeyName(42, "043.jpg");
            this.locationMaps.Images.SetKeyName(43, "044.jpg");
            this.locationMaps.Images.SetKeyName(44, "045.jpg");
            this.locationMaps.Images.SetKeyName(45, "046.jpg");
            this.locationMaps.Images.SetKeyName(46, "047.jpg");
            this.locationMaps.Images.SetKeyName(47, "048.jpg");
            this.locationMaps.Images.SetKeyName(48, "049.jpg");
            this.locationMaps.Images.SetKeyName(49, "050.jpg");
            this.locationMaps.Images.SetKeyName(50, "051.jpg");
            this.locationMaps.Images.SetKeyName(51, "052.jpg");
            this.locationMaps.Images.SetKeyName(52, "053.jpg");
            this.locationMaps.Images.SetKeyName(53, "054.jpg");
            this.locationMaps.Images.SetKeyName(54, "055.jpg");
            this.locationMaps.Images.SetKeyName(55, "056.jpg");
            this.locationMaps.Images.SetKeyName(56, "057.jpg");
            this.locationMaps.Images.SetKeyName(57, "058.jpg");
            this.locationMaps.Images.SetKeyName(58, "059.jpg");
            this.locationMaps.Images.SetKeyName(59, "060.jpg");
            this.locationMaps.Images.SetKeyName(60, "061.jpg");
            this.locationMaps.Images.SetKeyName(61, "062.jpg");
            this.locationMaps.Images.SetKeyName(62, "063.jpg");
            this.locationMaps.Images.SetKeyName(63, "064.jpg");
            this.locationMaps.Images.SetKeyName(64, "065.jpg");
            this.locationMaps.Images.SetKeyName(65, "066.jpg");
            this.locationMaps.Images.SetKeyName(66, "067.jpg");
            this.locationMaps.Images.SetKeyName(67, "068.jpg");
            this.locationMaps.Images.SetKeyName(68, "069.jpg");
            this.locationMaps.Images.SetKeyName(69, "070.jpg");
            this.locationMaps.Images.SetKeyName(70, "071.jpg");
            this.locationMaps.Images.SetKeyName(71, "072.jpg");
            this.locationMaps.Images.SetKeyName(72, "073.jpg");
            this.locationMaps.Images.SetKeyName(73, "074.jpg");
            this.locationMaps.Images.SetKeyName(74, "075.jpg");
            this.locationMaps.Images.SetKeyName(75, "076.jpg");
            this.locationMaps.Images.SetKeyName(76, "077.jpg");
            this.locationMaps.Images.SetKeyName(77, "078.jpg");
            this.locationMaps.Images.SetKeyName(78, "079.jpg");
            this.locationMaps.Images.SetKeyName(79, "080.jpg");
            this.locationMaps.Images.SetKeyName(80, "081.jpg");
            this.locationMaps.Images.SetKeyName(81, "082.jpg");
            this.locationMaps.Images.SetKeyName(82, "083.jpg");
            this.locationMaps.Images.SetKeyName(83, "084.jpg");
            this.locationMaps.Images.SetKeyName(84, "085.jpg");
            this.locationMaps.Images.SetKeyName(85, "086.jpg");
            this.locationMaps.Images.SetKeyName(86, "087.jpg");
            this.locationMaps.Images.SetKeyName(87, "088.jpg");
            this.locationMaps.Images.SetKeyName(88, "089.jpg");
            this.locationMaps.Images.SetKeyName(89, "090.jpg");
            this.locationMaps.Images.SetKeyName(90, "091.jpg");
            this.locationMaps.Images.SetKeyName(91, "092.jpg");
            this.locationMaps.Images.SetKeyName(92, "093.jpg");
            this.locationMaps.Images.SetKeyName(93, "094.jpg");
            this.locationMaps.Images.SetKeyName(94, "095.jpg");
            this.locationMaps.Images.SetKeyName(95, "096.jpg");
            this.locationMaps.Images.SetKeyName(96, "097.jpg");
            this.locationMaps.Images.SetKeyName(97, "098.jpg");
            this.locationMaps.Images.SetKeyName(98, "099.jpg");
            this.locationMaps.Images.SetKeyName(99, "100.jpg");
            this.locationMaps.Images.SetKeyName(100, "101.jpg");
            this.locationMaps.Images.SetKeyName(101, "102.jpg");
            this.locationMaps.Images.SetKeyName(102, "103.jpg");
            this.locationMaps.Images.SetKeyName(103, "104.jpg");
            this.locationMaps.Images.SetKeyName(104, "105.jpg");
            this.locationMaps.Images.SetKeyName(105, "106.jpg");
            this.locationMaps.Images.SetKeyName(106, "107.jpg");
            this.locationMaps.Images.SetKeyName(107, "108.jpg");
            this.locationMaps.Images.SetKeyName(108, "109.jpg");
            this.locationMaps.Images.SetKeyName(109, "110.jpg");
            this.locationMaps.Images.SetKeyName(110, "111.jpg");
            this.locationMaps.Images.SetKeyName(111, "112.jpg");
            this.locationMaps.Images.SetKeyName(112, "113.jpg");
            this.locationMaps.Images.SetKeyName(113, "114.jpg");
            this.locationMaps.Images.SetKeyName(114, "115.jpg");
            this.locationMaps.Images.SetKeyName(115, "116.jpg");
            this.locationMaps.Images.SetKeyName(116, "117.jpg");
            this.locationMaps.Images.SetKeyName(117, "118.jpg");
            this.locationMaps.Images.SetKeyName(118, "119.jpg");
            this.locationMaps.Images.SetKeyName(119, "120.jpg");
            this.locationMaps.Images.SetKeyName(120, "121.jpg");
            this.locationMaps.Images.SetKeyName(121, "122.jpg");
            this.locationMaps.Images.SetKeyName(122, "123.jpg");
            this.locationMaps.Images.SetKeyName(123, "124.jpg");
            this.locationMaps.Images.SetKeyName(124, "125.jpg");
            this.locationMaps.Images.SetKeyName(125, "126.jpg");
            this.locationMaps.Images.SetKeyName(126, "127.jpg");
            this.locationMaps.Images.SetKeyName(127, "128.jpg");
            this.locationMaps.Images.SetKeyName(128, "129.jpg");
            this.locationMaps.Images.SetKeyName(129, "130.jpg");
            this.locationMaps.Images.SetKeyName(130, "131.jpg");
            this.locationMaps.Images.SetKeyName(131, "132.jpg");
            this.locationMaps.Images.SetKeyName(132, "133.jpg");
            this.locationMaps.Images.SetKeyName(133, "134.jpg");
            this.locationMaps.Images.SetKeyName(134, "135.jpg");
            this.locationMaps.Images.SetKeyName(135, "136.jpg");
            this.locationMaps.Images.SetKeyName(136, "137.jpg");
            this.locationMaps.Images.SetKeyName(137, "138.jpg");
            this.locationMaps.Images.SetKeyName(138, "139.jpg");
            this.locationMaps.Images.SetKeyName(139, "140.jpg");
            this.locationMaps.Images.SetKeyName(140, "141.jpg");
            this.locationMaps.Images.SetKeyName(141, "142.jpg");
            this.locationMaps.Images.SetKeyName(142, "143.jpg");
            this.locationMaps.Images.SetKeyName(143, "144.jpg");
            this.locationMaps.Images.SetKeyName(144, "145.jpg");
            this.locationMaps.Images.SetKeyName(145, "146.jpg");
            this.locationMaps.Images.SetKeyName(146, "147.jpg");
            this.locationMaps.Images.SetKeyName(147, "148.jpg");
            this.locationMaps.Images.SetKeyName(148, "149.jpg");
            this.locationMaps.Images.SetKeyName(149, "150.jpg");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.materialTypeCombo);
            this.flowLayoutPanel1.Controls.Add(this.dungeonTypeCombo);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.difficultyTypeCombo);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.levelTextBox);
            this.flowLayoutPanel1.Controls.Add(this.searchButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(613, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // materialTypeCombo
            // 
            this.materialTypeCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTypeCombo.DisplayMember = "MaterialType";
            this.materialTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialTypeCombo.FormattingEnabled = true;
            this.materialTypeCombo.Location = new System.Drawing.Point(3, 4);
            this.materialTypeCombo.Name = "materialTypeCombo";
            this.materialTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.materialTypeCombo.TabIndex = 0;
            this.materialTypeCombo.ValueMember = "MaterialTypeId";
            // 
            // dungeonTypeCombo
            // 
            this.dungeonTypeCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dungeonTypeCombo.DisplayMember = "DungeonType";
            this.dungeonTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dungeonTypeCombo.FormattingEnabled = true;
            this.dungeonTypeCombo.Location = new System.Drawing.Point(130, 4);
            this.dungeonTypeCombo.Name = "dungeonTypeCombo";
            this.dungeonTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.dungeonTypeCombo.TabIndex = 1;
            this.dungeonTypeCombo.ValueMember = "DungeonTypeId";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "of";
            // 
            // difficultyTypeCombo
            // 
            this.difficultyTypeCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difficultyTypeCombo.DisplayMember = "DifficultyType";
            this.difficultyTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyTypeCombo.FormattingEnabled = true;
            this.difficultyTypeCombo.Location = new System.Drawing.Point(279, 4);
            this.difficultyTypeCombo.Name = "difficultyTypeCombo";
            this.difficultyTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.difficultyTypeCombo.TabIndex = 3;
            this.difficultyTypeCombo.ValueMember = "DifficultyTypeId";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "lvl";
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(429, 3);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(100, 20);
            this.levelTextBox.TabIndex = 5;
            this.levelTextBox.Text = "1";
            this.levelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.levelTextBox_Validating);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(535, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MapSeedDialogBox
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(767, 446);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mapLocationListView);
            this.Controls.Add(this.buttonPanel);
            this.Name = "MapSeedDialogBox";
            this.Text = "                   ";
            this.buttonPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView mapLocationListView;
        private System.Windows.Forms.ImageList locationMaps;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox materialTypeCombo;
        private System.Windows.Forms.ComboBox dungeonTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox difficultyTypeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}