
namespace APP3_TextBox
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_Idade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Nome = new System.Windows.Forms.TextBox();
            this.text_Sobrenome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Resposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira sua idade:";
            // 
            // text_Idade
            // 
            this.text_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Idade.Location = new System.Drawing.Point(94, 111);
            this.text_Idade.Name = "text_Idade";
            this.text_Idade.PasswordChar = '*';
            this.text_Idade.Size = new System.Drawing.Size(164, 31);
            this.text_Idade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira seu nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Insira Seu sobrenome:";
            // 
            // text_Nome
            // 
            this.text_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Nome.Location = new System.Drawing.Point(94, 182);
            this.text_Nome.Name = "text_Nome";
            this.text_Nome.Size = new System.Drawing.Size(165, 31);
            this.text_Nome.TabIndex = 4;
            // 
            // text_Sobrenome
            // 
            this.text_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Sobrenome.Location = new System.Drawing.Point(94, 264);
            this.text_Sobrenome.Name = "text_Sobrenome";
            this.text_Sobrenome.Size = new System.Drawing.Size(165, 31);
            this.text_Sobrenome.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(94, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apresentar Mensagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Resposta
            // 
            this.lbl_Resposta.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resposta.Location = new System.Drawing.Point(76, 413);
            this.lbl_Resposta.Name = "lbl_Resposta";
            this.lbl_Resposta.Size = new System.Drawing.Size(212, 100);
            this.lbl_Resposta.TabIndex = 7;
            this.lbl_Resposta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 540);
            this.Controls.Add(this.lbl_Resposta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_Sobrenome);
            this.Controls.Add(this.text_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Idade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Insira sua idade:";
            this.TextChanged += new System.EventHandler(this.ValidarTexto);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarInt);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Idade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Nome;
        private System.Windows.Forms.TextBox text_Sobrenome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Resposta;
    }
}

