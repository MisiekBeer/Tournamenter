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
            this.roundGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.roundGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundGroup.Panel)).BeginInit();
            this.roundGroup.Panel.SuspendLayout();
            this.roundGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundGroup
            // 
            this.roundGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundGroup.Location = new System.Drawing.Point(5, 5);
            this.roundGroup.Name = "roundGroup";
            // 
            // roundGroup.Panel
            // 
            this.roundGroup.Panel.AutoScroll = true;
            this.roundGroup.Panel.Controls.Add(this.tableLayout);
            this.roundGroup.Size = new System.Drawing.Size(397, 789);
            this.roundGroup.TabIndex = 0;
            this.roundGroup.ValuesPrimary.Heading = "Round";
            this.roundGroup.ValuesSecondary.Heading = "Round Description - player count etc.";
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
            this.tableLayout.RowCount = 1;
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
            this.Controls.Add(this.roundGroup);
            this.DoubleBuffered = true;
            this.RoundName = "RoundCtrl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(407, 799);
            ((System.ComponentModel.ISupportInitialize)(this.roundGroup.Panel)).EndInit();
            this.roundGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundGroup)).EndInit();
            this.roundGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup roundGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayout;

    }
}
