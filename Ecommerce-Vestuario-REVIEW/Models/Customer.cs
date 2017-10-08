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
		public bool InscritroNewletter { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

		public MembershipType MembershipType { get; set; } //Propriedade de navegação
		public byte MembershipTypeId { get; set; } //Chave estrangeira
    }
}