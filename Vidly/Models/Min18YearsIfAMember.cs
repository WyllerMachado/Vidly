using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Desconhecido || customer.MembershipTypeId == MembershipType.PagueComoUsar)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("A Data de Nascimento é necessária.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return age >= 18
                ? ValidationResult.Success
                : new ValidationResult("Você precisa ter pelo menos 18 anos para assinar um plano.");
        }
    }
}