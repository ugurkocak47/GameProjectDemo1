using Gun5Odev5.Abstract;
using Gun5Odev5.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Concrete
{
    internal class OfferManager : IOfferService
    {
        public void Add(Offer offer, Player player)
        {
            Console.WriteLine("The " + offer.OfferName + " offer is added to your " + player.Nickname + " account.");
        }

        public void Delete(Offer offer,Player player)
        {
            Console.WriteLine("The " + offer.OfferName + " offer is deleted from your " + player.Nickname + " account.");
        }

        public void Update(Offer offer, Player player)
        {
            Console.WriteLine("The " + offer.OfferName + " offer is updated in your " + player.Nickname +" account.");
        }
    }
}
