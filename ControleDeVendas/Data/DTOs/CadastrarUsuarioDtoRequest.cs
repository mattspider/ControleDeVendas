using System.ComponentModel.DataAnnotations;

namespace ControleDeVendas.Data.DTOs
{
    public class CadastrarUsuarioDtoRequest
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cargo { get; set; }


    }
}
