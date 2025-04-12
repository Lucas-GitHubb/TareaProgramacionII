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
    public partial class Form2 : Form
    {

        Form1 formPrincipal; // Variable para guardar referencia al Form1
        public Form2(string[] elementos,Form1 formDeOrigen)
        {
            InitializeComponent();
            formPrincipal = formDeOrigen; // Guardar la referencia al Form1, aquí el formPrincipal puede utilizar todos
                                          // los métodos y propiedades públicas de Form1

            foreach (string items in elementos)
            {
                lst_elementosnuevos.Items.Add(items);
            }
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
           formPrincipal.ReiniciarCarga(); //aqui por ejemplo se utilizar uno de los métodos para reiniciar la carga
                                           // de la lista de elementos en el Form1 y cambia la propiedad del botón inclusive
            formPrincipal.Show();
           this.Close();

        }
    }
}
