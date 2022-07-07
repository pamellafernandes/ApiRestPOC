using System;
using System.ComponentModel.DataAnnotations;

namespace AR.Domain
{
    public class Cliente
    {
        [Key]
        public Guid MyProperty { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} dever no máximo {1} caracteres")]
        public string Nome { get; set; }
        public double CPF { get; set; }
        public int Idade { get; set; }
    }
}
