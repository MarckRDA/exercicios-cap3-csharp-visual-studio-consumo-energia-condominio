namespace ConsumoEnergiaCondomínio
{
    partial class ConsumoEnergia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNCasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dvgResumo = new System.Windows.Forms.DataGridView();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResumo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº casa : ";
            // 
            // txtNCasa
            // 
            this.txtNCasa.Location = new System.Drawing.Point(65, 29);
            this.txtNCasa.Name = "txtNCasa";
            this.txtNCasa.Size = new System.Drawing.Size(81, 20);
            this.txtNCasa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consumo :";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(229, 28);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(88, 20);
            this.txtConsumo.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(330, 25);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dvgResumo
            // 
            this.dvgResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgResumo.Location = new System.Drawing.Point(15, 78);
            this.dvgResumo.Name = "dvgResumo";
            this.dvgResumo.Size = new System.Drawing.Size(390, 176);
            this.dvgResumo.TabIndex = 5;
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Location = new System.Drawing.Point(15, 272);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(111, 23);
            this.btnProcessarDados.TabIndex = 6;
            this.btnProcessarDados.Text = "Processar dados";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(166, 277);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "label3";
            // 
            // ConsumoEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 309);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.dvgResumo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNCasa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsumoEnergia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo de energia de um condomínio";
            ((System.ComponentModel.ISupportInitialize)(this.dvgResumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNCasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dvgResumo;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.Label lblResultado;
    }
}

