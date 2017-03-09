using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class MainForm : Form
    {
        PictureBox pb;
        Pantalla miPantalla;
        private void misControles()
        {
            pb=new PictureBox();
            
            this.Size=new Size(350,350);

            pb.Size=new Size(320,320);
            pb.Location= new Point(0,0);
            pb.BackColor = Color.Black;


        }
        public MainForm ()
        {
            misControles();


            miPantalla=new Pantalla(pb);
            Controls.Add (pb);
            Graphics g = miPantalla.obtenerG();
            g.Clear(Color.White);
            g.DrawLine(Pens.Black,0,0,10,10);
            miPantalla.actualizar();
        }    
    }
}
