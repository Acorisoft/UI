using System;
using System.Collections.Generic;
using System.Text;

namespace Acorisoft
{
	public static class BooleanBoxes
	{
		public static object TrueBox = true;

		public static object FalseBox = false;

		public static object Box(bool value)
		{
			if (value)
			{
				return TrueBox;
			}
			return FalseBox;
		}
	}
}
