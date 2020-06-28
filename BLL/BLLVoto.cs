using DAL;
using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVoto
    {
        private DALVoto dalVoto;
        private int a = 1;
        public BLLVoto(DALConexao cx)
        {
            dalVoto = new DALVoto(cx);
        }

        public void Incluir(MODELOVoto modelo)
        {
            

            try
            {
                if (Convert.ToString(modelo.IDURNA1) == "")
                {
                    throw new ArgumentNullException("ID Urna", "ID Urna não pode ser um campo vazio.");
                }
                if (object.ReferenceEquals(modelo.IDURNA1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Urna", "ID Urna só pode conter números.");

                }




                if (Convert.ToString(modelo.IDELEICAO1) == "")
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição não pode ser um campo vazio.");
                }

                if (object.ReferenceEquals(modelo.IDELEICAO1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição só pode conter números.");
                }




                if (Convert.ToString(modelo.IDPESSOA1) == "")
                {
                    throw new ArgumentNullException("ID Pessoa", "ID pessoa não pode ser um campo vazio.");
                }
                if (object.ReferenceEquals(modelo.IDPESSOA1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição só pode conter números.");
                }




                if (Convert.ToString(modelo.NUMEROVOTO1) == "")
                {
                    throw new ArgumentNullException("ID Pessoa", "ID pessoa não pode ser um campo vazio.");
                }
                if (object.ReferenceEquals(modelo.NUMEROVOTO1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição só pode conter números.");
                }




                dalVoto.Incluir(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
