/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2/2/2010
 * Time: 8:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices; 

namespace two_back
{
	/// <summary>
	/// Description of writeToPort.
	/// </summary>
	public class writeToPort
	{
		[DllImport("inpout32.dll",EntryPoint="Out32")]
		public static extern void Output(int address,int value);
		[DllImport("inpout32.dll",EntryPoint="Inp32")]
		public static extern int Input(int address);

		public writeToPort()
		{
		}
	}
}
