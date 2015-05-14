using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_CatalogoCD
{
    public partial class GUI : Form
    {
        static Catalogo c;
        public GUI()
        {
            InitializeComponent();
            c = new Catalogo();
            lblEstado.Text = c.Estado();
        }


        #region Métodos
        private void AnadirDVD()
        {
            lblAccion.Text = "Código de DVD para añadir?";
            string codigo = tbxVarios.Text;
            if (codigo != "")
            {
                c.AddEntrada(codigo);
            }
        }

        private void BorrarDVD()
        {
            lblAccion.Text = "Código de DVD para eliminar?";
            string codigo = tbxVarios.Text;
            if (codigo != "")
            {
                if (c.BorrarDVD(codigo) != 0)
                    lblEstado.Text = "Operación realizada, DVD eliminado..";
                else
                    lblEstado.Text = "Registro no encontrado..";
            }
        }
        #endregion

        private void btnLeer_Click(object sender, EventArgs e)
        {
            c.LeerDVD();
            rtbResultado.Text = c.ToString();
            lblAccion.Text = "Listado de DVD";
        }

        private void btnLeerAXml_Click_1(object sender, EventArgs e)
        {
            c.LeerDVD();
            rtbResultado.Text = c.Xml;
            lblAccion.Text = "Listado de DVD en XML";
        }

        private void btnAlAzar_Click_1(object sender, EventArgs e)
        {
            
            AnadirDVD();
            tbxVarios.Enabled = true;
            tbxVarios.Text = "";
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            
            BorrarDVD();
            tbxVarios.Enabled = true;
            tbxVarios.Text = "";
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolcar_Click(object sender, EventArgs e)
        {
            c.XmlAFichero();
            lblEstado.Text = c.Estado();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            c.FiltrarPorPais();
            rtbResultado.Text = (c.ToString());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

