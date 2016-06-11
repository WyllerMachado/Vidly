using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }  // Primary key

        [Required]  // Not null
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime? Birthdate { get; set; }


        [Display(Name = "Receber emails promocionais?")]
        public bool IsSubscribedToNewsletter { get; set; }


        public MembershipType MembershipType { get; set; }  // Navigation Property


        [Display(Name = "Plano")]
        public byte MembershipTypeId { get; set; }  // Foreign Key
    }
}