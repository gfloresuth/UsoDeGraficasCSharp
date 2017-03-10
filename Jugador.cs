using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class Jugador : IObjetoVisual
    {
        public Rectangle rect;
        public Jugador(int x, int y)
        {
            rect=new Rectangle(x,y,32,32);
        }
        public void pintar(Graphics g)
        {
            g.FillRectangle(Brushes.Blue,rect);
        }
        public void logica()
        {

        }
    }
}