using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class DatosVisuales
    {
        protected int _x;
        protected int _y;
        protected int _ancho;
        protected int _alto;
        public DatosVisuales(int x, int y, int ancho, int alto)
        {
            _x=x;
            _y=y;
            _ancho=ancho;
            _alto=alto;
        }
    }
}
