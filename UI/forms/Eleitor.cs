using BLL;
using DAL;
using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas.forms
{
    public partial class Eleitor : Form
    {
        public Eleitor()
        {
            InitializeComponent();
        }

        private void Inserir_botao_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleitor bllurna = new BLLEleitor(cx);

                MODELOEleitor p = new MODELOEleitor();
                p.IDELEICAO1 = Convert.ToInt32(ideleicao_text.Text);
                p.IDPESSOA1 = Convert.ToInt32(idpessoa_text.Text);
                p.IDEMPRESA1 = Convert.ToInt32(idempresa_text.Text);


                bllurna.Incluir(p);

                MessageBox.Show("Eleitor inserido com sucesso!");

                limparCampos();
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }

        public void limparCampos()
        {
            ideleicao_text.Clear();
            idpessoa_text.Clear();
            idempresa_text.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void Eleitor_Load(object sender, EventArgs e)
        {

        }
    }
}