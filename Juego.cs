using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class Juego
    {
        private Pantalla _pantalla;
        public Juego(Pantalla pantalla)
        {
            _pantalla = pantalla;
        }
        public void pintar()
        {
            Graphics g = _pantalla.obtenerG();
            g.Clear(Color.White);
            g.DrawLine(Pens.Blue,0,0,100,100);
            _pantalla.actualizar();
            
        }

        public void logica()
        {

        }

    }
}
