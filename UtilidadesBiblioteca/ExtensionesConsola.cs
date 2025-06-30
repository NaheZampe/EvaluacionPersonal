using System.Text.RegularExpressions;

namespace UtilidadesBiblioteca
{
    public static class ExtencionesConsola
    {
        /// <summary>
        /// Método estático para devolver un string
        /// </summary>
        /// <param name="mensajePantalla">Mensaje para solicitar el ingreso</param>
        /// <param name="esRequerido">Parametro opcional para establecer si el requerido o no</param>
        /// <returns>El texto pertinente</returns>
        public static string PedirString(string mensajePantalla, bool esRequerido = true)
        {
            string? texto;
            do
            {
                Console.Write(mensajePantalla);
                texto = Console.ReadLine();
                if (!string.IsNullOrEmpty(texto) && esRequerido)
                {
                    return texto;
                }
                Console.WriteLine("El dato es requerido...Reintentar");
                Console.ReadLine();
            } while (true);

        }
        /// <summary>
        /// Método estático para pedir un entero entre dos extremos
        /// </summary>
        /// <param name="mensaje">Mensaje en Pantalla</param>
        /// <param name="min">Valor mínimo del entero</param>
        /// <param name="max">Valor máximo del entero</param>
        /// <returns>El entero resultante</returns>
        public static int PedirEntero(string mensaje, int min = int.MinValue,
            int max = int.MaxValue)
        {
            string? textoEntero;
            do
            {
                textoEntero = PedirString(mensaje);
                if (int.TryParse(textoEntero, out int entero)
                    && entero >= min && entero <= max)
                {
                    return entero;
                }
                Console.WriteLine("No válido o fuera del rango permitido...Reintentar");
                Console.ReadLine();
            } while (true);

        }
        public static decimal PedirDecimal(string mensaje, decimal min = decimal.MinValue,
            decimal max = decimal.MaxValue)
        {
            string? textoDecimal;
            do
            {
                textoDecimal = PedirString(mensaje);
                if (decimal.TryParse(textoDecimal, out decimal Decimal)
                    && Decimal >= min && Decimal <= max)
                {
                    return Decimal;
                }
                Console.WriteLine("No válido o fuera del rango permitido...Reintentar");
                Console.ReadLine();
            } while (true);

        }
        public static DateTime PedirFecha(string mensaje)
        {
            DateTime fecha;
            Console.Write(mensaje);

            while (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.Write("Fecha inválida. Ingrese nuevamente (formato válido: dd/mm/yyyy o yyyy-mm-dd): ");
            }

            return fecha;
        }
        public static string PedirCodigo(string mensaje)
        {
            string? codigo;
            do
            {
                codigo = PedirString(mensaje);
                string patron = @"^MAT-\d{4}$";


                if (Regex.IsMatch(codigo, patron))
                {
                    return codigo;
                }
                Console.WriteLine("Formato de codigo no válido... Reintentar");
                Console.ReadLine();
            } while (true);

        }
        public static TEnum PedirEnum<TEnum>(string mensaje) where TEnum : struct, Enum
        {
            TEnum resultado;
            string entrada;

            // Mostrar opciones válidas
            Console.WriteLine($"Opciones disponibles para {typeof(TEnum).Name}:");
            foreach (var nombre in Enum.GetNames(typeof(TEnum)))
            {
                Console.WriteLine($"{nombre}");
            }

            // Pedir hasta que sea válido
            do
            {
                Console.WriteLine(mensaje);
                entrada = Console.ReadLine();

                if (!Enum.TryParse(entrada, true, out resultado) || !Enum.IsDefined(typeof(TEnum), resultado))
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese una de las opciones mostradas.");
                }

            } while (!Enum.TryParse(entrada, true, out resultado) || !Enum.IsDefined(typeof(TEnum), resultado));

            return resultado;
        }

        public static bool ConfirmarDatos(string mensaje)
        {
            string respuesta;
            do
            {
                respuesta = PedirString(mensaje);
                if (respuesta.Trim().ToLower() == "s")
                {
                    return true;
                }
                else if (respuesta.Trim().ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Opción ingresada no válida!!!");
                }
            } while (true);

        }
        public static bool AgregarObjeto()
        {
            var salir = true;
            while (salir)
            {

                var eleccion = PedirString("¿Desea agregar otra Piramide Cuadrada? Y/N: ");
                if (eleccion.ToUpper() == "N")
                {
                    salir = false;

                }
                else if (eleccion.ToUpper() == "Y")
                {
                    salir = false;
                    return true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Error.... Debe de Ingresar N Ó Y");
                    Console.WriteLine();
                }
            }
            return false;
        }
    }
}
