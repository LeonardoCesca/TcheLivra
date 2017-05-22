using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TcheLivra.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public virtual ICollection<Anuncio> Anuncio { get; set; }

    }
}