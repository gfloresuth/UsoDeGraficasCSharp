using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class Enemigo : DatosVisuales, IObjetoVisual
    {
        public Enemigo(int x, int y) : base (x,y,32,32)
        {

        }
        public void pintar(Graphics g)
        {
            g.FillRectangle(Brushes.Red,_x,_y,_ancho,_alto);
        }
        public void logica()
        {
            _x++;
            if (_x>100)
            {
                _x=0;
            }
        }
    }
}