using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Entitites
{
    internal class Offer
    {
        public int Id { get; set; }
        public int OfferCategory { get; set; } //Eşya, DLC, aksesuar indirimleri şeklinde 1,2,3...
        public int DiscountRatio { get; set; }
        public string OfferName { get; set; }
        public string Description { get; set; } 
    }
}
