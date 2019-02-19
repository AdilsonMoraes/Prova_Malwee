using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Malween.Dominio.Usuario.v1
{
    public class Usuario
    {
        public int Id { get; set; }
        [NotMapped]
        public string Token { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        
    }
}
