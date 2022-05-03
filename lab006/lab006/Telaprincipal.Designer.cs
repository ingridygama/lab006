
namespace lab006.lab006
{
    partial class Telaprincipal
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numValor1 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numValor3 = new System.Windows.Forms.NumericUpDown();
            this.numValor2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(76, 48);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(39, 15);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(76, 86);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(39, 15);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor2";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Location = new System.Drawing.Point(76, 122);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(39, 15);
            this.lblValor3.TabIndex = 2;
            this.lblValor3.Text = "Valor3";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultado.Location = new System.Drawing.Point(76, 218);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(364, 111);
            this.lblResultado.TabIndex = 3;
            // 
            // numValor1
            // 
            this.numValor1.Location = new System.Drawing.Point(132, 40);
            this.numValor1.Name = "numValor1";
            this.numValor1.Size = new System.Drawing.Size(120, 23);
            this.numValor1.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(107, 165);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(126, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numValor3
            // 
            this.numValor3.Location = new System.Drawing.Point(132, 120);
            this.numValor3.Name = "numValor3";
            this.numValor3.Size = new System.Drawing.Size(120, 23);
            this.numValor3.TabIndex = 6;
            // 
            // numValor2
            // 
            this.numValor2.Location = new System.Drawing.Point(132, 78);
            this.numValor2.Name = "numValor2";
            this.numValor2.Size = new System.Drawing.Size(120, 23);
            this.numValor2.TabIndex = 7;
            // 
            // Telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numValor2);
            this.Controls.Add(this.numValor3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.numValor1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Name = "Telaprincipal";
            this.Text = "Telaprincipal";
            ((System.ComponentModel.ISupportInitialize)(this.numValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numValor1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown numValor3;
        private System.Windows.Forms.NumericUpDown numValor2;
    }
}