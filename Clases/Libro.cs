using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clases
{
    public class Libro : Publicacion
    {
        public int CantPaginas { get; set; }
        public Libro(int cantPaginas) : base(string.Empty, string.Empty, DateTime.MinValue, string.Empty)
        {
            CantPaginas = cantPaginas;
            ValorReposicion = CalcularValorReposicion();
        }
        public Libro(string titulo, string codigo, DateTime fechaIngreso, string autor, int cantPaginas, decimal valorReposicion = 0) : base(titulo, codigo, fechaIngreso, autor, valorReposicion)
        {
            CantPaginas = cantPaginas;
            ValorReposicion = CalcularValorReposicion();
        }
        internal override decimal CalcularValorReposicion()
        {
            return CantPaginas * 10;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}");
            sb.AppendLine($"Titulo.............: {Titulo}");
            sb.AppendLine($"Autor..............: {Autor}");
            sb.AppendLine($"Codigo.............: {Codigo}");
            sb.AppendLine($"Fecha de Ingreso...: {FechaIngreso.ToShortDateString()}");
            sb.AppendLine($"Cantidad de Páginas: {CantPaginas}");
            sb.AppendLine($"Valor de Rep.......: ${ValorReposicion}");
            return sb.ToString();
        }
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CantPaginas <= 0) yield return new ValidationResult("La cantidad de páginas debe ser mayor que CERO!!!");

            foreach (var item in ValidateAtributosComun())
            {
                yield return item;
            }
        }
    }
}
