using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitosProgramables_Semaforo
{
    public partial class Form1 : Form
    {
        Controlador miControlador;

        public Form1()
        {

            InitializeComponent();
            miControlador = new Controlador(lblContador, new Semaforo(picBxSemaforo, Cardinalidad.NORTE), new Semaforo(picBxSemaforoSur, Cardinalidad.SUR), new Semaforo(picBxSemaforoEste, Cardinalidad.ESTE), new Semaforo(picBxSemaforoOeste, Cardinalidad.OESTE));

             /*

                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.PlayStateChange += Player_PlayStateChange;
                        wplayer.URL = Environment.CurrentDirectory + @"\s.mp3";
                        wplayer.controls.play();
                        pcxd.Width = 800;
                        pcxd.Height = 800;
            */

        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            miControlador.Iniciar();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            miControlador.Detener();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miControlador.IniciarPreventivas();
        }

        private void pcFondo_Click(object sender, EventArgs e)
        {

        }

        private void picBxSemaforo_Click(object sender, EventArgs e)
        {

        }


        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //Actions on stop
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miControlador.EventoDeMedioSegundo(null, null);
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            miControlador.Iniciar();
        }

        private void btnpreventivas_Click(object sender, EventArgs e)
        {
            miControlador.IniciarPreventivas();
        }

        private void btndetenre_Click(object sender, EventArgs e)
        {
            miControlador.Detener();
        }

        private void btntick_Click(object sender, EventArgs e)
        {
            miControlador.EventoDeMedioSegundo(null, null);
        }
    }
}
