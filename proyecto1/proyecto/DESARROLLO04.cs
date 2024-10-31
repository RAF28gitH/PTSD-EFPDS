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
using System.Collections.Generic;

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
			CFE();
			CIERRE form10 = new CIERRE();
			form10.Show();
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
			DESARROLLO03 DESARROLLO03 =new DESARROLLO03();
			DESARROLLO03.Show();
			Close();
		}
		
		bool traducirTexto = true;
		void Button3Click(object sender, EventArgs e)
		{
			string texto1Original = "Información: La figura principal parece ser la de un santo o un monje, vestido con una túnica y con una expresión de devoción o meditación, con los brazos cruzados sobre su pecho. El halo alrededor de su cabeza indica que es una figura sagrada o santa en la iconografía cristiana.";
    		string texto2Original = "Información: Una imagen de la Virgen con los ojos cerrados generalmente representa serenidad, paz y un estado profundo de oración o meditación.";
    		string texto3Original = "Información: Los ojos cerrados de la Virgen indican un estado de oración o contemplación profunda, en el que está conectada espiritualmente con Dios. Refleja su papel como intercesora, orando por los fieles ante Dios.";

    		string texto1Traducido = "Information: The main figure appears to be that of a saint or a monk, dressed in a robe with an expression of devotion or meditation, with arms crossed over the chest. The halo around the head indicates that it is a sacred or holy figure in Christian iconography.";
    		string texto2Traducido = "Information: An image of the Virgin with closed eyes generally represents serenity, peace, and a deep state of prayer or meditation.";
    		string texto3Traducido = "Information: The Virgin's closed eyes indicate a state of deep prayer or contemplation, in which she is spiritually connected with God. It reflects her role as an intercessor, praying for the faithful before God.";

    		label1.Text = traducirTexto ? texto1Traducido : texto1Original;
    		label2.Text = traducirTexto ? texto2Traducido : texto2Original;
    		label3.Text = traducirTexto ? texto3Traducido : texto3Original;
    		
    		traducirTexto=!traducirTexto;
		}
	}
}
