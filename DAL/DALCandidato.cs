using System;
using MODEL;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALCandidato
    {
        private DALConexao conexao;

        public DALCandidato(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOCandidato modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Candidatos (IDPESSOA, IDELEICAO, IDEMPRESA, NUMERO, SLOGAN, DESCRICAO, FOTO)" +
                    "VALUES (@idpes,@ideleic,@idempresa, @num, @slog, @desc, @foto);";
                   
                cmd.Parameters.AddWithValue("@idpes", modelo.IDPESSOA1);
                cmd.Parameters.AddWithValue("@ideleic", modelo.IDELEICAO1);
                cmd.Parameters.AddWithValue("@idempresa", modelo.IDEMPRESA1);
                cmd.Parameters.AddWithValue("@num", modelo.NUMERO1);
                cmd.Parameters.AddWithValue("@slog", modelo.SLOGAN1);
                cmd.Parameters.AddWithValue("@desc", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@foto", modelo.FOTO1);
               

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
