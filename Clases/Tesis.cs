using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clases
{
    public class Tesis : Publicacion
    {
        public Tesis(DateTime anioDefensa) : base(string.Empty, string.Empty, DateTime.MinValue, string.Empty, 0)
        {
            AnioDefensa = anioDefensa;
            int antiguedad = DateTime.Now.Year - AnioDefensa.Year;
            if (AnioDefensa.AddYears(antiguedad) > DateTime.Now)
            {
                antiguedad--;
            }
            Antiguedad = antiguedad;
            ValorReposicion = CalcularValorReposicion();
        }
        private readonly int Antiguedad;
        public enum Universidad
        {
            UP = 1,
            UCES,
            UBA
        }
        public Universidad universidad { get; set; }
        public DateTime AnioDefensa { get; set; }
        public Tesis(string titulo, string codigo, DateTime fechaIngreso, string autor, Universidad universidad, DateTime anioDefensa, decimal valorReposicion = 0)
            : base(titulo, codigo, fechaIngreso, autor, valorReposicion)
        {
            this.ValorReposicion = CalcularValorReposicion();
            this.universidad = universidad;
            AnioDefensa = anioDefensa;
            int antiguedad = DateTime.Now.Year - AnioDefensa.Year;
            if (AnioDefensa.AddYears(antiguedad) > DateTime.Now)
            {
                antiguedad--;
            }
            Antiguedad = antiguedad;
        }
        internal override decimal CalcularValorReposicion()
        {
            return 3000 + Antiguedad * 200;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}");
            sb.AppendLine($"Titulo.............: {Titulo}");
            sb.AppendLine($"Autor..............: {Autor}");
            sb.AppendLine($"Codigo.............: {Codigo}");
            sb.AppendLine($"Fecha de Ingreso...: {FechaIngreso.ToShortDateString()}");
            sb.AppendLine($"Universidad........: {universidad}");
            sb.AppendLine($"Año de Defensa.....: {AnioDefensa.ToShortDateString()}");
            sb.AppendLine($"Valor de Rep.......: ${ValorReposicion}");
            return sb.ToString();
        }
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (AnioDefensa > DateTime.Now) yield return new ValidationResult("El año de defensa no puede ser futuro!!!");

            foreach (var item in ValidateAtributosComun())
            {
                yield return item;
            }
        }
    }
}
