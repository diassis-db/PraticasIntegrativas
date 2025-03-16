using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Configuration;

namespace Alpha
{
    class BancoSQL
    {
        private static SqlConnection conectar;

        public static SqlConnection conexaoBanco()
        {
            string caminho = @"Data Source = DIASSIS-PC; Initial CATALOG=Delta; User ID = sa";
            conectar = new SqlConnection(caminho);
            conectar.Open();
            return conectar;
        }

        public static void dml(string v , string msgOK = null, string msgErro = null)
        {
            SqlDataAdapter da = null;
            try
            {
                var cp = conexaoBanco();
                var cmd = cp.CreateCommand();
                cmd.CommandText = v;
                da = new SqlDataAdapter(cmd.CommandText, cp);
                cmd.ExecuteNonQuery();
                cp.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }catch(Exception ex)
            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro + "\n" + ex.Message);
                }
            }
        }
    }
}
