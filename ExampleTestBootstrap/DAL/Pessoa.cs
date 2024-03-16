using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTestBootstrap.DAL
{
    [Table("Pessoa")]
    public class Pessoa
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome completo")]
        public string nome { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string cpf { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public int telefone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Endereço Relacionado")]
        [ForeignKey("Endereco_Id")]
        public virtual Endereco endereco { get; set; }

        public int Endereco_Id { get; set; }
    }
}
