using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Helpers
{
    public static class ComboHelper
    {
        public static void CargarComboPublicaciones(ComboBox cbo )
        {
            List<string> tipos = new List<string> { "Seleccione Un Tipo de Publicación", "Libro", "Revista", "Tesis" };
            cbo.DataSource = tipos;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboTipoRevista(ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(Revista.TipoDeRevista)).Cast<Revista.TipoDeRevista>().ToList();
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboUniversidad(ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(Tesis.Universidad)).Cast<Tesis.Universidad>().ToList();
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = 0;
        }
    }
}
