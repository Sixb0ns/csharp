/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 23/10/2026
 * Time: 07:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace multiplica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MultiplicarClick(object sender, EventArgs e)
		{
			double a=Convert.ToDouble(textBox1.Text)*Convert.ToDouble(textBox2.Text);
			textBox3.Visible=true;
			label3.Visible=true;
			textBox3.Text=Convert.ToString(a);
			textBox3.Enabled=false;
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//textBox3.Visible=false;	
			//label3.Visible=false;			
		}
	}
}
