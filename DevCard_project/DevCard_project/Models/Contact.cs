using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_project.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="Ce champs est obligatoir")]
        [MinLength(3, ErrorMessage ="Minimume caracter autorisé est 3")]
        [MaxLength(100, ErrorMessage = "Miximume caracter autorisé est 100")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Ce champs est obligatoir")]
        [EmailAddress(ErrorMessage ="Le format d'email n'est pas valid")]
        public string Email { get; set; }
        public string Message { get; set; }
        public int Service { get; set; }
        public SelectList Services { get; set; }

    }
}
