using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce_Vestuario_REVIEW.Models
{
    public class ValidateDataCadastro : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            TimeSpan intervalo = customer.DataCadastro.Value - customer.DataNascimento.Value;
            //int qtdAnos = intervalo.Days / 365;

            if(intervalo.Days < 0)
            new ValidationResult("A data de Cadastro não pode ser antes do Nascimento!");

            return ValidationResult.Success;
        }
    }
}