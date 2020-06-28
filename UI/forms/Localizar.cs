﻿using BLL;
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
    public partial class Localizar : Form
    {
        public MODELOPassoa modelpessoa;
        public Localizar()
        {
            InitializeComponent();
        }

        private void Localizar_Load(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLPessoa bllpessoa = new BLLPessoa(cx);
            DataTable tabela = bllpessoa.Localizar(TXTBusca.Text);
            DGVDados.DataSource = tabela;
        }

        private void DGVDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modelpessoa = new MODELOPassoa();

            this.modelpessoa.Id = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modelpessoa.Nome = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();

            DateTime data = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString());

            this.modelpessoa.DataNascimento = data;
            this.modelpessoa.Sexo = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modelpessoa.Email = DGVDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.modelpessoa.Cpf = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.Close();
        }
    }
    }

