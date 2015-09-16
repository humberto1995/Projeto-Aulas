using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Aulas
{
    public partial class FrmEditorTexto : Form
    {
        public FrmEditorTexto()
        {
            InitializeComponent();
        }

        private void FrmEditorTexto_Load(object sender, EventArgs e)
        {
            btnBrowser.Select();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //============== Altera a com do "richtextbox"
            colorDialog.ShowDialog();
            rtbEditor.SelectionColor = colorDialog.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //=============== Altera a fonte do "richtextbox"
            fontDialog.ShowDialog();
            rtbEditor.SelectionFont = fontDialog.Font;
        }

        private void Gravacao()
        {
            StreamWriter gravador = new StreamWriter(txtBrowser.Text);
            gravador.WriteLine("Editor de texto Criado por Humberto c. Krzywy - GuitHub = Humberto1995");
            gravador.WriteLine(string.Format("Texto criado por '{0}'",(txtNomeAutor.Text)));
            gravador.WriteLine(string.Format("Horário Criado / Editado '{0}'",(DateTime.Now)));

            gravador.Write(rtbEditor.Text);
            gravador.Close();
            MessageBox.Show("Arquivo gravado com Sucesso!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = txtBrowser.Text;

            if (txtBrowser.Text != "")
            {
                Gravacao();
            }
            else
            {
                saveFileDialog.ShowDialog();
                txtBrowser.Text = saveFileDialog.FileName;
                if (txtBrowser.Text != "")
                {
                    Gravacao();
                }
                else
                {
                    MessageBox.Show("Impossivel de ser gravado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ////================== Mostrar o caminho da pasta selecionada
            //openFileDialog.ShowDialog();
            //txtBrowser.Text = openFileDialog.FileName;

            if (txtBrowser.Text == "")
            {
                MessageBox.Show("Nenhum arquivo selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StreamReader leitor = new StreamReader(txtBrowser.Text);
            rtbEditor.Clear();

            ////================== Lendo todo Arquivo, até o fim
            //txtNomeAutor.Text = leitor.ReadLine();
            rtbEditor.Text = leitor.ReadToEnd();

            ////================== Lendo linha a linha
            //string linha = "";
            //int c = 0;
            //while (!(leitor.EndOfStream))
            //{
            //    c++;  //c = c + 1;
            //    linha = leitor.ReadLine();
            //    if (!(linha.Contains("@")))
            //    {
            //        rtbEditor.Text = rtbEditor.Text + linha + "\r\n";
            //    }
            //}

            leitor.Close();

            //---------------------------------------------------------------------------------------------------------------------------------

            //////================ Abrir Documentos com "Word ou Pdf"
            //String StrCaminho;
            //StrCaminho = txtBrowser.Text;
            //if (txtBrowser.Text == "")
            //{
            //    MessageBox.Show("Selecione o arquivo utilizando o Browser", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    System.Diagnostics.Process.Start(@StrCaminho);
            //}
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            //================ Chama o caminho da pasta para o "textbox"
            openFileDialog.ShowDialog();
            txtBrowser.Text = "";
            txtBrowser.Text = openFileDialog.FileName;
        }
    }
}
