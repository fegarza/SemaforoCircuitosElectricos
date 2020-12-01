using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AnimSharp.Animate;
using WinFormAnimation;

namespace CircuitosProgramables_Semaforo
{
    class Semaforo
    {
        //Punteros a los componentes del form
        private PictureBox Imagen;
        private PictureBox Muchi;
        private PictureBox Carro;

        private bool Preventivas = false;

        Cardinalidad CardinalidadSemaforo;
      
        public Semaforo(PictureBox _imagen,  Cardinalidad _cardinalidad, PictureBox _muchi, PictureBox _carro )
        {
            this.Carro = _carro;
            this.Muchi = _muchi;
            this.CardinalidadSemaforo = _cardinalidad;
            this.Imagen = _imagen;
            this.EstablecerImagen(Properties.Resources.apagados);
            this.Imagen.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public Semaforo(PictureBox _imagen, Cardinalidad _cardinalidad, PictureBox _muchi )
        {
           
            this.Muchi = _muchi;
            this.CardinalidadSemaforo = _cardinalidad;
            this.Imagen = _imagen;
            this.EstablecerImagen(Properties.Resources.apagados);
            this.Imagen.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public Semaforo(PictureBox _imagen, Cardinalidad _cardinalidad )
        {

          
            this.CardinalidadSemaforo = _cardinalidad;
            this.Imagen = _imagen;
            this.EstablecerImagen(Properties.Resources.apagados);
            this.Imagen.SizeMode = PictureBoxSizeMode.Zoom;
        }



        public void AnimarMuchi()
        {
            if(Muchi != null )
            {
                if (this.CardinalidadSemaforo == Cardinalidad.NORTE)
                {

                    new Animator2D(new Path2D(new Float2D(Muchi.Location.X, 700), Muchi.Location.ToFloat2D(), 20000)).Play(Muchi, Animator2D.KnownProperties.Location);
                 
                }
                else if (this.CardinalidadSemaforo == Cardinalidad.ESTE)
                {
                   
                    new Animator2D(new Path2D(new Float2D(-100, Muchi.Location.Y), Muchi.Location.ToFloat2D(), 20000)).Play(Muchi, Animator2D.KnownProperties.Location);
                  
                    
                   
                }

            }
            if (Carro != null)
            {
                if (this.CardinalidadSemaforo == Cardinalidad.NORTE)
                {

                     
                        new Animator2D(new Path2D(new Float2D(Carro.Location.X, 700), Carro.Location.ToFloat2D(), 1000)).Play(Carro, Animator2D.KnownProperties.Location);
 
                }
                else if (this.CardinalidadSemaforo == Cardinalidad.ESTE)
                {

                   
                        new Animator2D(new Path2D(new Float2D(-300, Carro.Location.Y), Carro.Location.ToFloat2D(), 17000)).Play(Carro, Animator2D.KnownProperties.Location);

                   
                }

            }
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
                    
                   if(Conteo == 1)
                    {
                        this.AnimarMuchi();
                    }
                       
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
