using Gun5Odev5.Abstract;
using Gun5Odev5.Entitites;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Gun5Odev5.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId),
                player.FirstName, player.LastName, player.DateOfBirth.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
