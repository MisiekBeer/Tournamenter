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
            this.globalPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tbKsywa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbImie = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupPunkty = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            // 
            // globalPalette
            // 
            this.globalPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.globalPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.palettePlayer.BasePalette = this.globalPalette;
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
            this.groupPunkty.Panel.Controls.Add(this.kryptonLabel1);
            this.groupPunkty.Panel.Controls.Add(this.kryptonLabel2);
            this.groupPunkty.Panel.Controls.Add(this.kryptonTextBox4);
            this.groupPunkty.Panel.Controls.Add(this.kryptonLabel4);
            this.groupPunkty.Panel.Controls.Add(this.kryptonTextBox2);
            this.groupPunkty.Panel.Controls.Add(this.kryptonLabel3);
            this.groupPunkty.Panel.Controls.Add(this.kryptonTextBox1);
            this.groupPunkty.Panel.Controls.Add(this.kryptonTextBox3);
            this.groupPunkty.Size = new System.Drawing.Size(374, 98);
            this.groupPunkty.TabIndex = 12;
            this.groupPunkty.Text = "Punkty:";
            this.groupPunkty.Values.Heading = "Punkty:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(63, 49);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.LightGreen;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "01";
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
            // kryptonTextBox4
            // 
            this.kryptonTextBox4.AlwaysActive = false;
            this.kryptonTextBox4.Location = new System.Drawing.Point(204, 65);
            this.kryptonTextBox4.MaxLength = 7;
            this.kryptonTextBox4.Name = "kryptonTextBox4";
            this.kryptonTextBox4.Palette = this.palettePlayer;
            this.kryptonTextBox4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTextBox4.ReadOnly = true;
            this.kryptonTextBox4.Size = new System.Drawing.Size(74, 26);
            this.kryptonTextBox4.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonTextBox4.TabIndex = 7;
            this.kryptonTextBox4.Text = "DP SUM";
            this.kryptonTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.AlwaysActive = false;
            this.kryptonTextBox2.Location = new System.Drawing.Point(204, 35);
            this.kryptonTextBox2.MaxLength = 6;
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Palette = this.palettePlayer;
            this.kryptonTextBox2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTextBox2.Size = new System.Drawing.Size(75, 26);
            this.kryptonTextBox2.TabIndex = 4;
            this.kryptonTextBox2.Text = "DP";
            this.kryptonTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.AlwaysActive = false;
            this.kryptonTextBox1.Location = new System.Drawing.Point(95, 35);
            this.kryptonTextBox1.MaxLength = 6;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Palette = this.palettePlayer;
            this.kryptonTextBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTextBox1.Size = new System.Drawing.Size(78, 26);
            this.kryptonTextBox1.TabIndex = 3;
            this.kryptonTextBox1.Text = "MP";
            this.kryptonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.AlwaysActive = false;
            this.kryptonTextBox3.Location = new System.Drawing.Point(95, 65);
            this.kryptonTextBox3.MaxLength = 7;
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Palette = this.palettePlayer;
            this.kryptonTextBox3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTextBox3.ReadOnly = true;
            this.kryptonTextBox3.Size = new System.Drawing.Size(78, 26);
            this.kryptonTextBox3.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonTextBox3.TabIndex = 6;
            this.kryptonTextBox3.Text = "MP SUM";
            this.kryptonTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupPunkty;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette palettePlayer;
        private System.Windows.Forms.BindingSource bindSrcPlayerStance;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette globalPalette;


    }
}
