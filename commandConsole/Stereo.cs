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
	/// Summary description for Stereo.
	/// </summary>
	public class Stereo
	{
		string location;

		public Stereo(string location) 
		{
			this.location = location;
		}

		public string On() 
		{
			return location + " stereo on";
		}

		public string Off() 
		{
			return location + " stereo off";
		}

		public string SetCD() 
		{
			return location + " established CD";
		}

		public string SetDVD() 
		{
			return location + " established DVD ";
		}

		public string SetRadio() 
		{
			return location + "Radio on";
		}

		public string SetVolume(int volume) 
		{
			// code to set the volume
			// valid range: 1-11 (after all 11 is better than 10, right?)
			return location + " Stereo volume set to " + volume;
		}
	}
}
