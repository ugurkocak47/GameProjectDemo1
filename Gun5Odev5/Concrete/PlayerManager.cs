using Gun5Odev5.Abstract;
using Gun5Odev5.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void CheckBalance(Player player)
        {
            Console.WriteLine(player.Nickname + "'s account balance is: " + player.AccountBalance);
        }

        public void Create(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine("Account created as: " + player.Nickname);
            }
            else
            {
                Console.WriteLine("Information is not valid");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Account " + player.Nickname + " has been deleted.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Account " + player.Nickname +  " has been updated.");
        }


    }
}
