using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ControleDeVendas.Data.Models
{
    [Table("TentativasDeLogin")]
    public class TentativaDeLoginModel
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataTentativa { get; set; }

        public string ?IP {  get; set; }

        public int? Sucesso { get;  set; }
    }
}
