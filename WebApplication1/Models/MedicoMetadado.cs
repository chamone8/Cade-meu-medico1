using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(MedicoMetadado))]
    public partial class Medico
    {

    }
    public class MedicoMetadado
    {
        [Required(ErrorMessage = "Obrigatório Informar o CRM")]
        [StringLength(30, ErrorMessage = "O CRM deve possuir no máximo 30 caracteres")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        [StringLength(80, ErrorMessage = "O nome deve possuir no maximo 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatorio")]
        [StringLength(100, ErrorMessage = "O Endereço deve conter no maximo 100 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatorio o Bairro")]
        [StringLength(60,ErrorMessage ="O Bairro deve conter no maximo 60 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage ="Obrigatorio o email")]
        [StringLength(100,ErrorMessage ="O email deve conter no maximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Obrigado informar se atende o convenio")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar se tem a clinica ")]
        public bool TemClinica { get; set; }

        [StringLength(80,ErrorMessage ="O Web site deve conter no maximo 80 caracteres")]
        public string WebsiteBlog { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ID da Cidade")]        public int IDCidade { get; set; }
        [Required(ErrorMessage ="Obrigatorio informar o ID da especialidade")]
        public int IDEspecialidade { get; set; }




    }
}