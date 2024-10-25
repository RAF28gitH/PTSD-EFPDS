/*
 * Created by SharpDevelop.
 * User: CC1-PC18
 * Date: 07/10/2024
 * Time: 01:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class CIERRE
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-1, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "https://chatgpt.com/";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(-1, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 45);
			this.label2.TabIndex = 1;
			this.label2.Text = "https://www.facebook.com/laoctavanoche/?locale=es_LA";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-1, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(243, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "https://es.wikipedia.org/wiki/La_Octava_Noche";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(95, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "cierre";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(166, 191);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(76, 38);
			this.button1.TabIndex = 4;
			this.button1.Text = "encuesta de satisfaccion";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// CIERRE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CIERRE";
			this.Text = "CIERRE";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
