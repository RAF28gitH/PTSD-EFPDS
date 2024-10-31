/*
 * Created by SharpDevelop.
 * User: CC1-PC18
 * Date: 07/10/2024
 * Time: 01:30 p. m.
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
	/// Description of DESARROLLO01.
	/// </summary>
	public partial class DESARROLLO01 : Form
	{
		public DESARROLLO01()
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
			DESARROLLO02 form3 = new DESARROLLO02();
			form3.Show();		
        	Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{	
			CFE();
			MainForm MainForm =new MainForm();
			MainForm.Show();
			Close();
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
	}
}
