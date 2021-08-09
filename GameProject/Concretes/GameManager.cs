using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    public class GameManager:IGameService
    {
        public void Add(Game game, Player player)
        {
            Console.WriteLine(game.GameName + " oyunu " +player.FirstName + " oyuncu tarafından " +  game.GamePrice + " Tl ye satın alındı");
        }

        public void Delete(Game game, Player player)
        {
            Console.WriteLine(game.GameName + " oyunu " + player.FirstName + " tarafından oyun listesinden silindi. " );
        }

        

        public void Update(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + " adlı oyuncu " + game.GameName + " adlı oyundaki üyeligini güncelledi");
        }
    }
}
