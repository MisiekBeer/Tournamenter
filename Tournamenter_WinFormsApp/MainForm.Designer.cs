namespace Tournamenter_WinFormsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.globalPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusRound = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMatchAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMatchPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.matchSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRoundStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPalette = this.globalPalette;
            this.kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // globalPalette
            // 
            this.globalPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.globalPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusProgress,
            this.statusRound,
            this.statusTime});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 823);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(1120, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(450, 17);
            this.statusLabel.Text = "Status:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusProgress
            // 
            this.statusProgress.AutoSize = false;
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(120, 16);
            // 
            // statusRound
            // 
            this.statusRound.AutoSize = false;
            this.statusRound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusRound.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.statusRound.Name = "statusRound";
            this.statusRound.Size = new System.Drawing.Size(100, 17);
            this.statusRound.Text = "Round: X";
            this.statusRound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTime
            // 
            this.statusTime.AutoSize = false;
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(145, 17);
            this.statusTime.Text = "Current time";
            this.statusTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMatchToolStripMenuItem,
            this.openMatchToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveMatchToolStripMenuItem,
            this.saveMatchAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.printMatchToolStripMenuItem,
            this.printMatchPreviewToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newMatchToolStripMenuItem
            // 
            this.newMatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newMatchToolStripMenuItem.Image")));
            this.newMatchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMatchToolStripMenuItem.Name = "newMatchToolStripMenuItem";
            this.newMatchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMatchToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.newMatchToolStripMenuItem.Text = "&New match";
            this.newMatchToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openMatchToolStripMenuItem
            // 
            this.openMatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openMatchToolStripMenuItem.Image")));
            this.openMatchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openMatchToolStripMenuItem.Name = "openMatchToolStripMenuItem";
            this.openMatchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMatchToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.openMatchToolStripMenuItem.Text = "&Open match";
            this.openMatchToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // saveMatchToolStripMenuItem
            // 
            this.saveMatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveMatchToolStripMenuItem.Image")));
            this.saveMatchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveMatchToolStripMenuItem.Name = "saveMatchToolStripMenuItem";
            this.saveMatchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMatchToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.saveMatchToolStripMenuItem.Text = "&Save match";
            // 
            // saveMatchAsToolStripMenuItem
            // 
            this.saveMatchAsToolStripMenuItem.Name = "saveMatchAsToolStripMenuItem";
            this.saveMatchAsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.saveMatchAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
            // 
            // printMatchToolStripMenuItem
            // 
            this.printMatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printMatchToolStripMenuItem.Image")));
            this.printMatchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printMatchToolStripMenuItem.Name = "printMatchToolStripMenuItem";
            this.printMatchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printMatchToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.printMatchToolStripMenuItem.Text = "&Print match status";
            this.printMatchToolStripMenuItem.Click += new System.EventHandler(this.printMatchToolStripMenuItem_Click);
            // 
            // printMatchPreviewToolStripMenuItem
            // 
            this.printMatchPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printMatchPreviewToolStripMenuItem.Image")));
            this.printMatchPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printMatchPreviewToolStripMenuItem.Name = "printMatchPreviewToolStripMenuItem";
            this.printMatchPreviewToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.printMatchPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printMatchPreviewToolStripMenuItem.Click += new System.EventHandler(this.printMatchPreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(208, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerListToolStripMenuItem,
            this.toolStripSeparator1,
            this.startMatchToolStripMenuItem,
            this.closeRoundToolStripMenuItem,
            this.toolStripSeparator5,
            this.matchSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // playerListToolStripMenuItem
            // 
            this.playerListToolStripMenuItem.Name = "playerListToolStripMenuItem";
            this.playerListToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.playerListToolStripMenuItem.Text = "Player List";
            this.playerListToolStripMenuItem.Click += new System.EventHandler(this.playerListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // startMatchToolStripMenuItem
            // 
            this.startMatchToolStripMenuItem.Name = "startMatchToolStripMenuItem";
            this.startMatchToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.startMatchToolStripMenuItem.Text = "Start match";
            this.startMatchToolStripMenuItem.Click += new System.EventHandler(this.startMatchToolStripMenuItem_Click);
            // 
            // closeRoundToolStripMenuItem
            // 
            this.closeRoundToolStripMenuItem.Name = "closeRoundToolStripMenuItem";
            this.closeRoundToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeRoundToolStripMenuItem.Text = "Close round";
            this.closeRoundToolStripMenuItem.Click += new System.EventHandler(this.closeRoundToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(150, 6);
            // 
            // matchSettingsToolStripMenuItem
            // 
            this.matchSettingsToolStripMenuItem.Name = "matchSettingsToolStripMenuItem";
            this.matchSettingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.matchSettingsToolStripMenuItem.Text = "Match Settings";
            this.matchSettingsToolStripMenuItem.Visible = false;
            this.matchSettingsToolStripMenuItem.Click += new System.EventHandler(this.matchSettingsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.saveRoundStatusToolStripMenuItem,
            this.toolStripSeparator6,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.customizeToolStripMenuItem.Text = "&Print round status";
            // 
            // saveRoundStatusToolStripMenuItem
            // 
            this.saveRoundStatusToolStripMenuItem.Name = "saveRoundStatusToolStripMenuItem";
            this.saveRoundStatusToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveRoundStatusToolStripMenuItem.Text = "Save round status";
            this.saveRoundStatusToolStripMenuItem.Click += new System.EventHandler(this.saveRoundStatusToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(165, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator7,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.kryptonPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1120, 774);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1120, 823);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.AutoScroll = true;
            this.kryptonPanel.Controls.Add(this.tableLayout);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(1120, 774);
            this.kryptonPanel.TabIndex = 0;
            // 
            // tableLayout
            // 
            this.tableLayout.AllowDrop = true;
            this.tableLayout.AutoScroll = true;
            this.tableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.MinimumSize = new System.Drawing.Size(800, 600);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(1120, 774);
            this.tableLayout.TabIndex = 0;
            this.tableLayout.DragDrop += new System.Windows.Forms.DragEventHandler(this.tableLayout_DragDrop);
            this.tableLayout.DragOver += new System.Windows.Forms.DragEventHandler(this.tableLayout_DragOver);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(3, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(133, 25);
            this.toolStrip.TabIndex = 2;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 845);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Tournamenter";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMatchAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMatchPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.ToolStripMenuItem playerListToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette globalPalette;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusRound;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripMenuItem startMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeRoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem saveRoundStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ToolStripMenuItem matchSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

