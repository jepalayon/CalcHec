using System;
using System.Windows.Forms;

namespace CalcHec
{
    public partial class CalcArea : Form
    {
        public CalcArea()
        {
            InitializeComponent();
           // Application.Run(new frmAbertura());


        }

        double somaresultado, medida01, medida02, medida03, resultado;
       

        private void button1_Click(object sender, EventArgs e)
        {
            medida01 = 0;
            medida02 = 0;
            medida03 = 0;
            resultado = 0;
            
            //validação de entrada somente de números
            if (txtMedida01.Visible == true)
            {

            try
            {
                medida01 = Convert.ToDouble(txtMedida01.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO! Medida 1 só aceita numeros");
                txtMedida01.SelectAll();
                txtMedida01.Focus();
                return;
            }
            }

            try
            {
                medida02 = Convert.ToDouble(txtMedida02.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO! Medida 2 só aceita numeros");
                txtMedida02.SelectAll();
                txtMedida02.Focus();
                return;
            }

            if (txtMedida03.Visible == Enabled)
            {
                try
                {
                    medida03 = Convert.ToDouble(txtMedida03.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERRO! Medida 3 só aceita numeros");
                    txtMedida03.SelectAll();
                    txtMedida03.Focus();
                    return;
                }
            }
            

            if (rdbTriângulo.Checked == false && rdbRetangulo.Checked == false && rdbCirculo.Checked == false)
            {
                MessageBox.Show("Você precisa escolher um dos Tipos de Figura");
                return;
            }


            //calculo conforme a dimensão escolhida e o tipo de figura geométrica
            if (rdbRetangulo.Checked == true)
            {
                resultado = (medida01 * medida02);
            }

            else
            {
                if (rdbTriângulo.Checked == true)
                {
                    resultado = (medida01 * medida02) / 2;
                }
                else
                {
                    if (rdbCirculo.Checked == true)
                    {
                        double pi = 3.1416;
                        resultado = pi * (medida02 * medida02);
                    }
                }
            }

            if (rdbHectares.Checked == true)
            {
                
                 resultado = resultado/ 10000;
                //string.Format("{0:N}", resultado);
                //lblResultado.Text = Convert.ToString(resultado);
                lblResultado.Text = resultado.ToString("N2");
                lblArea.Text = ("hectares");
            }

            else
            {
                if (rdbAlqueire.Checked == true)
                {
                    resultado = resultado / 24000;
                    lblResultado.Text = resultado.ToString("N2");
                    lblArea.Text = ("alqueires");
                }
                else
                {
                    if (rdbAlqueirao.Checked == true)
                    {
                        resultado = resultado / 48000;
                        lblResultado.Text = resultado.ToString("N2");
                        lblArea.Text = ("alqueirões");
                    }
                    
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado"; lblArea.Text = "Área";
            lblSomaResultados.Text = "Total"; lblAreaTot.Text = "Área";
            lblMedida1.Text = "Medida 1"; lblMedida2.Text = "Medida 2"; lblMedida3.Text = "Medida 3";
            txtMedida01.Text = ""; txtMedida02.Text = ""; txtMedida03.Text = "";
            rdbRetangulo.Checked = false; rdbTriângulo.Checked = false; rdbCirculo.Checked = false;
            lblMedida1.Visible = true; txtMedida01.Visible = true; lblMetro1.Visible = true;
            lblMedida2.Visible = true; txtMedida02.Visible = true; lblMetro2.Visible = true;
            lblMedida3.Visible = false; txtMedida03.Visible = false; lblMetro3.Visible = false;
            rdbHectares.Checked = true; rdbAlqueirao.Checked = false; rdbAlqueire.Checked = false;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtMedida01.Text = "";
            txtMedida02.Text = "";
            txtMedida03.Text = "";
        }

        private void CalcArea_Load(object sender, EventArgs e)
        {

        }

        private void rdbTriângulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTriângulo.Checked == true)
            {
                lblMedida1.Text = "Altura";
                lblMedida2.Text = "Base";
            }
        }

        private void rdbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCirculo.Checked == true)
            {
                lblMedida1.Visible = false;
                txtMedida01.Visible = false;
                lblMetro1.Visible = false;
                lblMedida2.Text = "Raio";
            }
        }

        private void rdbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRetangulo.Checked == true)
            {
                lblMedida1.Text = "Lado 1";
                lblMedida2.Text = "Lado 2";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double resultadoSoma;
            //somaresultado = 0;
            resultadoSoma = Convert.ToDouble(lblResultado.Text);
            somaresultado = somaresultado + resultadoSoma;


            if (rdbHectares.Checked == true)
            {
                //somaresultado = somaresultado / 10000;
                //string.Format("{0:N}", resultado);
                //lblResultado.Text = Convert.ToString(resultado);
                lblSomaResultados.Text = somaresultado.ToString("N2");
                lblAreaTot.Text = ("hectares");
            }

            else
            {
                if (rdbAlqueire.Checked == true)
                {
                    //somaresultado = somaresultado / 24000;
                    lblSomaResultados.Text = somaresultado.ToString("N2");
                    lblAreaTot.Text = ("alqueires");
                }
                else
                {
                    if (rdbAlqueirao.Checked == true)
                    {
                        //somaresultado = somaresultado / 48000;
                        lblSomaResultados.Text = somaresultado.ToString("N2");
                        lblAreaTot.Text = ("alqueirão");
                    }

                }
            }
        }
    }
}
