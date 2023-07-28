using Gun5Odev5.Abstract;
using Gun5Odev5.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev5.Concrete
{
    public class GameManager : IGameService
    {
        private IRefundCheckService _refundCheckService;


        public GameManager(IRefundCheckService refundCheckService)
        {
            _refundCheckService = refundCheckService;
        }
        public void Add(Game game, Player player)
        {
            if (game.Price < player.AccountBalance)
            {
                Console.WriteLine("The game " + game.GameName + " is added to the account library: " + player.Nickname);
                player.AccountBalance = player.AccountBalance - game.Price;
            }
            else
            {
                Console.WriteLine("Account balance is not enough to buy this game");
            }
        }

        public void Refund(Game game, Player player)
        {
            if (_refundCheckService.CheckIfRefundable(player))
            {
                player.AccountBalance += game.Price; 
                Console.WriteLine("Game has been refunded and the money is sent back to your account");

            }
            else
            {
                Console.WriteLine("The refundability of this game on your account has expired. (14 days have passed since you bought the game)");
            }
        }

        public void Remove(Game game, Player player)
        {
            Console.WriteLine(game.GameName + " is deleted from account library: " + player.Nickname);
        }
    }
}
