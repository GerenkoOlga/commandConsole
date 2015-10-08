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
	/// Summary description for RemoteControl.
	/// </summary>
	//
	// This is the invoker
	//
	public class RemoteControl 
	{
		ICommand1[] onCommands;
		ICommand1[] offCommands;
 
		public RemoteControl() 
		{
			onCommands = new ICommand1[7];
			offCommands = new ICommand1[7];
 
			ICommand1 noCommand = new NoCommand();
			for (int i = 0; i < 7; i++) 
			{
				onCommands[i] = noCommand;
				offCommands[i] = noCommand;
			}
		}
  
		public void SetCommand(int slot, ICommand1 onCommand, ICommand1 offCommand) 
		{
			onCommands[slot] = onCommand;
			offCommands[slot] = offCommand;
		}
 
		public object OnButtonWasPushed(int slot)
		{
			return onCommands[slot].Execute();
		}
 
		public object OffButtonWasPushed(int slot) 
		{
			return offCommands[slot].Execute();
		}
  
		public string toString() 
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("\n------ Remote Control -------\n");
			for (int i = 0; i < onCommands.Length; i++) 
			{
				sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name
					+ "    " + offCommands[i].GetType().Name + "\n");
			}
			return sb.ToString();
		}
	}
}
