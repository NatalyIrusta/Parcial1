
namespace Examen1.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext

    {
        public DataContext() : base("DafaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Examen1.Models.Persona> Personas { get; set; }
    }
}
