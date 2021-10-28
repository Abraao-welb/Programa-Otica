namespace Sistema_Ótica_Valentim
{
    partial class frm_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm_cad_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cs_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cs_consulta = new System.Windows.Forms.Button();
            this.btn_cad_cliente = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.btn_cad_produtos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frm_cad_cliente,
            this.btn_cs_cliente});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.clienteToolStripMenuItem.Text = "Clientes";
            // 
            // frm_cad_cliente
            // 
            this.frm_cad_cliente.Name = "frm_cad_cliente";
            this.frm_cad_cliente.Size = new System.Drawing.Size(126, 22);
            this.frm_cad_cliente.Text = "Cadastrar";
            this.frm_cad_cliente.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // btn_cs_cliente
            // 
            this.btn_cs_cliente.Name = "btn_cs_cliente";
            this.btn_cs_cliente.Size = new System.Drawing.Size(126, 22);
            this.btn_cs_cliente.Text = "Consultar";
            this.btn_cs_cliente.Click += new System.EventHandler(this.btn_cs_cliente_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.categoriasToolStripMenuItem,
            this.consultarToolStripMenuItem1});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            this.caixaToolStripMenuItem.Click += new System.EventHandler(this.caixaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Sistema_Ótica_Valentim.Properties.Resources._11_removebg_preview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(674, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 204);
            this.button1.TabIndex = 6;
            this.button1.Text = "Caixa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_cs_consulta
            // 
            this.btn_cs_consulta.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cs_consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cs_consulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cs_consulta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cs_consulta.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cs_consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cs_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cs_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cs_consulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cs_consulta.Image = global::Sistema_Ótica_Valentim.Properties.Resources.medique_o_avatar_do_perfil_da_pessoa_masculina_vetor_ícone_consulta_com_símbolo_pergunta_para_respostas_médicas_no_pictograma_124754713_removebg_preview__1_;
            this.btn_cs_consulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cs_consulta.Location = new System.Drawing.Point(398, 389);
            this.btn_cs_consulta.Name = "btn_cs_consulta";
            this.btn_cs_consulta.Size = new System.Drawing.Size(148, 134);
            this.btn_cs_consulta.TabIndex = 5;
            this.btn_cs_consulta.Text = "Consultar\r\nCliente";
            this.btn_cs_consulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cs_consulta.UseVisualStyleBackColor = false;
            this.btn_cs_consulta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cad_cliente
            // 
            this.btn_cad_cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cad_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cad_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_cliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cad_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cad_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cad_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_cliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cad_cliente.Image = global::Sistema_Ótica_Valentim.Properties.Resources._40358_removebg_preview;
            this.btn_cad_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_cliente.Location = new System.Drawing.Point(176, 389);
            this.btn_cad_cliente.Name = "btn_cad_cliente";
            this.btn_cad_cliente.Size = new System.Drawing.Size(148, 134);
            this.btn_cad_cliente.TabIndex = 4;
            this.btn_cad_cliente.Text = "Cadastrar\r\nCliente";
            this.btn_cad_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_cliente.UseVisualStyleBackColor = false;
            this.btn_cad_cliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cad_categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_categorias.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cad_categorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cad_categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cad_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_categorias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cad_categorias.Image = global::Sistema_Ótica_Valentim.Properties.Resources.inscription3_removebg_preview__3_;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(398, 205);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(148, 134);
            this.btn_cad_categorias.TabIndex = 3;
            this.btn_cad_categorias.Text = "Cadastrar\r\nCategorias\r\n";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.btn_cad_categorias_Click);
            // 
            // btn_cad_produtos
            // 
            this.btn_cad_produtos.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cad_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produtos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_produtos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cad_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cad_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cad_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_produtos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cad_produtos.Image = global::Sistema_Ótica_Valentim.Properties.Resources._126087_removebg_preview__1_;
            this.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.Location = new System.Drawing.Point(176, 205);
            this.btn_cad_produtos.Name = "btn_cad_produtos";
            this.btn_cad_produtos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cad_produtos.Size = new System.Drawing.Size(148, 134);
            this.btn_cad_produtos.TabIndex = 2;
            this.btn_cad_produtos.Text = "Cadastrar\r\nProdutos";
            this.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_produtos.UseVisualStyleBackColor = false;
            this.btn_cad_produtos.Click += new System.EventHandler(this.btn_cadastrar_produtos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sistema_Ótica_Valentim.Properties.Resources.otica_valentim3_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(1081, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 222);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cs_consulta);
            this.Controls.Add(this.btn_cad_cliente);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_produtos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Menu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frm_cad_cliente;
        private System.Windows.Forms.ToolStripMenuItem btn_cs_cliente;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_produtos;
        private System.Windows.Forms.Button btn_cad_categorias;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_cliente;
        private System.Windows.Forms.Button btn_cs_consulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
    }
}

