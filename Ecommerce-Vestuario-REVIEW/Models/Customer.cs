using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce_Vestuario_REVIEW.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Nome { get; set; }
        [Required]
        [StringLength(11)]
        public String CPF { get; set; }
		public bool InscritroNewletter { get; set; }
        [Required]
        public DateTime? DataNascimento { get; set; }
        [Required]
        public DateTime? DataCadastro { get; set; }

		public MembershipType MembershipType { get; set; } //Propriedade de navegação
		public byte MembershipTypeId { get; set; } //Chave estrangeira
    }
}