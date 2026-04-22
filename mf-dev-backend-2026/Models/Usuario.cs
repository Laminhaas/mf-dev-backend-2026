using System.ComponentModel.DataAnnotations;

namespace mf_dev_backend_2026.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome de usuário é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório!")]
        public string Senha { get; set; }
        [DataType(DataType.Password)]

        [Required(ErrorMessage = "Tipo de perfil é obrigatório!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
