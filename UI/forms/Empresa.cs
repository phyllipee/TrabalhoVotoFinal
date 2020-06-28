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
    public partial class Empresa : Form
    {
        public int guardar = 0;
        public Empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void limparCampos()
        {
            nameBox.Clear();
            descriptionBox.Clear();
            cnpjBox.Clear();
        }
        private void popularcampos(MODELOEmpresa p)
        {
            if (p != null)
            {
                guardar = p.IdEmpresa;
                nameBox.Text = p.NomeEmpresa;
                descriptionBox.Text = p.Descricao;
                cnpjBox.Text = p.CodeEmpresa;

            }
        }
        public Empresa(principals x)
        {
            InitializeComponent();
         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LocalizarEmpresa f = new LocalizarEmpresa();
            f.ShowDialog();
            if (f.modelempresa != null)
            {
                popularcampos(f.modelempresa);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.NomeEmpresa = nameBox.Text;
                p.Descricao = descriptionBox.Text;
                p.CodeEmpresa = cnpjBox.Text;
                p.IdEmpresa = guardar;


                bllempresa.Alterar(p);
                MessageBox.Show("Empresa alterada com sucesso.");

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
                    MessageBox.Show("Falha ao alterar erro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar erro geral:" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MODELOEmpresa a = new MODELOEmpresa();
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEmpresa bllempresa = new BLLEmpresa(cx);
                bllempresa.Excluir(guardar);
                MessageBox.Show("Empresa excluida com sucesso.");

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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();


                p.NomeEmpresa = nameBox.Text;
                p.Descricao = descriptionBox.Text;
                p.CodeEmpresa = cnpjBox.Text;



                bllempresa.Incluir(p);

                MessageBox.Show("Empresa inserida com sucesso");

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

        private void button5_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
