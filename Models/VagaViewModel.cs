using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TemTrampo.Models
{
    public class VagaViewModel
    {
        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(100, ErrorMessage = "O título não pode exceder 100 caracteres.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(1000, ErrorMessage = "A descrição não pode exceder 1000 caracteres.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O requisito é obrigatório.")]
        [StringLength(500, ErrorMessage = "O requisito não pode exceder 500 caracteres.")]
        public string? Requisito { get; set; }

        [StringLength(500, ErrorMessage = "O desejável não pode exceder 500 caracteres.")]
        public string? Desejavel { get; set; }

        [StringLength(500, ErrorMessage = "Os benefícios não podem exceder 500 caracteres.")]
        public string? Beneficios { get; set; }

        [Phone(ErrorMessage = "O número de telefone é inválido.")]
        [StringLength(20, ErrorMessage = "O número de telefone não pode exceder 20 caracteres.")]
        public string? Numero { get; set; }

        [EmailAddress(ErrorMessage = "O email é inválido.")]
        [StringLength(100, ErrorMessage = "O email não pode exceder 100 caracteres.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A escolaridade é obrigatória.")]
        [StringLength(50, ErrorMessage = "A escolaridade não pode exceder 50 caracteres.")]
        public string? Escolaridade { get; set; }

        [Required(ErrorMessage = "O nome da empresa é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome da empresa não pode exceder 100 caracteres.")]
        public string? Empresa { get; set; }

    }
}
