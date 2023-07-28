using Gun5Odev5.Abstract;
using Gun5Odev5.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Concrete
{
    public class RefundCheckManager : IRefundCheckService
    {
        public bool CheckIfRefundable(Player player)
        {
            if (player.AccountCreationDate.Year - DateTime.Today.Year == 0 & DateTime.Today.DayOfYear - player.AccountCreationDate.DayOfYear <= 14)
            {
                return true;
            }
            else { return false; }
        }
    }
}
