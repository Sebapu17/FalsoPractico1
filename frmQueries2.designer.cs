using System;

namespace EjemplosWin
{
    partial class frmQueries2
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
            this.rbtDelanteros = new System.Windows.Forms.RadioButton();
            this.rbtPorteros = new System.Windows.Forms.RadioButton();
            this.rbtMedios = new System.Windows.Forms.RadioButton();
            this.rbtDefensas = new System.Windows.Forms.RadioButton();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnProcesar2 = new System.Windows.Forms.Button();
            this.rbdMC = new System.Windows.Forms.RadioButton();
            this.rbdDfc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtDelanteros
            // 
            this.rbtDelanteros.AutoSize = true;
            this.rbtDelanteros.Location = new System.Drawing.Point(12, 28);
            this.rbtDelanteros.Name = "rbtDelanteros";
            this.rbtDelanteros.Size = new System.Drawing.Size(76, 17);
            this.rbtDelanteros.TabIndex = 1;
            this.rbtDelanteros.TabStop = true;
            this.rbtDelanteros.Text = "Delanteros";
            this.rbtDelanteros.UseVisualStyleBackColor = true;
            // 
            // rbtPorteros
            // 
            this.rbtPorteros.AutoSize = true;
            this.rbtPorteros.Location = new System.Drawing.Point(245, 28);
            this.rbtPorteros.Name = "rbtPorteros";
            this.rbtPorteros.Size = new System.Drawing.Size(64, 17);
            this.rbtPorteros.TabIndex = 2;
            this.rbtPorteros.TabStop = true;
            this.rbtPorteros.Text = "Porteros";
            this.rbtPorteros.UseVisualStyleBackColor = true;
            // 
            // rbtMedios
            // 
            this.rbtMedios.AutoSize = true;
            this.rbtMedios.Location = new System.Drawing.Point(12, 28);
            this.rbtMedios.Name = "rbtMedios";
            this.rbtMedios.Size = new System.Drawing.Size(76, 17);
            this.rbtMedios.TabIndex = 1;
            this.rbtMedios.TabStop = true;
            this.rbtMedios.Text = "Medios";
            this.rbtMedios.UseVisualStyleBackColor = true;
            // 
            // rbtDefensas
            // 
            this.rbtDefensas.Location = new System.Drawing.Point(0, 0);
            this.rbtDefensas.Name = "rbtDefensas";
            this.rbtDefensas.Size = new System.Drawing.Size(104, 24);
            this.rbtDefensas.TabIndex = 0;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(12, 58);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(297, 186);
            this.lstResultados.TabIndex = 3;
            // 
            // btnProcesar2
            // 
            this.btnProcesar2.Location = new System.Drawing.Point(234, 250);
            this.btnProcesar2.Name = "btnProcesar2";
            this.btnProcesar2.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar2.TabIndex = 5;
            this.btnProcesar2.Text = "Procesar";
            this.btnProcesar2.UseVisualStyleBackColor = true;
            this.btnProcesar2.Click += new System.EventHandler(this.btnProcesar2_Click);
            // 
            // rbdMC
            // 
            this.rbdMC.AutoSize = true;
            this.rbdMC.Location = new System.Drawing.Point(94, 28);
            this.rbdMC.Name = "rbdMC";
            this.rbdMC.Size = new System.Drawing.Size(59, 17);
            this.rbdMC.TabIndex = 6;
            this.rbdMC.TabStop = true;
            this.rbdMC.Text = "Medios";
            this.rbdMC.UseVisualStyleBackColor = true;
            // 
            // rbdDfc
            // 
            this.rbdDfc.AutoSize = true;
            this.rbdDfc.Location = new System.Drawing.Point(159, 28);
            this.rbdDfc.Name = "rbdDfc";
            this.rbdDfc.Size = new System.Drawing.Size(70, 17);
            this.rbdDfc.TabIndex = 7;
            this.rbdDfc.TabStop = true;
            this.rbdDfc.Text = "Defensas";
            this.rbdDfc.UseVisualStyleBackColor = true;
            // 
            // frmQueries2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 290);
            this.Controls.Add(this.rbdDfc);
            this.Controls.Add(this.rbdMC);
            this.Controls.Add(this.btnProcesar2);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.rbtPorteros);
            this.Controls.Add(this.rbtDelanteros);
            this.Name = "frmQueries2";
            this.Text = "Filtro puestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void rbtPorteros_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.RadioButton rbtDefensas;
        private System.Windows.Forms.RadioButton rbtMedios;
        private System.Windows.Forms.RadioButton rbtDelanteros;
        private System.Windows.Forms.RadioButton rbtPorteros;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnProcesar2;
        private System.Windows.Forms.RadioButton rbdMC;
        private System.Windows.Forms.RadioButton rbdDfc;
    }
}