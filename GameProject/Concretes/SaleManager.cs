using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    public class SaleManager: ISaleService
    {
        public void Order(Campaign campaign, Game game, Player player)
        {
            double afterCampaignPrice = game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);

            Console.WriteLine(player.FirstName + " adlı oyuncu " + game.GameName + " adlı oyunu " + game.GamePrice + " Tl yerine %" + campaign.DiscountRate + " indirimle " + afterCampaignPrice + " Tl ye aldı.");
        }
    }
}
