namespace Tournamenter_WinFormsApp
{
    partial class RoundCtrl
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
            this.roundHGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.roundHGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundHGroup.Panel)).BeginInit();
            this.roundHGroup.Panel.SuspendLayout();
            this.roundHGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundHGroup
            // 
            this.roundHGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundHGroup.Location = new System.Drawing.Point(5, 5);
            this.roundHGroup.Name = "roundHGroup";
            // 
            // roundHGroup.Panel
            // 
            this.roundHGroup.Panel.AutoScroll = true;
            this.roundHGroup.Panel.Controls.Add(this.tableLayout);
            this.roundHGroup.Size = new System.Drawing.Size(397, 789);
            this.roundHGroup.TabIndex = 0;
            this.roundHGroup.ValuesPrimary.Heading = "Round";
            this.roundHGroup.ValuesSecondary.Heading = "Round Description - player count etc.";
            // 
            // tableLayout
            // 
            this.tableLayout.AutoScroll = true;
            this.tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.Size = new System.Drawing.Size(395, 736);
            this.tableLayout.TabIndex = 0;
            // 
            // RoundCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.roundHGroup);
            this.DoubleBuffered = true;
            this.Name = "RoundCtrl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(407, 799);
            ((System.ComponentModel.ISupportInitialize)(this.roundHGroup.Panel)).EndInit();
            this.roundHGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundHGroup)).EndInit();
            this.roundHGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup roundHGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayout;

    }
}
