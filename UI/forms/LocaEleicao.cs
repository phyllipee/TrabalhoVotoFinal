using BLL;
using DAL;
using MODELO;
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
    public partial class LocaEleicao : Form
    {
        public MODELOEleicao modeloelei;
        public LocaEleicao()
        {
            InitializeComponent();
        }

        private void LocaEleicao_Load(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEleicao bllpessoa = new BLLEleicao(cx);
            DataTable tabela = bllpessoa.Localizar(TXTBuscar.Text);
            DGVDados.DataSource = tabela;
        }

        private void DGVDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modeloelei = new MODELOEleicao();

            this.modeloelei.Ideleicao = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modeloelei.Idempresa = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString());
            this.modeloelei.Nome = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modeloelei.Descricao = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modeloelei.Tipovoto = Convert.ToByte(DGVDados.Rows[e.RowIndex].Cells[4].Value);
            this.modeloelei.Mensagemencerrado = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.modeloelei.Mensagemfim = DGVDados.Rows[e.RowIndex].Cells[6].Value.ToString();
            DateTime data = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[7].Value.ToString());
            DateTime data1 = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[7].Value.ToString());

            this.modeloelei.Datainicio = data;
            this.modeloelei.Datafim = data1;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
