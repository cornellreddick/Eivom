using Eivom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eivom.ViewModels
{
    public class NewMoveFormViewModel
    {
        public IEnumerable<MembershipType> membershipTypes { get; set; }
        public Customer customer { get; set; }
    }
}