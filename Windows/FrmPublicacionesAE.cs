using Clases;
using System.Text.RegularExpressions;
using WindowsForms.Helpers;

namespace WindowsForms
{
    public partial class FrmPublicacionesAE : Form
    {
        private Publicacion? publicacion = null;
        private Publicacion? publicacionEditada;
        public FrmPublicacionesAE()
        {
            InitializeComponent();
        }
        private void FrmPublicacionesAE_Load(object sender, EventArgs e)
        {
            InhabilitarControles();
            ComboHelper.CargarComboPublicaciones(comboPublicacion);
            ComboHelper.CargarComboTipoRevista(comboTipoRevista);
            ComboHelper.CargarComboUniversidad(comboUni);
            if (publicacion is not null)
            {
                CargarDatos(publicacion);
            }
        }

        private void CargarDatos(Publicacion publicacion)
        {
            comboPublicacion.SelectedItem = publicacion.GetType().Name.ToString();
            comboPublicacion.Enabled = false;
            TxtCodigo.Text = publicacion.Codigo.ToString();
            TxtCodigo.Enabled = false;
            TxtTitulo.Text = publicacion.Titulo.ToString();
            TxtAutor.Text = publicacion.Autor.ToString();
            dateTimePickerIng.Value = publicacion.FechaIngreso;
            if (publicacion is Libro libro)
            {
                TxtCantPag.Text = libro.CantPaginas.ToString();
                dateTimePickerDef.Value = dateTimePickerDef.MinDate;
                LimpiarDateTimePicker(dateTimePickerDef);
            }
            else if (publicacion is Tesis tesis)
            {
                comboUni.SelectedItem = tesis.universidad;
                dateTimePickerDef.Value = tesis.AnioDefensa;
            }
            else if (publicacion is Revista revista)
            {
                comboTipoRevista.SelectedItem = revista.TipoRevista;
                dateTimePickerDef.Value = dateTimePickerDef.MinDate;
                LimpiarDateTimePicker(dateTimePickerDef);
            }
        }
        private void LimpiarDateTimePicker(DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = " ";
        }
        private void comboPublicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion = comboPublicacion.SelectedIndex;
            if (comboPublicacion.SelectedIndex > 0)
            {
                InhabilitarControles();
                HabilitarControles(seleccion);
            }
            if (comboPublicacion.SelectedIndex == 0)
            {
                InhabilitarControles();
            }

        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            var seleccion = comboPublicacion.SelectedIndex;
            string TipoSeleccionado = comboPublicacion.SelectedItem!.ToString()!;
            if (ValidarDatos(seleccion))
            {
                if (publicacion is null)
                {
                    switch (TipoSeleccionado)
                    {
                        case "Libro":
                            if (int.TryParse(TxtCantPag.Text, out int cantPaginas))
                                publicacion = new Libro(cantPaginas)
                                {
                                    Autor = TxtAutor.Text,
                                    Codigo = TxtCodigo.Text,
                                    Titulo = TxtTitulo.Text,
                                    FechaIngreso = dateTimePickerIng.Value
                                };
                            break;
                        case "Revista":
                            publicacion = new Revista()
                            {
                                Autor = TxtAutor.Text,
                                Codigo = TxtCodigo.Text,
                                Titulo = TxtTitulo.Text,
                                FechaIngreso = dateTimePickerIng.Value,
                                TipoRevista = (Revista.TipoDeRevista)comboTipoRevista.SelectedItem!
                            };
                            break;
                        case "Tesis":
                            var anioDef = dateTimePickerDef.Value;
                            publicacion = new Tesis(anioDef)
                            {
                                Autor = TxtAutor.Text,
                                Codigo = TxtCodigo.Text,
                                Titulo = TxtTitulo.Text,
                                FechaIngreso = dateTimePickerIng.Value,
                                universidad = (Tesis.Universidad)comboUni.SelectedItem!
                            };
                            break;
                        default:
                            break;
                    }
                }
                else if (publicacion is Libro libro && TipoSeleccionado == "Libro")
                {
                    if (int.TryParse(TxtCantPag.Text, out int cantPaginas))
                        libro.Autor = TxtAutor.Text;
                    libro.Codigo = TxtCodigo.Text;
                    libro.Titulo = TxtTitulo.Text;
                    libro.FechaIngreso = dateTimePickerIng.Value;
                    libro.CantPaginas = cantPaginas;
                    publicacionEditada = libro;
                }
                else if (publicacion is Revista revista && TipoSeleccionado == "Revista")
                {
                    revista.Autor = TxtAutor.Text;
                    revista.Codigo = TxtCodigo.Text;
                    revista.Titulo = TxtTitulo.Text;
                    revista.FechaIngreso = dateTimePickerIng.Value;
                    revista.TipoRevista = (Revista.TipoDeRevista)comboTipoRevista.SelectedItem!;
                    publicacionEditada = revista;
                }
                else if (publicacion is Tesis tesis && TipoSeleccionado == "Tesis")
                {
                    tesis.Autor = TxtAutor.Text;
                    tesis.Codigo = TxtCodigo.Text;
                    tesis.Titulo = TxtTitulo.Text;
                    tesis.FechaIngreso = dateTimePickerIng.Value;
                    tesis.universidad = (Tesis.Universidad)comboUni.SelectedItem!;
                    tesis.AnioDefensa = dateTimePickerDef.Value;
                    publicacionEditada = tesis;
                }
                DialogResult = DialogResult.OK;
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        internal Publicacion GetPublicacion() => publicacion;
        private void HabilitarControles(int seleccion)
        {
            TxtAutor.Enabled = true;
            TxtCodigo.Enabled = true;
            TxtTitulo.Enabled = true;
            dateTimePickerIng.Enabled = true;
            switch (seleccion)
            {
                case 1:
                    TxtCantPag.Enabled = true;
                    break;
                case 2:
                    comboTipoRevista.Enabled = true;
                    break;
                case 3:
                    dateTimePickerDef.Enabled = true;
                    comboUni.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void InhabilitarControles()
        {
            TxtAutor.Enabled = false;
            TxtCantPag.Enabled = false;
            TxtCodigo.Enabled = false;
            TxtTitulo.Enabled = false;
            dateTimePickerDef.Enabled = false;
            dateTimePickerIng.Enabled = false;
            comboTipoRevista.Enabled = false;
            comboUni.Enabled = false;

        }
        private bool ValidarDatos(int seleccion)
        {
            errorProvider1.Clear();
            var valido = true;

            if (comboPublicacion.SelectedIndex > 0)
            {
                if (string.IsNullOrEmpty(TxtAutor.Text))
                {
                    errorProvider1.SetError(TxtAutor, "Debe ingresar un Autor");
                    valido = false;
                }
                if (string.IsNullOrEmpty(TxtTitulo.Text))
                {
                    errorProvider1.SetError(TxtTitulo, "Debe ingresar un Título");
                    valido = false;
                }
                if (!ValidarCodigo(TxtCodigo.Text))
                {
                    errorProvider1.SetError(TxtCodigo, "Debe ingresar el Código con Formato MAT-XXXX");
                    valido = false;
                }
                if (dateTimePickerIng.Value > DateTime.Now)
                {
                    errorProvider1.SetError(dateTimePickerIng, "Debe ingresar una fecha anterior a la actual");
                    valido = false;
                }
            }
            if (dateTimePickerDef.Value > dateTimePickerIng.Value)
            {
                errorProvider1.SetError(dateTimePickerDef, "La fecha de defensa no puede ser mayor a la fecha de ingreso!!!");
                valido = false;
            }
            switch (seleccion)
            {
                case 0:
                    errorProvider1.SetError(comboPublicacion, "Debe seleccionar un Tipo de Publicación");
                    valido = false;
                    break;
                case 1:
                    if (!int.TryParse(TxtCantPag.Text, out int a))
                    {
                        errorProvider1.SetError(TxtCantPag, "Debe ingresar un Número Entero!!!");
                        valido = false;
                    }
                    else if (a < 0)
                    {
                        errorProvider1.SetError(TxtCantPag, "Debe ingresar un Número MAYOR A CERO!!!!");
                        valido = false;
                    }
                    break;
                case 2:
                    if (comboTipoRevista.SelectedItem is null)
                    {
                        errorProvider1.SetError(comboTipoRevista, "Debe seleccionar un Tipo de Publicación");
                        valido = false;
                    }
                    break;
                case 3:
                    if (dateTimePickerDef.Value > DateTime.Now)
                    {
                        errorProvider1.SetError(dateTimePickerDef, "Debe ingresar una fecha anterior a la actual");
                        valido = false;
                    }
                    if (comboUni.SelectedItem is null)
                    {
                        errorProvider1.SetError(comboUni, "Debe seleccionar un Tipo de Publicación");
                        valido = false;
                    }
                    break;
                default:
                    break;
            }
            return valido;
        }
        private bool ValidarCodigo(string text)
        {
            string patron = @"^MAT-\d{4}$";
            if (Regex.IsMatch(text, patron)) return true;
            return false;
        }
        internal void SetPublicacion(Publicacion publicacion)=> this.publicacion = publicacion;
    }
}
