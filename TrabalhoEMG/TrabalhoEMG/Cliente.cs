using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEMG
{

    public enum GenderType { Masculino, Feminino };
    public class Cliente
    {
        String name;

        DateTime dateTime;

        long id;

        GenderType gender;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
            }
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }


        public Cliente(String name, DateTime dateTime, GenderType gender)
        {
            this.name = name;
            this.dateTime = dateTime;
            this.gender = gender;
            this.id = Tempo.CurrentTimeMillis();
        }

        public Cliente(String name, DateTime dateTime, GenderType gender, long id)
        {
            this.name = name;
            this.dateTime = dateTime;
            this.gender = gender;
            this.id = id;
        }

        //CRUD

        //CREATE
        public static void addToDataBase(Dados datahelper, Cliente client)
        {
            DataRow datarow = datahelper.TableClients.NewRow();

            datarow[Dados.CLIENTS_NAME] = client.Name;
            datarow[Dados.CLIENTS_BIRTHDAY] = client.DateTime;
            datarow[Dados.CLIENTS_GENDER] = client.Gender;
            datarow[Dados.CLIENTS_ID] = client.Id;

            datahelper.TableClients.Rows.Add(datarow);
            datahelper.save();
        }

        //READ
        public static Cliente readOnDataBase(Dados datahelper, int index)
        {
            Cliente cliente;

            DataRow datarow = datahelper.TableClients.Rows[index];

            cliente = new Cliente(

            (String)datarow[Dados.CLIENTS_NAME],
             DateTime.Parse((String)datarow[Dados.CLIENTS_BIRTHDAY]),
            parseGender((String)datarow[Dados.CLIENTS_GENDER]),
            long.Parse((String)datarow[Dados.CLIENTS_ID]));

            return cliente;
        }

        //update
        public static void editOnDataBase(Dados dados, Cliente client, int indexEditar)
        {
            DataRow datarow = dados.TableClients.Rows[indexEditar];

            datarow[Dados.CLIENTS_NAME] = client.Name;
            datarow[Dados.CLIENTS_BIRTHDAY] = client.DateTime;
            datarow[Dados.CLIENTS_GENDER] = client.Gender;
            datarow[Dados.CLIENTS_ID] = client.Id;

            
            dados.save();
        }

        //DELETE
        public static void removeFromDataBase(Dados dataHelper, int indexToRemove)
        {
            dataHelper.TableClients.Rows.RemoveAt(indexToRemove);
            dataHelper.save();
        }


        public static List<Cliente> getClientsList(Dados datahelper)
        {
            List<Cliente> clients = new List<Cliente>();

            foreach (DataRow dataRow in datahelper.TableClients.Rows)
            {
                String name = (String)dataRow[Dados.CLIENTS_NAME];
                DateTime birthday = (DateTime)dataRow[Dados.CLIENTS_BIRTHDAY];
                GenderType gender = (GenderType)dataRow[Dados.CLIENTS_GENDER];

                clients.Add(new Cliente(name, birthday, gender));
            }
            return clients;
        }

        public static GenderType parseGender(String strGender)
        {
            if (strGender.CompareTo("Masculino") == 0)
            {
                return GenderType.Masculino;
            }
            else
            {
                return GenderType.Feminino;
            }

        }

    }
}
