using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static HeathClinicWebApi.Domains.TiposUsuarioDomain;
using static HeathClinicWebApi.Domains.ClinicaDomain;

namespace HeathClinicWebApi.Domains
{
    public class MedicoDomain
    {
        [Table(nameof(Medico))]

        public class Medico
        {
            [Key]

            public Guid? IdMedico { get; set; } = Guid.NewGuid();

            [Column(TypeName = "CHAR(6)")]
            [Required(ErrorMessage = "CRM obrigatorio!")]
            public string? CRM { get; set; }

            [Column(TypeName = "CHAR (11)")]
            [Required(ErrorMessage = "Contato obrigatorio!")]
            public string? Contato { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "Nome do medico obrigatorio!")]
            public string? NomeMedico { get; set; }

            [Required(ErrorMessage = "Clinica obrigatoria!")]
            public Guid? IdClinica { get; set; }

            [ForeignKey(nameof(IdClinica))]
            public ClinicaDomain? Clinica { get; set; }

            [Required(ErrorMessage = "Especialidade obrigatoria!")]
            public Guid? IdEspecialidade { get; set; }

            [ForeignKey(nameof(IdEspecialidade))]
            public EspecialidadeDomain? Especialidade { get; set; }

            [Required(ErrorMessage = "Informar o usuario!")]
            public Guid IdUsuario { get; set; }

            [ForeignKey(nameof(IdUsuario))]
            public UsuarioDomain? Usuario { get; set; }
        }
    }
}

