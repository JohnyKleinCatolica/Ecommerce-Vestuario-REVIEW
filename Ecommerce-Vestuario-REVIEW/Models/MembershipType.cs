using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_Vestuario_REVIEW.Models
{
	public class MembershipType
	{
		public byte Id { get; set; }
		public bool ClientePremium { get; set; }
		public int DuracaoEmMes { get; set; }
		public float Desconto { get; set; }
		public string Nome { get; set; }
	}
}