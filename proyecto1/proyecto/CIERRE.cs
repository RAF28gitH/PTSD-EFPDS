/*
 * Created by SharpDevelop.
 * User: CC1-PC18
 * Date: 07/10/2024
 * Time: 01:31 p. m.
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
	/// Description of CIERRE.
	/// </summary>
	public partial class CIERRE : Form
	{
		public CIERRE()
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
			EncuestaSatisfaccion EncuestaSatisfaccion = new EncuestaSatisfaccion();
			EncuestaSatisfaccion.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			DESARROLLO04 DESARROLLO04 = new DESARROLLO04();
			DESARROLLO04.Show();
			Close();
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
			System.Diagnostics.Process.Start("https://www.instagram.com/laoctavanoche/?hl=es");
		}
		
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

			System.Diagnostics.Process.Start("https://www.facebook.com/laoctavanoche/?locale=es_LA");
		}
		
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

			System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/La_Octava_Noche");			
		}
	}
}
