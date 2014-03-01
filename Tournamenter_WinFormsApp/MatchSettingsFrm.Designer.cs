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
			ComponentFactory.Krypton.Toolkit.KryptonLabel pointsForBayLabel;
			ComponentFactory.Krypton.Toolkit.KryptonLabel roundCountLabel;
			ComponentFactory.Krypton.Toolkit.KryptonLabel walkowerPointsLabel;
			ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
			this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.settingsGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
			this.tablesCount = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
			this.matchSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
			this.dgvPointRanges = new System.Windows.Forms.DataGridView();
			this.minPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WinPts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoosePts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pointRangesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.pointsForBay = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
			this.walkowerPoints = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
			this.roundCount = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
			pointsForBayLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			roundCountLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			walkowerPointsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.settingsGroupBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.settingsGroupBox.Panel)).BeginInit();
			this.settingsGroupBox.Panel.SuspendLayout();
			this.settingsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.matchSettingsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
			this.kryptonGroupBox1.Panel.SuspendLayout();
			this.kryptonGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPointRanges)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pointRangesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pointsForBayLabel
			// 
			pointsForBayLabel.Location = new System.Drawing.Point(193, 24);
			pointsForBayLabel.Name = "pointsForBayLabel";
			pointsForBayLabel.Size = new System.Drawing.Size(90, 20);
			pointsForBayLabel.TabIndex = 0;
			pointsForBayLabel.Values.Text = "Points For Bay:";
			// 
			// roundCountLabel
			// 
			roundCountLabel.Location = new System.Drawing.Point(10, 24);
			roundCountLabel.Name = "roundCountLabel";
			roundCountLabel.Size = new System.Drawing.Size(86, 20);
			roundCountLabel.TabIndex = 4;
			roundCountLabel.Values.Text = "Round Count:";
			// 
			// walkowerPointsLabel
			// 
			walkowerPointsLabel.Location = new System.Drawing.Point(193, 62);
			walkowerPointsLabel.Name = "walkowerPointsLabel";
			walkowerPointsLabel.Size = new System.Drawing.Size(104, 20);
			walkowerPointsLabel.TabIndex = 6;
			walkowerPointsLabel.Values.Text = "Walkower Points:";
			// 
			// kryptonLabel1
			// 
			kryptonLabel1.Location = new System.Drawing.Point(10, 62);
			kryptonLabel1.Name = "kryptonLabel1";
			kryptonLabel1.Size = new System.Drawing.Size(84, 20);
			kryptonLabel1.TabIndex = 11;
			kryptonLabel1.Values.Text = "Tables Count:";
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
			this.settingsGroupBox.Panel.Controls.Add(this.tablesCount);
			this.settingsGroupBox.Panel.Controls.Add(kryptonLabel1);
			this.settingsGroupBox.Panel.Controls.Add(this.kryptonGroupBox1);
			this.settingsGroupBox.Panel.Controls.Add(this.btnOK);
			this.settingsGroupBox.Panel.Controls.Add(pointsForBayLabel);
			this.settingsGroupBox.Panel.Controls.Add(this.pointsForBay);
			this.settingsGroupBox.Panel.Controls.Add(walkowerPointsLabel);
			this.settingsGroupBox.Panel.Controls.Add(this.walkowerPoints);
			this.settingsGroupBox.Panel.Controls.Add(roundCountLabel);
			this.settingsGroupBox.Panel.Controls.Add(this.roundCount);
			this.settingsGroupBox.Size = new System.Drawing.Size(384, 460);
			this.settingsGroupBox.TabIndex = 8;
			this.settingsGroupBox.Text = "Settings:";
			this.settingsGroupBox.Values.Heading = "Settings:";
			// 
			// tablesCount
			// 
			this.tablesCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "TablesCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tablesCount.Location = new System.Drawing.Point(116, 62);
			this.tablesCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.tablesCount.Name = "tablesCount";
			this.tablesCount.Size = new System.Drawing.Size(65, 22);
			this.tablesCount.TabIndex = 12;
			this.tablesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tablesCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// matchSettingsBindingSource
			// 
			this.matchSettingsBindingSource.AllowNew = false;
			this.matchSettingsBindingSource.DataSource = typeof(Logic.MatchSettings);
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
			// minPointsDataGridViewTextBoxColumn
			// 
			this.minPointsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.minPointsDataGridViewTextBoxColumn.DataPropertyName = "MinPoints";
			this.minPointsDataGridViewTextBoxColumn.FillWeight = 25F;
			this.minPointsDataGridViewTextBoxColumn.HeaderText = "Min Points";
			this.minPointsDataGridViewTextBoxColumn.Name = "minPointsDataGridViewTextBoxColumn";
			this.minPointsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// maxPointsDataGridViewTextBoxColumn
			// 
			this.maxPointsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.maxPointsDataGridViewTextBoxColumn.DataPropertyName = "MaxPoints";
			this.maxPointsDataGridViewTextBoxColumn.FillWeight = 25F;
			this.maxPointsDataGridViewTextBoxColumn.HeaderText = "Max Points";
			this.maxPointsDataGridViewTextBoxColumn.Name = "maxPointsDataGridViewTextBoxColumn";
			this.maxPointsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// WinPts
			// 
			this.WinPts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.WinPts.DataPropertyName = "WinPts";
			this.WinPts.FillWeight = 25F;
			this.WinPts.HeaderText = "Winner Pts";
			this.WinPts.Name = "WinPts";
			this.WinPts.ReadOnly = true;
			// 
			// LoosePts
			// 
			this.LoosePts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LoosePts.DataPropertyName = "LoosePts";
			this.LoosePts.FillWeight = 25F;
			this.LoosePts.HeaderText = "Looser Pts";
			this.LoosePts.Name = "LoosePts";
			this.LoosePts.ReadOnly = true;
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
			// pointsForBay
			// 
			this.pointsForBay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "PointsForBay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pointsForBay.Location = new System.Drawing.Point(303, 21);
			this.pointsForBay.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.pointsForBay.Name = "pointsForBay";
			this.pointsForBay.Size = new System.Drawing.Size(65, 22);
			this.pointsForBay.TabIndex = 1;
			this.pointsForBay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// walkowerPoints
			// 
			this.walkowerPoints.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "WalkowerPoints", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.walkowerPoints.Location = new System.Drawing.Point(303, 59);
			this.walkowerPoints.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.walkowerPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.walkowerPoints.Name = "walkowerPoints";
			this.walkowerPoints.Size = new System.Drawing.Size(65, 22);
			this.walkowerPoints.TabIndex = 7;
			this.walkowerPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.walkowerPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// roundCount
			// 
			this.roundCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "RoundCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.roundCount.Location = new System.Drawing.Point(116, 21);
			this.roundCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.roundCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.roundCount.Name = "roundCount";
			this.roundCount.Size = new System.Drawing.Size(65, 22);
			this.roundCount.TabIndex = 5;
			this.roundCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.roundCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
			((System.ComponentModel.ISupportInitialize)(this.matchSettingsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
			this.kryptonGroupBox1.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
			this.kryptonGroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPointRanges)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pointRangesBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown pointsForBay;
        private System.Windows.Forms.BindingSource matchSettingsBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown roundCount;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown walkowerPoints;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox settingsGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.DataGridView dgvPointRanges;
        private System.Windows.Forms.BindingSource pointRangesBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown tablesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn minPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinPts;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoosePts;
    }
}

