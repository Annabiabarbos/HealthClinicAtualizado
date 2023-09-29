using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HeathClinicWebApi.Domains
{
    [Table(nameof(Comentarios))]
    public class Comentarios
    {        
            [Key]

            public Guid? IdComentarios { get; set; } = Guid.NewGuid();

            [Column(TypeName = "VARCHAR(100)" )]
            public string? FeedBack { get; set;}

        
    }
}
