using BLL;
using DAL;
using MODELO;
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
    public partial class Eleicao : Form
    {
           
        public int guardar = 0;
        private principals frmPrincipal;
        public Eleicao()
        {
            InitializeComponent();
        }
        public Eleicao(principals frmPrincipal)
        {
            InitializeComponent();
         
        }

        private void CadastroEleicao_Load(object sender, EventArgs e)
        {

        }
        public void limparCampos()
        {
            NomeElei.Clear();
            Eleidesc.Clear();
            TipoVoto.Checked = false;
            Encerramento.Clear();
            Conclusao.Clear();
            IdEmpresa.Clear();
        }
        private void popularcampos(MODELOEleicao p)
        {


            if (p != null)
            {
                Inicio.Text = Convert.ToString(p.Datainicio);
                NomeElei.Text = p.Nome;

                Eleidesc.Text = p.Descricao;
                Encerramento.Text = p.Mensagemencerrado;
                Conclusao.Text = p.Mensagemfim;
                IdEmpresa.Text = p.Idempresa.ToString();
                if (p.Tipovoto == 1)
                {
                    TipoVoto.Checked = true;
                }
                if (p.Tipovoto == 0)
                {
                    TipoVoto.Checked = false;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            LocaEleicao f = new LocaEleicao();
         
            f.ShowDialog();

            if (f.modeloelei != null)
            {
                popularcampos(f.modeloelei);

                guardar = f.modeloelei.Ideleicao;
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao bllpessoa = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.Nome = NomeElei.Text;
                p.Datainicio = Convert.ToDateTime(Inicio.Text);
                p.Datafim = Convert.ToDateTime(Fim.Text);
                p.Descricao = Eleidesc.Text;
                p.Mensagemencerrado = Encerramento.Text;
                p.Mensagemfim = Conclusao.Text;
                p.Idempresa = Convert.ToInt32(IdEmpresa.Text);
                p.Ideleicao = guardar;
                if (TipoVoto.Checked == true)
                {
                    p.Tipovoto = 1;
                }
                if (TipoVoto.Checked == false)
                {
                    p.Tipovoto = 0;
                }

                bllpessoa.Alterar(p);
                MessageBox.Show("Usuario alterado com sucesso.");

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
                    MessageBox.Show("Falha ao alterar errro:" + ex.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar errro geral:" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEleicao bllpessoa = new BLLEleicao(cx);
                bllpessoa.Excluir(guardar);
                MessageBox.Show("Usuario excluido com sucesso.");

                limparCampos();
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao bllpessoa = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.Nome = NomeElei.Text;
                p.Datainicio = Convert.ToDateTime(Inicio.Text);
                p.Datafim = Convert.ToDateTime(Fim.Text);
                p.Descricao = Eleidesc.Text;
                p.Mensagemencerrado = Encerramento.Text;
                p.Mensagemfim = Conclusao.Text;
                p.Idempresa = Convert.ToInt32(IdEmpresa.Text);
                if (TipoVoto.Checked == true)
                {
                    p.Tipovoto = 1;
                }
                if (TipoVoto.Checked == false)
                {
                    p.Tipovoto = 0;
                }

                bllpessoa.Incluir(p);
                MessageBox.Show("Usuario inserido com sucesso id:");

                limparCampos();
                
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
