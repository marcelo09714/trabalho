using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEMG
{
    public class Dados
    {
        public static string DATATABLE_CLIENTS = "Clientes";
        public static string CLIENTS_NAME = "Nome";
        public static string CLIENTS_BIRTHDAY = "Data de Nascimento";
        public static string CLIENTS_GENDER = "Género";
        public static string CLIENTS_ID = "ID";

       /* public static string DATATABLE_TERAPIES = "datatable_medications";
        public static string MEDICATIONS_QTD = "qtd";
        public static string MEDICATIONS_POSOLOGY = "posology";
        public static string MEDICATIONS_CLIENT_ID = "client_id";
        public static string MEDICATIONS_ID = "id";
        public static string MEDICATIONS_NAME = "name";
        */
        DataSet dataSet;
        DataTable tableClients;
        //DataTable tableMedicactions;

        String filePath = "EMGClientes.xml";


        public DataTable TableClients
        {
            get
            {
                return tableClients;
            }

            set
            {
                tableClients = value;
            }
        }

       /* public DataTable TableMedicactions
        {
            get
            {
                return tableMedicactions;
            }

            set
            {
                tableMedicactions = value;
            }
        }*/

        public DataSet DataSet
        {
            get
            {
                return dataSet;
            }

            set
            {
                dataSet = value;
            }
        }

        public Dados()
        {
            DataSet = new DataSet("therapies_dataset");

            TableClients = new DataTable(DATATABLE_CLIENTS);
            TableClients.Columns.Add(CLIENTS_NAME);
            TableClients.Columns.Add(CLIENTS_BIRTHDAY);
            TableClients.Columns.Add(CLIENTS_GENDER);
            TableClients.Columns.Add(CLIENTS_ID);

          /*TableMedicactions = new DataTable(DATATABLE_TERAPIES);
            TableMedicactions.Columns.Add(MEDICATIONS_NAME);
            TableMedicactions.Columns.Add(MEDICATIONS_QTD);
            TableMedicactions.Columns.Add(MEDICATIONS_POSOLOGY);
            TableMedicactions.Columns.Add(MEDICATIONS_CLIENT_ID);
            TableMedicactions.Columns.Add(MEDICATIONS_ID);
            */
            DataSet.Tables.Add(TableClients);
           // DataSet.Tables.Add(TableMedicactions);

            load();
        }



        public void save()
        {
            DataSet.WriteXml(filePath);
        }

        public void load()
        {
            try
            {
                DataSet.ReadXml(filePath);
            }
            catch (FileNotFoundException e)
            {

            }
        }


    }
}
