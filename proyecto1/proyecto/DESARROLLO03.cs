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
			Close();
		}
		bool traducirTexto = true;
		void Button3Click(object sender, EventArgs e)
		{
    		string texto1Original = "Información: La imagen es una representación artística de Jesucristo, una figura central en la fe cristiana.";
    		string texto2Original = "Información: Representa a Jesucristo en actitud de oración, con las manos juntas y una expresión de serenidad en su rostro. La figura de Cristo con las manos juntas es un símbolo de oración, humildad y devoción, y es una representación común en el cristianismo.";
    		string texto3Original = "Información: La imagen es una representación artística de San Miguel Arcángel, hecho con varios colores. Una imagen de San Miguel muy colorida suele representar la vitalidad y la energía del arcángel. San Miguel es conocido como un protector y defensor contra el mal.";

    		string texto1Traducido = "Information: The image is an artistic representation of Jesus Christ, a central figure in the Christian faith.";
    		string texto2Traducido = "Information: It depicts Jesus Christ in a posture of prayer, with hands together and a serene expression on his face. The figure of Christ with hands together is a symbol of prayer, humility, and devotion, and is a common representation in Christianity.";
    		string texto3Traducido = "Information: The image is an artistic representation of Saint Michael the Archangel, made with various colors. A colorful image of Saint Michael often represents the vitality and energy of the archangel. Saint Michael is known as a protector and defender against evil.";

    		label1.Text = traducirTexto ? texto1Traducido : texto1Original;
    		label2.Text = traducirTexto ? texto2Traducido : texto2Original;
    		label3.Text = traducirTexto ? texto3Traducido : texto3Original;
    		
    		traducirTexto=!traducirTexto;
		}
	}
}
