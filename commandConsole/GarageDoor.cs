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
	/// Summary description for GarageDoor.
	/// </summary>
	public class GarageDoor
	{
		string location;
		public GarageDoor(string location)
		{
			this.location = location;
		}
		
		public string Up()
		{
            //����� � ����� �������
            return "\nThe door to the garage lift";
		}

		public string Down()
		{
            //����� � ����� ��������
            return "\nThe door to the garage to lower";
		}

		public string Stop()
		{//����� � ����� ����������
			return "\nThe door to the garage to stop";
		}

		public string LightOn()
		{
            //����� � ����� �������
			return "\nThe door to the garage open";
		}

		public string LightOff()
		{
            //����� � ����� �������
			return "\nThe door to the garage is closed";
		}
	}
}
