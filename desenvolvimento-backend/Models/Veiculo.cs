using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desenvolvimento_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Informe o ano de fabricação")]
        public int AnoFacricacao { get; set; }

        [Required(ErrorMessage = "Informe o ano do modelo")]
        public int AnoModelo { get; set; }

    }
}
