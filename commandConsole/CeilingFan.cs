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
	/// Summary description for CeilingFan.
	/// </summary>
	public class CeilingFan
	{
		string location = "";
		int level;
		public const int HIGH = 2;
		public const int MEDIUM = 1;
		public const int LOW = 0;
 
		public CeilingFan(string location) 
		{
			this.location = location;
		}
  
		public string High() 
		{
            // ����������- ������� ��������
            level = HIGH;
			return location + " turns the ceiling fan on to high";
 
		} 

		public string Medium() 
		{
			// ����������- ������� ��������
			level = MEDIUM;
            return location + "turns the ceiling fan on to medium";
		}

		public string Low() 
		{
			// ����������- ����� ��������
			level = LOW;
            return location + "turns the ceiling fan on to low";
		}
 
		public string Off() 
		{
			// ����������-��������
			level = 0;
            return location + "turns the ceiling fan off";
		}
 
		public int GetSpeed() 
		{
			return level;
		}
	}
}
