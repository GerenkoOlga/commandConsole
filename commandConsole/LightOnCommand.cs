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
	/// Summary description for LightOnCommand.
	/// </summary>
	public class LightOnCommand : ICommand1
	{
		Light light;

		public LightOnCommand(Light light)
		{
			this.light = light;
		}

		#region Command Members

		public object Execute()
		{
			return light.On();
		}

		#endregion
	}
}
