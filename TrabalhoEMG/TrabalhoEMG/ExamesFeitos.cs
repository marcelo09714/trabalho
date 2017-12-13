using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEMG
{
    class ExamesFeitos
    {
        public static string DATATABLE_EXAMES = "Exames";
        public static string EXAMES_NAME = "Nome Do Exame";

        DataSet dataSet;
        DataTable tableExames;

        String filePath = "EMGExames.xml";


        public DataTable TableExames
        {
            get
            {
                return tableExames;
            }

            set
            {
                tableExames = value;
            }
        }
        
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

        public ExamesFeitos()
        {
            DataSet = new DataSet("therapies_dataset");

            TableExames = new DataTable(DATATABLE_EXAMES);

            TableExames.Columns.Add(EXAMES_NAME);
            DataSet.Tables.Add(TableExames);

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

