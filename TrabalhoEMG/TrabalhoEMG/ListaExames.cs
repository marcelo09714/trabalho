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
    public partial class ListaExames : Form
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



        public ListaExames(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            this.Text = cliente.Name;
           
            /* DataView dataView = dataHelper.DataSet.Tables[DataHelper.DATATABLE_TERAPIES].DefaultView;
             dataView.RowFilter = string.Format("[{0}] = '{1}'", DataHelper.MEDICATIONS_CLIENT_ID, client.Id);
             dataGridViewTerapies.DataSource = dataView;
             */

            //Aparecer as horas e o dia no programa
            labelDataListaExames.Text = DateTime.Now.ToLongDateString();
            

            //Pôr a parte de trás das labels transparente
            labelDataListaExames.BackColor = Color.Transparent;
            labelHoraListaExames.BackColor = Color.Transparent;
            botaoRetroceder.BackColor = Color.Transparent;

            //conta o tempo
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        //contador do tempo
        void Timer_Tick(object sender, EventArgs e)
        {
            labelHoraListaExames.Text = DateTime.Now.ToLongTimeString();
        }

        private void botaoFazerExame_Click(object sender, EventArgs e)
        {
          
                Exame exame = new Exame(cliente);

                exame.Show();
            
        }

        //botao que serve para voltar atrás e esconde a página onde estavamos 
        private void botaoRetroceder_Click(object sender, EventArgs e)
        {
            Registo registo = new Registo();

            this.Hide();
            registo.ShowDialog();
            
        }

        
    }

}