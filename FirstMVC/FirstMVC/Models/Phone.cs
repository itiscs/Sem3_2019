using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVC.Models
{
    [Display(Name ="Мобильные устройства")]
    public class Phone
    {
        public int Id { get; set; }
        [MaxLength(20)]
        [Display(Name="Категория")]
        public string Category { get; set; }

        [MaxLength(100)]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Производитель")]
        public string Company { get; set; }

        [Display(Name = "Цена")]
        [Range(1000,200000)]
        public decimal Price { get; set; }

    }
}
