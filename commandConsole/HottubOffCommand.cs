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
	/// Summary description for HottubOnCommand.
	/// </summary>
	public class HottubOffCommand : ICommand1
	{
		Hottub hottub;

		public HottubOffCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}

		#region Command Members
		public object Execute()
		{
			return hottub.Off();
		}
		#endregion
	}
}
