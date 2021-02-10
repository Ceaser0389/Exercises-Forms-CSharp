
namespace APP5_Janelas
{
    partial class frm_Janela3
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
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_01
            // 
            this.btn_01.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_01.Location = new System.Drawing.Point(31, 100);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(103, 49);
            this.btn_01.TabIndex = 0;
            this.btn_01.Text = "Reniciar";
            this.btn_01.UseVisualStyleBackColor = true;
            this.btn_01.Click += new System.EventHandler(this.btn_01_Click);
            // 
            // btn_02
            // 
            this.btn_02.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_02.Location = new System.Drawing.Point(205, 100);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(103, 49);
            this.btn_02.TabIndex = 1;
            this.btn_02.Text = "Voltar";
            this.btn_02.UseVisualStyleBackColor = true;
            this.btn_02.Click += new System.EventHandler(this.btn_02_Click);
            // 
            // frm_Janela3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 171);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.btn_01);
            this.Name = "frm_Janela3";
            this.Text = "Janela3";
            this.Load += new System.EventHandler(this.Janela3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_02;
    }
}