﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DriveASC.ui
{
	public class PanelEx : Panel
	{
		public PanelEx()
		{
			SetStyle(
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.AllPaintingInWmPaint,
				true);
		}
	}
}
