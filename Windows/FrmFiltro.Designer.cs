namespace WindowsForms
{
    partial class FrmFiltro
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
            comboPublicacion = new ComboBox();
            label1 = new Label();
            btnOk = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            TxtTexto = new TextBox();
            lblTexto = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // comboPublicacion
            // 
            comboPublicacion.FormattingEnabled = true;
            comboPublicacion.Location = new Point(132, 9);
            comboPublicacion.Name = "comboPublicacion";
            comboPublicacion.Size = new Size(215, 23);
            comboPublicacion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Publicación:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 120);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(116, 69);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(231, 120);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 69);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // TxtTexto
            // 
            TxtTexto.Location = new Point(132, 42);
            TxtTexto.Name = "TxtTexto";
            TxtTexto.Size = new Size(215, 23);
            TxtTexto.TabIndex = 7;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(12, 42);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(0, 15);
            lblTexto.TabIndex = 6;
            // 
            // FrmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 282);
            Controls.Add(TxtTexto);
            Controls.Add(lblTexto);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(comboPublicacion);
            Controls.Add(label1);
            Name = "FrmFiltro";
            Text = "FrmFiltroType";
            Load += FrmFiltroType_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboPublicacion;
        private Label label1;
        private Button btnOk;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private TextBox TxtTexto;
        private Label lblTexto;
    }
}