using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
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
            //serve para aparecer o nome do cliente em cima 
            this.cliente = cliente;
            InitializeComponent();
            this.Text = cliente.Name;

            /* DataView dataView = dataHelper.DataSet.Tables[DataHelper.DATATABLE_TERAPIES].DefaultView;
             dataView.RowFilter = string.Format("[{0}] = '{1}'", DataHelper.MEDICATIONS_CLIENT_ID, client.Id);
             dataGridViewTerapies.DataSource = dataView;
             */

            //Aparecer as horas e o dia no programa
            labelDataExame.Text = DateTime.Now.ToLongDateString();
           
            //Pôr a parte de trás das labels transparente
            labelDataExame.BackColor = Color.Transparent;
            labelHoraExame.BackColor = Color.Transparent;
            botaoRetroceder.BackColor = Color.Transparent;

            //conta o tempo
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }
        //contador de tempo
        void Timer_Tick(object sender, EventArgs e)
        {
            labelHoraExame.Text = DateTime.Now.ToLongTimeString();
        }

    private void comecar_Click(object sender, EventArgs e)
        {
            //Create Plotview object
            PlotView myPlot = new PlotView();

            //Create Plotmodel object
            var myModel = new PlotModel { Title = "Exame" };
            myModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));

            //Assign PlotModel to PlotView
            myPlot.Model = myModel;

            //Set up plot for display
            myPlot.Dock = System.Windows.Forms.DockStyle.Bottom;
            myPlot.Location = new System.Drawing.Point(0, 0);
            myPlot.Size = new System.Drawing.Size(623, 229);
            myPlot.TabIndex = 0;

            //Add plot control to form
            Controls.Add(myPlot);
           
        }

        //botao que serve para voltar atrás e esconde a página onde estavamos 
        private void botaoRetroceder_Click(object sender, EventArgs e)
        {
            ListaExames listaexames = new ListaExames(cliente);

            this.Hide();
            listaexames.ShowDialog();

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
