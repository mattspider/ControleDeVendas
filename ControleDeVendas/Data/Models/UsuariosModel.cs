using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeVendas.Data.Models
{

    public enum Situacao
    {
        Ativo,
        Inativo
    }


    [Table("Usuarios")]
    public class UsuariosModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Login {  get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cargo { get; set; }

        [Required]
        public Situacao Situacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime CriadoEm { get; set; }

        public DateTime ?AtualizadoEm { get; set; }


    }
}
