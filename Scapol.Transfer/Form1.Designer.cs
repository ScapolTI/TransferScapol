namespace Scapol.Transfer
{
    partial class fPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpOperacao = new System.Windows.Forms.TabPage();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.tpMaterial = new System.Windows.Forms.TabPage();
            this.tbTransfere = new System.Windows.Forms.TabPage();
            this.btnDistribui = new System.Windows.Forms.Button();
            this.btnGarante = new System.Windows.Forms.Button();
            this.btnCompleta = new System.Windows.Forms.Button();
            this.btnTroca = new System.Windows.Forms.Button();
            this.lblConexao = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbControl.SuspendLayout();
            this.tpOperacao.SuspendLayout();
            this.tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tpOperacao);
            this.tbControl.Controls.Add(this.tpLista);
            this.tbControl.Controls.Add(this.tpMaterial);
            this.tbControl.Controls.Add(this.tbTransfere);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(0, 0);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(456, 331);
            this.tbControl.TabIndex = 0;
            // 
            // tpOperacao
            // 
            this.tpOperacao.Controls.Add(this.lblConexao);
            this.tpOperacao.Controls.Add(this.btnTroca);
            this.tpOperacao.Controls.Add(this.btnCompleta);
            this.tpOperacao.Controls.Add(this.btnGarante);
            this.tpOperacao.Controls.Add(this.btnDistribui);
            this.tpOperacao.Location = new System.Drawing.Point(4, 25);
            this.tpOperacao.Name = "tpOperacao";
            this.tpOperacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpOperacao.Size = new System.Drawing.Size(448, 302);
            this.tpOperacao.TabIndex = 0;
            this.tpOperacao.Text = "Operação";
            this.tpOperacao.UseVisualStyleBackColor = true;
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.panel1);
            this.tpLista.Controls.Add(this.dgvLista);
            this.tpLista.Location = new System.Drawing.Point(4, 25);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(448, 302);
            this.tpLista.TabIndex = 1;
            this.tpLista.Text = "Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // tpMaterial
            // 
            this.tpMaterial.Location = new System.Drawing.Point(4, 25);
            this.tpMaterial.Name = "tpMaterial";
            this.tpMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaterial.Size = new System.Drawing.Size(448, 270);
            this.tpMaterial.TabIndex = 2;
            this.tpMaterial.Text = "Material";
            this.tpMaterial.UseVisualStyleBackColor = true;
            // 
            // tbTransfere
            // 
            this.tbTransfere.Location = new System.Drawing.Point(4, 25);
            this.tbTransfere.Name = "tbTransfere";
            this.tbTransfere.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransfere.Size = new System.Drawing.Size(448, 270);
            this.tbTransfere.TabIndex = 3;
            this.tbTransfere.Text = "Trasfere";
            this.tbTransfere.UseVisualStyleBackColor = true;
            // 
            // btnDistribui
            // 
            this.btnDistribui.Location = new System.Drawing.Point(75, 33);
            this.btnDistribui.Name = "btnDistribui";
            this.btnDistribui.Size = new System.Drawing.Size(112, 89);
            this.btnDistribui.TabIndex = 0;
            this.btnDistribui.Text = "Distribui";
            this.btnDistribui.UseVisualStyleBackColor = true;
            this.btnDistribui.Click += new System.EventHandler(this.btnDistribui_Click);
            // 
            // btnGarante
            // 
            this.btnGarante.Location = new System.Drawing.Point(224, 33);
            this.btnGarante.Name = "btnGarante";
            this.btnGarante.Size = new System.Drawing.Size(112, 89);
            this.btnGarante.TabIndex = 1;
            this.btnGarante.Text = "Garante";
            this.btnGarante.UseVisualStyleBackColor = true;
            this.btnGarante.Click += new System.EventHandler(this.btnGarante_Click);
            // 
            // btnCompleta
            // 
            this.btnCompleta.Location = new System.Drawing.Point(75, 137);
            this.btnCompleta.Name = "btnCompleta";
            this.btnCompleta.Size = new System.Drawing.Size(112, 89);
            this.btnCompleta.TabIndex = 2;
            this.btnCompleta.Text = "Completa";
            this.btnCompleta.UseVisualStyleBackColor = true;
            this.btnCompleta.Click += new System.EventHandler(this.btnCompleta_Click);
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(224, 137);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(112, 89);
            this.btnTroca.TabIndex = 3;
            this.btnTroca.Text = "Troca";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexao.Location = new System.Drawing.Point(6, 3);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(0, 16);
            this.lblConexao.TabIndex = 4;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(3, 3);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(442, 296);
            this.dgvLista.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblCodBarras);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 57);
            this.panel1.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(4, 4);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(0, 16);
            this.lblProduto.TabIndex = 0;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(22, 30);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(75, 16);
            this.lblCodBarras.TabIndex = 1;
            this.lblCodBarras.Text = "Cód.Barras";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 2;
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 331);
            this.Controls.Add(this.tbControl);
            this.Name = "fPrincipal";
            this.Text = "SCAPOL Transfer";
            this.Load += new System.EventHandler(this.fPrincipal_Load);
            this.tbControl.ResumeLayout(false);
            this.tpOperacao.ResumeLayout(false);
            this.tpOperacao.PerformLayout();
            this.tpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tpOperacao;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.TabPage tpMaterial;
        private System.Windows.Forms.TabPage tbTransfere;
        private System.Windows.Forms.Button btnTroca;
        private System.Windows.Forms.Button btnCompleta;
        private System.Windows.Forms.Button btnGarante;
        private System.Windows.Forms.Button btnDistribui;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}

