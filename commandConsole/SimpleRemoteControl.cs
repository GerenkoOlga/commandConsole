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
	/// Summary description for SimpleRemoteControl
	/// </summary>
	public class SimpleRemoteControl
	{
		ICommand1 slot;

		public SimpleRemoteControl()
		{}

		public object SetCommand(ICommand1 command)
		{
			slot = command;
			return slot;
		}

		public object ButtonWasPressed()
		{
			return slot.Execute();
		}
	}
}
