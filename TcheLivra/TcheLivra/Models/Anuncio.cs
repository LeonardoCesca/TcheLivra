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
        
        [Display(Name = "Data")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Data { get; set; }


        [StringLength(60, MinimumLength = 3)]
        public string Director { get; set; }
        
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }

        [Display(Name = "Upload image")]
        public byte[] ImageFile { get; set; }
        public string ImageMimeType { get; set; }

        [Display(Name = "Image link")]
        [DataType(DataType.ImageUrl)]
        public String ImageUrl { get; set; }        
    }
}