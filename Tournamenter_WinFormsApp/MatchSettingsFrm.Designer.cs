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
            System.Windows.Forms.Label pointsForDrawLabel;
            System.Windows.Forms.Label roundCountLabel;
            System.Windows.Forms.Label walkowerPointsLabel;
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.settingsGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pointsForBayTextBox = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.pointsForDrawTextBox = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.walkowerPointsTextBox = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.roundCountTextBox = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.matchSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            pointsForBayLabel = new System.Windows.Forms.Label();
            pointsForDrawLabel = new System.Windows.Forms.Label();
            roundCountLabel = new System.Windows.Forms.Label();
            walkowerPointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGroupBox.Panel)).BeginInit();
            this.settingsGroupBox.Panel.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsForBayLabel
            // 
            pointsForBayLabel.AutoSize = true;
            pointsForBayLabel.Location = new System.Drawing.Point(10, 61);
            pointsForBayLabel.Name = "pointsForBayLabel";
            pointsForBayLabel.Size = new System.Drawing.Size(78, 13);
            pointsForBayLabel.TabIndex = 0;
            pointsForBayLabel.Text = "Points For Bay:";
            // 
            // pointsForDrawLabel
            // 
            pointsForDrawLabel.AutoSize = true;
            pointsForDrawLabel.Location = new System.Drawing.Point(10, 98);
            pointsForDrawLabel.Name = "pointsForDrawLabel";
            pointsForDrawLabel.Size = new System.Drawing.Size(85, 13);
            pointsForDrawLabel.TabIndex = 2;
            pointsForDrawLabel.Text = "Points For Draw:";
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
            walkowerPointsLabel.Location = new System.Drawing.Point(10, 135);
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
            this.kryptonPanel.Size = new System.Drawing.Size(248, 237);
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
            this.settingsGroupBox.Panel.Controls.Add(this.btnOK);
            this.settingsGroupBox.Panel.Controls.Add(pointsForBayLabel);
            this.settingsGroupBox.Panel.Controls.Add(this.pointsForBayTextBox);
            this.settingsGroupBox.Panel.Controls.Add(pointsForDrawLabel);
            this.settingsGroupBox.Panel.Controls.Add(walkowerPointsLabel);
            this.settingsGroupBox.Panel.Controls.Add(this.pointsForDrawTextBox);
            this.settingsGroupBox.Panel.Controls.Add(this.walkowerPointsTextBox);
            this.settingsGroupBox.Panel.Controls.Add(roundCountLabel);
            this.settingsGroupBox.Panel.Controls.Add(this.roundCountTextBox);
            this.settingsGroupBox.Size = new System.Drawing.Size(248, 237);
            this.settingsGroupBox.TabIndex = 8;
            this.settingsGroupBox.Text = "Settings:";
            this.settingsGroupBox.Values.Heading = "Settings:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(66, 178);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 8;
            this.btnOK.Values.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pointsForBayTextBox
            // 
            this.pointsForBayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "PointsForBay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pointsForBayTextBox.Location = new System.Drawing.Point(127, 58);
            this.pointsForBayTextBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.pointsForBayTextBox.Name = "pointsForBayTextBox";
            this.pointsForBayTextBox.Size = new System.Drawing.Size(80, 22);
            this.pointsForBayTextBox.TabIndex = 1;
            // 
            // pointsForDrawTextBox
            // 
            this.pointsForDrawTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "PointsForDraw", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pointsForDrawTextBox.Location = new System.Drawing.Point(127, 95);
            this.pointsForDrawTextBox.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.pointsForDrawTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointsForDrawTextBox.Name = "pointsForDrawTextBox";
            this.pointsForDrawTextBox.Size = new System.Drawing.Size(80, 22);
            this.pointsForDrawTextBox.TabIndex = 3;
            this.pointsForDrawTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // walkowerPointsTextBox
            // 
            this.walkowerPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "WalkowerPoints", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.walkowerPointsTextBox.Location = new System.Drawing.Point(127, 132);
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
            this.roundCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchSettingsBindingSource, "RoundCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roundCountTextBox.Location = new System.Drawing.Point(127, 21);
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
            // MatchSettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 237);
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
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown pointsForBayTextBox;
        private System.Windows.Forms.BindingSource matchSettingsBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown pointsForDrawTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown roundCountTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown walkowerPointsTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox settingsGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
    }
}

