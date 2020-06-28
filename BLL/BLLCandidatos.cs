using DAL;
using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCandidatos
    {
        private DALCandidato dalCandidato;
        private int a;


        public BLLCandidatos(DALConexao cx)
        {
            dalCandidato = new DALCandidato(cx);
        }

        public void Incluir(MODELOCandidato modelo)
        {

            try
            {
                if (Convert.ToString(modelo.IDPESSOA1) == "")
                {
                    throw new ArgumentNullException("ID Pessoa", "ID Pessoa não pode ser um campo vazio.");
                }
                if (object.ReferenceEquals(modelo.IDPESSOA1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição só pode conter números.");
                }





                if (Convert.ToString(modelo.IDELEICAO1) == "")
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição não pode ser um campo vazio.");
                }
                if (object.ReferenceEquals(modelo.IDELEICAO1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição só pode conter números.");
                }






                if (Convert.ToString(modelo.IDEMPRESA1) == "")
                {
                    throw new ArgumentNullException("ID Empresa", "ID Empresa não pode ser um campo vazio.");
                }
                if (object.ReferenceEquals(modelo.IDEMPRESA1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição só pode conter números.");
                }





                if (Convert.ToString(modelo.NUMERO1) == "")
                {
                    throw new ArgumentNullException("Numero Candidato", "Numero Candidato não pode ser um campo vazio.");
                }
                if (object.ReferenceEquals(modelo.NUMERO1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição só pode conter números.");
                }





                dalCandidato.Incluir(modelo);
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