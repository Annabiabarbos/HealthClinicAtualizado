using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static HeathClinicWebApi.Domains.TiposUsuarioDomain;
using System.Diagnostics.Contracts;

namespace HeathClinicWebApi.Domains
{
    public class PacienteDomain
    {
        [Table(nameof(Paciente))]
        public class Paciente
        {
            [Key]
            public Guid? IdPaciente { get; set; } = Guid.NewGuid();

            [Column(TypeName = "CHAR(14)")]
            [Required(ErrorMessage = "CPF obrigatorio!")]
            public string? CPF { get; set; }

            [Column(TypeName = "VARCHAR(14)")]
            [Required(ErrorMessage = "Endereco obrigatorio!")]
            public string? Endereco { get; set; }

            [Column(TypeName = "CHAR(11)")]
            [Required(ErrorMessage = "Telefone obrigatorio!")]
            public string? Telefone { get; set; }

            [Required(ErrorMessage = "Informar o usuario!")]
            public Guid? IdUsuario { get; set; }

            [ForeignKey(nameof(IdUsuario))]
            public UsuarioDomain? Usuario { get; set; }
        }
    }
}