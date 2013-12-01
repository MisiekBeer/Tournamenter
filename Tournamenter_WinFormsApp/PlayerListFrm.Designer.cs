namespace Tournamenter_WinFormsApp
{
    partial class PlayerListFrm
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
            ComponentFactory.Krypton.Toolkit.KryptonLabel playerIdLabel;
            ComponentFactory.Krypton.Toolkit.KryptonLabel nameLabel;
            ComponentFactory.Krypton.Toolkit.KryptonLabel surnameLabel;
            ComponentFactory.Krypton.Toolkit.KryptonLabel nickLabel;
            ComponentFactory.Krypton.Toolkit.KryptonLabel tagLabel;
            ComponentFactory.Krypton.Toolkit.KryptonLabel infoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerListFrm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.splitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.checkBtnAddPlayer = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkButtonEditPlayer = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkButtonRemovePlayer = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnAddToMatch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnEditCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.playerIdTextBox = new System.Windows.Forms.TextBox();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.checkSet = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            playerIdLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            nameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            surnameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            nickLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            tagLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            infoLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel1)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel2)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.toolStripContainer2.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkSet)).BeginInit();
            this.SuspendLayout();
            // 
            // playerIdLabel
            // 
            playerIdLabel.Location = new System.Drawing.Point(12, 20);
            playerIdLabel.Name = "playerIdLabel";
            playerIdLabel.Size = new System.Drawing.Size(60, 20);
            playerIdLabel.TabIndex = 0;
            playerIdLabel.TabStop = false;
            playerIdLabel.Values.Text = "Player Id:";
            // 
            // nameLabel
            // 
            nameLabel.Location = new System.Drawing.Point(12, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(46, 20);
            nameLabel.TabIndex = 2;
            nameLabel.TabStop = false;
            nameLabel.Values.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.Location = new System.Drawing.Point(12, 110);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(61, 20);
            surnameLabel.TabIndex = 4;
            surnameLabel.TabStop = false;
            surnameLabel.Values.Text = "Surname:";
            // 
            // nickLabel
            // 
            nickLabel.Location = new System.Drawing.Point(12, 155);
            nickLabel.Name = "nickLabel";
            nickLabel.Size = new System.Drawing.Size(37, 20);
            nickLabel.TabIndex = 6;
            nickLabel.TabStop = false;
            nickLabel.Values.Text = "Nick:";
            // 
            // tagLabel
            // 
            tagLabel.Location = new System.Drawing.Point(12, 200);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(33, 20);
            tagLabel.TabIndex = 8;
            tagLabel.TabStop = false;
            tagLabel.Values.Text = "Tag:";
            // 
            // infoLabel
            // 
            infoLabel.Location = new System.Drawing.Point(12, 245);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(35, 20);
            infoLabel.TabIndex = 10;
            infoLabel.TabStop = false;
            infoLabel.Values.Text = "Info:";
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(842, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 17);
            this.labelStatus.Text = "Ready";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(842, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "&Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem,
            this.editPlayerToolStripMenuItem,
            this.deletePlayerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // newPlayerToolStripMenuItem
            // 
            this.newPlayerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newPlayerToolStripMenuItem.Image")));
            this.newPlayerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            this.newPlayerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newPlayerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newPlayerToolStripMenuItem.Text = "&New player";
            this.newPlayerToolStripMenuItem.Click += new System.EventHandler(this.newPlayerToolStripMenuItem_Click);
            // 
            // editPlayerToolStripMenuItem
            // 
            this.editPlayerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editPlayerToolStripMenuItem.Image")));
            this.editPlayerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPlayerToolStripMenuItem.Name = "editPlayerToolStripMenuItem";
            this.editPlayerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editPlayerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editPlayerToolStripMenuItem.Text = "&Edit player";
            this.editPlayerToolStripMenuItem.Click += new System.EventHandler(this.editPlayerToolStripMenuItem_Click);
            // 
            // deletePlayerToolStripMenuItem
            // 
            this.deletePlayerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePlayerToolStripMenuItem.Image")));
            this.deletePlayerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletePlayerToolStripMenuItem.Name = "deletePlayerToolStripMenuItem";
            this.deletePlayerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deletePlayerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deletePlayerToolStripMenuItem.Text = "&Delete player";
            this.deletePlayerToolStripMenuItem.Click += new System.EventHandler(this.removePlayerStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.kryptonPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(842, 598);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(842, 623);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.splitContainer);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(842, 598);
            this.kryptonPanel.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvPlayers);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnClose);
            this.splitContainer.Panel2.Controls.Add(this.kryptonGroupBox2);
            this.splitContainer.Panel2.Controls.Add(this.btnAddToMatch);
            this.splitContainer.Panel2.Controls.Add(this.kryptonGroupBox1);
            this.splitContainer.Size = new System.Drawing.Size(842, 598);
            this.splitContainer.SplitterDistance = 555;
            this.splitContainer.TabIndex = 11;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlayers.Location = new System.Drawing.Point(0, 0);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(555, 598);
            this.dgvPlayers.TabIndex = 0;
            this.dgvPlayers.SelectionChanged += new System.EventHandler(this.dgvPlayers_SelectionChanged);
            this.dgvPlayers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPlayers_KeyDown);
            this.dgvPlayers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPlayers_MouseDown);
            this.dgvPlayers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvPlayers_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(96, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 50);
            this.btnClose.TabIndex = 12;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(8, 3);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.checkBtnAddPlayer);
            this.kryptonGroupBox2.Panel.Controls.Add(this.checkButtonEditPlayer);
            this.kryptonGroupBox2.Panel.Controls.Add(this.checkButtonRemovePlayer);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(265, 105);
            this.kryptonGroupBox2.TabIndex = 11;
            this.kryptonGroupBox2.Text = "Operation:";
            this.kryptonGroupBox2.Values.Heading = "Operation:";
            // 
            // checkBtnAddPlayer
            // 
            this.checkBtnAddPlayer.Location = new System.Drawing.Point(3, 3);
            this.checkBtnAddPlayer.Name = "checkBtnAddPlayer";
            this.checkBtnAddPlayer.Size = new System.Drawing.Size(126, 25);
            this.checkBtnAddPlayer.TabIndex = 1;
            this.checkBtnAddPlayer.Values.Text = "Add new player";
            // 
            // checkButtonEditPlayer
            // 
            this.checkButtonEditPlayer.Location = new System.Drawing.Point(3, 44);
            this.checkButtonEditPlayer.Name = "checkButtonEditPlayer";
            this.checkButtonEditPlayer.Size = new System.Drawing.Size(125, 25);
            this.checkButtonEditPlayer.TabIndex = 2;
            this.checkButtonEditPlayer.Values.Text = "Edit player data";
            // 
            // checkButtonRemovePlayer
            // 
            this.checkButtonRemovePlayer.Location = new System.Drawing.Point(154, 3);
            this.checkButtonRemovePlayer.Name = "checkButtonRemovePlayer";
            this.checkButtonRemovePlayer.Size = new System.Drawing.Size(104, 25);
            this.checkButtonRemovePlayer.TabIndex = 3;
            this.checkButtonRemovePlayer.Values.Text = "Delete player";
            // 
            // btnAddToMatch
            // 
            this.btnAddToMatch.Location = new System.Drawing.Point(22, 473);
            this.btnAddToMatch.Name = "btnAddToMatch";
            this.btnAddToMatch.Size = new System.Drawing.Size(236, 50);
            this.btnAddToMatch.TabIndex = 10;
            this.btnAddToMatch.Values.Text = "Add player to match";
            this.btnAddToMatch.Click += new System.EventHandler(this.btnAddToMatch_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox1.Location = new System.Drawing.Point(8, 114);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnEditCancel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnEditOK);
            this.kryptonGroupBox1.Panel.Controls.Add(infoLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.infoTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(tagLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tagTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(nickLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.nickTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(surnameLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.surnameTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(nameLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.nameTextBox);
            this.kryptonGroupBox1.Panel.Controls.Add(playerIdLabel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.playerIdTextBox);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(265, 353);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Text = "Player data:";
            this.kryptonGroupBox1.Values.Heading = "Player data:";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(154, 292);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(90, 25);
            this.btnEditCancel.TabIndex = 11;
            this.btnEditCancel.Values.Text = "Cancel";
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditOK
            // 
            this.btnEditOK.Location = new System.Drawing.Point(12, 292);
            this.btnEditOK.Name = "btnEditOK";
            this.btnEditOK.Size = new System.Drawing.Size(100, 25);
            this.btnEditOK.TabIndex = 9;
            this.btnEditOK.Values.Text = "OK";
            this.btnEditOK.Click += new System.EventHandler(this.btnEditOK_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(103, 245);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(141, 20);
            this.infoTextBox.TabIndex = 8;
            // 
            // tagTextBox
            // 
            this.tagTextBox.Location = new System.Drawing.Point(103, 200);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(141, 20);
            this.tagTextBox.TabIndex = 7;
            // 
            // nickTextBox
            // 
            this.nickTextBox.Location = new System.Drawing.Point(103, 155);
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(141, 20);
            this.nickTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(103, 110);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(141, 20);
            this.surnameTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(141, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // playerIdTextBox
            // 
            this.playerIdTextBox.Location = new System.Drawing.Point(103, 20);
            this.playerIdTextBox.Name = "playerIdTextBox";
            this.playerIdTextBox.ReadOnly = true;
            this.playerIdTextBox.Size = new System.Drawing.Size(141, 20);
            this.playerIdTextBox.TabIndex = 0;
            this.playerIdTextBox.TabStop = false;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.BottomToolStripPanel
            // 
            this.toolStripContainer2.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.AutoScroll = true;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStripContainer1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(842, 623);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(842, 670);
            this.toolStripContainer2.TabIndex = 3;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer3
            // 
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.AutoScroll = true;
            this.toolStripContainer3.ContentPanel.Controls.Add(this.toolStripContainer2);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(842, 670);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(842, 694);
            this.toolStripContainer3.TabIndex = 4;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // checkSet
            // 
            this.checkSet.CheckButtons.Add(this.checkBtnAddPlayer);
            this.checkSet.CheckButtons.Add(this.checkButtonEditPlayer);
            this.checkSet.CheckButtons.Add(this.checkButtonRemovePlayer);
            this.checkSet.CheckedButtonChanged += new System.EventHandler(this.checkSet_CheckedButtonChanged);
            // 
            // PlayerListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 694);
            this.Controls.Add(this.toolStripContainer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "PlayerListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Player List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerListFrm_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel1)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel2)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.toolStripContainer2.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.TextBox nickTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox playerIdTextBox;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddToMatch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditOK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkButtonRemovePlayer;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkButtonEditPlayer;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkBtnAddPlayer;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet checkSet;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
    }
}

