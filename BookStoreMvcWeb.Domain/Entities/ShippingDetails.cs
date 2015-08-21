using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMvcWeb.Domain.Entities
{
    public class ShippingDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAdress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
