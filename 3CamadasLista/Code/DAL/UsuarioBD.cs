using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace _3CamadasLista.Code.DAL
{
    class UsuarioBD
    {
        
        private MySqlConnection con = new MySqlConnection();
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;
      
        
        public void Conectar()
        {
            try
            {
                con.ConnectionString = Properties.Settings.Default.CST;
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);

            }
        }
        public void ExecutarCmn(string comandoSql)
        {
            try
            {
                MySqlCommand cmn = new MySqlCommand(comandoSql, con);
                cmn.ExecuteNonQuery();
                MessageBox.Show("O registro foi gravado com sucesso");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);

            }
        }

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, con);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);
            return data;
        }
    }
}
