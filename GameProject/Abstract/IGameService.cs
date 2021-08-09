using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Add(Game game, Player player);
        void Delete(Game game, Player player);
        void Update(Game game, Player player);


    }
}
