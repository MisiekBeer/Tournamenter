namespace Tournamenter_WinFormsApp
{
    partial class MatchSettingsFrm
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
            System.Windows.Forms.Label pointsForBayLabel;
            System.Windows.Forms.Label roundCountLabel;
            System.Windows.Forms.Label walkowerPointsLabel;
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.settingsGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvPointRanges = new System.Windows.Forms.DataGridView();
            this.pointRangesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pointsForBayTextBox = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.walkowerPointsTextBox = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.roundCountTextBox = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.matchSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinPts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoosePts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pointsForBayLabel = new System.Windows.Forms.Label();
            roundCountLabel = new System.Windows.Forms.Label();
            walkowerPointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroupBox.Panel)).BeginInit();
            this.settingsGroupBox.Panel.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointRanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointRangesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsForBayLabel
            // 
            pointsForBayLabel.AutoSize = true;
            pointsForBayLabel.Location = new System.Drawing.Point(193, 24);
            pointsForBayLabel.Name = "pointsForBayLabel";
            pointsForBayLabel.Size = new System.Drawing.Size(78, 13);
            pointsForBayLabel.TabIndex = 0;
            pointsForBayLabel.Text = "Points For Bay:";
            // 
            // roundCountLabel
            // 
            roundCountLabel.AutoSize = true;
            roundCountLabel.Location = new System.Drawing.Point(10, 24);
            roundCountLabel.Name = "roundCountLabel";
            roundCountLabel.Size = new System.Drawing.Size(73, 13);
            roundCountLabel.TabIndex = 4;
            roundCountLabel.Text = "Round Count:";
            // 
            // walkowerPointsLabel
            // 
            walkowerPointsLabel.AutoSize = true;
            walkowerPointsLabel.Location = new System.Drawing.Point(193, 62);
            walkowerPointsLabel.Name = "walkowerPointsLabel";
            walkowerPointsLabel.Size = new System.Drawing.Size(90, 13);
            walkowerPointsLabel.TabIndex = 6;
            walkowerPointsLabel.Text = "Walkower Points:";
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.settingsGroupBox);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(384, 460);
            this.kryptonPanel.TabIndex = 0;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.settingsGroupBox.Name = "settingsGroupBox";
            // 
            // settingsGroupBox.Panel
            // 
            this.settingsGroupBox.Panel.Controls.Add(this.kryptonGroupBox1);
            this.settingsGroupBox.Panel.Controls.Add(this.btnOK);
            this.settingsGroupBox.Panel.Controls.Add(pointsForBayLabel);
            this.settingsGroupBox.Panel.Controls.Add(this.pointsForBayTextBox);
            this.settingsGroupBox.Panel.Controls.Add(walkowerPointsLabel);
            this.settingsGroupBox.Panel.Controls.Add(this.walkowerPointsTextBox);
            this.settingsGroupBox.Panel.Controls.Add(roundCountLabel);
            this.settingsGroupBox.Panel.Controls.Add(this.roundCountTextBox);
            this.settingsGroupBox.Size = new System.Drawing.Size(384, 460);
            this.settingsGroupBox.TabIndex = 8;
            this.settingsGroupBox.Text = "Settings:";
            this.settingsGroupBox.Values.Heading = "Settings:";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 87);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.dgvPointRanges);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(374, 307);
            this.kryptonGroupBox1.TabIndex = 10;
            this.kryptonGroupBox1.Text = "Point Ranges Difference";
            this.kryptonGroupBox1.Values.Heading = "Point Ranges Difference";
            // 
            // dgvPointRanges
            // 
            this.dgvPointRanges.AutoGenerateColumns = false;
            this.dgvPointRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointRanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.minPointsDataGridViewTextBoxColumn,
            this.maxPointsDataGridViewTextBoxColumn,
            this.WinPts,
            this.LoosePts});
            this.dgvPointRanges.DataSource = this.pointRangesBindingSource;
            this.dgvPointRanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPointRanges.Location = new System.Drawing.Point(0, 0);
            this.dgvPointRanges.Name = "dgvPointRanges";
            this.dgvPointRanges.RowHeadersWidth = 25;
            this.dgvPointRanges.Size = new System.Drawing.Size(370, 283);
            this.dgvPointRanges.TabIndex = 9;
            this.dgvPointRanges.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPointRanges_CellPainting);
            // 
            // pointRangesBindingSource
            // 
            this.pointRangesBindingSource.AllowNew = false;
            this.pointRangesBindingSource.DataMember = "PointRanges";
            this.pointRangesBindingSource.DataSource = this.matchSettingsBindingSource;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(287, 404);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 8;
            this.btnOK.Values.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pointsForBayTextBox
            // 
            this.pointsForBayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "PointsForBay", true));
            this.pointsForBayTextBox.Location = new System.Drawing.Point(288, 21);
            this.pointsForBayTextBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.pointsForBayTextBox.Name = "pointsForBayTextBox";
            this.pointsForBayTextBox.Size = new System.Drawing.Size(80, 22);
            this.pointsForBayTextBox.TabIndex = 1;
            // 
            // walkowerPointsTextBox
            // 
            this.walkowerPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "WalkowerPoints", true));
            this.walkowerPointsTextBox.Location = new System.Drawing.Point(288, 59);
            this.walkowerPointsTextBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.walkowerPointsTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.walkowerPointsTextBox.Name = "walkowerPointsTextBox";
            this.walkowerPointsTextBox.Size = new System.Drawing.Size(80, 22);
            this.walkowerPointsTextBox.TabIndex = 7;
            this.walkowerPointsTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // roundCountTextBox
            // 
            this.roundCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "RoundCount", true));
            this.roundCountTextBox.Location = new System.Drawing.Point(101, 21);
            this.roundCountTextBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.roundCountTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roundCountTextBox.Name = "roundCountTextBox";
            this.roundCountTextBox.Size = new System.Drawing.Size(80, 22);
            this.roundCountTextBox.TabIndex = 5;
            this.roundCountTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // matchSettingsBindingSource
            // 
            this.matchSettingsBindingSource.AllowNew = false;
            this.matchSettingsBindingSource.DataSource = typeof(Logic.MatchSettings);
            // 
            // minPointsDataGridViewTextBoxColumn
            // 
            this.minPointsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.minPointsDataGridViewTextBoxColumn.DataPropertyName = "MinPoints";
            this.minPointsDataGridViewTextBoxColumn.FillWeight = 25F;
            this.minPointsDataGridViewTextBoxColumn.HeaderText = "MinPoints";
            this.minPointsDataGridViewTextBoxColumn.Name = "minPointsDataGridViewTextBoxColumn";
            this.minPointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxPointsDataGridViewTextBoxColumn
            // 
            this.maxPointsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxPointsDataGridViewTextBoxColumn.DataPropertyName = "MaxPoints";
            this.maxPointsDataGridViewTextBoxColumn.FillWeight = 25F;
            this.maxPointsDataGridViewTextBoxColumn.HeaderText = "MaxPoints";
            this.maxPointsDataGridViewTextBoxColumn.Name = "maxPointsDataGridViewTextBoxColumn";
            this.maxPointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WinPts
            // 
            this.WinPts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WinPts.DataPropertyName = "WinPts";
            this.WinPts.FillWeight = 25F;
            this.WinPts.HeaderText = "WinPts";
            this.WinPts.Name = "WinPts";
            this.WinPts.ReadOnly = true;
            // 
            // LoosePts
            // 
            this.LoosePts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoosePts.DataPropertyName = "LoosePts";
            this.LoosePts.FillWeight = 25F;
            this.LoosePts.HeaderText = "LoosePts";
            this.LoosePts.Name = "LoosePts";
            this.LoosePts.ReadOnly = true;
            // 
            // MatchSettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 460);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatchSettingsFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MatchSettings";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroupBox.Panel)).EndInit();
            this.settingsGroupBox.Panel.ResumeLayout(false);
            this.settingsGroupBox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroupBox)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointRanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointRangesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown pointsForBayTextBox;
        private System.Windows.Forms.BindingSource matchSettingsBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown roundCountTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown walkowerPointsTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox settingsGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.DataGridView dgvPointRanges;
        private System.Windows.Forms.BindingSource pointRangesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn minPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinPts;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoosePts;
    }
}

