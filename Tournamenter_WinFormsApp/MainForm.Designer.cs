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
            this.btnNewMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpenMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveMatchAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrintMatchPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayerList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStartMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseRound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMatchSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnNewMatch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnOpenMatch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveMatch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrintMatchState = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
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
            this.btnNewMatch,
            this.toolStripSeparator2,
            this.btnOpenMatch,
            this.btnSaveMatch,
            this.btnSaveMatchAs,
            this.toolStripSeparator3,
            this.btnPrintMatchPreview,
            this.btnPrintMatch,
            this.toolStripSeparator4,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.Image = ((System.Drawing.Image)(resources.GetObject("btnNewMatch.Image")));
            this.btnNewMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewMatch.Size = new System.Drawing.Size(211, 22);
            this.btnNewMatch.Text = "&New match";
            this.btnNewMatch.Click += new System.EventHandler(this.newMatch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // btnOpenMatch
            // 
            this.btnOpenMatch.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenMatch.Image")));
            this.btnOpenMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenMatch.Name = "btnOpenMatch";
            this.btnOpenMatch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpenMatch.Size = new System.Drawing.Size(211, 22);
            this.btnOpenMatch.Text = "&Open match";
            this.btnOpenMatch.Click += new System.EventHandler(this.loadMatch_Click);
            // 
            // btnSaveMatch
            // 
            this.btnSaveMatch.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveMatch.Image")));
            this.btnSaveMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveMatch.Name = "btnSaveMatch";
            this.btnSaveMatch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveMatch.Size = new System.Drawing.Size(211, 22);
            this.btnSaveMatch.Text = "&Save match";
            this.btnSaveMatch.Click += new System.EventHandler(this.saveMatchStatus_Click);
            // 
            // btnSaveMatchAs
            // 
            this.btnSaveMatchAs.Name = "btnSaveMatchAs";
            this.btnSaveMatchAs.Size = new System.Drawing.Size(211, 22);
            this.btnSaveMatchAs.Text = "Save &As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
            // 
            // btnPrintMatchPreview
            // 
            this.btnPrintMatchPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMatchPreview.Image")));
            this.btnPrintMatchPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintMatchPreview.Name = "btnPrintMatchPreview";
            this.btnPrintMatchPreview.Size = new System.Drawing.Size(211, 22);
            this.btnPrintMatchPreview.Text = "Print Pre&view";
            this.btnPrintMatchPreview.Click += new System.EventHandler(this.printMatchPreviewToolStripMenuItem_Click);
            // 
            // btnPrintMatch
            // 
            this.btnPrintMatch.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMatch.Image")));
            this.btnPrintMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintMatch.Name = "btnPrintMatch";
            this.btnPrintMatch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.btnPrintMatch.Size = new System.Drawing.Size(211, 22);
            this.btnPrintMatch.Text = "&Print match status";
            this.btnPrintMatch.Click += new System.EventHandler(this.printMatchToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(208, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(211, 22);
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlayerList,
            this.toolStripSeparator1,
            this.btnStartMatch,
            this.btnCloseRound,
            this.toolStripSeparator5,
            this.btnMatchSettings});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // btnPlayerList
            // 
            this.btnPlayerList.Name = "btnPlayerList";
            this.btnPlayerList.Size = new System.Drawing.Size(153, 22);
            this.btnPlayerList.Text = "Player List";
            this.btnPlayerList.Click += new System.EventHandler(this.playerList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(153, 22);
            this.btnStartMatch.Text = "Start match";
            this.btnStartMatch.Click += new System.EventHandler(this.startMatch_Click);
            // 
            // btnCloseRound
            // 
            this.btnCloseRound.Name = "btnCloseRound";
            this.btnCloseRound.Size = new System.Drawing.Size(153, 22);
            this.btnCloseRound.Text = "Close round";
            this.btnCloseRound.Click += new System.EventHandler(this.closeRound_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(150, 6);
            // 
            // btnMatchSettings
            // 
            this.btnMatchSettings.Name = "btnMatchSettings";
            this.btnMatchSettings.Size = new System.Drawing.Size(153, 22);
            this.btnMatchSettings.Text = "Match Settings";
            this.btnMatchSettings.Click += new System.EventHandler(this.matchSettings_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOptions});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // btnOptions
            // 
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(116, 22);
            this.btnOptions.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelpContents,
            this.toolStripSeparator7,
            this.btnAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // btnHelpContents
            // 
            this.btnHelpContents.Name = "btnHelpContents";
            this.btnHelpContents.Size = new System.Drawing.Size(122, 22);
            this.btnHelpContents.Text = "&Contents";
            this.btnHelpContents.Click += new System.EventHandler(this.helpContents_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(119, 6);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(122, 22);
            this.btnAbout.Text = "&About...";
            this.btnAbout.Click += new System.EventHandler(this.about_Click);
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
            this.tsBtnNewMatch,
            this.tsBtnOpenMatch,
            this.tsBtnSaveMatch,
            this.tsBtnPrintMatchState,
            this.toolStripSeparator,
            this.tsBtnHelp});
            this.toolStrip.Location = new System.Drawing.Point(3, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(133, 25);
            this.toolStrip.TabIndex = 2;
            // 
            // tsBtnNewMatch
            // 
            this.tsBtnNewMatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNewMatch.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNewMatch.Image")));
            this.tsBtnNewMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNewMatch.Name = "tsBtnNewMatch";
            this.tsBtnNewMatch.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNewMatch.Text = "&New";
            this.tsBtnNewMatch.Click += new System.EventHandler(this.newMatch_Click);
            // 
            // tsBtnOpenMatch
            // 
            this.tsBtnOpenMatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnOpenMatch.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnOpenMatch.Image")));
            this.tsBtnOpenMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpenMatch.Name = "tsBtnOpenMatch";
            this.tsBtnOpenMatch.Size = new System.Drawing.Size(23, 22);
            this.tsBtnOpenMatch.Text = "&Open";
            this.tsBtnOpenMatch.Click += new System.EventHandler(this.loadMatch_Click);
            // 
            // tsBtnSaveMatch
            // 
            this.tsBtnSaveMatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSaveMatch.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSaveMatch.Image")));
            this.tsBtnSaveMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveMatch.Name = "tsBtnSaveMatch";
            this.tsBtnSaveMatch.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSaveMatch.Text = "&Save";
            this.tsBtnSaveMatch.Click += new System.EventHandler(this.saveMatchStatus_Click);
            // 
            // tsBtnPrintMatchState
            // 
            this.tsBtnPrintMatchState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrintMatchState.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrintMatchState.Image")));
            this.tsBtnPrintMatchState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrintMatchState.Name = "tsBtnPrintMatchState";
            this.tsBtnPrintMatchState.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrintMatchState.Text = "&Print";
            this.tsBtnPrintMatchState.Click += new System.EventHandler(this.printMatchToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnHelp
            // 
            this.tsBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnHelp.Image")));
            this.tsBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHelp.Name = "tsBtnHelp";
            this.tsBtnHelp.Size = new System.Drawing.Size(23, 22);
            this.tsBtnHelp.Text = "He&lp";
            this.tsBtnHelp.Click += new System.EventHandler(this.helpContents_Click);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Open match file";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML match files|*.xml|All files|*.*";
            this.saveFileDialog.InitialDirectory = "d:\\";
            this.saveFileDialog.Title = "Save match file";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select folder to store match saves";
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
        private System.Windows.Forms.ToolStripMenuItem btnNewMatch;
        private System.Windows.Forms.ToolStripMenuItem btnOpenMatch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnSaveMatch;
        private System.Windows.Forms.ToolStripMenuItem btnSaveMatchAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnPrintMatch;
        private System.Windows.Forms.ToolStripMenuItem btnPrintMatchPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOptions;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHelpContents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnNewMatch;
        private System.Windows.Forms.ToolStripButton tsBtnOpenMatch;
        private System.Windows.Forms.ToolStripButton tsBtnSaveMatch;
        private System.Windows.Forms.ToolStripButton tsBtnPrintMatchState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsBtnHelp;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.ToolStripMenuItem btnPlayerList;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette globalPalette;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusRound;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripMenuItem btnStartMatch;
        private System.Windows.Forms.ToolStripMenuItem btnCloseRound;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ToolStripMenuItem btnMatchSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

