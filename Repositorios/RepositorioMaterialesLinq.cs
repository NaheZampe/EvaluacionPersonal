using Clases;
using System.Linq;

namespace Repositorios
{
    public class RepositorioMaterialesLinq
    {
        private List<Publicacion> publicaciones = new();
        public static RepositorioMaterialesLinq? instancia = null;
        public static RepositorioMaterialesLinq GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new RepositorioMaterialesLinq();
            }
            return instancia;
        }
        public List<Publicacion> GetPorFechaIngreso()
        {
            return publicaciones.OrderBy(p=>p.FechaIngreso).ToList();
        }
        public List<Publicacion> GetPorVRMayorA(decimal valor)
        {
            return publicaciones.Where(p => p.ValorReposicion > valor).ToList();
        }
        private void CargarLista()
        {
            var FI = new DateTime(2020, 6, 20);
            var FI2 = new DateTime(2021, 6, 20);
            var libro = new Libro("Pinocho", "MAT-0000", FI2, "Carlo Collodi", 282);
            var revista = new Revista("AAA", "MAT-0002", FI2, "Carlo Collodi", Revista.TipoDeRevista.Deportiva);
            var tesis = new Tesis("Combustión Espontanea", "MAT-0001", FI2, "Joseph Jacobs",Tesis.Universidad.UBA,FI);
            publicaciones.Add(libro);
            publicaciones.Add(revista);
            publicaciones.Add(tesis);
        }
        public Publicacion? this[string codigo]
        {
            get
            {
                return publicaciones.FirstOrDefault(p => p.Codigo == codigo);
            }
        }
        public List<Publicacion> GetPublicaciones()
        {
            return publicaciones.OrderBy(p=>p.Codigo).ToList();
        }
        private RepositorioMaterialesLinq()
        {
            CargarLista();
        }
        public List<Publicacion> BuscarPorTitulo(string titulo)
        {
            return publicaciones.FindAll(p => p.Titulo == titulo)!.ToList();
        }
        public void Agregar(Publicacion publicacion)
        {    
            publicaciones.Add(publicacion);   
        }
        public void Borrar(Publicacion publicacion)
        {
            publicaciones.Remove(publicacion);
        }
        public List<Publicacion> GetPorTipo(string tipo) => publicaciones.Where(p => p.GetType().Name == tipo).ToList();
        

        
    }
}
