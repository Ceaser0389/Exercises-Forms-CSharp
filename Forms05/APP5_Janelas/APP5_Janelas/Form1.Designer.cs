
namespace APP5_Janelas
{
    partial class frm_janela1
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
            this.lbl_janela1 = new System.Windows.Forms.Label();
            this.btn_proxJanela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_janela1
            // 
            this.lbl_janela1.AutoSize = true;
            this.lbl_janela1.Location = new System.Drawing.Point(74, 49);
            this.lbl_janela1.Name = "lbl_janela1";
            this.lbl_janela1.Size = new System.Drawing.Size(104, 13);
            this.lbl_janela1.TabIndex = 0;
            this.lbl_janela1.Text = "Esta é primeira jaela ";
            // 
            // btn_proxJanela
            // 
            this.btn_proxJanela.Location = new System.Drawing.Point(67, 94);
            this.btn_proxJanela.Name = "btn_proxJanela";
            this.btn_proxJanela.Size = new System.Drawing.Size(120, 29);
            this.btn_proxJanela.TabIndex = 1;
            this.btn_proxJanela.Text = "Ir para proxima janela";
            this.btn_proxJanela.UseVisualStyleBackColor = true;
            this.btn_proxJanela.Click += new System.EventHandler(this.btn_proxJanela_Click);
            // 
            // frm_janela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 170);
            this.Controls.Add(this.btn_proxJanela);
            this.Controls.Add(this.lbl_janela1);
            this.Name = "frm_janela1";
            this.Text = "Janela1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_janela1;
        private System.Windows.Forms.Button btn_proxJanela;
    }
}

