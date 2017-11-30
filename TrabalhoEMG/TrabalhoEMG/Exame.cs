using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEMG
{
    public partial class Exame : Form
    {
        private Cliente cliente;

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public Exame(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            this.Text = cliente.Name;
            //Aparecer as horas e o dia no programa
            labelDataExame.Text = DateTime.Now.ToLongDateString();
            labelHoraExame.Text = DateTime.Now.ToLongTimeString();

            //Pôr a parte de trás das labels transparente
            labelDataExame.BackColor = Color.Transparent;
            labelHoraExame.BackColor = Color.Transparent;
        }

        private void comecar_Click(object sender, EventArgs e)
        {

            

        }
    }
}
