using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ecommerce_Vestuario_REVIEW.Models;

namespace Ecommerce_Vestuario_REVIEW.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customer Customer { get; set; }
    }
}