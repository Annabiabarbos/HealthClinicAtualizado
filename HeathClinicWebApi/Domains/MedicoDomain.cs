using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HeathClinicWebApi.Domains
{
    public class MedicoDomain
    {
        [Table(nameof(Medico))]

        public class Medico
        {
            [Key]

            public Guid IdUsuario { get; set; } = Guid.NewGuid();

            [Column(TypeName ="CHAR(6)"))]
            [Required(ErrorMessage ="CRM obrigatorio!")]
            public string CRM { get; set; }

            [Column(TypeName = "CHAR (11)")]
            [Required(ErrorMessage ="Contato obrigatorio")]
            public string Contato { get; set; }
        }
  

        public string CRM { get; set; }

        public string Contato { get; set; } 

        public string NomeMedico { get; set;}

    }
}
