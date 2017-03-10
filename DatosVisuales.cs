using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class DatosVisuales
    {
        public int _x;
        public int _y;
        public int _ancho;
        public int _alto;
        public DatosVisuales(int x, int y, int ancho, int alto)
        {
            _x=x;
            _y=y;
            _ancho=ancho;
            _alto=alto;
        }
    }
}
