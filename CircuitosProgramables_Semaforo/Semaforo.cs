using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitosProgramables_Semaforo
{
    class Semaforo
    {
        //Punteros a los componentes del form
        private PictureBox Imagen;

        private bool Preventivas = false;

        Cardinalidad CardinalidadSemaforo;
      
        public Semaforo(PictureBox _imagen,  Cardinalidad _cardinalidad )
        {
            this.CardinalidadSemaforo = _cardinalidad;
            this.Imagen = _imagen;
            this.EstablecerImagen(Properties.Resources.apagados);
            this.Imagen.SizeMode = PictureBoxSizeMode.Zoom;
        }
 
 
        public void EstablecerImagen(Bitmap _img)
        {
            switch (CardinalidadSemaforo)
            {
                case Cardinalidad.OESTE:
                    _img.RotateFlip(RotateFlipType.Rotate90FlipX);
                    break;
                case Cardinalidad.ESTE:
                    _img.RotateFlip(RotateFlipType.Rotate270FlipX);
                    break;
                case Cardinalidad.SUR:
                    _img.RotateFlip(RotateFlipType.Rotate180FlipX);
                    break;
            }

            this.Imagen.Image = _img;

        }
 
        public void EventoDeMedioSegundo(int Conteo)
        {
            bool Entero = (Conteo % 2) == 0;

            if (!Preventivas)
            {
                if (Conteo < 29)
                { 
                    this.EstablecerImagen(Properties.Resources.verde);
                }
                //Verde parpadeando
                else if (Conteo < 36)
                {
                    //Cada segundo completo encendido
                    if (Entero)
                    {
                         this.EstablecerImagen(Properties.Resources.verde);
                     }
                    //Cada medio segundo apagado
                    else
                    {
                        this.EstablecerImagen(Properties.Resources.apagados);
                    }
                }
                //Amarillo encendido 
                else if (Conteo < 41)
                {
                    this.EstablecerImagen(Properties.Resources.amarillo);
                }
                //Semaforo apagado
                else if (Conteo == 41)
                {
                    this.EstablecerImagen(Properties.Resources.apagados);
                }
                //Semaforo en rojo
                else if (Conteo < 45)
                {
     
                    this.EstablecerImagen(Properties.Resources.rojo);
                }
                else if (Conteo == 46)
                {
                    this.EstablecerImagen(Properties.Resources.rojo);
                }

            }
            else
            {
                if (Entero)
                {
                     this.EstablecerImagen(Properties.Resources.amarillo);
                }
                else
                {
                    this.EstablecerImagen(Properties.Resources.apagados);
                }
            }
        }
        public void ModoEspera()
        {
            this.EstablecerImagen(Properties.Resources.rojo);
        }

        public void EventoDeMedioSegundo(bool Entero)
        {
            if (Entero)
            {
                this.EstablecerImagen(Properties.Resources.amarillo);
            }
            else
            {
                this.EstablecerImagen(Properties.Resources.apagados);
            }
        }

    }


    enum Cardinalidad
    {
        NORTE, SUR, ESTE, OESTE
    }
   


}
