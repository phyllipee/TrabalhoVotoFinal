using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUrna
    {
        private DALConexao conexao;

        public DALUrna(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOUrna modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Urna (IDURNA, NOME, DESCRICAO, IP)" +
                    "VALUES (NULL,@nome,@desc,@ip);" + "SELECT MAX(IDURNA) FROM Urna;" ;
                cmd.Parameters.AddWithValue("@nome", modelo.NOME1);
                cmd.Parameters.AddWithValue("@desc", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@ip", modelo.IP1);

                conexao.Conectar();

                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IDURNA1 = idInserido;



            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }
    }
}

