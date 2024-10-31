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
	/// Description of DESARROLLO02.
	/// </summary>
	public partial class DESARROLLO02 : Form
	{
		public DESARROLLO02()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			CFE();
			DESARROLLO03 form4 = new DESARROLLO03();
			form4.Show();
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
		
		void Button1Click(object sender, EventArgs e)
		{
			DESARROLLO01 DESARROLLO01 =new DESARROLLO01();
			DESARROLLO01.Show();
			Close();
		}
		
		bool traducirTexto = true;
		void Button3Click(object sender, EventArgs e)
		{
    		string texto1Original = "Información: La imagen muestra una representación de la Virgen de Guadalupe, a menudo considerada un símbolo de fe e identidad para muchas personas en México y América Latina.";
    		string texto2Original = "Información: La imagen parece representar a un ángel o un santo guerrero, posiblemente San Miguel Arcángel. San Miguel es frecuentemente representado como un arcángel con armadura, llevando una espada o lanza, simbolizando su papel como protector y líder en la batalla contra las fuerzas del mal.";
    		string texto3Original = "Información: La imagen representa a la Virgen del Carmen, una advocación mariana muy popular en la Iglesia Católica. La Virgen del Carmen es conocida por su manto azul y dorado, que simboliza la protección divina.";

    		string texto1Traducido = "Information: The image shows a representation of the Virgin of Guadalupe, often considered a symbol of faith and identity for many people in Mexico and Latin America.";
    		string texto2Traducido = "Information: The image appears to represent an angel or a warrior saint, possibly Saint Michael the Archangel. Saint Michael is often depicted as an archangel in armor, wielding a sword or spear, symbolizing his role as protector and leader in the battle against the forces of evil.";
    		string texto3Traducido = "Information: The image represents Our Lady of Mount Carmel, a very popular Marian devotion in the Catholic Church. Our Lady of Mount Carmel is known for her blue and gold mantle, symbolizing divine protection.";

    		label1.Text = traducirTexto ? texto1Traducido : texto1Original;
    		label2.Text = traducirTexto ? texto2Traducido : texto2Original;
    		label3.Text = traducirTexto ? texto3Traducido : texto3Original;
    		
    		traducirTexto=!traducirTexto;
		}

	}
}
