using System.ComponentModel.DataAnnotations;

namespace DVG_Filmes.View.Models
{
    public class Cliente
    {
        [Required(ErrorMessage ="Informe o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o Telefone")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe o CPF")]
        [StringLength(maximumLength:11, MinimumLength =11, ErrorMessage ="o CPF deve conter 11 caracteres")]
        public String CPF { get; set; }
        [Required(ErrorMessage = "Informe o Email")]
        public String Email { get; set; }

    }
}
