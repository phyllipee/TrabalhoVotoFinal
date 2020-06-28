using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class DALEleitor
    {
        private DALConexao conexao;

        public DALEleitor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOEleitor modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Eleitor (IDPESSOA, IDELEICAO, IDEMPRESA)" +
                    "VALUES (@idpes,@ideleic,@idempresa);";
                    
                cmd.Parameters.AddWithValue("@idpes", modelo.IDPESSOA1);
                cmd.Parameters.AddWithValue("@ideleic", modelo.IDELEICAO1);
                cmd.Parameters.AddWithValue("@idempresa", modelo.IDEMPRESA1);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
               
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
