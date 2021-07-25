namespace CalcHec
{
    partial class CalcArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcArea));
            this.lblMedida1 = new System.Windows.Forms.Label();
            this.txtMedida01 = new System.Windows.Forms.TextBox();
            this.txtMedida02 = new System.Windows.Forms.TextBox();
            this.lblMedida2 = new System.Windows.Forms.Label();
            this.lblMetro1 = new System.Windows.Forms.Label();
            this.lblMetro2 = new System.Windows.Forms.Label();
            this.grbMedidas = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMetro3 = new System.Windows.Forms.Label();
            this.txtMedida03 = new System.Windows.Forms.TextBox();
            this.lblMedida3 = new System.Windows.Forms.Label();
            this.grbResultadoEm = new System.Windows.Forms.GroupBox();
            this.rdbAlqueirao = new System.Windows.Forms.RadioButton();
            this.rdbAlqueire = new System.Windows.Forms.RadioButton();
            this.rdbHectares = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grbFiguraArea = new System.Windows.Forms.GroupBox();
            this.rdbCirculo = new System.Windows.Forms.RadioButton();
            this.rdbTriângulo = new System.Windows.Forms.RadioButton();
            this.rdbRetangulo = new System.Windows.Forms.RadioButton();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.grbSomaResultados = new System.Windows.Forms.GroupBox();
            this.lblSomaResultados = new System.Windows.Forms.Label();
            this.lblAreaTot = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.grbMedidas.SuspendLayout();
            this.grbResultadoEm.SuspendLayout();
            this.grbFiguraArea.SuspendLayout();
            this.grbResultado.SuspendLayout();
            this.grbSomaResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMedida1
            // 
            this.lblMedida1.AutoSize = true;
            this.lblMedida1.Location = new System.Drawing.Point(8, 22);
            this.lblMedida1.Name = "lblMedida1";
            this.lblMedida1.Size = new System.Drawing.Size(51, 13);
            this.lblMedida1.TabIndex = 0;
            this.lblMedida1.Text = "Medida 1";
            // 
            // txtMedida01
            // 
            this.txtMedida01.Location = new System.Drawing.Point(92, 19);
            this.txtMedida01.Name = "txtMedida01";
            this.txtMedida01.Size = new System.Drawing.Size(100, 20);
            this.txtMedida01.TabIndex = 1;
            // 
            // txtMedida02
            // 
            this.txtMedida02.Location = new System.Drawing.Point(92, 75);
            this.txtMedida02.Name = "txtMedida02";
            this.txtMedida02.Size = new System.Drawing.Size(100, 20);
            this.txtMedida02.TabIndex = 3;
            // 
            // lblMedida2
            // 
            this.lblMedida2.AutoSize = true;
            this.lblMedida2.Location = new System.Drawing.Point(8, 80);
            this.lblMedida2.Name = "lblMedida2";
            this.lblMedida2.Size = new System.Drawing.Size(51, 13);
            this.lblMedida2.TabIndex = 2;
            this.lblMedida2.Text = "Medida 2";
            // 
            // lblMetro1
            // 
            this.lblMetro1.AutoSize = true;
            this.lblMetro1.Location = new System.Drawing.Point(207, 22);
            this.lblMetro1.Name = "lblMetro1";
            this.lblMetro1.Size = new System.Drawing.Size(38, 13);
            this.lblMetro1.TabIndex = 4;
            this.lblMetro1.Text = "metros";
            // 
            // lblMetro2
            // 
            this.lblMetro2.AutoSize = true;
            this.lblMetro2.Location = new System.Drawing.Point(207, 78);
            this.lblMetro2.Name = "lblMetro2";
            this.lblMetro2.Size = new System.Drawing.Size(38, 13);
            this.lblMetro2.TabIndex = 5;
            this.lblMetro2.Text = "metros";
            // 
            // grbMedidas
            // 
            this.grbMedidas.Controls.Add(this.button2);
            this.grbMedidas.Controls.Add(this.lblMetro3);
            this.grbMedidas.Controls.Add(this.txtMedida03);
            this.grbMedidas.Controls.Add(this.lblMedida3);
            this.grbMedidas.Controls.Add(this.txtMedida01);
            this.grbMedidas.Controls.Add(this.lblMetro2);
            this.grbMedidas.Controls.Add(this.lblMedida1);
            this.grbMedidas.Controls.Add(this.lblMetro1);
            this.grbMedidas.Controls.Add(this.lblMedida2);
            this.grbMedidas.Controls.Add(this.txtMedida02);
            this.grbMedidas.Location = new System.Drawing.Point(23, 12);
            this.grbMedidas.Name = "grbMedidas";
            this.grbMedidas.Size = new System.Drawing.Size(256, 215);
            this.grbMedidas.TabIndex = 6;
            this.grbMedidas.TabStop = false;
            this.grbMedidas.Text = "Medidas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar Números";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblMetro3
            // 
            this.lblMetro3.AutoSize = true;
            this.lblMetro3.Location = new System.Drawing.Point(210, 133);
            this.lblMetro3.Name = "lblMetro3";
            this.lblMetro3.Size = new System.Drawing.Size(38, 13);
            this.lblMetro3.TabIndex = 8;
            this.lblMetro3.Text = "metros";
            this.lblMetro3.Visible = false;
            // 
            // txtMedida03
            // 
            this.txtMedida03.Location = new System.Drawing.Point(92, 130);
            this.txtMedida03.Name = "txtMedida03";
            this.txtMedida03.Size = new System.Drawing.Size(100, 20);
            this.txtMedida03.TabIndex = 7;
            this.txtMedida03.Visible = false;
            // 
            // lblMedida3
            // 
            this.lblMedida3.AutoSize = true;
            this.lblMedida3.Location = new System.Drawing.Point(8, 133);
            this.lblMedida3.Name = "lblMedida3";
            this.lblMedida3.Size = new System.Drawing.Size(51, 13);
            this.lblMedida3.TabIndex = 6;
            this.lblMedida3.Text = "Medida 3";
            this.lblMedida3.Visible = false;
            // 
            // grbResultadoEm
            // 
            this.grbResultadoEm.Controls.Add(this.rdbAlqueirao);
            this.grbResultadoEm.Controls.Add(this.rdbAlqueire);
            this.grbResultadoEm.Controls.Add(this.rdbHectares);
            this.grbResultadoEm.Location = new System.Drawing.Point(308, 12);
            this.grbResultadoEm.Name = "grbResultadoEm";
            this.grbResultadoEm.Size = new System.Drawing.Size(169, 163);
            this.grbResultadoEm.TabIndex = 7;
            this.grbResultadoEm.TabStop = false;
            this.grbResultadoEm.Text = "Resultado em";
            // 
            // rdbAlqueirao
            // 
            this.rdbAlqueirao.AutoSize = true;
            this.rdbAlqueirao.Location = new System.Drawing.Point(32, 107);
            this.rdbAlqueirao.Name = "rdbAlqueirao";
            this.rdbAlqueirao.Size = new System.Drawing.Size(69, 17);
            this.rdbAlqueirao.TabIndex = 2;
            this.rdbAlqueirao.Text = "Alqueirão";
            this.rdbAlqueirao.UseVisualStyleBackColor = true;
            // 
            // rdbAlqueire
            // 
            this.rdbAlqueire.AutoSize = true;
            this.rdbAlqueire.Location = new System.Drawing.Point(32, 69);
            this.rdbAlqueire.Name = "rdbAlqueire";
            this.rdbAlqueire.Size = new System.Drawing.Size(63, 17);
            this.rdbAlqueire.TabIndex = 1;
            this.rdbAlqueire.Text = "Alqueire";
            this.rdbAlqueire.UseVisualStyleBackColor = true;
            // 
            // rdbHectares
            // 
            this.rdbHectares.AutoSize = true;
            this.rdbHectares.Checked = true;
            this.rdbHectares.Location = new System.Drawing.Point(32, 35);
            this.rdbHectares.Name = "rdbHectares";
            this.rdbHectares.Size = new System.Drawing.Size(68, 17);
            this.rdbHectares.TabIndex = 0;
            this.rdbHectares.TabStop = true;
            this.rdbHectares.Text = "Hectares";
            this.rdbHectares.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(23, 426);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 32);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(7, 37);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(103, 24);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(146, 37);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(54, 24);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Área";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(368, 425);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 32);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar Tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.Location = new System.Drawing.Point(564, 425);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 32);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // grbFiguraArea
            // 
            this.grbFiguraArea.Controls.Add(this.rdbCirculo);
            this.grbFiguraArea.Controls.Add(this.rdbTriângulo);
            this.grbFiguraArea.Controls.Add(this.rdbRetangulo);
            this.grbFiguraArea.Location = new System.Drawing.Point(494, 12);
            this.grbFiguraArea.Name = "grbFiguraArea";
            this.grbFiguraArea.Size = new System.Drawing.Size(170, 163);
            this.grbFiguraArea.TabIndex = 13;
            this.grbFiguraArea.TabStop = false;
            this.grbFiguraArea.Text = "Tipo de Figura";
            // 
            // rdbCirculo
            // 
            this.rdbCirculo.AutoSize = true;
            this.rdbCirculo.Location = new System.Drawing.Point(7, 107);
            this.rdbCirculo.Name = "rdbCirculo";
            this.rdbCirculo.Size = new System.Drawing.Size(59, 17);
            this.rdbCirculo.TabIndex = 2;
            this.rdbCirculo.Text = "Círculo";
            this.rdbCirculo.UseVisualStyleBackColor = true;
            this.rdbCirculo.CheckedChanged += new System.EventHandler(this.rdbCirculo_CheckedChanged);
            // 
            // rdbTriângulo
            // 
            this.rdbTriângulo.AutoSize = true;
            this.rdbTriângulo.Location = new System.Drawing.Point(7, 69);
            this.rdbTriângulo.Name = "rdbTriângulo";
            this.rdbTriângulo.Size = new System.Drawing.Size(69, 17);
            this.rdbTriângulo.TabIndex = 1;
            this.rdbTriângulo.Text = "Triângulo";
            this.rdbTriângulo.UseVisualStyleBackColor = true;
            this.rdbTriângulo.CheckedChanged += new System.EventHandler(this.rdbTriângulo_CheckedChanged);
            // 
            // rdbRetangulo
            // 
            this.rdbRetangulo.AutoSize = true;
            this.rdbRetangulo.Location = new System.Drawing.Point(7, 35);
            this.rdbRetangulo.Name = "rdbRetangulo";
            this.rdbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rdbRetangulo.TabIndex = 0;
            this.rdbRetangulo.Text = "Retângulo";
            this.rdbRetangulo.UseVisualStyleBackColor = true;
            this.rdbRetangulo.CheckedChanged += new System.EventHandler(this.rdbRetangulo_CheckedChanged);
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.lblResultado);
            this.grbResultado.Controls.Add(this.lblArea);
            this.grbResultado.Location = new System.Drawing.Point(23, 233);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(256, 102);
            this.grbResultado.TabIndex = 14;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Área Calculada";
            // 
            // grbSomaResultados
            // 
            this.grbSomaResultados.Controls.Add(this.lblSomaResultados);
            this.grbSomaResultados.Controls.Add(this.lblAreaTot);
            this.grbSomaResultados.Location = new System.Drawing.Point(357, 233);
            this.grbSomaResultados.Name = "grbSomaResultados";
            this.grbSomaResultados.Size = new System.Drawing.Size(256, 102);
            this.grbSomaResultados.TabIndex = 15;
            this.grbSomaResultados.TabStop = false;
            this.grbSomaResultados.Text = "Soma das Áreas";
            // 
            // lblSomaResultados
            // 
            this.lblSomaResultados.AutoSize = true;
            this.lblSomaResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaResultados.Location = new System.Drawing.Point(7, 37);
            this.lblSomaResultados.Name = "lblSomaResultados";
            this.lblSomaResultados.Size = new System.Drawing.Size(56, 24);
            this.lblSomaResultados.TabIndex = 9;
            this.lblSomaResultados.Text = "Total";
            this.lblSomaResultados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAreaTot
            // 
            this.lblAreaTot.AutoSize = true;
            this.lblAreaTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaTot.Location = new System.Drawing.Point(133, 37);
            this.lblAreaTot.Name = "lblAreaTot";
            this.lblAreaTot.Size = new System.Drawing.Size(54, 24);
            this.lblAreaTot.TabIndex = 10;
            this.lblAreaTot.Text = "Área";
            this.lblAreaTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSomar.Location = new System.Drawing.Point(195, 424);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(100, 32);
            this.btnSomar.TabIndex = 16;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.button2_Click);
            // 
            // CalcArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 488);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.grbSomaResultados);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.grbFiguraArea);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbResultadoEm);
            this.Controls.Add(this.grbMedidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Área";
            this.Load += new System.EventHandler(this.CalcArea_Load);
            this.grbMedidas.ResumeLayout(false);
            this.grbMedidas.PerformLayout();
            this.grbResultadoEm.ResumeLayout(false);
            this.grbResultadoEm.PerformLayout();
            this.grbFiguraArea.ResumeLayout(false);
            this.grbFiguraArea.PerformLayout();
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            this.grbSomaResultados.ResumeLayout(false);
            this.grbSomaResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMedida1;
        private System.Windows.Forms.TextBox txtMedida01;
        private System.Windows.Forms.TextBox txtMedida02;
        private System.Windows.Forms.Label lblMedida2;
        private System.Windows.Forms.Label lblMetro1;
        private System.Windows.Forms.Label lblMetro2;
        private System.Windows.Forms.GroupBox grbMedidas;
        private System.Windows.Forms.GroupBox grbResultadoEm;
        private System.Windows.Forms.RadioButton rdbAlqueirao;
        private System.Windows.Forms.RadioButton rdbAlqueire;
        private System.Windows.Forms.RadioButton rdbHectares;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblMedida3;
        private System.Windows.Forms.Label lblMetro3;
        private System.Windows.Forms.TextBox txtMedida03;
        private System.Windows.Forms.GroupBox grbFiguraArea;
        private System.Windows.Forms.RadioButton rdbRetangulo;
        private System.Windows.Forms.RadioButton rdbTriângulo;
        private System.Windows.Forms.RadioButton rdbCirculo;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.GroupBox grbSomaResultados;
        private System.Windows.Forms.Label lblSomaResultados;
        private System.Windows.Forms.Label lblAreaTot;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button button2;
    }
}

