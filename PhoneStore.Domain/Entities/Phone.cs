using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneStore.Domain.Entities
{
    [Table("Phones")]
    public class Phone
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Brand")]
        [Required(ErrorMessage = "Please, enter phone brand.")]
        public string Brand { get; set; }
        [Display(Name = "Model")]
        [Required(ErrorMessage = "Please, enter phone model.")]
        public string Model { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please, enter phone description.")]
        public string Description { get; set; }
        [Display(Name = "Memory")]
        [Required(ErrorMessage = "Please, enter phone memory.")]
        public int Memory { get; set; }
        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Please, enter phone quantity.")]
        public int Quantity { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please, enter phone price.")]
        public int Price { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
