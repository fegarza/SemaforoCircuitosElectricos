using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace CircuitosProgramables_Semaforo
{
    class Controlador
    {
        /// <summary>
        /// Mi contador de medios segundos
        /// </summary>
        Timer Contador = new Timer();

        Semaforo SemaforoNorte;
        Semaforo SemaforoSur;
        Semaforo SemaforoEste;
        Semaforo SemaforoOeste;

        private Label LblContador;

        /// <summary>
        /// Saber si en el conteo se encuentra como un numero entero en segundos
        /// </summary>
        private bool Entero = false;
        private bool Preventivas = false;

        private Modo ModoContador = Modo.VERTICALES;
        private int ConteoSemaforo = 0;

        /// <summary>
        /// Conteo de los medio segundos x semaforo
        /// </summary>
        private int Conteo = 0;




        public Controlador(Label _lblContador, Semaforo _semaforoNorte, Semaforo _semaforoSur, Semaforo _semaforoEste, Semaforo _semaforoOeste)
        {
            this.LblContador = _lblContador;
            this.SemaforoNorte = _semaforoNorte;
            this.SemaforoSur = _semaforoSur;
            this.SemaforoEste = _semaforoEste;
            this.SemaforoOeste = _semaforoOeste;

            this.AsignarConteo("0", Color.Gray);

            Contador.Interval = 500;
            Contador.Tick += new EventHandler(EventoDeMedioSegundo);
            Contador.Enabled = true;
            Contador.Stop();
        }


        public void EventoDeMedioSegundo(object source, EventArgs e)
        {
            if (!Preventivas) { 
            //Variar el valor para cada 2 medio segundos
            Entero = !Entero;

            if (Entero)
            {
                ConteoSemaforo++;
            }
            

            if (this.ModoContador == Modo.VERTICALES)
            {
                this.SemaforoNorte.EventoDeMedioSegundo(Conteo);
                this.SemaforoSur.EventoDeMedioSegundo(Conteo);
            }
            else
            {
                this.SemaforoEste.EventoDeMedioSegundo(Conteo);
                this.SemaforoOeste.EventoDeMedioSegundo(Conteo);
            }

            //Verde prendido
            if (Conteo < 29)
            {
                if (Entero)
                {
                    this.AsignarConteo(ConteoSemaforo.ToString(), Color.LawnGreen);
                }
             }
            else if(Conteo == 29)
            {
                this.AsignarConteo("0", Color.Gray);
            }
            //Verde parpadeando
            else if (Conteo < 35)
            {
                if (Entero)
                {
                    this.AsignarConteo((ConteoSemaforo - 15).ToString(), Color.LawnGreen);
                }
                else
                {
                   
                        this.AsignarConteo("0", Color.Gray);
                   
                }
             
            }
            else if (Conteo == 35)
            {
                this.AsignarConteo("0", Color.Gray);
            }
            //Amarillo encendido 
            else if (Conteo < 41)
            {
                if (Entero)
                {
                    this.AsignarConteo((ConteoSemaforo - 18).ToString(), Color.Yellow);

                }
            }
            else if (Conteo == 41)
            {
                this.AsignarConteo("0", Color.Gray);
            }
            //Semaforo en rojo
            else if (Conteo < 45)
            {
                if (Entero)
                {
                    this.AsignarConteo((ConteoSemaforo - 21).ToString(), Color.Red);
                }
            }
            else if (Conteo == 46)
            {
                this.AsignarConteo("0", Color.Gray);
                this.Switcheo();
                return;
            }
             

            Conteo++;
            }
            else
            {
                Entero = !Entero;
                SemaforoNorte.EventoDeMedioSegundo(Entero);
                SemaforoSur.EventoDeMedioSegundo(Entero);
                SemaforoEste.EventoDeMedioSegundo(Entero);
                SemaforoOeste.EventoDeMedioSegundo(Entero);
                if (Entero)
                {
                    this.AsignarConteo("0", Color.Yellow);
                }
                else
                {
                    this.AsignarConteo("0", Color.Gray);
                }
                Conteo++;
            }
        }

        public void AsignarConteo(String _texto, Color _color)
        {
            this.LblContador.Text = _texto;
            this.SetColor(_color);
        }
        public void AsignarConteo(String _texto)
        {
            this.LblContador.Text = _texto;
        }
        public void SetColor(Color _color)
        {
            this.LblContador.ForeColor = _color;
        }

        public void Iniciar()
        {
            if (Preventivas)
            {
                Preventivas = false;
                this.Default();
            }
            Contador.Start();
        }

        public void Detener()
        {
            Contador.Stop();
        }

        public void Reiniciar()
        {
            this.Contador.Stop();
            this.Conteo = 0;
            this.ConteoSemaforo = 0;
            Entero = false;
            this.LblContador.Text = "0";
            this.LblContador.ForeColor = Color.Gray;
            this.Iniciar();
        }

        public void Switcheo()
        {
            if(this.ModoContador  == Modo.VERTICALES)
            {
                this.ModoContador = Modo.HORIZONTALES;
            }
            else
            {
                this.ModoContador = Modo.VERTICALES;
            }
            this.Reiniciar();
        }

        public void Default()
        {
            this.Contador.Stop();
            this.SemaforoEste.EventoDeMedioSegundo(false);
            this.SemaforoOeste.EventoDeMedioSegundo(false);
            this.SemaforoSur.EventoDeMedioSegundo(false);
            this.SemaforoNorte.EventoDeMedioSegundo(false);
            this.ModoContador = Modo.HORIZONTALES;
            this.Conteo = 0;
            this.ConteoSemaforo = 0;
            Entero = false;
            this.LblContador.Text = "0";
            this.LblContador.ForeColor = Color.Gray;
        }

        public void IniciarPreventivas()
        {
            this.Preventivas = true;
            this.Contador.Stop();
            this.Conteo = 0;
            this.ConteoSemaforo = 0;
            Entero = false;
            this.LblContador.Text = "0";
            this.LblContador.ForeColor = Color.Gray;
            Contador.Start();
        }


    }

    enum Modo
    {
        HORIZONTALES,
        VERTICALES
    }


}
