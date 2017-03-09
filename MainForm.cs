using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class MainForm : Form
    {
        PictureBox pb;
        private Pantalla miPantalla;
        private Juego juego;
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


            Controls.Add (pb);
            miPantalla=new Pantalla(pb);
            juego = new Juego(miPantalla);
            juego.pintar();


        }    
    }
}
