using System.ComponentModel.DataAnnotations.Schema;

namespace Malween.Dominio.Login.v1
{
    public class UsuarioLogin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool IsAdministrator { get; set; }
        public string TokenAuth { get; set; }
    }
}
