namespace WindowsForms
{
    partial class FrmPublicacionesAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboPublicacion = new ComboBox();
            comboTipoRevista = new ComboBox();
            comboUni = new ComboBox();
            TxtCodigo = new TextBox();
            TxtTitulo = new TextBox();
            TxtAutor = new TextBox();
            TxtCantPag = new TextBox();
            BtnOK = new Button();
            BtnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            dateTimePickerIng = new DateTimePicker();
            dateTimePickerDef = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 15);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Publicación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 50);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 78);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 0;
            label3.Text = "Titulo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 108);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 0;
            label4.Text = "Autor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 140);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 0;
            label5.Text = "Fecha de Ingreso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 173);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 0;
            label6.Text = "Cantidad de paginas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 204);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 0;
            label7.Text = "Tipo de Revista:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 236);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 0;
            label8.Text = "Universidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 264);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 0;
            label9.Text = "Fecha de Defensa:";
            // 
            // comboPublicacion
            // 
            comboPublicacion.FormattingEnabled = true;
            comboPublicacion.Location = new Point(162, 12);
            comboPublicacion.Name = "comboPublicacion";
            comboPublicacion.Size = new Size(215, 23);
            comboPublicacion.TabIndex = 1;
            comboPublicacion.SelectedIndexChanged += comboPublicacion_SelectedIndexChanged;
            // 
            // comboTipoRevista
            // 
            comboTipoRevista.FormattingEnabled = true;
            comboTipoRevista.Location = new Point(162, 201);
            comboTipoRevista.Name = "comboTipoRevista";
            comboTipoRevista.Size = new Size(215, 23);
            comboTipoRevista.TabIndex = 1;
            // 
            // comboUni
            // 
            comboUni.FormattingEnabled = true;
            comboUni.Location = new Point(162, 233);
            comboUni.Name = "comboUni";
            comboUni.Size = new Size(215, 23);
            comboUni.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(162, 47);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(215, 23);
            TxtCodigo.TabIndex = 2;
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(162, 76);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(215, 23);
            TxtTitulo.TabIndex = 2;
            // 
            // TxtAutor
            // 
            TxtAutor.Location = new Point(162, 108);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(215, 23);
            TxtAutor.TabIndex = 2;
            // 
            // TxtCantPag
            // 
            TxtCantPag.Location = new Point(162, 170);
            TxtCantPag.Name = "TxtCantPag";
            TxtCantPag.Size = new Size(215, 23);
            TxtCantPag.TabIndex = 2;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(67, 308);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(126, 60);
            BtnOK.TabIndex = 3;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(216, 308);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(126, 60);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dateTimePickerIng
            // 
            dateTimePickerIng.Location = new Point(162, 142);
            dateTimePickerIng.Name = "dateTimePickerIng";
            dateTimePickerIng.Size = new Size(215, 23);
            dateTimePickerIng.TabIndex = 4;
            // 
            // dateTimePickerDef
            // 
            dateTimePickerDef.Location = new Point(162, 262);
            dateTimePickerDef.Name = "dateTimePickerDef";
            dateTimePickerDef.Size = new Size(215, 23);
            dateTimePickerDef.TabIndex = 4;
            // 
            // FrmPublicacionesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 380);
            ControlBox = false;
            Controls.Add(dateTimePickerDef);
            Controls.Add(dateTimePickerIng);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOK);
            Controls.Add(TxtCantPag);
            Controls.Add(TxtAutor);
            Controls.Add(TxtTitulo);
            Controls.Add(TxtCodigo);
            Controls.Add(comboUni);
            Controls.Add(comboTipoRevista);
            Controls.Add(comboPublicacion);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(429, 419);
            MinimumSize = new Size(429, 419);
            Name = "FrmPublicacionesAE";
            Text = "PublicacionesAE";
            Load += FrmPublicacionesAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboPublicacion;
        private ComboBox comboTipoRevista;
        private ComboBox comboUni;
        private TextBox TxtCodigo;
        private TextBox TxtTitulo;
        private TextBox TxtAutor;
        private TextBox TxtCantPag;
        private Button BtnOK;
        private Button BtnCancelar;
        private ErrorProvider errorProvider1;
        private DateTimePicker dateTimePickerIng;
        private DateTimePicker dateTimePickerDef;
    }
}