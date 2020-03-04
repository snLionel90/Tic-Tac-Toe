using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        bool turno = true; ///los turnos de los jugadoress
        int turno_cont = 0;
        String[] jugador = { "Jugador 1", "jugador 2" };

        public Form1()
        {
            InitializeComponent();
            A1.Enabled = false;
                A2.Enabled = false;
                    A3.Enabled = false;
            B1.Enabled = false;
                B2.Enabled = false;
                    B3.Enabled = false;
            C1.Enabled = false;
                C2.Enabled = false;
                    C3.Enabled = false;

           Informacion.Text = "Haz clik en Archivo/Nuevo Juego para empezar";
        }

        ///Menu de programa
        private void mASINFOToolStripMenuItem_Click(object sender, EventArgs e)
        { //Informacion del programa
            MessageBox.Show("Tres en una raya o TictacToe,Para Jugar: " +
                "\n,1 clicka en los botones \n 2 cada jugador tendra un turno \n " +
                "3 gana el primero en alinear las 3 casillas");
        }

        private void SalirPorPatasToolStripMenuItem_Click(object sender, EventArgs e)
        { //opcion de Salir del programa
            Application.Exit();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        { //Info creador y version del programa
            MessageBox.Show("TicTcTo/Tres En raya Version 1.1.2019 \n" +
                " Juego creado por: Lionel Sanchez (c)2019");
        }

        private void NuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        { //opcion para iniciar un nuevo juego
            turno = true;       
            turno_cont = 1;
            cojones.Text = "0";
            labelTurnoJ1.Text = "Empieza el " +jugador[0];
            labelTxt.Text = "";

            A1.Text = ""; A1.Enabled = true;
            A2.Text = ""; A2.Enabled = true;
            A3.Text = ""; A3.Enabled = true;
            B1.Text = ""; B1.Enabled = true;
            B2.Text = ""; B2.Enabled = true;
            B3.Text = ""; B3.Enabled = true;
            C1.Text = ""; C1.Enabled = true;
            C2.Text = ""; C2.Enabled = true;
            C3.Text = ""; C3.Enabled = true;

        }

        ///AREA DEL JUEGO, Creo un metodo para empezar la prueba nada mas clicar el boton de iniciar
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turno)
            {
                b.Text = "X";
                labelTurnoJ1.Text = "Turno para " +jugador[1];
            }
            else
            {
                b.Text = "O";
                labelTurnoJ1.Text = "Turno para " + jugador[0]; 
            }
            turno = !turno;
            cojones.Text = turno_cont.ToString();
            turno_cont += 1;

            b.Enabled = false;
            bool ganador = true;

            /// Horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {              
                ganador = true;
                labelTxt.Text = "Has Ganado ";
                labelTurnoJ1.Enabled = false;
                
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {                
                ganador = true;
                labelTxt.Text = "Has Ganado " ;
                labelTurnoJ1.Enabled = false;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {              
                ganador = true;
                labelTxt.Text = "Has Ganado " ;
                labelTurnoJ1.Enabled = false;
            }

            /// Verticaal
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A2.Enabled))
            {              
                ganador = true;
                labelTxt.Text = "Has Ganado ";
                labelTurnoJ1.Enabled = false;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B2.Enabled)) 
            {              
                
                ganador = true;
                labelTxt.Text = "Has Ganado ";
                labelTurnoJ1.Enabled = false;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C3.Text) && (!C2.Enabled))
            {              
                ganador = true;
                labelTxt.Text = "Has Ganado ";
                labelTurnoJ1.Enabled = false;
            }

            ///DIAGONALL
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {              
                ganador = true;
                labelTxt.Text = "Has Ganado ";
                labelTurnoJ1.Enabled = false;
            }

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {              
                ganador = true;
                labelTxt.Text = "Has Ganado ";
                labelTurnoJ1.Enabled = false;
                
            }          
        }      
        private void Form1_Load(object sender, EventArgs e) {}     
    }
}
