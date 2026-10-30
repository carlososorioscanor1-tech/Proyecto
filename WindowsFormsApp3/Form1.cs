using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // 1. Definir los límites y el radio de redondeado
            Rectangle bounds = new Rectangle(0, 0, panel2.Width, panel2.Height);
            int cornerRadius = 25; // Sube este número si quieres que las esquinas sean más redondas

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // 2. Recortar el panel con la forma redondeada
            panel2.Region = new Region(path);

            // 3. Dibujar la línea de contorno (Borde) para que resalte
            using (Pen pen = new Pen(Color.FromArgb(100, 150, 240), 2)) // Color azul claro brillante y grosor de 2 píxeles
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void btnRuleta_Click(object sender, EventArgs e)
{
    // 1. Creamos una instancia de la pantalla de la ruleta (Form2)
    Form2 pantallaRuleta = new Form2();

    // 2. La mostramos en la pantalla
    pantallaRuleta.Show();

    // 3. Opcional: Si quieres ocultar este menú principal mientras juegas, descomenta la siguiente línea:
    // this.Hide();
}

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {            // Crear una nueva instancia del formulario de Historial
            FrmHistorial formularioHistorial = new FrmHistorial();

            // Mostrar el formulario en pantalla
            formularioHistorial.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            FrmHistorial formularioHistorial = new FrmHistorial();
            formularioHistorial.Show();
        }
    }
}
