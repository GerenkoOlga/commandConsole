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
	/// Summary description for StereoOnWithCDCommand.
	/// </summary>
	public class StereoOnWithCDCommand :ICommand1
	{
		Stereo stereo;
		public StereoOnWithCDCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		#region Command Members

		public object Execute()
		{
			return stereo.On() + 
				"\n" + stereo.SetCD() +
				"\n" + stereo.SetVolume(11);
		}

		#endregion
	}
}
