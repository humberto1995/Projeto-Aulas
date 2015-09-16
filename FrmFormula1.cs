using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Aulas
{
    public partial class FrmFormula1 : Form
    {
        decimal[] TempoCarro;
        int ContaCarro;
        public FrmFormula1()
        {
            InitializeComponent();
        }

        private void FrmFormula1_Load(object sender, EventArgs e)
        {
            TempoCarro = new decimal[10];
            ContaCarro = 0;
            lblQuantidadeArmazenamento.Text = "Quantidade é " +ContaCarro;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal soma = 0;
            decimal melhor = TempoCarro[1];
            for (int t = 1; t <= ContaCarro; t++)
            {
                soma = soma + TempoCarro[t];
                if (melhor > TempoCarro[t])
                {
                    melhor = TempoCarro[t];
                }
            }
            decimal Media;
            Media = soma / ContaCarro;
            txtMediaTempos.Text = Convert.ToString(Media);
            txtMelhorVolta.Text = Convert.ToString(melhor);

        }

        private void btnArmazenar_Click(object sender, EventArgs e)
        {
            ContaCarro++;
            TempoCarro[ContaCarro] = Convert.ToDecimal(txtTempoVoltas.Text);
            lblQuantidadeArmazenamento.Text = "Quantidade é " + ContaCarro;
            txtTempoVoltas.Text = "";
        }
    }
}
