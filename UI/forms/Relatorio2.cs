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
    public partial class Relatorio2 : Form
    {
        public Relatorio2()
        {
            InitializeComponent();
        }

        private void Relatorio2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sql10351329DataSet.Eleicao'. Você pode movê-la ou removê-la conforme necessário.
            this.eleicaoTableAdapter.Fill(this.sql10351329DataSet.Eleicao);

            this.reportViewer1.RefreshReport();
        }
    }
}
