using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Logic;

namespace Tournamenter_WinFormsApp
{
    public partial class MatchSettingsFrm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
		#region props
		public MatchSettings Settings { get { return (MatchSettings)matchSettingsBindingSource.DataSource; } } 
		#endregion

		#region fields
		bool _isReadonly; 
		#endregion

		#region ctor
		public MatchSettingsFrm()
		{
			InitializeComponent();
		} 
		#endregion

		#region methods
		public MatchSettingsFrm(MatchSettings settings, bool isReadonly)
			: this()
		{
			matchSettingsBindingSource.DataSource = settings.Clone();

			if (isReadonly)
			{
				_isReadonly = true;
				SetReadonlyMode();
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			MatchSettings.DefaultSettings = Settings;
			this.Close();
		}

		internal void SetReadonlyMode()
		{
			_isReadonly = pointsForBay.ReadOnly = walkowerPoints.ReadOnly = roundCount.ReadOnly =
				tablesCount.ReadOnly = dgvPointRanges.ReadOnly = true;
		}

		private void dgvPointRanges_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == maxPointsDataGridViewTextBoxColumn.Index && e.RowIndex > 0)
				if (e.Value != null && (int)e.Value == int.MaxValue)
				{
					e.PaintBackground(e.CellBounds, true);
					e.Graphics.DrawString("...", maxPointsDataGridViewTextBoxColumn.InheritedStyle.Font, Brushes.Black, e.CellBounds);
					e.Handled = true;
				}
		} 
		#endregion
    }
}