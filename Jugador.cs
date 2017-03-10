using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class Jugador : DatosVisuales, IObjetoVisual
    {
        public Jugador(int x, int y) : base (x,y,32,32)
        {

        }
        public void pintar(Graphics g)
        {
            g.FillRectangle(Brushes.Blue,_x,_y,_ancho,_alto);
        }
        public void logica()
        {

        }
    }
}