using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_Vestuario_REVIEW.Models
{
    public class Accessories
    {
        public int Id { get; set; }
        public String UrlImagem { get; set; }
        public String Nome { get; set; }
        public String Cor { get; set; }
        public Double Preco { get; set; }
    }
}