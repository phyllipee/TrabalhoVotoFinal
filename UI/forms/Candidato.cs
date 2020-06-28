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
    public partial class Candidato : Form
    {
        private string fpessoa = "";
        public Candidato()
        {
            InitializeComponent();
        }

        private void Candidato_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            if (!string.IsNullOrEmpty(op.FileName))
            {
                fpessoa = op.FileName;
                Caixa_Imagem.Load(fpessoa);
            }
        }

        private void Remover_btn_Click(object sender, EventArgs e)
        {
            fpessoa = "";
            Caixa_Imagem.Image = null;
        }

        private void Salvar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLCandidatos bllempresa = new BLLCandidatos(cx);

                MODELOCandidato p = new MODELOCandidato();
                p.IDELEICAO1 = Convert.ToInt32(IDeleicao_box.Text);
                p.IDEMPRESA1 = Convert.ToInt32(IDempresa_box.Text);
                p.IDPESSOA1 = Convert.ToInt32(IDpessoa_box.Text);
                p.NUMERO1 = Convert.ToInt32(Numero_box.Text);
                p.SLOGAN1 = Slogan_box.Text;
                p.DESCRICAO1 = Descri_box.Text;
                p.carregarImagem(fpessoa);

                bllempresa.Incluir(p);
                MessageBox.Show("Candidato inserido com sucesso!");
                limparcampos();
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
        public void limparcampos()
        {
            IDeleicao_box.Clear();
            IDempresa_box.Clear();
            IDpessoa_box.Clear();
            Numero_box.Clear();
            Slogan_box.Clear();
            Descri_box.Clear();
            Caixa_Imagem.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparcampos();
        }

        private void Caixa_Imagem_Click(object sender, EventArgs e)
        {

        }
    }
}
