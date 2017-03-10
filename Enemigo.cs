using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class Enemigo : IObjetoVisual
    {
        public Rectangle rect;
        public int direccion;
        public Enemigo(int x, int y)
        {
            rect=new Rectangle(x,y,32,32);
            direccion=5;
        }
        public void pintar(Graphics g)
        {
            g.FillRectangle(Brushes.Red,rect);
        }
        public void logica()
        {
            rect.X+=direccion;
            if (rect.X>200)
            {
                rect.X=200;
                direccion = -5;
            }
            if (rect.X<0)
            {
                rect.X=0;
                direccion = 5;
            }
        }
    }
}