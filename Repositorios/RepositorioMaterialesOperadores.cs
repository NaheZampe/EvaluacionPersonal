using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioMaterialesOperadores
    {
        private static List<Publicacion> publicaciones = new();
        public static RepositorioMaterialesOperadores? instancia = null;
        public List<Publicacion> GetPublicaciones()
        {
            return publicaciones;
        }
        private RepositorioMaterialesOperadores()
        {
            CargarLista();
        }
        public static RepositorioMaterialesOperadores GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new RepositorioMaterialesOperadores();
            }
            return instancia;
        }
        public Publicacion? this[string codigo]
        {
            get
            {
                return publicaciones.FirstOrDefault(p => p.Codigo == codigo);
            }
        }
        public List<Publicacion> GetXTitulo(string titulo)=> publicaciones.Where(p => p.Titulo == titulo).ToList();
        public Publicacion this[int index]
        {
            get => RepositorioMaterialesLinq.GetInstancia().GetPublicaciones()[index];
            set => RepositorioMaterialesLinq.GetInstancia().GetPublicaciones()[index] = value;
        }
        public static bool operator + (Publicacion publicacion, RepositorioMaterialesOperadores repo)
        {
            if (publicacion != repo)
            {
                publicaciones.Add(publicacion);
                return true;
            }
            else
            {
                Publicacion? pubEnRepo = repo[publicacion.Codigo];
                if (pubEnRepo is not null && pubEnRepo.GetType() == publicacion.GetType())
                {
                    if (pubEnRepo is Libro l)
                    {
                        l.Autor = publicacion.Autor;
                        l.Titulo = publicacion.Titulo;
                        l.FechaIngreso = publicacion.FechaIngreso;
                        l.CantPaginas = ((Libro)publicacion).CantPaginas;
                        return true;
                    }

                    if (pubEnRepo is Revista r)
                    {
                        r.Autor = publicacion.Autor;
                        r.Titulo = publicacion.Titulo;
                        r.FechaIngreso = publicacion.FechaIngreso;
                        r.TipoRevista = ((Revista)publicacion).TipoRevista;
                        return true;
                    }

                    if (pubEnRepo is Tesis t)
                    {
                        t.Autor = publicacion.Autor;
                        t.Titulo = publicacion.Titulo;
                        t.FechaIngreso = publicacion.FechaIngreso;
                        t.AnioDefensa = ((Tesis)publicacion).AnioDefensa;
                        t.universidad = ((Tesis)publicacion).universidad;
                        return true;
                    }
                }
            }
                return false;
        }
        private void CargarLista()
        {
            var FI = new DateTime(2020, 6, 20);
            var FI2 = new DateTime(2021, 6, 20);
            var libro = new Libro("Pinocho", "MAT-0000", FI2, "Carlo Collodi", 282);
            var libro2 = new Libro("Pinocho", "MAT-0003", FI2, "Carlo Collodi", 282);
            var revista = new Revista("AAA", "MAT-0002", FI2, "Carlo Collodi", Revista.TipoDeRevista.Deportiva);
            var tesis = new Tesis("Combustión Espontanea", "MAT-0001", FI2, "Joseph Jacobs", Tesis.Universidad.UBA, FI);
            publicaciones.Add(libro);
            publicaciones.Add(revista);
            publicaciones.Add(tesis);
            publicaciones.Add(libro2);
        }
        public List<Publicacion> GetPorFechaIngreso()
        {
            return publicaciones.OrderBy(p => p.FechaIngreso).ToList();
        }
        public IEnumerable<object> GetPorVRMayorA(decimal valor)
        {
            return publicaciones.Where(p => p.ValorReposicion > valor).ToList();
        }
        public static bool operator - (Publicacion publicacion, RepositorioMaterialesOperadores repo)
        {
            if (publicacion == repo)
            {
                publicaciones.Remove(publicacion);
                return true;
            }
            return false;
        }
        public static bool operator == (Publicacion publicacion, RepositorioMaterialesOperadores repo)
        {
            if (repo[publicacion.Codigo] is null) 
            {
                return false;
            }
            else
            {
                return true;
            }     
        }
        public static bool operator != (Publicacion publicacion, RepositorioMaterialesOperadores repo)
        {
            return !(publicacion == repo);
        }
    }
}
