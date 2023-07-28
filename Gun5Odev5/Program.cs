using Gun5Odev5.Abstract;
using Gun5Odev5.Adapters;
using Gun5Odev5.Concrete;
using Gun5Odev5.Entitites;
using System.Security.Cryptography.X509Certificates;

namespace Gun5Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            GameManager gameManager = new GameManager(new RefundCheckManager());
            OfferManager offerManager =new OfferManager();


            Player player1 = new Player {Id=1,NationalityId="13121336224",FirstName="Muhammed Uğur",LastName="Koçak",DateOfBirth = new DateTime(2006,4,24),
                AccountCreationDate = new DateTime(2023,7,17),Nickname="Nerex",AccountBalance=4000 };

            Game game1 = new Game {Id=1,GameName="Minecraft",Price=1200 };

            Offer offer1 = new Offer {Id=1,OfferName="Minecraft Discount Coupon",OfferCategory=3,
                Description="This offer gives you %50 discount on your Minecraft payment", DiscountRatio=50 };

            //Oyunu almadan önce, aldıktan ve iade ettikten sonraki bakiyemizi kontrol edelim.
            playerManager.Create(player1);
            playerManager.CheckBalance(player1);
            gameManager.Add(game1,player1);
            playerManager.CheckBalance(player1);
            gameManager.Refund(game1, player1);
            playerManager.CheckBalance(player1);

            //hesabımıza offer ekleyelim
            offerManager.Add(offer1,player1);

            //--------------------------------------------------------------------------

            playerManager.Update(player1);
            gameManager.Remove(game1,player1 );
            offerManager.Update(offer1 , player1);



        }
    }
}