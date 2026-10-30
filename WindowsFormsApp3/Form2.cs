using System;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        // AQUÍ DEBEN IR LAS VARIABLES GLOBALES:
        string numeroApostado = "";
        string colorApostado = "";
        string paridadApostada = "";
        double saldo = 100.00;
        double montoApuesta = 10.00;
        int ticksContador = 0;
        int numeroFalsoSimulado = 0;
        Random randomEfecto = new Random();

        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelMesa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGirarRuleta_Click(object sender, EventArgs e)

        {
            // Modificación para el efecto visual del timer
            // Cambiado 'tmr1' por 'timer1' para controlar el componente
            if (timer1.Enabled)
            {
                timer1.Start();
                return;
            }


            // 1. Crear el generador de números aleatorios para la ruleta
            Random random = new Random();
            int numeroGanador = random.Next(0, 38);

            // 2. Determinar las propiedades del número obtenido
            string color = "";
            string paridad = "";

            if (numeroGanador == 0)
            {
                color = "VERDE";
                paridad = "NEUTRO";
            }
            else if (numeroGanador == 37) // <-- AGREGA ESTO
            {
                color = "VERDE";
                paridad = "NEUTRO";
            }
            else
            {
                // Aquí sigue tu código normal de paridad...

                // Determinamos si es PAR o IMPAR
                paridad = (numeroGanador % 2 == 0) ? "PAR" : "IMPAR";

                // Array con los números que tradicionalmente son ROJOS en la ruleta americana
                int[] numerosRojos = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

                // Comprobamos si el número obtenido está en la lista de rojos
                if (Array.Exists(numerosRojos, element => element == numeroGanador))
                {
                    color = "ROJO";
                }
                else
                {
                    color = "NEGRO";
                }
                // --- PEGAR AQUÍ ANTES DE LA LLAVE DE CIERRE ---

                // Descontamos el costo de la apuesta
                saldo -= montoApuesta;

                string numeroGanadorTexto = numeroGanador.ToString();
                if (numeroGanador == 37) numeroGanadorTexto = "00";

                bool gano = false;
                double premio = 0;

                // Evaluamos la apuesta
                if (!string.IsNullOrEmpty(numeroApostado) && numeroApostado == numeroGanadorTexto)
                {
                    premio = montoApuesta * 35;
                    gano = true;
                }
                else if (!string.IsNullOrEmpty(colorApostado) && colorApostado == color)
                {
                    premio = montoApuesta * 2;
                    gano = true;
                }
                else if (!string.IsNullOrEmpty(paridadApostada) && paridadApostada == paridad)
                {
                    premio = montoApuesta * 2;
                    gano = true;
                }

                // Aplicamos resultado financiero
                if (gano)
                {
                    saldo += premio;
                    // Ajusta el nombre si tu etiqueta de resultado se llama diferente
                    label7.Text = $"{numeroGanadorTexto} • {color} • {paridad}\n¡GANASTE! + ${premio:F2}";
                }
                else
                {
                    label7.Text = $"{numeroGanadorTexto} • {color} • {paridad}\n¡PERDISTE! - ${montoApuesta:F2}";
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnNumero(object sender, EventArgs e)
        {
            // 1. Identificamos qué botón exacto fue presionado
            Button botonPresionado = (Button)sender;

            // 2. Extraemos el número que tiene escrito (ej: "23", "0", "00")
            string numeroSeleccionado = botonPresionado.Text;

            // 3. (Opcional) Guardamos el número en una variable global para evaluar la apuesta después
            // numeroApostado = numeroSeleccionado;

            // Línea de prueba para verificar que funciona con cualquier botón:
            MessageBox.Show("Has apostado por el número: " + numeroSeleccionado);
        }

        private void btnColor(object sender, EventArgs e)
        {

        }

        private void btnParidad(object sender, EventArgs e)
        {

        }
    }
}
