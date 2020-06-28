namespace PadraoDeProjetoEmCamadas.forms
{
    partial class Urna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urna));
            this.panel1 = new System.Windows.Forms.Panel();
            this.voltar_botao = new System.Windows.Forms.Button();
            this.Inserir_botao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IP_text = new System.Windows.Forms.TextBox();
            this.Descricao_text = new System.Windows.Forms.TextBox();
            this.Nome_text = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.voltar_botao);
            this.panel1.Controls.Add(this.Inserir_botao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 89);
            this.panel1.TabIndex = 0;
            // 
            // voltar_botao
            // 
            this.voltar_botao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voltar_botao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.voltar_botao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltar_botao.ForeColor = System.Drawing.Color.White;
            this.voltar_botao.Location = new System.Drawing.Point(706, 27);
            this.voltar_botao.Margin = new System.Windows.Forms.Padding(4);
            this.voltar_botao.Name = "voltar_botao";
            this.voltar_botao.Size = new System.Drawing.Size(105, 44);
            this.voltar_botao.TabIndex = 9;
            this.voltar_botao.Text = "Cancelar";
            this.voltar_botao.UseVisualStyleBackColor = false;
            this.voltar_botao.Click += new System.EventHandler(this.voltar_botao_Click);
            // 
            // Inserir_botao
            // 
            this.Inserir_botao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Inserir_botao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Inserir_botao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Inserir_botao.ForeColor = System.Drawing.Color.White;
            this.Inserir_botao.Location = new System.Drawing.Point(13, 27);
            this.Inserir_botao.Margin = new System.Windows.Forms.Padding(4);
            this.Inserir_botao.Name = "Inserir_botao";
            this.Inserir_botao.Size = new System.Drawing.Size(105, 44);
            this.Inserir_botao.TabIndex = 7;
            this.Inserir_botao.Text = "Inserir";
            this.Inserir_botao.UseVisualStyleBackColor = false;
            this.Inserir_botao.Click += new System.EventHandler(this.Inserir_botao_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.IP_text);
            this.panel2.Controls.Add(this.Descricao_text);
            this.panel2.Controls.Add(this.Nome_text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 312);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "IP";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // IP_text
            // 
            this.IP_text.Location = new System.Drawing.Point(26, 133);
            this.IP_text.Margin = new System.Windows.Forms.Padding(4);
            this.IP_text.Name = "IP_text";
            this.IP_text.Size = new System.Drawing.Size(232, 22);
            this.IP_text.TabIndex = 7;
            // 
            // Descricao_text
            // 
            this.Descricao_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Descricao_text.Location = new System.Drawing.Point(661, 51);
            this.Descricao_text.Margin = new System.Windows.Forms.Padding(4);
            this.Descricao_text.Multiline = true;
            this.Descricao_text.Name = "Descricao_text";
            this.Descricao_text.Size = new System.Drawing.Size(147, 213);
            this.Descricao_text.TabIndex = 6;
            // 
            // Nome_text
            // 
            this.Nome_text.Location = new System.Drawing.Point(26, 51);
            this.Nome_text.Margin = new System.Windows.Forms.Padding(4);
            this.Nome_text.Name = "Nome_text";
            this.Nome_text.Size = new System.Drawing.Size(571, 22);
            this.Nome_text.TabIndex = 5;
            // 
            // Urna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urna";
            this.Text = "Urna";
            this.Load += new System.EventHandler(this.Urna_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP_text;
        private System.Windows.Forms.TextBox Descricao_text;
        private System.Windows.Forms.TextBox Nome_text;
        private System.Windows.Forms.Button voltar_botao;
        private System.Windows.Forms.Button Inserir_botao;
    }
}