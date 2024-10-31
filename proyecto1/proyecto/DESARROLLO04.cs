/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 10/10/2024
 * Time: 11:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of DESARROLLO04.
	/// </summary>
	public partial class DESARROLLO04 : Form
	{
		public DESARROLLO04()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			CIERRE form10 = new CIERRE();
			form10.Show();			
		}
	}
}
