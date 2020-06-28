using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneStore.Domain.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Please, enter your email address.")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please, enter your password.")]
        public string Password { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telephone number")]
        [Required(ErrorMessage = "Please, enter your telephone number.")]
        public string TelephoneNumber { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please, enter your name.")]
        public string Name { get; set; }
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Please, enter your age.")]
        public int Age { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
