using System;
using System.Windows.Forms;

namespace CalcHec.Forms
{
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
            Desaparece();
        }

        void Desaparece()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            this.Opacity = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;

            if (ativo)
            {
                this.Opacity -= 0.01D;
            }

            if (this.Opacity == 0)
            {
                ativo = false;
                timer1.Enabled = false;
                CalcArea calculo = new CalcArea();
                calculo.Show();
                //meuPlayer.controls.stop();
                this.Hide();
            }

        }
    }
}
