
namespace NotifyIcon_ToolTip
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confg1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 29);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "Digite aqui o seu nome");
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(27, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(422, 29);
            this.textBox2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox2, "Digite aqui seu sobrenome");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(155, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aperte Aki";
            this.toolTip1.SetToolTip(this.button1, "Irá mostrar um pop com o seu nome e sobrenome");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda com Componente";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçãoToolStripMenuItem,
            this.configuraçãoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 48);
            // 
            // opçãoToolStripMenuItem
            // 
            this.opçãoToolStripMenuItem.Name = "opçãoToolStripMenuItem";
            this.opçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opçãoToolStripMenuItem.Text = "Opção:";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confg1ToolStripMenuItem,
            this.config2ToolStripMenuItem,
            this.config3ToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuraçãoToolStripMenuItem.Text = "Configuração:";
            // 
            // confg1ToolStripMenuItem
            // 
            this.confg1ToolStripMenuItem.Name = "confg1ToolStripMenuItem";
            this.confg1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.confg1ToolStripMenuItem.Text = "Config1";
            this.confg1ToolStripMenuItem.Click += new System.EventHandler(this.confg1ToolStripMenuItem_Click);
            // 
            // config2ToolStripMenuItem
            // 
            this.config2ToolStripMenuItem.Name = "config2ToolStripMenuItem";
            this.config2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.config2ToolStripMenuItem.Text = "Config 2";
            this.config2ToolStripMenuItem.Click += new System.EventHandler(this.config2ToolStripMenuItem_Click);
            // 
            // config3ToolStripMenuItem
            // 
            this.config3ToolStripMenuItem.Name = "config3ToolStripMenuItem";
            this.config3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.config3ToolStripMenuItem.Text = "Config 3";
            this.config3ToolStripMenuItem.Click += new System.EventHandler(this.config3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confg1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config3ToolStripMenuItem;
    }
}

