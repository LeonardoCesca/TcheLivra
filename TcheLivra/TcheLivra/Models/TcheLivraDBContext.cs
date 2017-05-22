using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TcheLivra.Models
{
    public class TcheLivraDBContext : DbContext
    {
        public TcheLivraDBContext() : base("TcheLivraDbContext")
 {
        }
        public DbSet<Anuncio> Anuncio { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}