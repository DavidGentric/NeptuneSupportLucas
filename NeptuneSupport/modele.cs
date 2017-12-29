using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptuneSupport
{
    class Modele
    {
        #region Propriétés
        private FbConnection myConnection;
        private bool connopen = false;
        private FbDataAdapter da = new FbDataAdapter();
        private string dbName;
        #endregion

        #region Accesseurs
        public bool Connopen { get => connopen; set => connopen = value; }
        public string DbName { get => dbName; set => dbName = value; }
        #endregion

        public Modele(string dbN)  //constructeur
        {
            dbName = dbN;
        }

        public void ConnexionFB()
        {
            string connectionString=
            "User=localhost;" +
            "Password=2309Fire;" +
            "Database=" + DbName + ";" +
            "DataSource=localhost;" +
            "Port=3050;" +
            "Dialect=1;" +  //Dialect=1 ou 3;
            "Charset=NONE;" +
            "Role=;" +
            "Connection lifetime=15;" +
            "Pooling=true;" +
            "MinPoolSize=0;" +
            "MaxPoolSize=50;" +
            "Packet Size=8192;" +
            "ServerType=0";

            myConnection = new FbConnection(connectionString);

            try
            {
                myConnection.Open();
                connopen = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeconnexionFB()
        {
            if (!connopen) return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string Query(string sql)  //requête classique
        {
            try
            {
                var dataSet = new DataSet();

                var command = new FbCommand(sql, myConnection) { CommandType = CommandType.StoredProcedure };

                var dataAdapter = new FbDataAdapter { SelectCommand = command };

                dataAdapter.Fill(dataSet);

                return dataSet.Tables[0].Rows[0]["Item"].ToString();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DateTime QueryTime(string sql)  //requête dateTime
        {
            try
            {
                var dataSet = new DataSet();

                var command = new FbCommand(sql, myConnection) { CommandType = CommandType.StoredProcedure };

                var dataAdapter = new FbDataAdapter { SelectCommand = command };

                dataAdapter.Fill(dataSet);

                return Convert.ToDateTime(dataSet.Tables[0].Rows[0]["Item"]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}