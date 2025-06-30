using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Clases
{
    public abstract class Publicacion : IValidatableObject
    {
        public Publicacion(string titulo, string codigo, DateTime fechaIngreso, string autor, decimal valorReposicion = 0)
        {
            Titulo = titulo;
            Codigo = codigo;
            FechaIngreso = fechaIngreso;
            Autor = autor;
            ValorReposicion = valorReposicion;
        }

        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Autor { get; set; }
        public decimal ValorReposicion { get; protected set; }

        internal abstract decimal CalcularValorReposicion();

        public abstract override string ToString();

        public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
        public IEnumerable<ValidationResult> ValidateAtributosComun()
        {
            string patron = @"^MAT-\d{4}$"; //Definimos el Patrón de validación

            if (string.IsNullOrWhiteSpace(Codigo))//Preguntamos si el codigo es nulo ó esta conformado por espacios en blanco
            {
                yield return new ValidationResult("El código no puede estar vacío!!!");
            }
            else if (!Regex.IsMatch(Codigo, patron))//Preguntamos si el Código coincide con el Patron
            {
                yield return new ValidationResult("El código debe tener el formato MAT-XXXX (X = dígitos)");
            }

            if (string.IsNullOrWhiteSpace(Autor)) yield return new ValidationResult("El autor no puede estar vacio!!!");

            if (string.IsNullOrWhiteSpace(Titulo)) yield return new ValidationResult("El titulo no puede estar vacio!!!");

            if (FechaIngreso > DateTime.Today) yield return new ValidationResult("La fecha no puede ser mayor a la fecha actual!!!");
        }
    }
}
