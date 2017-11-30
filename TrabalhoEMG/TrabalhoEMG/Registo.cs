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
    public partial class Registo : Form
    {
        
        Dados dados;

        public Registo()
        {
            InitializeComponent();
            dados = new Dados();

            //Pôr a parte de trás das labels transparente
            labelData.BackColor = Color.Transparent;
            labelHora.BackColor = Color.Transparent;
            labelGenero.BackColor = Color.Transparent;
            labelNome.BackColor = Color.Transparent;
            labelDataNascimento.BackColor = Color.Transparent;
            radioButtonMasculino.BackColor = Color.Transparent;
            radioButtonFeminino.BackColor = Color.Transparent;

            //Aparecer as horas e o dia no programa
            labelData.Text = DateTime.Now.ToLongDateString();
            labelHora.Text = DateTime.Now.ToLongTimeString();


            dataGridViewClientes.DataSource = dados.DataSet;
            dataGridViewClientes.DataMember = Dados.DATATABLE_CLIENTS;
            dataGridViewClientes.AutoGenerateColumns = true;
            dataGridViewClientes.AutoResizeColumns();
        }

        private void Registo_Load(object sender, EventArgs e)
        {

        }

        //Botão para adicionar um cliente
        private void botaoAdicionar(object sender, EventArgs e)
        {

            Cliente clientToAdd = new Cliente(textBoxNome.Text, dateTimePicker.Value, getCheckedGender());

            
            Cliente.addToDataBase(dados, clientToAdd);

        }

        //Botão para apagar o cliente selecionado
        private void botaoApagar(object sender, EventArgs e)
        {
            int indexToRemove = dataGridViewClientes.CurrentCell.RowIndex;

            if (indexToRemove > -1)//faz com que se quisermos apagar algo que nao esta selecionado nao deie erro
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja apagar o cliente selecionado?", "Atenção!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    
                    Cliente.removeFromDataBase(dados, indexToRemove);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente!");
            }
        }

        //Botão para editar o cliente selecionado
        private void botaoEditar(object sender, EventArgs e)
        {
            int indexEditar;
            indexEditar = dataGridViewClientes.CurrentCell.RowIndex;

            if (indexEditar > -1)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja editar o cliente selecionado?", "Atenção!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Cliente clientToEdit = new Cliente(textBoxNome.Text, dateTimePicker.Value, getCheckedGender());
                    
                    clientToEdit.Name = textBoxNome.Text;
                    clientToEdit.DateTime = dateTimePicker.Value;
                    clientToEdit.Gender = getCheckedGender();
                  
                    Cliente.editOnDataBase(dados, clientToEdit, indexEditar);
                }
            }
            else
                MessageBox.Show("Por favor selecione um cliente!");
        }


        GenderType getCheckedGender()
        {
            bool isMasculino = radioButtonMasculino.Checked;
            GenderType gender;
            if (isMasculino) gender = GenderType.Masculino;
            else gender = GenderType.Feminino;
            return gender;
        }


        //Carregar duas vezes no cliente e aparecer a form exame
        private void dataGridViewClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridViewClientes.CurrentCell.RowIndex; // listBoxClientes.SelectedIndex;

            if (index > -1)
            {

                Cliente cliente = Cliente.readOnDataBase(dados, index);

                Exame exame = new Exame(cliente);

                exame.Show();

            }
        }
    }
}
