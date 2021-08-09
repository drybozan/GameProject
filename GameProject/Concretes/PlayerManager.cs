using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    public class PlayerManager : IPlayerService
    {
        //dependency injection mernisten aldığı cevabı iletecek
        private IPlayerCheckService playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            this.playerCheckService = playerCheckService;
        }

        public void Save(Player player)
        {
            if (playerCheckService.IsRealPerson(player) == true)
            {
                Console.WriteLine("Oyuncu Başarıyla Kayıt oldu : " + player.FirstName+" "+player.LastName );
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
        }


        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt silindi");
        }

     

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
