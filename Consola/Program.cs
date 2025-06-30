using Clases;
using Repositorios;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using UtilidadesBiblioteca;
using static System.Runtime.InteropServices.JavaScript.JSType;


internal class Program
{

    private static void Main(string[] args)
    {
        bool salir = true;
        var publicaciones = RepositorioMaterialesOperadores.GetInstancia().GetPublicaciones();
        //Variables de la clase base
        string titulo, autor, codigo;
        DateTime fecha;
        do
        {
            Console.WriteLine("Biblioteca");
            Console.WriteLine("1-Listado");
            Console.WriteLine("2-Buscar por Titulo");
            Console.WriteLine("3-Buscar por Antigüedad");
            Console.WriteLine("4-Buscar por Valor de Reposición mayor A");
            Console.WriteLine("5-Agregar");
            Console.WriteLine("6-Borrar");
            Console.WriteLine("7-Editar");
            Console.WriteLine("0-Salir");

            var opcion = ExtencionesConsola.PedirEntero("Escoja una opción (0-7): ");
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    GetPublicaciones(publicaciones);
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    do
                    {
                        titulo = ExtencionesConsola.PedirString("Ingrese el título a buscar: ");
                        if (string.IsNullOrWhiteSpace(titulo)) Console.WriteLine("El titulo no debe ser nulo");
                    } while (string.IsNullOrWhiteSpace(titulo));
                    Console.Clear();
                    BuscarXTitulo(titulo);
                    break;
                case 3:
                    Console.Clear();
                    BuscarXAnt();
                    break;
                case 4:
                    decimal valor = 0;
                    do
                    {
                        valor = ExtencionesConsola.PedirDecimal("Ingrese el Valor de Reposicion MAYOR QUE 0(CERO): ");
                    } while (valor < 0);
                    Console.Clear();
                    BuscarXValor(valor);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("1-Libro");
                    Console.WriteLine("2-Revista");
                    Console.WriteLine("3-Tesis");
                    var seleccion = ExtencionesConsola.PedirEntero("Selecione el tipo de publicacion: ");
                    Console.Clear();
                    AgregarPublicacion(seleccion, publicaciones);
                    break;
                case 6:
                    Console.Clear();
                    var codigoBorrar = ExtencionesConsola.PedirCodigo("Ingrese el Codigo que desea borrar: ");
                    var pBorrar = RepositorioMaterialesOperadores.GetInstancia()[codigoBorrar];
                    if (pBorrar is not null)
                    {
                        if (pBorrar - RepositorioMaterialesOperadores.GetInstancia())
                        {
                            Console.WriteLine("Publicacion Eliminada!!!");
                        }
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("El Registro no Existe!!!");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }

                    break;
                case 7:
                    Console.Clear();
                    //Variable del codigo de publicacion a editar
                    var codigoEditar = ExtencionesConsola.PedirCodigo("Ingrese el codigo de la Publicación a Editar: ");
                    //Variable de publicacion a editar
                    var pEditar = RepositorioMaterialesOperadores.GetInstancia()[codigoEditar];
                    if (pEditar is not null)
                    {
                        Console.WriteLine(pEditar);

                        int posicion = publicaciones.IndexOf(pEditar);

                        EditarPublicacion(pEditar);
                        Console.WriteLine("Oprima una tecla para continuar...");
                        Console.ReadKey();

                        Console.Clear();
                    }
                    else
                    {
                        Console.Write($"El código: {codigoEditar} no existe!!! Joder!!!");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;
                case 0:
                    salir = false;
                    break;
                default:
                    break;
            }
        } while (salir);

    }

    private static void EditarPublicacion(Publicacion pEditar)
    {
        //Variables para validar las Publicaciones
        ValidationContext context;
        List<ValidationResult> errors;
        bool result;

        //Variables de la clase base
        string titulo, autor;
        DateTime fecha;

        //Variable de publicacion editada;
        Publicacion? pEditada;
        switch (pEditar)
        {
            case Libro:
                PedirDatosPub(out titulo, out autor, out fecha);
                var paginas = ExtencionesConsola.PedirEntero("Ingrese la Cantidad de Paginas: ");
                pEditada = new Libro(titulo, pEditar.Codigo, fecha, autor, paginas);

                context = new ValidationContext(pEditada);
                errors = new List<ValidationResult>();
                result = Validator.TryValidateObject(pEditada, context, errors, true);
                if (result)
                {
                    Console.WriteLine(pEditada);
                    if (pEditada + RepositorioMaterialesOperadores.GetInstancia())
                    {
                        Console.WriteLine("Libro Editado!!!");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo Editar!!!");
                    }
                }
                else
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                break;

            case Tesis:
                PedirDatosPub(out titulo, out autor, out fecha);
                Tesis.Universidad universidad = ExtencionesConsola.PedirEnum<Tesis.Universidad>("Ingrese la Universidad: ");
                var fechaDefensa = ExtencionesConsola.PedirFecha("Ingrese la fecha de defensa: ");
                pEditada = new Tesis(titulo, pEditar.Codigo, fecha, autor, universidad, fechaDefensa);

                context = new ValidationContext(pEditada);
                errors = new List<ValidationResult>();
                result = Validator.TryValidateObject(pEditada, context, errors, true);

                if (result)
                {
                    Console.WriteLine(pEditada);
                    if (pEditada + RepositorioMaterialesOperadores.GetInstancia())
                    {
                        Console.WriteLine("Tesis Editada!!!");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo Editar!!!");
                    }
                }
                else
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                break;
            case Revista:

                PedirDatosPub(out titulo, out autor, out fecha);
                Revista.TipoDeRevista tipoDeRevista = ExtencionesConsola.PedirEnum<Revista.TipoDeRevista>("Ingrese El Tipo de Revista: ");
                pEditada = new Revista(titulo, pEditar.Codigo, fecha, autor, tipoDeRevista);

                context = new ValidationContext(pEditada);
                errors = new List<ValidationResult>();
                result = Validator.TryValidateObject(pEditada, context, errors, true);
                if (result)
                {
                    Console.WriteLine(pEditada);
                    if (pEditada + RepositorioMaterialesOperadores.GetInstancia())
                    {
                        Console.WriteLine("Revista Editada!!!");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo Editar!!!");
                    }
                }
                else
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                break;
            default:
                break;
        }
    }



    private static void AgregarPublicacion(int seleccion, List<Publicacion> publicaciones)
    {
        //Variables para validar las Publicaciones
        ValidationContext context;
        List<ValidationResult> errors;
        bool result;

        //Variables de la clase base
        string titulo, autor, codigo;
        DateTime fecha;
        switch (seleccion)
        {

            case 1:

                PedirDatosPub(out titulo, out autor, out fecha);
                codigo = PedirCodigo(publicaciones);
                var paginas = ExtencionesConsola.PedirEntero("Ingrese la Cantidad de Paginas: ");
                var libro = new Libro(titulo, codigo, fecha, autor, paginas);

                context = new ValidationContext(libro);
                errors = new List<ValidationResult>();
                result = Validator.TryValidateObject(libro, context, errors, true);
                if (result)
                {
                    Console.WriteLine(libro);
                    if (libro + RepositorioMaterialesOperadores.GetInstancia())
                    {
                        Console.WriteLine("Libro agregado!!!");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Registro Existente!!!");
                    }

                }
                else
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                break;
            case 2:
                PedirDatosPub(out titulo, out autor, out fecha);
                codigo = PedirCodigo(publicaciones);
                Revista.TipoDeRevista tipoDeRevista = ExtencionesConsola.PedirEnum<Revista.TipoDeRevista>("Ingrese El Tipo de Revista: ");

                Revista revista = new(titulo, codigo, fecha, autor, tipoDeRevista);
                context = new ValidationContext(revista);
                errors = new List<ValidationResult>();
                result = Validator.TryValidateObject(revista, context, errors, true);
                if (result)
                {
                    Console.WriteLine(revista);
                    if (revista + RepositorioMaterialesOperadores.GetInstancia())
                    {
                        Console.WriteLine("Revista agregada!!!");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Registro Existente!!!");
                    }
                }
                else
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                break;
            case 3:

                PedirDatosPub(out titulo, out autor, out fecha);
                codigo = PedirCodigo(publicaciones);
                Tesis.Universidad universidad = ExtencionesConsola.PedirEnum<Tesis.Universidad>("Ingrese la Universidad: ");
                var fechaDef = ExtencionesConsola.PedirFecha("Ingrese la fecha de Defensa con formato 'DD/MM/AAAA': ");
                var tesis = new Tesis(titulo, codigo, fecha, autor, universidad, fechaDef);

                context = new ValidationContext(tesis);
                errors = new List<ValidationResult>();
                result = Validator.TryValidateObject(tesis, context, errors, true);
                if (result)
                {
                    Console.WriteLine(tesis);
                    if (tesis + RepositorioMaterialesOperadores.GetInstancia())
                    {
                        Console.WriteLine("Tesis agregada!!!");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Registro Existente!!!");
                    }
                }
                else
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                break;


            default:
                break;
        }
    }

    private static string PedirCodigo(List<Publicacion> publicaciones)
    {
        string codigo;
        do
        {
            codigo = ExtencionesConsola.PedirCodigo("Ingrese el Codigo con formato 'MAT-XXXX': ");
            if (publicaciones.Any(p => p.Codigo == codigo))
            {
                Console.WriteLine($"Código '{codigo}' Existente!!!");
            }
        } while (publicaciones.Any(p => p.Codigo == codigo));
        return codigo;
    }

    private static void PedirDatosPub(out string titulo, out string autor, out DateTime fecha)
    {

        titulo = ExtencionesConsola.PedirString("Ingrese el Titulo: ");
        autor = ExtencionesConsola.PedirString("Ingrese el Autor: ");
        fecha = ExtencionesConsola.PedirFecha("Ingrese la fecha de ingreso con formato 'DD/MM/AAAA': ");
    }

    private static void BuscarXValor(decimal valor)
    {
        var buscarXValor = RepositorioMaterialesOperadores.GetInstancia().GetPorVRMayorA(valor);
        foreach (var pub in buscarXValor)
        {
            Console.WriteLine(pub);
        }
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }

    private static void BuscarXAnt()
    {
        var buscarXAnt = RepositorioMaterialesOperadores.GetInstancia().GetPorFechaIngreso();
        foreach (var pub in buscarXAnt)
        {
            Console.WriteLine(pub);
        }
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }

    private static void BuscarXTitulo(string titulo)
    {
        var publicacionesXTit = RepositorioMaterialesOperadores.GetInstancia().GetXTitulo(titulo);
        foreach (var pub in publicacionesXTit)
        {
            Console.WriteLine(pub);
        }
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void GetPublicaciones(List<Publicacion> publicaciones)
    {
        foreach (var publicacion in publicaciones)
        {
            Console.WriteLine(publicacion);
        }
    }
}