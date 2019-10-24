using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_second.Models
{
    
    public class Phone
    {   
        
        public int Id { get; set; }
        [Display(Name="Категория")]
        [MaxLength(20)]
        public string Category { get; set; }

        [Display(Name = "Наименование")]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Производитель")]
        [MaxLength(50)]
        public string Company { get; set; }

        [Display(Name = "Цена")]
        [Range(1000,200000)]
        public int Price { get; set; }
    }



}
