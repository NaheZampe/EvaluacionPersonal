using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clases
{
    public class Revista : Publicacion
    {
        public Revista() : base(string.Empty, string.Empty, DateTime.MinValue, string.Empty, 0)
        {
            ValorReposicion = CalcularValorReposicion();
        }
        public enum TipoDeRevista
        {
            Deportiva = 1,
            Moda,
            Chistes,
            Autos,
            Anime
        }
        public TipoDeRevista TipoRevista { get; set; }
        public Revista(string titulo, string codigo, DateTime fechaIngreso, string autor, TipoDeRevista tipoRevista, decimal valorReposicion = 0) : base(titulo, codigo, fechaIngreso, autor, valorReposicion)
        {
            TipoRevista = tipoRevista;
            this.ValorReposicion = CalcularValorReposicion();
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}");
            sb.AppendLine($"Titulo.............: {Titulo}");
            sb.AppendLine($"Autor..............: {Autor}");
            sb.AppendLine($"Codigo.............: {Codigo}");
            sb.AppendLine($"Fecha de Ingreso...: {FechaIngreso.ToShortDateString()}");
            sb.AppendLine($"Tipo de Revista....: {TipoRevista}");
            sb.AppendLine($"Valor de Rep.......: ${ValorReposicion}");
            return sb.ToString();
        }
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var item in ValidateAtributosComun())
            {
                yield return item;
            }
        }

        internal override decimal CalcularValorReposicion()
        {
            return 1000;
        }
    }
}
