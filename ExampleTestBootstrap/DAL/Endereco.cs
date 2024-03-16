using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleTestBootstrap.DAL
{
    [Table("Enderecoes")]
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string logradouro { get; set; }

        [Required]
        [Display(Name = "Nº")]
        public int numero { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Required]
        [Display(Name = "CEP")]
        public string cep { get; set; }
    }
}