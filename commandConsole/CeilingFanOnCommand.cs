using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


namespace commandConsole

{
	/// <summary>
	/// Summary description for CeilingFanOnCommand.
	/// </summary>
	public class CeilingFanOnCommand : ICommand1
	{
		CeilingFan ceilingFan;

		public CeilingFanOnCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		#region Command Members

		public object Execute()
		{
			return ceilingFan.High();
		}

		#endregion
	}
}
