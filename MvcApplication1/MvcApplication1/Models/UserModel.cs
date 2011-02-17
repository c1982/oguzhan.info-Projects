using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class UserModel
    {
        [Display(Name = "Adınız")]
        [Required(ErrorMessage="Adınızı Girmediniz")]
        public string Name { get; set; }
    }
}