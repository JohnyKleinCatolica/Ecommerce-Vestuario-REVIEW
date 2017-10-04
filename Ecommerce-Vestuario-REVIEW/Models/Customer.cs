using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_Vestuario_REVIEW.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}