using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneStore.Domain.Entities
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Role")]
        [Required(ErrorMessage = "Please, enter role name.")]
        public string Name { get; set; }
    }
}
