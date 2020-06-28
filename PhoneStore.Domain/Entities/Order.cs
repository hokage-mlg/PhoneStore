using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneStore.Domain.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "PhoneId")]
        public int PhoneId { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Display(Name = "UserId")]
        public int UserId { get; set; }
        [Display(Name = "DeliveryId")]
        public int DeliveryId { get; set; }
        [Display(Name = "DeliveryStatus")]
        public string DeliveryStatus { get; set; }
        public Phone Phone { get; set; }
        public User User { get; set; }
        public DeliveryDetails DeliveryDetails { get; set; }
    }
}
