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
    public partial class FrmCaixaLoja : Form
    {
        string[] CodigoProduto = new string[6];
        string[] NomeProduto = new string [6];
        decimal[] Preco = new decimal[6];
        decimal SomaTotal;
        public FrmCaixaLoja()
        {
            InitializeComponent();
        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text.Length == 5)
            {
                int ind = 0;
                for (int cp = 1; cp < CodigoProduto.Length; cp++)
                {
                    if (txtCodigoProduto.Text == CodigoProduto[cp])
                    {
                        ind = cp;
                    }
                }
                if (ind == 0)
                {
                    MessageBox.Show("Produto não Encontrado");
                }
                else
                {
                    listBox1.Items.Add(string.Format("#{0} - {1} - {2:c}",CodigoProduto[ind] , NomeProduto[ind] , Preco[ind]));
                    SomaTotal = SomaTotal + Preco[ind];
                    lblValor.Text = string.Format("VALOR TOTAL:{0:c}" , SomaTotal);
                    pictureBox1.ImageLocation = @"c:\imagens\" + CodigoProduto[ind] + ".jpg";

                    txtCodigoProduto.Text = "";
                    txtCodigoProduto.Focus();
                }
            }
        }

        private void FrmCaixaLoja_Load(object sender, EventArgs e)
        {
            CarregaArray();
            SomaTotal = 0;
        }

        private void CarregaArray()
        {
            CodigoProduto[1] = "12345";
            CodigoProduto[2] = "23456";
            CodigoProduto[3] = "34567";
            CodigoProduto[4] = "45678";
            CodigoProduto[5] = "56789";

            NomeProduto[1] = "SHAMPOO FRUCTIS";
            NomeProduto[2] = "SABONETE DOVE";
            NomeProduto[3] = "GEL BOZZANO";
            NomeProduto[4] = "DESCOLORANTE MARCIA";
            NomeProduto[5] = "TALCO POLVILHO";

            Preco[1] = 8.99M;
            Preco[2] = 1.99M;
            Preco[3] = 9.99M;
            Preco[4] = 3.99M;
            Preco[5] = 12.99M;
        }
    }
}
