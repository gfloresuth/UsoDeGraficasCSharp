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
        private Timer timer1;
        private void misControles()
        {
            pb=new PictureBox();
            timer1=new Timer();
            timer1.Interval=35;
            
            this.Size=new Size(350,350);

            pb.Size=new Size(320,320);
            pb.Location= new Point(0,0);
            pb.BackColor = Color.Black;
            timer1.Tick += timer1_Tick;
            Controls.Add (pb);



        }
        private void timer1_Tick(Object sender, EventArgs e)
        {
            timer1.Stop();
            juego.logica();
            juego.pintar();
            timer1.Start();
        }
        public MainForm ()
        {
            misControles();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            miPantalla=new Pantalla(pb);
            juego = new Juego(miPantalla);
            juego.pintar();
            timer1.Start();

        }    
    }
}
