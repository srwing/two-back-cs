/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2/1/2010
 * Time: 6:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.Diagnostics;

namespace two_back
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int[] numbers;
		int count, total_count;
		TextWriter tw;
		bool onscreen;
		Stopwatch stopwatch;
		const int MAX_COUNT = 100;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.ControlBox = false; //The two C# lines take care of removing the title-bar.
			this.Text = string.Empty;
			//this.ShowInTaskBar = false;


			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			count=0;
			total_count=0;
			numbers = new int[100]{8,2,5,7,4,7,1,4,9,6,5,6,9,1,4,1,5,7,4,9,3,9,3,6,5,3,7,4,3,1,6,8,9,4,3,1,
									7,6,3,5,9,3,4,5,7,8,1,5,2,3,4,6,5,1,4,2,4,7,5,6,8,5,7,4,9,3,2,2,4,3,6,
									7,2,3,6,9,4,6,3,5,2,8,9,4,1,5,9,8,4,2,9,3,8,7,5,7,1,6,8,7};

			//string fname=DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() +
			//			DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".txt";
			
			string format = "Mdyy_hmmff";
			
			tw = new StreamWriter(DateTime.Now.ToString(format) + ".txt");
			
			format = "MMM d yyyy, HH:mm:ff";    
			tw.WriteLine(DateTime.Now.ToString(format));
			tw.WriteLine("EEG Signals: 1 - when subject clicks a button, 2 - when a new number comes on screen\n");
			tw.WriteLine("msec\tNumber\tCode");
			writeToPort.Output(52440,9);//0xCCD8 in hex
			
			onscreen = false;
			stopwatch = new Stopwatch();
			
			stopwatch.Start();
			timer1.Interval = 2000;
			timer1.Start();
		}
		
		void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
//    if (e.KeyChar >= 48 && e.KeyChar <= 57)
//    {
//        MessageBox.Show("Form.KeyPress: '" +
//            e.KeyChar.ToString() + "' pressed.");

//		switch (e.alt e.KeyCode)
				switch (e.KeyChar) 
        		{
					case (char) 'q':
			//Keys.Escape:
        				Application.Exit();
//            case (char)49:
//            case (char)52:
//            case (char)55:
//                MessageBox.Show("Form.KeyPress: '" +
//                    e.KeyChar.ToString() + "' consumed.");
                		e.Handled = true;
                		break;
        		}
//    }
		}
/*KeysConverter kc = new KeysConverter();
string keyChar = kc.ConvertToString(keyData);

protected override bool ProcessCmdKey(ref Message msg, Keys keyData)      
  {
     const int WM_KEYDOWN = 0x100;

     if (msg.Msg == WM_KEYDOWN)
     {            
        // 2 is used to translate into an unshifted character value 
        int nonVirtualKey = MapVirtualKey((uint)keyData, 2);

        char mappedChar = Convert.ToChar(nonVirtualKey);
     }

     return base.ProcessCmdKey(ref msg, keyData);
  }
*/			
		void Timer1Tick(object sender, EventArgs e)
		{
			if (count>=33) count=0;
			//string txt = DateTime.Now.Millisecond.ToString();
			
			//string txt = (Stopwatch.GetTimestamp()/Stopwatch.Frequency).ToString();
			string txt = stopwatch.ElapsedMilliseconds.ToString();
			if (!onscreen)
			{
				textBox1.Text = numbers[count].ToString();
				textBox1.Visible = true;
				tw.WriteLine(txt + "\t" + numbers[count].ToString() + "\tOnscreen");
				writeToPort.Output(52440,2);//0xCCD8 in hex
				onscreen=true;
			//if (count>2) getInput();
				count++;
				total_count++;
				if (total_count>MAX_COUNT) Application.Exit();
			} else {
				//textBox1.Visible = false;
				textBox1.Text="";
				onscreen=false;
			}
			//Application.DoEvents();
		}
		void writeToText(int num)
		{
			writeToPort.Output(52440,1);//0xCCD8 in hex
			//string txt = (Stopwatch.GetTimestamp()/Stopwatch.Frequency).ToString();
			string txt = stopwatch.ElapsedMilliseconds.ToString();
			txt += "\t" + num.ToString() + "\tPressed";
			//string txt = DateTime.Now.Millisecond.ToString() + "\t" + num.ToString() + "\tPressed";
			tw.WriteLine(txt);
/*			btn1.Visible = false;
			btn2.Visible = false;
			btn3.Visible = false;
			btn4.Visible = false;
			btn5.Visible = false;
			btn6.Visible = false;
			btn7.Visible = false;
			btn8.Visible = false;
			btn9.Visible = false;
			label1.Visible = false;
*/			
//			timer1.Start();
		}
		void getInput()
		{
/*			btn1.Visible = true;
			btn2.Visible = true;
			btn3.Visible = true;
			btn4.Visible = true;
			btn5.Visible = true;
			btn6.Visible = true;
			btn7.Visible = true;
			btn8.Visible = true;
			btn9.Visible = true;
			label1.Visible = true;
*/			
//			timer1.Stop();
		}
		void Btn1Click(object sender, EventArgs e)
		{
			writeToText(1);
		}
		
		void Btn2Click(object sender, EventArgs e)
		{
			writeToText(2);
		}
		
		void Btn3Click(object sender, EventArgs e)
		{
			writeToText(3);
		}
		
		void Btn4Click(object sender, EventArgs e)
		{
			writeToText(4);
		}
		
		void Btn5Click(object sender, EventArgs e)
		{
			writeToText(5);
		}
		
		void Btn6Click(object sender, EventArgs e)
		{
			writeToText(6);
		}
		
		void Btn7Click(object sender, EventArgs e)
		{
			writeToText(7);
		}
		
		void Btn8Click(object sender, EventArgs e)
		{
			writeToText(8);
		}
		
		void Btn9Click(object sender, EventArgs e)
		{
			writeToText(9);
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			writeToPort.Output(52440,9);//0xCCD8 in hex
			tw.WriteLine("END");
			stopwatch.Stop();
			tw.Close();
		}	
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			//if (e.KeyCode == Keys.F1)
			if (e.KeyCode == Keys.Escape)				
			{
				//MainFormFormClosing(sender, e);
				this.Close();
			} 
			if (e.KeyCode == Keys.ShiftKey) 
			{
        		if (GetAsyncKeyState(Keys.LShiftKey) < 0) 
        		{
        			//MessageBox.Show("Left Shift Key");
        			MessageBox.Show(randomNumber(2.5,3.0).ToString());
        		}
        		if (GetAsyncKeyState(Keys.RShiftKey) < 0) MessageBox.Show("Right Shift Key");
      		}
		}
		[System.Runtime.InteropServices.DllImport("user32.dll")]
    	private static extern short GetAsyncKeyState(Keys key);
		public static double randomNumber(double min, double max) 
		{
			//return min + (new Random()).Next(max-min);
			return min + (new Random()).NextDouble();
		}
	}
}
