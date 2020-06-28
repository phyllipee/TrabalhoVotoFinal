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
    public partial class Pessoa : Form
    {
        public Pessoa(principals f)
        {
            InitializeComponent();
           
        }
        public Pessoa()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            TXTCPF.Clear();
            TXTEmail.Clear();
            TXTId.Clear();
            TXTNome.Clear();
            DTPNascimento.Text = "";
            CB_Sexo.SelectedItem = null;
        }
        private void TXTNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTPNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CB_Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Localizar f = new Localizar();
            f.ShowDialog();

            if (f.modelpessoa != null)
            {
                popularcampos(f.modelpessoa);
            }
           
        }

        private void popularcampos(MODELOPassoa p)
        {
            if (p != null)
            {
                DTPNascimento.Text = Convert.ToString(p.DataNascimento);
                TXTNome.Text = p.Nome;
                TXTCPF.Text = p.Cpf;
                TXTEmail.Text = p.Email;
                TXTId.Text = p.Id.ToString();
                switch (p.Sexo)
                {
                    case "M":
                        CB_Sexo.SelectedItem = "Masculino";
                        break;
                    case "F":
                        CB_Sexo.SelectedItem = "Feminino";
                        break;
                    case "O":
                        CB_Sexo.SelectedItem = "Outro";
                        break;

                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLPessoa bllpessoa = new BLLPessoa(cx);

                MODELOPassoa p = new MODELOPassoa();
                p.Nome = TXTNome.Text;
                p.DataNascimento = new DateTime(DTPNascimento.Value.Year,
                    DTPNascimento.Value.Month,
                    DTPNascimento.Value.Day);

                switch (CB_Sexo.SelectedItem.ToString())
                {
                    case "Masculino":
                        p.Sexo = "M";
                        break;
                    case "Feminino":
                        p.Sexo = "F";
                        break;
                    case "Outro":
                        p.Sexo = "O";
                        break;
                }

                p.Email = TXTEmail.Text;
                p.Cpf = TXTCPF.Text;
                p.Id = Convert.ToInt32(TXTId.Text);

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
                BLLPessoa bllpessoa = new BLLPessoa(cx);
                bllpessoa.Excluir(Convert.ToInt32(TXTId.Text));
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

                BLLPessoa bllpessoa = new BLLPessoa(cx);

                MODELOPassoa p = new MODELOPassoa();
                p.Nome = TXTNome.Text;
                p.DataNascimento = new DateTime(DTPNascimento.Value.Year,
                    DTPNascimento.Value.Month,
                    DTPNascimento.Value.Day);

                switch (CB_Sexo.SelectedItem.ToString())
                {
                    case "Masculino":
                        p.Sexo = "M";
                        break;
                    case "Feminino":
                        p.Sexo = "F";
                        break;
                    case "Outro":
                        p.Sexo = "O";
                        break;
                }

                p.Email = TXTEmail.Text;
                p.Cpf = TXTCPF.Text;

                bllpessoa.Incluir(p);
                TXTId.Text = p.Id.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.Id);

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

        private void CadastroPessoa_Load(object sender, EventArgs e)
        {
            CB_Sexo.Items.Add("Masculino");
            CB_Sexo.Items.Add("Feminino");
            CB_Sexo.Items.Add("Outros");

        }
    }
}
