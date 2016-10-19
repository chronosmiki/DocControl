using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DocControl.Dao
{
    class ConectaBD
    {
        private String sql = "Server=localhost;Database=doccontrol;Uid=root;Pwd=";
        private MySqlConnection conn;

        public MySqlConnection Conecta()
        {
            try
            {
                conn = new MySqlConnection(sql);
                conn.Open();
                
            }catch(MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar no banco de dados \n" + ex.Message, "Erro ao conectar no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
            return conn;
        }

    }
}
