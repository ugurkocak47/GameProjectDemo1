using Gun5Odev5.Abstract;
using Gun5Odev5.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
