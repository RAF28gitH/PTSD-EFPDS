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
using System.Collections.Generic;

namespace proyecto
{
	/// <summary>
	/// Description of DESARROLLO03.
	/// </summary>
	public partial class DESARROLLO03 : Form
	{
		public DESARROLLO03()
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
			CFE();
			DESARROLLO04 form5 = new DESARROLLO04();
			form5.Show();
		}
		void CFE()
		{
    		Form mf = Application.OpenForms["MainForm"];
    		List<Form> lfc = new List<Form>();
    		
    		foreach (Form f in Application.OpenForms)
    		{
        		if (f == mf)
        		{
            		continue;
        		}

        		lfc.Add(f);
    		}
    		
    		foreach (Form f in lfc)
    		{
        		f.Close();
    		}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			DESARROLLO02 DESARROLLO02 =new	DESARROLLO02();
			DESARROLLO02.Show();
			Hide();
		}
	}
}
