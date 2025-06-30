using Clases;
using Repositorios;
using WindowsForms.Helper;

namespace WindowsForms
{
    public partial class FrmPrincipal : Form
    {
        private List<Publicacion> publicaciones;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PedirLista();
            GridHelper.MostrarDatosEnGrilla(publicaciones, DgvDatos);
        }
        private void PedirLista()
        {
            publicaciones = RepositorioMaterialesLinq.GetInstancia().GetPublicaciones();
        }
        private void tBtnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new FrmPublicacionesAE() { Text = "Nueva Publicación" };
            DialogResult = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;
            var publicacion = frm.GetPublicacion();
            if (RepositorioMaterialesLinq.GetInstancia()[publicacion.Codigo] is null)
            {
                RepositorioMaterialesLinq.GetInstancia().Agregar(publicacion);
                MessageBox.Show("Registro agregado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PedirLista();
                GridHelper.MostrarDatosEnGrilla(publicaciones, DgvDatos);
            }
            else
            {
                MessageBox.Show("Registro Existente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtbBorrar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            DataGridViewRow r = DgvDatos.SelectedRows[0];
            Publicacion? publicacion = r.Tag as Publicacion;
            if (publicacion is null) return;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el registro {publicacion}?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                RepositorioMaterialesLinq.GetInstancia().Borrar(publicacion);
                GridHelper.QuitarFila(r, DgvDatos);
                MessageBox.Show("Registro Eliminado", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0) return;
            DataGridViewRow r = DgvDatos.SelectedRows[0];
            Publicacion? publicacion = r.Tag as Publicacion;
            if (publicacion is null) return;

            var frm = new FrmPublicacionesAE() { Text = "Editar Publicación" };
            frm.SetPublicacion(publicacion);
            DialogResult = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;

            PedirLista();
            MessageBox.Show("Registro Editado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridHelper.MostrarDatosEnGrilla(publicaciones, DgvDatos);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tipoPublicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmFiltro() { Text = "Filtrar por Tipo" };
            DialogResult = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;
            string type = frm.GetTipo();
            var publicacionesFiltrada = RepositorioMaterialesLinq.GetInstancia().GetPorTipo(type);
            GridHelper.MostrarDatosEnGrilla(publicacionesFiltrada, DgvDatos);
            splBtnFiltrar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PedirLista();
            GridHelper.MostrarDatosEnGrilla(publicaciones, DgvDatos);
            splBtnFiltrar.Enabled=true;
        }

        private void tituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmFiltro() { Text = "Filtrar por Titulo" };

            DialogResult = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;
            var texto = frm.GetTexto();
            var pubFiltradas = RepositorioMaterialesLinq.GetInstancia().BuscarPorTitulo(texto);
            GridHelper.MostrarDatosEnGrilla(pubFiltradas, DgvDatos);
            splBtnFiltrar .Enabled = false;
        }

        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmFiltro() { Text = "Filtrar por Codigo" };

            DialogResult = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;
            var texto = frm.GetTexto();
            var pubFiltrada = RepositorioMaterialesLinq.GetInstancia()[texto];
            GridHelper.LimpiarGrilla(DgvDatos);
            var r = GridHelper.ConstruirFila(DgvDatos);
            GridHelper.SetearFila(r, pubFiltrada!);
            GridHelper.AgregarFila(DgvDatos, r);
            splBtnFiltrar.Enabled = false;
        }
    }
}
