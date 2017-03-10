using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class Juego
    {
        private Pantalla _pantalla;
        private Jugador jugador1;
        public Juego(Pantalla pantalla)
        {
            _pantalla = pantalla;
            jugador1=new Jugador(10,10);
        }
        public void pintar()
        {
            Graphics g = _pantalla.obtenerG();
            g.Clear(Color.White);
            g.DrawLine(Pens.Red,0,0,100,100);
            jugador1.pintar(g);
            _pantalla.actualizar();
            
        }

        public void logica()
        {

        }

    }
}
