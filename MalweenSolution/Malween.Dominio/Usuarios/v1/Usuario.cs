using Malween.Dominio.Fornecedores.v1;
using System.ComponentModel.DataAnnotations.Schema;

namespace Malween.Dominio.Usuarios.v1
{
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [NotMapped]
        public string Token { get; set; }

        public string Email { get; set; }

        public string Nome { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

    }
}
