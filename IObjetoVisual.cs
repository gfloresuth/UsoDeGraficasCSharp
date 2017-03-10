using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public interface IObjetoVisual
    {
        void pintar(Graphics g);
        void logica();
    }
}