using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HeathClinicWebApi.Domains
{
    public partial class ClinicaDomain
    {
        [Table(nameof(Clinica))]
        public class Clinica
        {
            [Key]
            public Guid IdClinica { get; set; } = Guid.NewGuid();

            [Column(TypeName ="VARCHAR (20)")]
            [Required(ErrorMessage = "Nome Fantasia obrigatório!")]
            public string? NomeFantasia { get; set; }

            [Column(TypeName = "VARCHAR (100)")]
            [Required(ErrorMessage = "Razao social obrigatória!")]
            public string? RazaoSocial { get; set; }


            [Column(TypeName = "VARCHAR (100)")]
            [Required (ErrorMessage = "Endereço obrigatório!")]
            public string? Endereco { get; set; }

            [Column(TypeName = "CHAR (14)")]
            [Required(ErrorMessage = "CNPJ obrigatório!")]
            public string? CNPJ { get; set; }

            [Column(TypeName = "TIME")]
            [Required(ErrorMessage = "Horario de abertura obrigatório!")]
            public TimeOnly? HorarioAbertura { get; set; }
            

            [Column(TypeName = "TIME")]
            [Required(ErrorMessage = " Horario de fechamento obrigatório!")]
            public TimeOnly? HorarioFechamento { get; set; }

            [Column (TypeName = "VARCHAR (100")]
            [Required(ErrorMessage = "Descrição da clinica obrigatória!")]
            public string? DescricaoClinica { get; set; }
        }
    }
}

