﻿using OxyPlot;
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
            this.cliente = cliente;
            InitializeComponent();
            this.Text = cliente.Name;

           /* DataView dataView = dataHelper.DataSet.Tables[DataHelper.DATATABLE_TERAPIES].DefaultView;
            dataView.RowFilter = string.Format("[{0}] = '{1}'", DataHelper.MEDICATIONS_CLIENT_ID, client.Id);
            dataGridViewTerapies.DataSource = dataView;
            */

            //Aparecer as horas e o dia no programa
            labelDataExame.Text = DateTime.Now.ToLongDateString();
            labelHoraExame.Text = DateTime.Now.ToLongTimeString();

            //Pôr a parte de trás das labels transparente
            labelDataExame.BackColor = Color.Transparent;
            labelHoraExame.BackColor = Color.Transparent;
        }

        private void comecar_Click(object sender, EventArgs e)
        {
            //Create Plotview object
            PlotView myPlot = new PlotView();

            //Create Plotmodel object
            var myModel = new PlotModel { Title = "Simple Plot" };
            myModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));

            //Assign PlotModel to PlotView
            myPlot.Model = myModel;

            //Set up plot for display
            myPlot.Dock = System.Windows.Forms.DockStyle.Bottom;
            myPlot.Location = new System.Drawing.Point(0, 0);
            myPlot.Size = new System.Drawing.Size(500, 500);
            myPlot.TabIndex = 0;

            //Add plot control to form
            Controls.Add(myPlot);
            /*
            //Create a data set to feed to the chart
            double[] DataArray = new double[] { 1, 2, 3, 5, 4, 3, 2, 1 };
            double[] DataArray2 = new double[] { 1, 5, 1, 5, 1, 5, 1, 5 };

            for (int i = 0; i & lt; DataArray.GetLength(0) ; i++)
            {
                //send X and Y data points to the chart
                grafico.Series["Primeiro Exame"].Points.AddXY(i, DataArray[i]);
                grafico.Series["Segundo Exame"].Points.AddXY(i, DataArray2[i]);
            }
            */
        }
    }
}
