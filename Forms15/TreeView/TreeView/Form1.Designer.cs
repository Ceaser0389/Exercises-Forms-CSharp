
namespace TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Queijo");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Presunto");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Salame");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Frios", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Leite");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Suco de Laranja");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Liquidos", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sonho");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Dounts");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Doces", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Pão Frances");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Pão de Forma");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Paes", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Padaria", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Chocolate");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Bala");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("finis");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Gulosemas", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Refrigerante");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Cerveja");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Liquido", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Bolacha");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Biscoito");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Batatinha");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Diversos", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Supermercado", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode21,
            treeNode25});
            this.ArvoreDeCompras = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ArvoreDeCompras
            // 
            this.ArvoreDeCompras.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ArvoreDeCompras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArvoreDeCompras.ForeColor = System.Drawing.Color.Black;
            this.ArvoreDeCompras.LabelEdit = true;
            this.ArvoreDeCompras.LineColor = System.Drawing.Color.DimGray;
            this.ArvoreDeCompras.Location = new System.Drawing.Point(30, 12);
            this.ArvoreDeCompras.Name = "ArvoreDeCompras";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Queijo";
            treeNode2.Name = "Node8";
            treeNode2.Text = "Presunto";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Salame";
            treeNode4.BackColor = System.Drawing.Color.White;
            treeNode4.Name = "Node1";
            treeNode4.Text = "Frios";
            treeNode5.Name = "Node11";
            treeNode5.Text = "Leite";
            treeNode6.Name = "Node12";
            treeNode6.Text = "Suco de Laranja";
            treeNode7.Name = "Node10";
            treeNode7.Text = "Liquidos";
            treeNode8.Name = "Node15";
            treeNode8.Text = "Sonho";
            treeNode9.Name = "Node16";
            treeNode9.Text = "Dounts";
            treeNode10.Name = "Node13";
            treeNode10.Text = "Doces";
            treeNode11.Name = "Node18";
            treeNode11.Text = "Pão Frances";
            treeNode12.Name = "Node19";
            treeNode12.Text = "Pão de Forma";
            treeNode13.Name = "Node17";
            treeNode13.Text = "Paes";
            treeNode14.ForeColor = System.Drawing.Color.DarkCyan;
            treeNode14.Name = "Node0";
            treeNode14.Text = "Padaria";
            treeNode15.Name = "Node25";
            treeNode15.Text = "Chocolate";
            treeNode16.Name = "Node27";
            treeNode16.Text = "Bala";
            treeNode17.Name = "Node28";
            treeNode17.Text = "finis";
            treeNode18.Name = "Node21";
            treeNode18.Text = "Gulosemas";
            treeNode19.Name = "Node30";
            treeNode19.Text = "Refrigerante";
            treeNode20.Name = "Node31";
            treeNode20.Text = "Cerveja";
            treeNode21.Name = "Node29";
            treeNode21.Text = "Liquido";
            treeNode22.Name = "Node35";
            treeNode22.Text = "Bolacha";
            treeNode23.Name = "Node36";
            treeNode23.Text = "Biscoito";
            treeNode24.Name = "Node37";
            treeNode24.Text = "Batatinha";
            treeNode25.Name = "Node34";
            treeNode25.Text = "Diversos";
            treeNode26.ForeColor = System.Drawing.Color.DarkCyan;
            treeNode26.Name = "Node20";
            treeNode26.Text = "Supermercado";
            this.ArvoreDeCompras.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode26});
            this.ArvoreDeCompras.Size = new System.Drawing.Size(251, 376);
            this.ArvoreDeCompras.TabIndex = 0;
            this.ArvoreDeCompras.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 451);
            this.Controls.Add(this.ArvoreDeCompras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ArvoreDeCompras;
    }
}

