using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Helper
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<A>(List<A> lista, DataGridView dgv) where A : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(r, dgv);
            }
        }

        private static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Libro libro:
                    r.Cells[0].Value = typeof(Libro).Name.ToString();
                    r.Cells[1].Value = libro.Codigo;
                    r.Cells[2].Value = libro.Titulo;
                    r.Cells[3].Value = libro.Autor;
                    r.Cells[4].Value = libro.FechaIngreso.ToShortDateString();
                    r.Cells[5].Value = libro.ValorReposicion;
                    r.Cells[6].Value = libro.CantPaginas;
                    break;
                case Revista revista:
                    r.Cells[0].Value = typeof(Revista).Name.ToString();
                    r.Cells[1].Value = revista.Codigo;
                    r.Cells[2].Value = revista.Titulo;
                    r.Cells[3].Value = revista.Autor;
                    r.Cells[4].Value = revista.FechaIngreso.ToShortDateString();
                    r.Cells[5].Value = revista.ValorReposicion;
                    r.Cells[7].Value = revista.TipoRevista;
                    break;
                case Tesis tesis:
                    r.Cells[0].Value = typeof(Tesis).Name.ToString();
                    r.Cells[1].Value = tesis.Codigo;
                    r.Cells[2].Value = tesis.Titulo;
                    r.Cells[3].Value = tesis.Autor;
                    r.Cells[4].Value = tesis.FechaIngreso.ToShortDateString();
                    r.Cells[5].Value = tesis.ValorReposicion;
                    r.Cells[8].Value = tesis.universidad;
                    r.Cells[9].Value = tesis.AnioDefensa.ToShortDateString();
                    break;

            }
            r.Tag = obj;
        }

        public static void AgregarFila(DataGridView dgvDatos, DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        internal static void QuitarFila(DataGridViewRow r, DataGridView dgvDatos)
        {
            dgvDatos.Rows.Remove(r);
        }
    }
}

