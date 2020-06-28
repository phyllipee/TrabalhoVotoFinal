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
    public partial class Voto : Form
    {
        public Voto()
        {
            InitializeComponent();
        }

        private void inserir_botao_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLVoto bllurna = new BLLVoto(cx);

                MODELOVoto p = new MODELOVoto();
                p.IDELEICAO1 = Convert.ToInt32(ideleicao_text.Text);
                p.IDURNA1 = Convert.ToInt32(idurna_text.Text);
                p.IDPESSOA1 = Convert.ToInt32(idpessoa_text.Text);
                p.NUMEROVOTO1 = Convert.ToInt32(numerovoto_text.Text);



                bllurna.Incluir(p);

                MessageBox.Show("Voto computado com sucesso !!");

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
            idurna_text.Clear();
            idpessoa_text.Clear();
            numerovoto_text.Clear();

        }
        private void voltar_botao_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void Voto_Load(object sender, EventArgs e)
        {

        }
    }
}
