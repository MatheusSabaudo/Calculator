namespace Calcolatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_piu = new System.Windows.Forms.Button();
            this.btn_meno = new System.Windows.Forms.Button();
            this.btn_per = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_modulo = new System.Windows.Forms.Button();
            this.btn_elev = new System.Windows.Forms.Button();
            this.btn_radice = new System.Windows.Forms.Button();
            this.btn_estrazione = new System.Windows.Forms.Button();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_risultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_piu
            // 
            this.btn_piu.Location = new System.Drawing.Point(21, 145);
            this.btn_piu.Name = "btn_piu";
            this.btn_piu.Size = new System.Drawing.Size(75, 23);
            this.btn_piu.TabIndex = 0;
            this.btn_piu.Text = "+";
            this.btn_piu.UseVisualStyleBackColor = true;
            this.btn_piu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_meno
            // 
            this.btn_meno.Location = new System.Drawing.Point(21, 186);
            this.btn_meno.Name = "btn_meno";
            this.btn_meno.Size = new System.Drawing.Size(75, 23);
            this.btn_meno.TabIndex = 1;
            this.btn_meno.Text = "-";
            this.btn_meno.UseVisualStyleBackColor = true;
            this.btn_meno.Click += new System.EventHandler(this.btn_meno_Click);
            // 
            // btn_per
            // 
            this.btn_per.Location = new System.Drawing.Point(21, 225);
            this.btn_per.Name = "btn_per";
            this.btn_per.Size = new System.Drawing.Size(75, 23);
            this.btn_per.TabIndex = 2;
            this.btn_per.Text = "*";
            this.btn_per.UseVisualStyleBackColor = true;
            this.btn_per.Click += new System.EventHandler(this.btn_per_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(123, 225);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_modulo
            // 
            this.btn_modulo.Location = new System.Drawing.Point(123, 187);
            this.btn_modulo.Name = "btn_modulo";
            this.btn_modulo.Size = new System.Drawing.Size(75, 23);
            this.btn_modulo.TabIndex = 4;
            this.btn_modulo.Text = "%";
            this.btn_modulo.UseVisualStyleBackColor = true;
            this.btn_modulo.Click += new System.EventHandler(this.btn_modulo_Click);
            // 
            // btn_elev
            // 
            this.btn_elev.Location = new System.Drawing.Point(123, 146);
            this.btn_elev.Name = "btn_elev";
            this.btn_elev.Size = new System.Drawing.Size(75, 23);
            this.btn_elev.TabIndex = 5;
            this.btn_elev.Text = "^";
            this.btn_elev.UseVisualStyleBackColor = true;
            this.btn_elev.Click += new System.EventHandler(this.btn_elev_Click);
            // 
            // btn_radice
            // 
            this.btn_radice.Location = new System.Drawing.Point(217, 146);
            this.btn_radice.Name = "btn_radice";
            this.btn_radice.Size = new System.Drawing.Size(75, 23);
            this.btn_radice.TabIndex = 6;
            this.btn_radice.Text = "radice";
            this.btn_radice.UseVisualStyleBackColor = true;
            this.btn_radice.Click += new System.EventHandler(this.btn_radice_Click);
            // 
            // btn_estrazione
            // 
            this.btn_estrazione.Location = new System.Drawing.Point(217, 186);
            this.btn_estrazione.Name = "btn_estrazione";
            this.btn_estrazione.Size = new System.Drawing.Size(75, 23);
            this.btn_estrazione.TabIndex = 7;
            this.btn_estrazione.Text = "estrazione";
            this.btn_estrazione.UseVisualStyleBackColor = true;
            this.btn_estrazione.Click += new System.EventHandler(this.btn_estrazione_Click);
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(139, 44);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 8;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(139, 85);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero 2:";
            // 
            // lbl_risultato
            // 
            this.lbl_risultato.AutoSize = true;
            this.lbl_risultato.Location = new System.Drawing.Point(251, 230);
            this.lbl_risultato.Name = "lbl_risultato";
            this.lbl_risultato.Size = new System.Drawing.Size(13, 13);
            this.lbl_risultato.TabIndex = 12;
            this.lbl_risultato.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 312);
            this.Controls.Add(this.lbl_risultato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.btn_estrazione);
            this.Controls.Add(this.btn_radice);
            this.Controls.Add(this.btn_elev);
            this.Controls.Add(this.btn_modulo);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_per);
            this.Controls.Add(this.btn_meno);
            this.Controls.Add(this.btn_piu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_piu;
        private System.Windows.Forms.Button btn_meno;
        private System.Windows.Forms.Button btn_per;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_modulo;
        private System.Windows.Forms.Button btn_elev;
        private System.Windows.Forms.Button btn_radice;
        private System.Windows.Forms.Button btn_estrazione;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_risultato;
    }
}

