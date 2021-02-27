/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2/1/2010
 * Time: 6:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace two_back
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 560);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1065, 0);
			this.panel1.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1065, 0);
			this.panel2.TabIndex = 13;
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(1065, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(0, 560);
			this.panel3.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel4.AutoSize = true;
			this.panel4.Location = new System.Drawing.Point(0, 22);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(64, 498);
			this.panel4.TabIndex = 15;
			// 
			// panel5
			// 
			this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.btn8);
			this.panel5.Controls.Add(this.btn7);
			this.panel5.Controls.Add(this.btn6);
			this.panel5.Controls.Add(this.btn5);
			this.panel5.Controls.Add(this.btn4);
			this.panel5.Controls.Add(this.btn3);
			this.panel5.Controls.Add(this.btn2);
			this.panel5.Controls.Add(this.btn1);
			this.panel5.Controls.Add(this.btn9);
			this.panel5.Controls.Add(this.textBox1);
			this.panel5.Location = new System.Drawing.Point(70, 47);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(913, 451);
			this.panel5.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(241, 251);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(579, 23);
			this.label1.TabIndex = 32;
			this.label1.Text = "Click the number that was displayed two back";
			// 
			// btn8
			// 
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(718, 307);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(75, 76);
			this.btn8.TabIndex = 31;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.Btn8Click);
			// 
			// btn7
			// 
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(619, 307);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(75, 76);
			this.btn7.TabIndex = 30;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.Btn7Click);
			// 
			// btn6
			// 
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(520, 307);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(75, 76);
			this.btn6.TabIndex = 29;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.Btn6Click);
			// 
			// btn5
			// 
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(421, 307);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(75, 76);
			this.btn5.TabIndex = 28;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.Btn5Click);
			// 
			// btn4
			// 
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(322, 307);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(75, 76);
			this.btn4.TabIndex = 27;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.Btn4Click);
			// 
			// btn3
			// 
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(223, 307);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(75, 76);
			this.btn3.TabIndex = 26;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(124, 307);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(75, 76);
			this.btn2.TabIndex = 25;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(25, 307);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(75, 76);
			this.btn1.TabIndex = 24;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btn9
			// 
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(817, 307);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(75, 76);
			this.btn9.TabIndex = 23;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.Btn9Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
			this.textBox1.Location = new System.Drawing.Point(423, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(62, 116);
			this.textBox1.TabIndex = 22;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1065, 41);
			this.panel6.TabIndex = 17;
			// 
			// panel7
			// 
			this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel7.Location = new System.Drawing.Point(989, 41);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(76, 519);
			this.panel7.TabIndex = 18;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlText;
			this.ClientSize = new System.Drawing.Size(1065, 560);
			this.ControlBox = false;
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "two-back";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
