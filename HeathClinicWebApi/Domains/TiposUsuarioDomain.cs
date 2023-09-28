using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HeathClinicWebApi.Domains
{
    public  partial class TiposUsuarioDomain
    {
        [Table(nameof(TiposUsuario))]
        public class TiposUsuario
        {
            [Key]
            public Guid? IdTipoUsuario { get; set; } = Guid.NewGuid();

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "Titulo do tipo usuário obrigatório!")]
            public string? TituloTipoUsuario { get; set; }
        }
    }
}
