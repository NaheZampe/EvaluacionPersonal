using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Helpers;

namespace WindowsForms
{
    public partial class FrmFiltro : Form
    {
        public FrmFiltro()
        {
            InitializeComponent();
        }
        private string type;
        private string texto="";
        private void FrmFiltroType_Load(object sender, EventArgs e)
        {
            ComboHelper.CargarComboPublicaciones(comboPublicacion);
            if (Text == "Filtrar por Titulo")
            {
                comboPublicacion.Enabled = false;
                lblTexto.Text = "Titulo:";
            }
            else if (Text == "Filtrar por Codigo")
            {
                comboPublicacion.Enabled = false;
                lblTexto.Text = "Codigo:";
            }
            else
            {
                TxtTexto.Enabled = false;
            }
        }
        private bool ValidarCodigo(string text)
        {
            string patron = @"^MAT-\d{4}$";
            if (Regex.IsMatch(text, patron)) return true;
            return false;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Text == "Filtrar por Codigo")
            {
                texto = TxtTexto.Text;
                if (!ValidarCodigo(texto))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(TxtTexto, "Formato no válido");
                    TxtTexto.Focus();
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else if (Text=="Filtrar por Titulo")
            {
                texto = TxtTexto.Text;
                if (ValidarDatos(texto))
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else if (ValidarDatos())
            {
                type = comboPublicacion.SelectedItem!.ToString();
                DialogResult = DialogResult.OK;
            }
            
        }
        internal string GetTipo() => type;
        private bool ValidarDatos(string texto="")
        {
            errorProvider1.Clear();
            var valido = true;
            if (Text == "Filtrar por Titulo")
            {
                if (string.IsNullOrEmpty(texto))
                {
                    errorProvider1.SetError(TxtTexto, "Debe ingresar un Titulo!!");
                    valido = false;
                }
            }
            else if (comboPublicacion.SelectedIndex<1)
            {
                errorProvider1.SetError(comboPublicacion, "Debe seleccionar un tipo de publicación!!");
                valido = false;
            }
            
            return valido;
        }

        internal string GetTexto() => texto;
    }
}
