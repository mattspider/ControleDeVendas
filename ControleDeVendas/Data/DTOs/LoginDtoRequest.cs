using System.ComponentModel.DataAnnotations;

namespace ControleDeVendas.Data.DTOs
{
    public class LoginDtoRequest
    {
        [Required]
        public string usuario { get; set; }
        [Required]
        public string senha { get; set; }
    }
}
