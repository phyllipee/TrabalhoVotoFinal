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
    public class BLLUrna
    {
        private DALUrna dalUrna;
        private int a;
        public BLLUrna(DALConexao cx)
        {
            dalUrna = new DALUrna(cx);
        }
        public void Incluir(MODELOUrna modelo)
        {

            try
            {
               
                
                if (modelo.NOME1 == "")
                {
                    throw new ArgumentNullException("Nome", "Nome não pode ser um campo vazio.");
                }
                bool Caracter = Regex.IsMatch(modelo.NOME1, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));
                if (Caracter == true)
                {
                    throw new ArgumentNullException("Nome", "Nome não pode ter caractéres especiais");
                }





                if (Convert.ToString(modelo.IP1) == "")
                {
                    throw new ArgumentNullException("IP", "IP não pode ser um campo vazio.");
                }
                if (object.ReferenceEquals(modelo.IP1.GetType(), a.GetType()) == false)
                {
                    throw new ArgumentNullException("ID Eleição", "ID Eleição só pode conter números.");
                }





                dalUrna.Incluir(modelo);
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
