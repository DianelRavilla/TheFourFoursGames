using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Calculus;

namespace PAII_Proyecto5
{
    public partial class Juego : Form
    {
        int INS1, INS2, INS3, INS4, INS5, INS6;

        int LIBRO_CONDICION;
        // 0 : ABIERTO
        // 1 : CERRADO

        Resultados R = new Resultados();
        Random sem = new Random();
        public Juego()
        {
            InitializeComponent();
            PANEL_JUEGO.Hide();
            HISTORIA_INTRO.Image = Properties.Resources.PRESENTACION_HISTORIA;
            TIEMPO_INTRO.Start();

            LIBRO_CONDICION = 0;
            INS1 = INS2 = INS3 = INS4 = INS5 = INS6 = 0;
            BEREMIZ_LIBRO_ABIERTO.Visible = false;
            PANEL_SOLUCIONARIO.Visible = false;
            PANEL_SOLUCIONES.Visible = false;
            PANEL_LOGROS.Visible = false;
        }

        private void TIEMPO_INTRO_Tick(object sender, EventArgs e)
        {
            TIEMPO_INTRO.Stop();
            HISTORIA_INTRO.Image = Properties.Resources.PRESENTACION_TITULO_DEL_JUEGO;
            TIEMPO_TITULO_JUEGO.Start();

        }
        private void TIEMPO_TITULO_JUEGO_Tick(object sender, EventArgs e)
        {
            TIEMPO_TITULO_JUEGO.Stop();
            HISTORIA_INTRO.Image = Properties.Resources.PRESENTACION_TITULO_DEL_JUEGO_FINAL;
            TIEMPO_COMENZAR.Start();
        }
        private void TIEMPO_COMENZAR_Tick(object sender, EventArgs e)
        {
            TIEMPO_COMENZAR.Stop();
            BotonContinuar.Visible = true;
            BotonOmitir.Visible = false;
        }

        private void BotonContinuar_MouseMove(object sender, MouseEventArgs e)
        {
            BotonContinuar.Image = Properties.Resources.CONTINUAR_1;

        }
        private void BotonContinuar_MouseLeave(object sender, EventArgs e)
        {
            BotonContinuar.Image = Properties.Resources.CONTINUAR_0;
        }

        private void BotonContinuar_MouseDown(object sender, MouseEventArgs e)
        {
            BotonContinuar.Visible = false;
            BotonOmitir.Visible = false;
            HISTORIA_INTRO.Visible = false;
            IniciarJuego();
        }
        private void BotonOmitir_MouseDown(object sender, MouseEventArgs e)
        {
            TIEMPO_TITULO_JUEGO_Tick(sender, e);
        }


        //INICANDO JUEGO////
        int temporizador;
        private void IniciarJuego()
        {
            PANEL_JUEGO.Show();
            PANEL_JUEGO.BringToFront();
            NUMERO.Text = "1";

            LOGRO_NOTIFICACION.Visible = false;
            LOGRO_IMAGEN.Visible = false;
            LOGRO_DESCRIPCION.Visible = false;

            temporizador = 0;
            TUTORIAL.Start();
        }
     
        private void TUTORIAL_Tick(object sender, EventArgs e)
        {
            if (temporizador == 0)
            {
                TEXTO_EXPLICACION.Text = "Pulsa sobre mi libro al lado derecho para comnenzar. Comienza a resolver los ejercicios\n" +
                    "propuestos en la pestaña solucionario";
                temporizador++;
            }
            else if (temporizador == 1)
            {
                TEXTO_EXPLICACION.Text = "Aqui puedes realizar operaciones auxiliares, basta con escribir tu operacion y dar click\n" +
                    "sobre ella el resultado aparecera automaticamente";
                temporizador++;
            }
            else if (temporizador == 2)
            {
                TEXTO_EXPLICACION.Text = "Cuanto creas tener la solucion, escribela en SOLUCION y verifica tu solucion, si tu\n" +
                    "solucion es acertada, recibiras una bonificacion de puntos, con ellas, conseguiras varios logros\n" +
                    "trata de conseguirlos todos.";
                temporizador++;
            }
            else if (temporizador == 3)
            {
                TEXTO_EXPLICACION.Text = "Vuelve a mi libro y pulsa sobre soluciones para observar las soluciones que hayas\n" +
                    "calculado anteriormente, te podran ayudar. Tambien en la pestaña LOGROS podras ver los logros obtenidos\n" +
                    "durante esta partida";
                temporizador++;
            }
            else if (temporizador == 4)
            {
                TEXTO_EXPLICACION.Text = "Si crees estar cansado, pulsa REPOSAR en mi libro y nos veremos en otra ocasion...\n" +
                    "...¡QUE TE DIVIERTAS!!";
                temporizador++;
            }
            else if (temporizador == 5)
            {
                TEXTO_EXPLICACION.Text = "";
                temporizador++;
            }
            if (temporizador < 6)
                TUTORIAL.Start();
        }

        //LIBRO ABAJO
        private void BEREMIZ_LIBRO_MouseMove(object sender, MouseEventArgs e)
        {
            BEREMIZ_LIBRO.Image = Properties.Resources.BEREMIZ_LIBRO_1;
        }
        private void BEREMIZ_LIBRO_MouseLeave(object sender, EventArgs e)
        {
            BEREMIZ_LIBRO.Image = Properties.Resources.BEREMIZ_LIBRO_0;
        }

        private void BEREMIZ_LIBRO_MouseDown(object sender, MouseEventArgs e)
        {
            if (LIBRO_CONDICION == 0)
            {
                BEREMIZ_LIBRO_ABIERTO.Visible = true;
                INS1 = INS2 = INS3 = INS4 = INS5 = INS6 = 0;
                LIBRO_CONDICION = 1;
            }
            else
            {
                BEREMIZ_LIBRO_ABIERTO.Visible = false;
                PANEL_SOLUCIONARIO.Visible = false;
                PANEL_SOLUCIONES.Visible = false;
                PANEL_LOGROS.Visible = false;
                INS1 = INS2 = INS3 = INS4 = INS5 = INS6 = 0;
                LIBRO_CONDICION = 0;
            }
        }

        //LIBRO ABIERTO
        private void CursorPersonalizado()
        {
            Icon a;
            a = Properties.Resources.BEREMIZ_PLUMA1;
            BEREMIZ_LIBRO_ABIERTO.Cursor = new Cursor(a.Handle);
        }
        private void BEREMIZ_LIBRO_ABIERTO_MouseMove(object sender, MouseEventArgs e)
        {
            CursorPersonalizado();
        }

///EVENTOS MOUSEDOWN PRIMERA PLANA
        private void BOTON_SOLUCIONARIO_MouseMove(object sender, MouseEventArgs e)
        {
            BOTON_SOLUCIONARIO.BorderStyle = BorderStyle.FixedSingle;
        }
        private void BOTON_SOLUCIONARIO_MouseLeave(object sender, EventArgs e)
        {
            BOTON_SOLUCIONARIO.BorderStyle = BorderStyle.None;
        }
        private void BOTON_SOLUCIONARIO_MouseDown(object sender, MouseEventArgs e)
        {
            BEREMIZ_LIBRO_ABIERTO.Visible = false;
            PANEL_SOLUCIONARIO.Visible = true;
        }

        private void SOLUCIONARIO_ATRAS_MouseMove(object sender, MouseEventArgs e)
        {
            SOLUCIONARIO_ATRAS.BorderStyle = BorderStyle.FixedSingle;
        }
        private void SOLUCIONARIO_ATRAS_MouseLeave(object sender, EventArgs e)
        {
            SOLUCIONARIO_ATRAS.BorderStyle = BorderStyle.None;
        }
        private void SOLUCIONARIO_ATRAS_MouseDown(object sender, MouseEventArgs e)
        {
            BEREMIZ_LIBRO_ABIERTO.Visible = true;
            PANEL_SOLUCIONARIO.Visible = false;
        }

        private void BOTON_SOLUCIONES_MouseMove(object sender, MouseEventArgs e)
        {
            BOTON_SOLUCIONES.BorderStyle = BorderStyle.FixedSingle;
        }
        private void BOTON_SOLUCIONES_MouseLeave(object sender, EventArgs e)
        {
            BOTON_SOLUCIONES.BorderStyle = BorderStyle.None;
        }
        private void BOTON_SOLUCIONES_MouseDown(object sender, MouseEventArgs e)
        {
            PANEL_SOLUCIONES.Visible = true;
        }

        private void SOLUCIONES_CERRAR_MouseMove(object sender, MouseEventArgs e)
        {
            SOLUCIONES_CERRAR.BorderStyle = BorderStyle.FixedSingle;
        }
        private void SOLUCIONES_CERRAR_MouseLeave(object sender, EventArgs e)
        {
            SOLUCIONES_CERRAR.BorderStyle = BorderStyle.None;
        }
        private void SOLUCIONES_CERRAR_MouseDown(object sender, MouseEventArgs e)
        {
            PANEL_SOLUCIONES.Visible = false;
        }

        private void BOTON_LOGROS_MouseMove(object sender, MouseEventArgs e)
        {
            BOTON_LOGROS.BorderStyle = BorderStyle.FixedSingle;
        }
        private void BOTON_LOGROS_MouseLeave(object sender, EventArgs e)
        {
            BOTON_LOGROS.BorderStyle = BorderStyle.None;
        }
        private void BOTON_LOGROS_MouseDown(object sender, MouseEventArgs e)
        {
            BEREMIZ_LIBRO_ABIERTO.Visible = false;
            PANEL_LOGROS.Visible = true;
            dgvLOGROS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLOGROS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void LOGROS_ATRAS_MouseMove(object sender, MouseEventArgs e)
        {
            LOGROS_ATRAS.BorderStyle = BorderStyle.FixedSingle;
        }
        private void LOGROS_ATRAS_MouseLeave(object sender, EventArgs e)
        {
            LOGROS_ATRAS.BorderStyle = BorderStyle.None;
        }
        private void LOGROS_ATRAS_MouseDown(object sender, MouseEventArgs e)
        {
            BEREMIZ_LIBRO_ABIERTO.Visible = true;
            PANEL_LOGROS.Visible = false;
        }


        private void BOTON_REPOSAR_MouseMove(object sender, MouseEventArgs e)
        {
            BOTON_REPOSAR.BorderStyle = BorderStyle.FixedSingle;
        }
        private void BOTON_REPOSAR_MouseLeave(object sender, EventArgs e)
        {
            BOTON_REPOSAR.BorderStyle = BorderStyle.None;
        }
        private void BOTON_REPOSAR_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult DR = MessageBox.Show("Estas seguro que deseas retirarte de la partida?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else { }
        }


        ///SOLUCIONARIO
        Validacion val = new Validacion();

        private void PANEL_SOLUCIONARIO_MouseMove(object sender, MouseEventArgs e)
        {
            CursorPersonalizado();
        }

        public void CalculoPorInstancias(TextBox t)
        {
            string ecuacion = "";
            double resultado = 0;
            Calculo evaluar = new Calculo();

            ecuacion = t.Text;
            evaluar.Sintaxis(ecuacion, 'x');
            resultado = evaluar.EvaluaFx(0);
            t.Text = "";
            t.Text = ecuacion + " = " + resultado;
        }
       
        //EVENTOS MOUSEDOWN
        private void txtINSTANCIA1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (INS1 == 0)
                {
                    CalculoPorInstancias(txtINSTANCIA1);
                    INS1 = 1;
                }
                else
                {
                    txtINSTANCIA1.Text = "";
                    INS1 = 0;
                }
            }
            catch { }
        }
        private void txtINSTANCIA2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (INS2 == 0)
                {
                    CalculoPorInstancias(txtINSTANCIA2);
                    INS2 = 1;
                }
                else
                {
                    txtINSTANCIA2.Text = "";
                    INS2 = 0;
                }
            }
            catch { }
        }
        private void txtINSTANCIA3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (INS3 == 0)
                {
                    CalculoPorInstancias(txtINSTANCIA3);
                    INS3 = 1;
                }
                else
                {
                    txtINSTANCIA3.Text = "";
                    INS3 = 0;
                }
            }
            catch { }
        }
        private void txtINSTANCIA4_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (INS4 == 0)
                {
                    CalculoPorInstancias(txtINSTANCIA4);
                    INS4 = 1;
                }
                else
                {
                    txtINSTANCIA4.Text = "";
                    INS4 = 0;
                }
            }
            catch { }
        }
        private void txtINSTANCIA5_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (INS5 == 0)
                {
                    CalculoPorInstancias(txtINSTANCIA5);
                    INS5 = 1;
                }
                else
                {
                    txtINSTANCIA5.Text = "";
                    INS5 = 0;
                }
            }
            catch { }
        }
        private void txtINSTANCIA6_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (INS6 == 0)
                {
                    CalculoPorInstancias(txtINSTANCIA6);
                    INS6 = 1;
                }
                else
                {
                    txtINSTANCIA6.Text = "";
                    INS6 = 0;
                }
            }
            catch { }
        }

        //EVENTOS KEYPRESS
        private void txtINSTANCIA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
        private void txtINSTANCIA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
        private void txtINSTANCIA3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
        private void txtINSTANCIA4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
        private void txtINSTANCIA5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
        private void txtINSTANCIA6_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
        private void txtSOLUCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        //BOTON COMPROBAR SOLUCION
        private void btnComprobarSolucion_Click(object sender, EventArgs e)
        {
            if (ComprobarCuatroCuatros())
            {
                int resultado = Int32.Parse(NUMERO.Text);
                string ecuacion = txtSOLUCION.Text;

                try { R.ComprobarAñdirSolucion(ecuacion, resultado, 1, NUMERO); }
                catch { MessageBox.Show("No se puede comprobar esta solucion"); }

                ActualizarLogros();
                ActualizarSoluciones();

                txtSOLUCION.Text = "";
            }
            else { MessageBox.Show("Recuerda que debes usar cuatro cuatros"); }          
        }
        private bool ComprobarCuatroCuatros()
        {
            string cadena = txtSOLUCION.Text;
            char[] cad = cadena.ToCharArray();

            int contador = 0;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == '4')
                    contador++;
            }

            if (contador == 4)
                return true;
            else
                return false;
        }

        //BOTON CAMBIAR
        private void btnCambiar_MouseDown(object sender, MouseEventArgs e)
        {
            NUMERO.Text = Convert.ToString(sem.Next(0, 10));
        }

        //LOGROS
        private void ActualizarLogros()
        {
            PUNTOS.Text = Convert.ToString(R.CalcularPuntuacion());
            R.ObtenLogro(dgvLOGROS, LOGRO_NOTIFICACION, LOGRO_DESCRIPCION, LOGRO_IMAGEN, TIEMPO_LOGRO);
        }
        private void TIEMPO_LOGRO_Tick(object sender, EventArgs e)
        {
            LOGRO_NOTIFICACION.Visible = false;
            LOGRO_IMAGEN.Visible = false;
            LOGRO_DESCRIPCION.Visible = false;
        }

        //SOLUCIONES
        private void ActualizarSoluciones()
        {
            R.Soluciones(lbxSOLUCIONES);
        }

        //SALIR DEL JUEGO
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Estas seguro que deseas retirarte de la partida?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else { }
        }
    }
}
