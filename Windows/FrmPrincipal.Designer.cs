namespace WindowsForms
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            toolStrip1 = new ToolStrip();
            BtnAgregar = new ToolStripButton();
            BtbBorrar = new ToolStripButton();
            BtnEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            splBtnFiltrar = new ToolStripSplitButton();
            tipoPublicaciónToolStripMenuItem = new ToolStripMenuItem();
            tituloToolStripMenuItem = new ToolStripMenuItem();
            codigoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            btnActualizar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnCerrar = new ToolStripButton();
            DgvDatos = new DataGridView();
            Publicacion = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            FechaIng = new DataGridViewTextBoxColumn();
            ValorRep = new DataGridViewTextBoxColumn();
            CantPag = new DataGridViewTextBoxColumn();
            TipoRev = new DataGridViewTextBoxColumn();
            TipoUni = new DataGridViewTextBoxColumn();
            FechaDef = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { BtnAgregar, BtbBorrar, BtnEditar, toolStripSeparator1, splBtnFiltrar, toolStripSeparator2, btnActualizar, toolStripSeparator3, btnCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1370, 38);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Image = (Image)resources.GetObject("BtnAgregar.Image");
            BtnAgregar.ImageTransparentColor = Color.Magenta;
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(53, 35);
            BtnAgregar.Text = "Agregar";
            BtnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnAgregar.Click += tBtnAgregar_Click;
            // 
            // BtbBorrar
            // 
            BtbBorrar.Image = (Image)resources.GetObject("BtbBorrar.Image");
            BtbBorrar.ImageTransparentColor = Color.Magenta;
            BtbBorrar.Name = "BtbBorrar";
            BtbBorrar.Size = new Size(43, 35);
            BtbBorrar.Text = "Borrar";
            BtbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtbBorrar.Click += BtbBorrar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Image = (Image)resources.GetObject("BtnEditar.Image");
            BtnEditar.ImageTransparentColor = Color.Magenta;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(41, 35);
            BtnEditar.Text = "Editar";
            BtnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // splBtnFiltrar
            // 
            splBtnFiltrar.DropDownItems.AddRange(new ToolStripItem[] { tipoPublicaciónToolStripMenuItem, tituloToolStripMenuItem, codigoToolStripMenuItem });
            splBtnFiltrar.Image = (Image)resources.GetObject("splBtnFiltrar.Image");
            splBtnFiltrar.ImageTransparentColor = Color.Magenta;
            splBtnFiltrar.Name = "splBtnFiltrar";
            splBtnFiltrar.Size = new Size(53, 35);
            splBtnFiltrar.Text = "Filtrar";
            splBtnFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tipoPublicaciónToolStripMenuItem
            // 
            tipoPublicaciónToolStripMenuItem.Name = "tipoPublicaciónToolStripMenuItem";
            tipoPublicaciónToolStripMenuItem.Size = new Size(180, 22);
            tipoPublicaciónToolStripMenuItem.Text = "Tipo Publicación";
            tipoPublicaciónToolStripMenuItem.Click += tipoPublicaciónToolStripMenuItem_Click;
            // 
            // tituloToolStripMenuItem
            // 
            tituloToolStripMenuItem.Name = "tituloToolStripMenuItem";
            tituloToolStripMenuItem.Size = new Size(180, 22);
            tituloToolStripMenuItem.Text = "Titulo";
            tituloToolStripMenuItem.Click += tituloToolStripMenuItem_Click;
            // 
            // codigoToolStripMenuItem
            // 
            codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            codigoToolStripMenuItem.Size = new Size(180, 22);
            codigoToolStripMenuItem.Text = "Codigo";
            codigoToolStripMenuItem.Click += codigoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // btnActualizar
            // 
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageTransparentColor = Color.Magenta;
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(63, 35);
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 38);
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.ImageTransparentColor = Color.Magenta;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(43, 35);
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // DgvDatos
            // 
            DgvDatos.AllowUserToAddRows = false;
            DgvDatos.AllowUserToDeleteRows = false;
            DgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDatos.Columns.AddRange(new DataGridViewColumn[] { Publicacion, Codigo, Titulo, Autor, FechaIng, ValorRep, CantPag, TipoRev, TipoUni, FechaDef });
            DgvDatos.Dock = DockStyle.Fill;
            DgvDatos.Location = new Point(0, 38);
            DgvDatos.MultiSelect = false;
            DgvDatos.Name = "DgvDatos";
            DgvDatos.ReadOnly = true;
            DgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDatos.Size = new Size(1370, 563);
            DgvDatos.TabIndex = 8;
            // 
            // Publicacion
            // 
            Publicacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Publicacion.HeaderText = "Publicación";
            Publicacion.Name = "Publicacion";
            Publicacion.ReadOnly = true;
            Publicacion.Resizable = DataGridViewTriState.False;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Resizable = DataGridViewTriState.False;
            // 
            // Titulo
            // 
            Titulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Titulo.HeaderText = "Título";
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Resizable = DataGridViewTriState.False;
            // 
            // Autor
            // 
            Autor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Resizable = DataGridViewTriState.False;
            // 
            // FechaIng
            // 
            FechaIng.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaIng.HeaderText = "Fecha de Ingreso";
            FechaIng.Name = "FechaIng";
            FechaIng.ReadOnly = true;
            FechaIng.Resizable = DataGridViewTriState.False;
            // 
            // ValorRep
            // 
            ValorRep.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ValorRep.HeaderText = "Reposición";
            ValorRep.Name = "ValorRep";
            ValorRep.ReadOnly = true;
            ValorRep.Resizable = DataGridViewTriState.False;
            // 
            // CantPag
            // 
            CantPag.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CantPag.HeaderText = "Cantidad de Páginas";
            CantPag.Name = "CantPag";
            CantPag.ReadOnly = true;
            CantPag.Resizable = DataGridViewTriState.False;
            // 
            // TipoRev
            // 
            TipoRev.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoRev.HeaderText = "Tipo de Revista";
            TipoRev.Name = "TipoRev";
            TipoRev.ReadOnly = true;
            TipoRev.Resizable = DataGridViewTriState.False;
            // 
            // TipoUni
            // 
            TipoUni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoUni.HeaderText = "Universidad";
            TipoUni.Name = "TipoUni";
            TipoUni.ReadOnly = true;
            TipoUni.Resizable = DataGridViewTriState.False;
            // 
            // FechaDef
            // 
            FechaDef.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaDef.HeaderText = "Fecha de Defensa";
            FechaDef.Name = "FechaDef";
            FechaDef.ReadOnly = true;
            FechaDef.Resizable = DataGridViewTriState.False;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 601);
            Controls.Add(DgvDatos);
            Controls.Add(toolStrip1);
            Name = "FrmPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView DgvDatos;
        private DataGridViewTextBoxColumn Publicacion;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn FechaIng;
        private DataGridViewTextBoxColumn ValorRep;
        private DataGridViewTextBoxColumn CantPag;
        private DataGridViewTextBoxColumn TipoRev;
        private DataGridViewTextBoxColumn TipoUni;
        private DataGridViewTextBoxColumn FechaDef;
        private ToolStripButton BtnAgregar;
        private ToolStripButton BtbBorrar;
        private ToolStripButton BtnEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnActualizar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnCerrar;
        private ToolStripSplitButton splBtnFiltrar;
        private ToolStripMenuItem tipoPublicaciónToolStripMenuItem;
        private ToolStripMenuItem tituloToolStripMenuItem;
        private ToolStripMenuItem codigoToolStripMenuItem;
    }
}
