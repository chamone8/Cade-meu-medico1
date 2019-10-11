using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(EspercialidadeMetadado))]
    public partial class Especialidades
    {

    }
    public class EspercialidadeMetadado
    {
        [Required(ErrorMessage ="Obrigatorio digitar o nome")]
        [StringLength(80,ErrorMessage ="O maximo de caracteres a ser digitado é 80")]
        public string Nome { get; set; }
    }
}