using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apyAllia20260401
{
    public partial class frmMain : Form
    {
        //Declaracion de variables globales
                string varCodigo = "";
                string varNombre = "";
                string varDescripcion = "";
                int varPrecio = 0;
                int varStock = 0;
                string varCategoria = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lblInfo.Text =  "Codigo: " + maskedTxtCodigo.Text 
            + " /  Nombre: " + txtNombre.Text + "\n"  + " /  Descripcion: " 
            + txtDescripcion.Text + " \n " + " /  Precio: " + maskedTxtPrecio.Text + " /  Stock: " 
            + maskedTxtStock.Text + " /  Categoria: " + cmbGestion.Text ;

            varCodigo = maskedTxtCodigo.Text;
            varNombre = txtNombre.Text;
            varDescripcion = txtDescripcion.Text;
            //es para que se comvierta el texto a numero entero, ya que el maskedTxtPrecio es un tipo de dato string
            varPrecio = Convert.ToInt32(maskedTxtPrecio.Text);
            varStock = Convert.ToInt32(maskedTxtStock.Text);
            varCategoria = cmbGestion.Text;

            MessageBox.Show("Producto cargado correctamente.", "Gestión de Productos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
