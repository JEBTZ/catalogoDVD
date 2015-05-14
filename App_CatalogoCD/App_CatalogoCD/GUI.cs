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
            c = new Catalogo();
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            c.LeerDVD();
            rtbResultado.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.LeerDVD();
            rtbResultado.Text = c.Xml;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnadirDVD();
            txbDatos.Enabled = true;
            txbDatos.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BorrarDVD();
            txbDatos.Enabled = true;
            txbDatos.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActualizarDVD();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VolcarAFichero();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c.FiltrarPorPais();
            rtbResultado.Text = (c.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static void BorrarDVD()
        {
            Console.WriteLine();
            Console.WriteLine("Código de DVD para eliminar?");
            string codigo = Console.ReadLine();
            Console.WriteLine("Borrando el DVD con código: " + codigo);
            if (c.BorrarDVD(codigo) != 0)
                Console.WriteLine("Operación realizada");
            else
                Console.WriteLine("Registro no encontrado");
        }
        static void AnadirDVD()
        {
            Console.WriteLine();
            Console.WriteLine("Código de DVD para añadir?");
            string codigo = Console.ReadLine();
            Console.WriteLine("Añadiendo el DVD con código: " + codigo);
            c.AddEntrada(codigo);
        }

        static void PedirCampos(dvd registro)
        {
            string entrada;

            Console.Write("Titulo: [" + registro.Titulo + "]: ");
            entrada = Console.ReadLine();
            if (entrada != "")
                registro.Titulo = entrada;
            Console.Write("Artista: [" + registro.Artista + "]: ");
            entrada = Console.ReadLine();
            if (entrada != "")
                registro.Artista = entrada;
            Console.Write("Pais: [" + registro.Pais + "]: ");
            entrada = Console.ReadLine();
            if (entrada != "")
                registro.Pais = entrada;
            Console.Write("Compañía: [" + registro.Compania + "]: ");
            entrada = Console.ReadLine();
            if (entrada != "")
                registro.Compania = entrada;
            Console.Write("Precio: [" + registro.Precio + "]: ");
            entrada = Console.ReadLine();
            if (entrada != "")
                registro.Precio = Decimal.Parse(entrada);
            Console.Write("Año: [" + registro.Anio + "]: ");
            entrada = Console.ReadLine();
            if (entrada != "")
                registro.Anio = ushort.Parse(entrada);
        }

        static void ActualizarDVD()
        {
            dvd registro;

            Console.WriteLine("\nCódigo de DVD para modificar?");
            string codigo = Console.ReadLine();

            registro = c.LeerDVD(codigo);
            if (registro != null)
            {
                Console.WriteLine(registro.ToString());

                PedirCampos(registro);

                Console.WriteLine(registro.ToString());
                Console.Write("Es correcto? [s/n] ");
                if (Console.ReadKey().Key.Equals(ConsoleKey.S))
                {
                    if (c.ActualizarDVD(registro) == 1)
                        Console.WriteLine("\nRegistro actualizado correctamente");
                    else
                        Console.WriteLine("Error al actualizar el registro");
                }
            }
            else
                Console.WriteLine("Disco no encontrado");
        }
        static void VolcarAFichero()
        {
            c.XmlAFichero();
        }
    }
}
