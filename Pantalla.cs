using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graficas
{
    public class Pantalla
    {
        private Bitmap imagen;
        private PictureBox _pb;
        private Graphics g;
        public Pantalla(PictureBox pb)
        {
            _pb=pb;
            imagen = new Bitmap(pb.Width,pb.Height);
            g=Graphics.FromImage(imagen);

        }
        public void actualizar()
        {
            _pb.Image = imagen;
        }
        public Graphics obtenerG()
        {
            return g;
        }

    }
}
