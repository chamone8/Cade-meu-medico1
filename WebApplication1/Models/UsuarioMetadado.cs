using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuarios
    {

    }
    public class UsuarioMetadado
    {
        
        public long IDUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatorio o Nome do Usuario")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatorio o Login do Usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Obrigatorio a senha do Usuario")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Obrigatorio o Email do Usuario")]
        public string Email { get; set; }
    }
}