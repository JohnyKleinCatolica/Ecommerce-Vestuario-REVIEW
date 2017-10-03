using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Video_Locadora_ExemploMVC_REVIEW.Models
{
    public class Customer
    {
        String Nome { get; set; }
        String CPF { get; set; }
        DateTime DataNascimento { get; set; }
        DateTime DataCadastro { get; set; }
    }
}