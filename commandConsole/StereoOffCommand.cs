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
	/// Summary description for StereoOffCommand.
	/// </summary>
	public class StereoOffCommand :ICommand1
	{
		Stereo stereo;
		public StereoOffCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		#region Command Members

		public object Execute()
		{
			return stereo.Off();
		}

		#endregion
	}
}
