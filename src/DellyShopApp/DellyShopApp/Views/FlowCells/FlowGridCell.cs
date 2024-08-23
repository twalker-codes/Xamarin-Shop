﻿using System;
using Xamarin.Forms;

namespace DellyShopApp.Views.FlowCells
{
    /// <summary>
	/// FlowListView grid cell.
	/// </summary>
	[Helpers.Preserve(AllMembers = true)]
    public class FlowGridCell : Grid, IFlowViewCell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DLToolkit.Forms.Controls.FlowGridCell"/> class.
        /// </summary>
        public FlowGridCell()
        {
        }

        /// <summary>
        /// Raised when cell is tapped.
        /// </summary>
        public virtual void OnTapped()
        {
        }
    }
}
