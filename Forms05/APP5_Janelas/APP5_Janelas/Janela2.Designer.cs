
namespace APP5_Janelas
{
    partial class frm_Janela2
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_proxJanela = new System.Windows.Forms.Button();
            this.lbl_01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(111, 135);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 33);
            this.btn_voltar.TabIndex = 0;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_proxJanela
            // 
            this.btn_proxJanela.Location = new System.Drawing.Point(111, 197);
            this.btn_proxJanela.Name = "btn_proxJanela";
            this.btn_proxJanela.Size = new System.Drawing.Size(75, 41);
            this.btn_proxJanela.TabIndex = 1;
            this.btn_proxJanela.Text = "Proxima janela";
            this.btn_proxJanela.UseVisualStyleBackColor = true;
            this.btn_proxJanela.Click += new System.EventHandler(this.btn_proxJanela_Click);
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_01.Location = new System.Drawing.Point(53, 80);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(236, 25);
            this.lbl_01.TabIndex = 2;
            this.lbl_01.Text = "Esta é a segunda janela";
            this.lbl_01.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_Janela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 286);
            this.Controls.Add(this.lbl_01);
            this.Controls.Add(this.btn_proxJanela);
            this.Controls.Add(this.btn_voltar);
            this.Name = "frm_Janela2";
            this.Text = "Janela2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_proxJanela;
        private System.Windows.Forms.Label lbl_01;
    }
}