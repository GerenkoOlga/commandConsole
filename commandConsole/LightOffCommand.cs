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
	public class LightOffCommand : ICommand1
	{
		Light light;

		public LightOffCommand(Light light)
		{
			this.light = light;
		}

		#region Command Members

		public object Execute()
		{
			return light.Off();
		}

		#endregion
	}
}
