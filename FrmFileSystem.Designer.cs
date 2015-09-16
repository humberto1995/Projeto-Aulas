namespace Projeto_Aulas
{
    partial class FrmFileSystem
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
            this.txtEspacoLivreDriver = new System.Windows.Forms.TextBox();
            this.txtTipoDriver = new System.Windows.Forms.TextBox();
            this.lblEspacoLivreDriver = new System.Windows.Forms.Label();
            this.lblTipoDriver = new System.Windows.Forms.Label();
            this.lblEscolhaDriver = new System.Windows.Forms.Label();
            this.cbbEscolhaDriver = new System.Windows.Forms.ComboBox();
            this.txtNomeDriver = new System.Windows.Forms.TextBox();
            this.txtCapacidadeDriver = new System.Windows.Forms.TextBox();
            this.txtFormatoDriver = new System.Windows.Forms.TextBox();
            this.lblNomeDriver = new System.Windows.Forms.Label();
            this.lblCapacidadeTotalDriver = new System.Windows.Forms.Label();
            this.lblFormatoDriver = new System.Windows.Forms.Label();
            this.txtCaminhoDriver = new System.Windows.Forms.TextBox();
            this.lblCaminhoDriver = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblListaAqruivos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEspacoLivreDriver
            // 
            this.txtEspacoLivreDriver.Location = new System.Drawing.Point(141, 112);
            this.txtEspacoLivreDriver.Name = "txtEspacoLivreDriver";
            this.txtEspacoLivreDriver.ReadOnly = true;
            this.txtEspacoLivreDriver.Size = new System.Drawing.Size(238, 20);
            this.txtEspacoLivreDriver.TabIndex = 1;
            // 
            // txtTipoDriver
            // 
            this.txtTipoDriver.Location = new System.Drawing.Point(115, 162);
            this.txtTipoDriver.Name = "txtTipoDriver";
            this.txtTipoDriver.ReadOnly = true;
            this.txtTipoDriver.Size = new System.Drawing.Size(264, 20);
            this.txtTipoDriver.TabIndex = 2;
            // 
            // lblEspacoLivreDriver
            // 
            this.lblEspacoLivreDriver.AutoSize = true;
            this.lblEspacoLivreDriver.Location = new System.Drawing.Point(35, 115);
            this.lblEspacoLivreDriver.Name = "lblEspacoLivreDriver";
            this.lblEspacoLivreDriver.Size = new System.Drawing.Size(100, 13);
            this.lblEspacoLivreDriver.TabIndex = 3;
            this.lblEspacoLivreDriver.Text = "Espaço Livre Driver";
            // 
            // lblTipoDriver
            // 
            this.lblTipoDriver.AutoSize = true;
            this.lblTipoDriver.Location = new System.Drawing.Point(35, 165);
            this.lblTipoDriver.Name = "lblTipoDriver";
            this.lblTipoDriver.Size = new System.Drawing.Size(74, 13);
            this.lblTipoDriver.TabIndex = 4;
            this.lblTipoDriver.Text = "Tipo de Driver";
            // 
            // lblEscolhaDriver
            // 
            this.lblEscolhaDriver.AutoSize = true;
            this.lblEscolhaDriver.Location = new System.Drawing.Point(26, 28);
            this.lblEscolhaDriver.Name = "lblEscolhaDriver";
            this.lblEscolhaDriver.Size = new System.Drawing.Size(90, 13);
            this.lblEscolhaDriver.TabIndex = 5;
            this.lblEscolhaDriver.Text = "Escolha os Driver";
            // 
            // cbbEscolhaDriver
            // 
            this.cbbEscolhaDriver.FormattingEnabled = true;
            this.cbbEscolhaDriver.Location = new System.Drawing.Point(127, 25);
            this.cbbEscolhaDriver.Name = "cbbEscolhaDriver";
            this.cbbEscolhaDriver.Size = new System.Drawing.Size(252, 21);
            this.cbbEscolhaDriver.TabIndex = 6;
            this.cbbEscolhaDriver.SelectedIndexChanged += new System.EventHandler(this.cbbEscolhaDriver_SelectedIndexChanged);
            // 
            // txtNomeDriver
            // 
            this.txtNomeDriver.Location = new System.Drawing.Point(122, 188);
            this.txtNomeDriver.Name = "txtNomeDriver";
            this.txtNomeDriver.ReadOnly = true;
            this.txtNomeDriver.Size = new System.Drawing.Size(257, 20);
            this.txtNomeDriver.TabIndex = 7;
            // 
            // txtCapacidadeDriver
            // 
            this.txtCapacidadeDriver.Location = new System.Drawing.Point(178, 85);
            this.txtCapacidadeDriver.Name = "txtCapacidadeDriver";
            this.txtCapacidadeDriver.ReadOnly = true;
            this.txtCapacidadeDriver.Size = new System.Drawing.Size(201, 20);
            this.txtCapacidadeDriver.TabIndex = 8;
            // 
            // txtFormatoDriver
            // 
            this.txtFormatoDriver.Location = new System.Drawing.Point(132, 214);
            this.txtFormatoDriver.Name = "txtFormatoDriver";
            this.txtFormatoDriver.ReadOnly = true;
            this.txtFormatoDriver.Size = new System.Drawing.Size(247, 20);
            this.txtFormatoDriver.TabIndex = 9;
            // 
            // lblNomeDriver
            // 
            this.lblNomeDriver.AutoSize = true;
            this.lblNomeDriver.Location = new System.Drawing.Point(35, 191);
            this.lblNomeDriver.Name = "lblNomeDriver";
            this.lblNomeDriver.Size = new System.Drawing.Size(81, 13);
            this.lblNomeDriver.TabIndex = 10;
            this.lblNomeDriver.Text = "Nome do Driver";
            // 
            // lblCapacidadeTotalDriver
            // 
            this.lblCapacidadeTotalDriver.AutoSize = true;
            this.lblCapacidadeTotalDriver.Location = new System.Drawing.Point(35, 88);
            this.lblCapacidadeTotalDriver.Name = "lblCapacidadeTotalDriver";
            this.lblCapacidadeTotalDriver.Size = new System.Drawing.Size(137, 13);
            this.lblCapacidadeTotalDriver.TabIndex = 11;
            this.lblCapacidadeTotalDriver.Text = "Capacidade Total do Driver";
            // 
            // lblFormatoDriver
            // 
            this.lblFormatoDriver.AutoSize = true;
            this.lblFormatoDriver.Location = new System.Drawing.Point(35, 217);
            this.lblFormatoDriver.Name = "lblFormatoDriver";
            this.lblFormatoDriver.Size = new System.Drawing.Size(91, 13);
            this.lblFormatoDriver.TabIndex = 12;
            this.lblFormatoDriver.Text = "Formato do Driver";
            // 
            // txtCaminhoDriver
            // 
            this.txtCaminhoDriver.Location = new System.Drawing.Point(120, 138);
            this.txtCaminhoDriver.Name = "txtCaminhoDriver";
            this.txtCaminhoDriver.ReadOnly = true;
            this.txtCaminhoDriver.Size = new System.Drawing.Size(259, 20);
            this.txtCaminhoDriver.TabIndex = 13;
            // 
            // lblCaminhoDriver
            // 
            this.lblCaminhoDriver.AutoSize = true;
            this.lblCaminhoDriver.Location = new System.Drawing.Point(35, 141);
            this.lblCaminhoDriver.Name = "lblCaminhoDriver";
            this.lblCaminhoDriver.Size = new System.Drawing.Size(79, 13);
            this.lblCaminhoDriver.TabIndex = 14;
            this.lblCaminhoDriver.Text = "Caminho Driver";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(404, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 199);
            this.listBox1.TabIndex = 15;
            // 
            // lblListaAqruivos
            // 
            this.lblListaAqruivos.AutoSize = true;
            this.lblListaAqruivos.Location = new System.Drawing.Point(484, 25);
            this.lblListaAqruivos.Name = "lblListaAqruivos";
            this.lblListaAqruivos.Size = new System.Drawing.Size(88, 13);
            this.lblListaAqruivos.TabIndex = 16;
            this.lblListaAqruivos.Text = "Lista de Arquivos";
            // 
            // FrmFileSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 278);
            this.Controls.Add(this.lblListaAqruivos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblCaminhoDriver);
            this.Controls.Add(this.txtCaminhoDriver);
            this.Controls.Add(this.lblFormatoDriver);
            this.Controls.Add(this.lblCapacidadeTotalDriver);
            this.Controls.Add(this.lblNomeDriver);
            this.Controls.Add(this.txtFormatoDriver);
            this.Controls.Add(this.txtCapacidadeDriver);
            this.Controls.Add(this.txtNomeDriver);
            this.Controls.Add(this.cbbEscolhaDriver);
            this.Controls.Add(this.lblEscolhaDriver);
            this.Controls.Add(this.lblTipoDriver);
            this.Controls.Add(this.lblEspacoLivreDriver);
            this.Controls.Add(this.txtTipoDriver);
            this.Controls.Add(this.txtEspacoLivreDriver);
            this.Name = "FrmFileSystem";
            this.Text = "File System / Sistema de Arquivos";
            this.Load += new System.EventHandler(this.FrmFileSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEspacoLivreDriver;
        private System.Windows.Forms.TextBox txtTipoDriver;
        private System.Windows.Forms.Label lblEspacoLivreDriver;
        private System.Windows.Forms.Label lblTipoDriver;
        private System.Windows.Forms.Label lblEscolhaDriver;
        private System.Windows.Forms.ComboBox cbbEscolhaDriver;
        private System.Windows.Forms.TextBox txtNomeDriver;
        private System.Windows.Forms.TextBox txtCapacidadeDriver;
        private System.Windows.Forms.TextBox txtFormatoDriver;
        private System.Windows.Forms.Label lblNomeDriver;
        private System.Windows.Forms.Label lblCapacidadeTotalDriver;
        private System.Windows.Forms.Label lblFormatoDriver;
        private System.Windows.Forms.TextBox txtCaminhoDriver;
        private System.Windows.Forms.Label lblCaminhoDriver;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblListaAqruivos;
    }
}