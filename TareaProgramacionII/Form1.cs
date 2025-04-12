using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaProgramacionII
{
    public partial class Form1 : Form
    {

        string[] arregloDeElementos = new string[5];
        int indiceActual = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;

        }

        private void txt_mostarnombre_Click(object sender, EventArgs e)
        {
            lbl_mostranombre.Text = txt_nombre.Text;
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            lbl_mostranombre.Text = "¡Hola " + txt_nombre.Text + "!";
            txt_nombre.Clear();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            lst_palabrascontenido.Items.Add(txt_palabras.Text);
            txt_palabras.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           //CAMBIAR LAS PROPIEDADES DEL LABEL: lbl_cambios

           this.BackColor = Color.Orange;
           this.lbl_cambios.ForeColor = Color.Red;
           this.lbl_cambios.Text = "4. Se ha cambiado el texto y color de este label.";

        //***********************************************************************************

           //CAMBIAR LAS PROPIEDADES DEL LABEL: lbl_cambiarporcodigo

           this.lbl_cambiarporcodigo.Font = new Font("Arial", 12, FontStyle.Bold);
           this.lbl_cambiarporcodigo.TextAlign = ContentAlignment.BottomRight;
           this.lbl_cambiarporcodigo.Size = new Size(200, 50);

            //***********************************************************************************


            //AQUÍ SE CAMBIAN LOS NOMBRES Y MÉTODOS DE LOS BOTONES

            btn_azul.Name = "Boton Azul";
            btn_amarillo.Name = "Boton Amarillo";
            btn_verde.Name = "Boton Verde";

            btn_azul.Click += MiMetodoPresionarBoton;
            btn_amarillo.Click += MiMetodoPresionarBoton;
            btn_verde.Click += MiMetodoPresionarBoton;


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola este es un mensaje","Mensaje de Visual Studio",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_ocultarlabel_Click(object sender, EventArgs e)
        {
            lbl_ocultarse.Visible = false;
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            
            if (txt_palabravalidar.Text == "")
            {
                MessageBox.Show("Por favor ingrese una palabra para validar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_palabravalidar.Clear();
            }

            txt_palabravalidar.Clear();
        }

        private void btn_borrarcontenido_Click(object sender, EventArgs e)
        {
            txt_palabras.Clear();
            lst_palabrascontenido.Items.Clear();

        }
        private void MiMetodoPresionarBoton(object sender, EventArgs e)
        {
            Button botonusado = sender as Button;

            if (botonusado != null)
            {
                switch(botonusado.Name)
                {
                    case "Boton Azul":
                        this.BackColor = Color.Blue;
                        MessageBox.Show("Usted presiono el botón: " + btn_azul.Name,"Mensaje",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                        break;
                    case "Boton Amarillo":
                        this.BackColor = Color.Yellow;
                        MessageBox.Show("Usted presiono el botón: " + btn_amarillo.Name, "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        break;
                    case "Boton Verde":
                        this.BackColor = Color.Green;
                        MessageBox.Show("Usted presiono el botón: " + btn_verde.Name, "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        break;

                    default:
                        break;

                }
            }


        }
        private void btn_mostraritemseleccionado_Click(object sender, EventArgs e)
        {
            if(lst_palabrascontenido.SelectedItem != null)
            {
                MessageBox.Show("El item seleccionado es: " + lst_palabrascontenido.SelectedItem.ToString(), "Item Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un item de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_cambiarporcodigo_Click(object sender, EventArgs e)
        {

        }
        public void ReiniciarCarga()
        {
            arregloDeElementos = new string[5];     // Vuelve a crear el arreglo vacío
            indiceActual = 0;                       // Reinicia el índice

            txt_elementosagregados.Clear();         // Limpia el textbox
            txt_elementosagregados.Enabled = true;  // Lo vuelve a habilitar

            btn_agregarElementos.Text = "AGREGAR ELEMENTO";  // Cambia el texto del botón
        }


        private void btn_agregarElementos_Click(object sender, EventArgs e)
        {

            // Si el botón ya cambió de función, mostrar elementos y abrir Form2
            if (btn_agregarElementos.Text == "MOSTRAR ELEMENTOS")
            {
                Form2 ventanaSiguiente = new Form2(arregloDeElementos,this); // si necesitás enviar Form1
                ventanaSiguiente.Show();
                this.Hide();
                return;
            }


            string nuevoElemento = txt_elementosagregados.Text.Trim();

            if(string.IsNullOrEmpty(nuevoElemento))
            {
                MessageBox.Show("Por favor ingrese un elemento para agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(indiceActual < arregloDeElementos.Length)
            {
                arregloDeElementos[indiceActual] = nuevoElemento;
                indiceActual++;

                MessageBox.Show("Elemento agregado: " + nuevoElemento, "Elemento Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_elementosagregados.Clear();
            }

            if(indiceActual == arregloDeElementos.Length)
            {
                MessageBox.Show("¡Se completaron los 5 elementos!");
                btn_agregarElementos.Text = "MOSTRAR ELEMENTOS";
                txt_elementosagregados.Enabled = false;

            }

           

        }
    }
}
