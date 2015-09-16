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
    public partial class FrmFileSystem : Form
    {
        public FrmFileSystem()
        {
            InitializeComponent();
        }

        private void FrmFileSystem_Load(object sender, EventArgs e)
        {
            string[] ld = Directory.GetLogicalDrives();

            foreach (string lista in ld)
            {
                cbbEscolhaDriver.Items.Add(lista);
            }
            cbbEscolhaDriver.Focus();
            cbbEscolhaDriver.Select();
        }

        private void cbbEscolhaDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo di = new DriveInfo(cbbEscolhaDriver.Text);

            if (di.IsReady == true)
            {

                txtCapacidadeDriver.Text = Convert.ToString(di.TotalSize);

                txtEspacoLivreDriver.Text = Convert.ToString(di.AvailableFreeSpace);

                txtCaminhoDriver.Text = Convert.ToString(di.RootDirectory);

                txtTipoDriver.Text = Convert.ToString(di.DriveType);

                txtNomeDriver.Text = Convert.ToString(di.VolumeLabel);

                txtFormatoDriver.Text = Convert.ToString(di.DriveFormat);

                DirectoryInfo diri = new DirectoryInfo(cbbEscolhaDriver.Text);
                FileInfo[] listaFiles = diri.GetFiles();

                listBox1.Items.Clear();
                foreach (FileInfo o in listaFiles)
                {
                    listBox1.Items.Add(string.Format("{0} / {1:n0}",o.Name,o.Length));       
                }
            }
            else
            {
                MessageBox.Show("Impossivel de Ler o Disco.","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCapacidadeDriver.Text = "";
                txtEspacoLivreDriver.Text = "";
                txtCaminhoDriver.Text = "";
                txtTipoDriver.Text = "";
                txtNomeDriver.Text = "";
                txtFormatoDriver.Text = "";
                listBox1.Items.Clear();
            }
            
        }
    }
}
