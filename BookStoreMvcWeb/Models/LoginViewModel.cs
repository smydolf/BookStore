using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BookStoreMvcWeb.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="Nazwa użytkownika")]
        public string UserName { get; set; }

        [Required]
        [Display(Name="Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
