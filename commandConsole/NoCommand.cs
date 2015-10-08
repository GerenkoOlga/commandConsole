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
	/// Summary description for NoCommand.
	/// </summary>
	public class NoCommand : ICommand1
	{
		public NoCommand()
		{}

		#region Command Members
		public object Execute()
		{
			return null;
		}
		#endregion
	}
}
