using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneStore.Domain.Entities
{
    [Table("DeliveryDetails")]
    public class DeliveryDetails
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please, enter your full name.")]
        public string FullName { get; set; }
        [Display(Name = "Postcode")]
        [Required(ErrorMessage = "Please, enter your postcode.")]
        public string Postcode { get; set; }
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please, enter your country.")]
        public string Country { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "Please, enter your сity.")]
        public string City { get; set; }
        [Display(Name = "Street")]
        [Required(ErrorMessage = "Please, enter your street.")]
        public string Street { get; set; }
        [Display(Name = "Building")]
        [Required(ErrorMessage = "Please, enter your building number.")]
        public string Building { get; set; }
        [Display(Name = "Apartment number")]
        [Required(ErrorMessage = "Please, enter your apartment number.")]
        public string ApartmentNum { get; set; }
        [Display(Name = "Gift wrap")]
        public bool GiftWrap { get; set; }
        [Display(Name = "Payment type")]
        [Required(ErrorMessage = "Please, enter your payment type.")]
        public string Payment { get; set; }
    }
}
