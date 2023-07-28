using Gun5Odev5.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Abstract
{
    internal interface IOfferService
    {
        void Add(Offer offer,Player player);
        void Update(Offer offer,Player player);
        void Delete(Offer offer,Player player);
    }
}
