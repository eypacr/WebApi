using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public abstract record BookDtoForManipulation
    {
        [Required(ErrorMessage = "Başlık zorunlu bir alandır.")]
        [MinLength(2, ErrorMessage = "Başlık en az 2 karakterden oluşmalıdır")]
        [MaxLength(50, ErrorMessage = "Başlık en fazla 50 karakterden oluşmalıdır")]
        public String Title { get; init; }

        [Required(ErrorMessage = "Fiyat zorunlu bir alandır.")]
        [Range(10,1000)]
        public decimal Price { get; init; }
    }
}
