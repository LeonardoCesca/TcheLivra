using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TcheLivra.Models
{
    public class Anuncio
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        public int ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }

        [Display(Name = "Inserir foto")]
        public byte[] ImageFile { get; set; }
        public string ImageMimeType { get; set; }
        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}