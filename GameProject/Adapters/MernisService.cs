using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisService : IPlayerCheckService
    {
        public bool IsRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client
                .TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(),
                    player.BirthYear.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
