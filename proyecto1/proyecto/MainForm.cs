/*
 * Created by SharpDevelop.
 * User: CC1_PC19
 * Date: 07/10/2024
 * Time: 12:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
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
		
		void Button1Click(object sender, EventArgs e)
		{
			CFE();
			DESARROLLO01 form2 = new DESARROLLO01();
			form2.Show();
			Hide();
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
