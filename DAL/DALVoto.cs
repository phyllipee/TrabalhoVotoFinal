using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace DAL
{
   public class DALVoto
    {
        private DALConexao conexao;

        public DALVoto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOVoto modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "insert into Voto(IDELEICAO, IDURNA, IDPESSOA, NUMEROVOTO)" +
                    "VALUES (@i, @b,@c,@d);";
                cmd.Parameters.AddWithValue("@i", modelo.IDELEICAO1);
                cmd.Parameters.AddWithValue("@b", modelo.IDURNA1);
                cmd.Parameters.AddWithValue("@c", modelo.IDPESSOA1);
                cmd.Parameters.AddWithValue("@d", modelo.NUMEROVOTO1);
               

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
