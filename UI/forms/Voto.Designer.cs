namespace PadraoDeProjetoEmCamadas.forms
{
    partial class Voto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.voltar_botao = new System.Windows.Forms.Button();
            this.inserir_botao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idpessoa_text = new System.Windows.Forms.TextBox();
            this.numerovoto_text = new System.Windows.Forms.TextBox();
            this.idurna_text = new System.Windows.Forms.TextBox();
            this.ideleicao_text = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.voltar_botao);
            this.panel1.Controls.Add(this.inserir_botao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 87);
            this.panel1.TabIndex = 0;
            // 
            // voltar_botao
            // 
            this.voltar_botao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voltar_botao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.voltar_botao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltar_botao.ForeColor = System.Drawing.Color.White;
            this.voltar_botao.Location = new System.Drawing.Point(713, 29);
            this.voltar_botao.Margin = new System.Windows.Forms.Padding(4);
            this.voltar_botao.Name = "voltar_botao";
            this.voltar_botao.Size = new System.Drawing.Size(105, 44);
            this.voltar_botao.TabIndex = 7;
            this.voltar_botao.Text = "Cancelar";
            this.voltar_botao.UseVisualStyleBackColor = false;
            this.voltar_botao.Click += new System.EventHandler(this.voltar_botao_Click);
            // 
            // inserir_botao
            // 
            this.inserir_botao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inserir_botao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.inserir_botao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inserir_botao.ForeColor = System.Drawing.Color.White;
            this.inserir_botao.Location = new System.Drawing.Point(13, 29);
            this.inserir_botao.Margin = new System.Windows.Forms.Padding(4);
            this.inserir_botao.Name = "inserir_botao";
            this.inserir_botao.Size = new System.Drawing.Size(105, 44);
            this.inserir_botao.TabIndex = 6;
            this.inserir_botao.Text = "Inserir";
            this.inserir_botao.UseVisualStyleBackColor = false;
            this.inserir_botao.Click += new System.EventHandler(this.inserir_botao_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.idpessoa_text);
            this.panel2.Controls.Add(this.numerovoto_text);
            this.panel2.Controls.Add(this.idurna_text);
            this.panel2.Controls.Add(this.ideleicao_text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 314);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero Voto";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id Pessoa";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id Urna";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id Eleleição";
            // 
            // idpessoa_text
            // 
            this.idpessoa_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idpessoa_text.Location = new System.Drawing.Point(27, 116);
            this.idpessoa_text.Margin = new System.Windows.Forms.Padding(4);
            this.idpessoa_text.Name = "idpessoa_text";
            this.idpessoa_text.Size = new System.Drawing.Size(222, 22);
            this.idpessoa_text.TabIndex = 8;
            // 
            // numerovoto_text
            // 
            this.numerovoto_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numerovoto_text.Location = new System.Drawing.Point(27, 259);
            this.numerovoto_text.Margin = new System.Windows.Forms.Padding(4);
            this.numerovoto_text.Name = "numerovoto_text";
            this.numerovoto_text.Size = new System.Drawing.Size(222, 22);
            this.numerovoto_text.TabIndex = 7;
            // 
            // idurna_text
            // 
            this.idurna_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idurna_text.Location = new System.Drawing.Point(27, 190);
            this.idurna_text.Margin = new System.Windows.Forms.Padding(4);
            this.idurna_text.Name = "idurna_text";
            this.idurna_text.Size = new System.Drawing.Size(222, 22);
            this.idurna_text.TabIndex = 6;
            // 
            // ideleicao_text
            // 
            this.ideleicao_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ideleicao_text.Location = new System.Drawing.Point(27, 46);
            this.ideleicao_text.Margin = new System.Windows.Forms.Padding(4);
            this.ideleicao_text.Name = "ideleicao_text";
            this.ideleicao_text.Size = new System.Drawing.Size(222, 22);
            this.ideleicao_text.TabIndex = 5;
            // 
            // Voto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Voto";
            this.Text = "Voto";
            this.Load += new System.EventHandler(this.Voto_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button voltar_botao;
        private System.Windows.Forms.Button inserir_botao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox idpessoa_text;
        private System.Windows.Forms.TextBox numerovoto_text;
        private System.Windows.Forms.TextBox idurna_text;
        private System.Windows.Forms.TextBox ideleicao_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}