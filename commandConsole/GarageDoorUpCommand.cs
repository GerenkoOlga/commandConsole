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
	/// Summary description for GarageDoorOpenCommand.
	/// </summary>
	public class GarageDoorUpCommand : ICommand1
	{
		GarageDoor garageDoor;

		public GarageDoorUpCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		#region Command Members

		public object Execute()
		{
			return garageDoor.Up();
		}

		#endregion
	}
}
