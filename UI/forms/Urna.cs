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
    public partial class Urna : Form
    {
        public Urna()
        {
            InitializeComponent();
        }

        private void Inserir_botao_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLUrna bllurna = new BLLUrna(cx);

                MODELOUrna p = new MODELOUrna();
                p.NOME1 = Nome_text.Text;
                p.DESCRICAO1 = Descricao_text.Text;



                p.IP1 = Convert.ToInt32(IP_text.Text);


                bllurna.Incluir(p);
                p.IDURNA1 = 0;
                MessageBox.Show("Urna computada com sucesso!");

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
            Nome_text.Clear();
            Descricao_text.Clear();
            IP_text.Clear();

        }

        private void voltar_botao_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void Urna_Load(object sender, EventArgs e)
        {
   
        }
    }
}
