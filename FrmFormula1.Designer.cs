namespace Projeto_Aulas
{
    partial class FrmFormula1
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
            this.txtTempoVoltas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMediaTempos = new System.Windows.Forms.TextBox();
            this.lblMediaTempos = new System.Windows.Forms.Label();
            this.lblMelhorVolta = new System.Windows.Forms.Label();
            this.txtMelhorVolta = new System.Windows.Forms.TextBox();
            this.btnArmazenar = new System.Windows.Forms.Button();
            this.lblTempoVoltas = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblObs2 = new System.Windows.Forms.Label();
            this.lblQuantidadeArmazenamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTempoVoltas
            // 
            this.txtTempoVoltas.Location = new System.Drawing.Point(153, 37);
            this.txtTempoVoltas.Name = "txtTempoVoltas";
            this.txtTempoVoltas.Size = new System.Drawing.Size(131, 20);
            this.txtTempoVoltas.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(40, 139);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(174, 44);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMediaTempos
            // 
            this.txtMediaTempos.Location = new System.Drawing.Point(370, 139);
            this.txtMediaTempos.Name = "txtMediaTempos";
            this.txtMediaTempos.ReadOnly = true;
            this.txtMediaTempos.Size = new System.Drawing.Size(100, 20);
            this.txtMediaTempos.TabIndex = 2;
            // 
            // lblMediaTempos
            // 
            this.lblMediaTempos.AutoSize = true;
            this.lblMediaTempos.Location = new System.Drawing.Point(247, 142);
            this.lblMediaTempos.Name = "lblMediaTempos";
            this.lblMediaTempos.Size = new System.Drawing.Size(102, 13);
            this.lblMediaTempos.TabIndex = 3;
            this.lblMediaTempos.Text = "Médias dos Tempos";
            // 
            // lblMelhorVolta
            // 
            this.lblMelhorVolta.AutoSize = true;
            this.lblMelhorVolta.Location = new System.Drawing.Point(263, 166);
            this.lblMelhorVolta.Name = "lblMelhorVolta";
            this.lblMelhorVolta.Size = new System.Drawing.Size(66, 13);
            this.lblMelhorVolta.TabIndex = 4;
            this.lblMelhorVolta.Text = "Melhor Volta";
            // 
            // txtMelhorVolta
            // 
            this.txtMelhorVolta.Location = new System.Drawing.Point(370, 163);
            this.txtMelhorVolta.Name = "txtMelhorVolta";
            this.txtMelhorVolta.ReadOnly = true;
            this.txtMelhorVolta.Size = new System.Drawing.Size(100, 20);
            this.txtMelhorVolta.TabIndex = 5;
            // 
            // btnArmazenar
            // 
            this.btnArmazenar.Location = new System.Drawing.Point(325, 24);
            this.btnArmazenar.Name = "btnArmazenar";
            this.btnArmazenar.Size = new System.Drawing.Size(93, 33);
            this.btnArmazenar.TabIndex = 6;
            this.btnArmazenar.Text = "Armazenar";
            this.btnArmazenar.UseVisualStyleBackColor = true;
            this.btnArmazenar.Click += new System.EventHandler(this.btnArmazenar_Click);
            // 
            // lblTempoVoltas
            // 
            this.lblTempoVoltas.AutoSize = true;
            this.lblTempoVoltas.Location = new System.Drawing.Point(52, 40);
            this.lblTempoVoltas.Name = "lblTempoVoltas";
            this.lblTempoVoltas.Size = new System.Drawing.Size(95, 13);
            this.lblTempoVoltas.TabIndex = 7;
            this.lblTempoVoltas.Text = "Tempos das Votas";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(12, 90);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(475, 13);
            this.lblObs.TabIndex = 8;
            this.lblObs.Text = "Obs: Coloque os tempos das voltas no campo de Tempos das Notas e Aperter o Botão " +
    "Armazenar, ";
            // 
            // lblObs2
            // 
            this.lblObs2.AutoSize = true;
            this.lblObs2.Location = new System.Drawing.Point(37, 103);
            this.lblObs2.Name = "lblObs2";
            this.lblObs2.Size = new System.Drawing.Size(433, 13);
            this.lblObs2.TabIndex = 9;
            this.lblObs2.Text = "Depois de Armazenar aperte em Calcular para saber a Media dos tempos e a Melhor V" +
    "olta.";
            // 
            // lblQuantidadeArmazenamento
            // 
            this.lblQuantidadeArmazenamento.AutoSize = true;
            this.lblQuantidadeArmazenamento.Location = new System.Drawing.Point(331, 60);
            this.lblQuantidadeArmazenamento.Name = "lblQuantidadeArmazenamento";
            this.lblQuantidadeArmazenamento.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidadeArmazenamento.TabIndex = 14;
            this.lblQuantidadeArmazenamento.Text = "Quantidade";
            // 
            // FrmFormula1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 209);
            this.Controls.Add(this.lblQuantidadeArmazenamento);
            this.Controls.Add(this.lblObs2);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblTempoVoltas);
            this.Controls.Add(this.btnArmazenar);
            this.Controls.Add(this.txtMelhorVolta);
            this.Controls.Add(this.lblMelhorVolta);
            this.Controls.Add(this.lblMediaTempos);
            this.Controls.Add(this.txtMediaTempos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTempoVoltas);
            this.Name = "FrmFormula1";
            this.Text = "Formula1";
            this.Load += new System.EventHandler(this.FrmFormula1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempoVoltas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMediaTempos;
        private System.Windows.Forms.Label lblMediaTempos;
        private System.Windows.Forms.Label lblMelhorVolta;
        private System.Windows.Forms.TextBox txtMelhorVolta;
        private System.Windows.Forms.Button btnArmazenar;
        private System.Windows.Forms.Label lblTempoVoltas;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblObs2;
        private System.Windows.Forms.Label lblQuantidadeArmazenamento;
    }
}