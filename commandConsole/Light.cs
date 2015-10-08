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
	/// Summary description for Light.
	/// </summary>
	public class Light
	{
		string location;
		public Light(string location)
		{
			this.location = location;
		}
		
		public string On()
		{//Свет включен
			return location + "The light is turned on ";
		}

		public string Off()
		{
            //Свет выключен
			return location + "Lights off ";
		}
	}
}
