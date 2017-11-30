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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        int carregar = 0;
      

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (carregar < 100)
            {
                carregar = carregar + 3;
            }
            else
            {
                tempo.Enabled = false;
                this.Visible = false;
                Registo registo = new Registo();
                registo.ShowDialog();
            }
        }
    }
}
