using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStoreMvcWeb.Domain.Entities
{
    public class Product
    {

        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Pole Tytuł jest wymagane ")]
        [Display(Name = "Tytuł")]
        public string Name { get; set; }
        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Pole Autor jest wymagane ")]
        public string Author { get; set; }
        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Pole Opis jest wymagane ")]
        [UIHint("MultilineText")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Pole Kategoria jest wymagane ")]
        [Display(Name = "Kategoria")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Pole Cena jest wymagane ")]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
    }
}
