namespace Tournamenter_WinFormsApp
{
    partial class PlayerPositionCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.tbNazwisko = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.palettePlayer = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tbKsywa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbImie = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupPunkty = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.labelPosition = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbTotalBigPoints = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbBigPoints = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbSmallPoints = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbTotalSmallPoints = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bindSrcPlayerStance = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPunkty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPunkty.Panel)).BeginInit();
            this.groupPunkty.Panel.SuspendLayout();
            this.groupPunkty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcPlayerStance)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(5, 5);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.tbNazwisko);
            this.kryptonGroup1.Panel.Controls.Add(this.tbKsywa);
            this.kryptonGroup1.Panel.Controls.Add(this.tbImie);
            this.kryptonGroup1.Panel.Controls.Add(this.groupPunkty);
            this.kryptonGroup1.Size = new System.Drawing.Size(376, 138);
            this.kryptonGroup1.TabIndex = 0;
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.AlwaysActive = false;
            this.tbNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcPlayerStance, "Player.Surname", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbNazwisko.Location = new System.Drawing.Point(230, 3);
            this.tbNazwisko.MaxLength = 35;
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Palette = this.palettePlayer;
            this.tbNazwisko.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.tbNazwisko.ReadOnly = true;
            this.tbNazwisko.Size = new System.Drawing.Size(140, 26);
            this.tbNazwisko.TabIndex = 2;
            this.tbNazwisko.Text = "Nazwisko";
            // 
            // palettePlayer
            // 
            this.palettePlayer.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.palettePlayer.Common.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.palettePlayer.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.palettePlayer.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.palettePlayer.LabelStyles.LabelNormalControl.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            // 
            // tbKsywa
            // 
            this.tbKsywa.AlwaysActive = false;
            this.tbKsywa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcPlayerStance, "Player.Nick", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbKsywa.Location = new System.Drawing.Point(110, 3);
            this.tbKsywa.MaxLength = 25;
            this.tbKsywa.Name = "tbKsywa";
            this.tbKsywa.Palette = this.palettePlayer;
            this.tbKsywa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.tbKsywa.ReadOnly = true;
            this.tbKsywa.Size = new System.Drawing.Size(114, 26);
            this.tbKsywa.TabIndex = 1;
            this.tbKsywa.Text = "Ksywa";
            // 
            // tbImie
            // 
            this.tbImie.AlwaysActive = false;
            this.tbImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcPlayerStance, "Player.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbImie.Location = new System.Drawing.Point(4, 3);
            this.tbImie.MaxLength = 25;
            this.tbImie.Name = "tbImie";
            this.tbImie.Palette = this.palettePlayer;
            this.tbImie.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.tbImie.ReadOnly = true;
            this.tbImie.Size = new System.Drawing.Size(100, 26);
            this.tbImie.TabIndex = 0;
            this.tbImie.Text = "Imię";
            // 
            // groupPunkty
            // 
            this.groupPunkty.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.groupPunkty.CaptionOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.groupPunkty.CaptionOverlap = 0D;
            this.groupPunkty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPunkty.Location = new System.Drawing.Point(0, 38);
            this.groupPunkty.Name = "groupPunkty";
            // 
            // groupPunkty.Panel
            // 
            this.groupPunkty.Panel.Controls.Add(this.labelPosition);
            this.groupPunkty.Panel.Controls.Add(this.kryptonLabel2);
            this.groupPunkty.Panel.Controls.Add(this.tbTotalBigPoints);
            this.groupPunkty.Panel.Controls.Add(this.kryptonLabel4);
            this.groupPunkty.Panel.Controls.Add(this.tbBigPoints);
            this.groupPunkty.Panel.Controls.Add(this.kryptonLabel3);
            this.groupPunkty.Panel.Controls.Add(this.tbSmallPoints);
            this.groupPunkty.Panel.Controls.Add(this.tbTotalSmallPoints);
            this.groupPunkty.Size = new System.Drawing.Size(374, 98);
            this.groupPunkty.TabIndex = 12;
            this.groupPunkty.Text = "Position:\r\n\r\nPoints:\r\n";
            this.groupPunkty.Values.Heading = "Position:\r\n\r\nPoints:\r\n";
            // 
            // labelPosition
            // 
            this.labelPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcPlayerStance, "Place", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelPosition.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.labelPosition.Location = new System.Drawing.Point(14, 4);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(63, 49);
            this.labelPosition.StateCommon.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.labelPosition.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Values.Text = "01";
            this.labelPosition.TextChanged += new System.EventHandler(this.labelPosition_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(117, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Palette = this.palettePlayer;
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel2.Size = new System.Drawing.Size(36, 26);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "MP";
            // 
            // tbTotalBigPoints
            // 
            this.tbTotalBigPoints.AlwaysActive = false;
            this.tbTotalBigPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcPlayerStance, "TotalBigVP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.tbTotalBigPoints.Location = new System.Drawing.Point(204, 65);
            this.tbTotalBigPoints.MaxLength = 7;
            this.tbTotalBigPoints.Name = "tbTotalBigPoints";
            this.tbTotalBigPoints.Palette = this.palettePlayer;
            this.tbTotalBigPoints.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.tbTotalBigPoints.ReadOnly = true;
            this.tbTotalBigPoints.Size = new System.Drawing.Size(74, 26);
            this.tbTotalBigPoints.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTotalBigPoints.TabIndex = 7;
            this.tbTotalBigPoints.Text = "DP SUM";
            this.tbTotalBigPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(225, 4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Palette = this.palettePlayer;
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel4.Size = new System.Drawing.Size(33, 26);
            this.kryptonLabel4.TabIndex = 10;
            this.kryptonLabel4.Values.Text = "DP";
            // 
            // tbBigPoints
            // 
            this.tbBigPoints.AlwaysActive = false;
            this.tbBigPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcPlayerStance, "BigVP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.tbBigPoints.Location = new System.Drawing.Point(204, 35);
            this.tbBigPoints.MaxLength = 6;
            this.tbBigPoints.Name = "tbBigPoints";
            this.tbBigPoints.Palette = this.palettePlayer;
            this.tbBigPoints.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.tbBigPoints.Size = new System.Drawing.Size(75, 26);
            this.tbBigPoints.TabIndex = 4;
            this.tbBigPoints.Text = "DP";
            this.tbBigPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(14, 65);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Palette = this.palettePlayer;
            this.kryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel3.Size = new System.Drawing.Size(57, 26);
            this.kryptonLabel3.TabIndex = 9;
            this.kryptonLabel3.Values.Text = "SUMA";
            // 
            // tbSmallPoints
            // 
            this.tbSmallPoints.AlwaysActive = false;
            this.tbSmallPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcPlayerStance, "SmallVP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.tbSmallPoints.Location = new System.Drawing.Point(95, 35);
            this.tbSmallPoints.MaxLength = 6;
            this.tbSmallPoints.Name = "tbSmallPoints";
            this.tbSmallPoints.Palette = this.palettePlayer;
            this.tbSmallPoints.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.tbSmallPoints.Size = new System.Drawing.Size(78, 26);
            this.tbSmallPoints.TabIndex = 3;
            this.tbSmallPoints.Text = "MP";
            this.tbSmallPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalSmallPoints
            // 
            this.tbTotalSmallPoints.AlwaysActive = false;
            this.tbTotalSmallPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcPlayerStance, "TotalSmallVP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.tbTotalSmallPoints.Location = new System.Drawing.Point(95, 65);
            this.tbTotalSmallPoints.MaxLength = 7;
            this.tbTotalSmallPoints.Name = "tbTotalSmallPoints";
            this.tbTotalSmallPoints.Palette = this.palettePlayer;
            this.tbTotalSmallPoints.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.tbTotalSmallPoints.ReadOnly = true;
            this.tbTotalSmallPoints.Size = new System.Drawing.Size(78, 26);
            this.tbTotalSmallPoints.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTotalSmallPoints.TabIndex = 6;
            this.tbTotalSmallPoints.Text = "MP SUM";
            this.tbTotalSmallPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bindSrcPlayerStance
            // 
            this.bindSrcPlayerStance.AllowNew = false;
            this.bindSrcPlayerStance.DataSource = typeof(Logic.PlayerStance);
            // 
            // PlayerPositionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonGroup1);
            this.Name = "PlayerPositionCtrl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(386, 148);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupPunkty.Panel)).EndInit();
            this.groupPunkty.Panel.ResumeLayout(false);
            this.groupPunkty.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPunkty)).EndInit();
            this.groupPunkty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcPlayerStance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbNazwisko;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbKsywa;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbImie;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupPunkty;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbTotalBigPoints;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbBigPoints;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSmallPoints;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbTotalSmallPoints;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette palettePlayer;
        private System.Windows.Forms.BindingSource bindSrcPlayerStance;


    }
}
