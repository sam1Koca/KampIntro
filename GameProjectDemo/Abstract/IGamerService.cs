using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGamerService // Oyuncu Manager için bir interface
    {
        void Add(Gamer gamer); // Oyuncu parametresi alarak işlem yapacak
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
