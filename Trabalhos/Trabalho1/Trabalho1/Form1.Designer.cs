namespace Trabalho1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Modelo_textbox = new System.Windows.Forms.TextBox();
            this.Marca_textbox = new System.Windows.Forms.TextBox();
            this.Placa_textbox = new System.Windows.Forms.TextBox();
            this.Capacidade_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cadastrar_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Modelo_textbox
            // 
            this.Modelo_textbox.Location = new System.Drawing.Point(82, 12);
            this.Modelo_textbox.Name = "Modelo_textbox";
            this.Modelo_textbox.Size = new System.Drawing.Size(143, 20);
            this.Modelo_textbox.TabIndex = 0;
            // 
            // Marca_textbox
            // 
            this.Marca_textbox.Location = new System.Drawing.Point(82, 38);
            this.Marca_textbox.Name = "Marca_textbox";
            this.Marca_textbox.Size = new System.Drawing.Size(143, 20);
            this.Marca_textbox.TabIndex = 1;
            // 
            // Placa_textbox
            // 
            this.Placa_textbox.Location = new System.Drawing.Point(82, 64);
            this.Placa_textbox.Name = "Placa_textbox";
            this.Placa_textbox.Size = new System.Drawing.Size(143, 20);
            this.Placa_textbox.TabIndex = 2;
            // 
            // Capacidade_textbox
            // 
            this.Capacidade_textbox.Location = new System.Drawing.Point(82, 90);
            this.Capacidade_textbox.Name = "Capacidade_textbox";
            this.Capacidade_textbox.Size = new System.Drawing.Size(143, 20);
            this.Capacidade_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capacidade";
            // 
            // Cadastrar_button
            // 
            this.Cadastrar_button.Location = new System.Drawing.Point(12, 116);
            this.Cadastrar_button.Name = "Cadastrar_button";
            this.Cadastrar_button.Size = new System.Drawing.Size(213, 51);
            this.Cadastrar_button.TabIndex = 9;
            this.Cadastrar_button.Text = "CADASTRAR";
            this.Cadastrar_button.UseVisualStyleBackColor = true;
            this.Cadastrar_button.Click += new System.EventHandler(this.Cadastrar_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 381);
            this.listBox1.TabIndex = 10;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(190, 566);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(35, 20);
            this.ID_textbox.TabIndex = 11;
            this.ID_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_textbox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 598);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Cadastrar_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Capacidade_textbox);
            this.Controls.Add(this.Placa_textbox);
            this.Controls.Add(this.Marca_textbox);
            this.Controls.Add(this.Modelo_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Modelo_textbox;
        private System.Windows.Forms.TextBox Marca_textbox;
        private System.Windows.Forms.TextBox Placa_textbox;
        private System.Windows.Forms.TextBox Capacidade_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cadastrar_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.Label label5;
    }
}

