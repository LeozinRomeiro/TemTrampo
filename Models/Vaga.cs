using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TemTrampo.Models
{
    public class Vaga
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Requisito { get; set; }
        public string Desejavel { get; set; }
        public string Beneficios { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        public string Escolaridade { get; set; }
        public string Empresa { get; set; }
    }
}
