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
    public partial class LocalizarEmpresa : Form
    {
        public MODELOEmpresa modelempresa;
        public LocalizarEmpresa()
        {
            InitializeComponent();
        }

        private void LocalizarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEmpresa bllempresa = new BLLEmpresa(cx);
            DataTable tabela = bllempresa.Localizar(TXTBusca.Text);
            DGVDados.DataSource = tabela;
        }

        private void DGVDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modelempresa = new MODELOEmpresa();

            this.modelempresa.IdEmpresa = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modelempresa.NomeEmpresa = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.modelempresa.Descricao = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modelempresa.CodeEmpresa = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();

            Empresa x = new Empresa();

            x.guardar = modelempresa.IdEmpresa;




            this.Close();
        }

        private void TXTBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
