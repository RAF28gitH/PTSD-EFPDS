﻿/*
 * Created by SharpDevelop.
 * User: CC1-PC18
 * Date: 07/10/2024
 * Time: 01:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace proyecto
{
	/// <summary>
	/// Description of EncuestaSatisfaccion.
	/// </summary>
	public partial class EncuestaSatisfaccion : Form
	{
		public EncuestaSatisfaccion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLScVCKmjmhbhXLvzQo13xDkqbDruY2ivGKUxcHi8IE8cziMZCw/viewform?usp=sf_link");
		}
	}
}
