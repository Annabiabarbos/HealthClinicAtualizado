using HeathClinicWebApi.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace HeathClinicWebApi.Context
{
    public  class HealthContext : DbContext
    {
      
        public DbSet<TiposUsuario> TiposUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }    

        public DbSet<Paciente> Paciente { get; set; }   

        public DbSet<Medico> Medico { get; set; }

        public DbSet<Especialidade> Especialidade { get; set; }

        public DbSet<Consulta> Consulta { get; set; }

        public DbSet<Comentarios> Comentario { get; set; }

        public DbSet<Clinica> Clinica { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE05-S14; Database=Health_Clinic_manha_; user Id=sa; pwd=Senai@134; TrustServerCertificate=true;");



            base.OnConfiguring(optionsBuilder);
        }
    }


}

