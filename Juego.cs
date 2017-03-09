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
            _pantalla.actualizar();
            
        }

    }
}
