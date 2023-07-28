using Gun5Odev5.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
