namespace PadraoDeProjetoEmCamadas.forms
{
    partial class Localizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localizar));
            this.DGVDados = new System.Windows.Forms.DataGridView();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.TXTBusca = new System.Windows.Forms.TextBox();
            this.LBLBusca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDados
            // 
            this.DGVDados.AllowUserToAddRows = false;
            this.DGVDados.AllowUserToDeleteRows = false;
            this.DGVDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDados.Location = new System.Drawing.Point(25, 63);
            this.DGVDados.Margin = new System.Windows.Forms.Padding(4);
            this.DGVDados.Name = "DGVDados";
            this.DGVDados.ReadOnly = true;
            this.DGVDados.RowHeadersWidth = 51;
            this.DGVDados.Size = new System.Drawing.Size(780, 314);
            this.DGVDados.TabIndex = 7;
            this.DGVDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDados_CellContentClick);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BTNBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNBuscar.ForeColor = System.Drawing.Color.White;
            this.BTNBuscar.Location = new System.Drawing.Point(705, 27);
            this.BTNBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(100, 28);
            this.BTNBuscar.TabIndex = 6;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = false;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // TXTBusca
            // 
            this.TXTBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBusca.Location = new System.Drawing.Point(25, 30);
            this.TXTBusca.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBusca.Name = "TXTBusca";
            this.TXTBusca.Size = new System.Drawing.Size(658, 22);
            this.TXTBusca.TabIndex = 5;
            // 
            // LBLBusca
            // 
            this.LBLBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLBusca.AutoSize = true;
            this.LBLBusca.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBusca.Location = new System.Drawing.Point(22, 9);
            this.LBLBusca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLBusca.Name = "LBLBusca";
            this.LBLBusca.Size = new System.Drawing.Size(143, 17);
            this.LBLBusca.TabIndex = 4;
            this.LBLBusca.Text = "Localizar por nome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TXTBusca);
            this.panel1.Controls.Add(this.BTNBuscar);
            this.panel1.Controls.Add(this.DGVDados);
            this.panel1.Controls.Add(this.LBLBusca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 401);
            this.panel1.TabIndex = 8;
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 401);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Localizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            this.Load += new System.EventHandler(this.Localizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDados;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.TextBox TXTBusca;
        private System.Windows.Forms.Label LBLBusca;
        private System.Windows.Forms.Panel panel1;
    }
}