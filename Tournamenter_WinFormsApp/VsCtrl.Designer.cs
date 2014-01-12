namespace Tournamenter_WinFormsApp
{
    partial class VsCtrl
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
            this.vsGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            ((System.ComponentModel.ISupportInitialize)(this.vsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsGroup.Panel)).BeginInit();
            this.vsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsGroup
            // 
            this.vsGroup.AutoSize = true;
            this.vsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsGroup.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.vsGroup.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top;
            this.vsGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.vsGroup.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.vsGroup.Location = new System.Drawing.Point(5, 5);
            this.vsGroup.Name = "vsGroup";
            // 
            // vsGroup.Panel
            // 
            this.vsGroup.Panel.AllowDrop = true;
            this.vsGroup.Size = new System.Drawing.Size(466, 308);
            this.vsGroup.StateCommon.HeaderPrimary.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.vsGroup.TabIndex = 0;
            this.vsGroup.ValuesPrimary.Heading = "VS";
            this.vsGroup.ValuesPrimary.Image = null;
            this.vsGroup.ValuesSecondary.Heading = "Table number";
            // 
            // VsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.vsGroup);
            this.DoubleBuffered = true;
            this.Name = "VsCtrl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(476, 318);
            ((System.ComponentModel.ISupportInitialize)(this.vsGroup.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsGroup)).EndInit();
            this.vsGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup vsGroup;

    }
}
