using GameCenter.Business.Abstract;
using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.Concrede.Sales
{
    class BlackFridaySalesManager : ISaleService
    {
        public void Discount(IEntity game)
        {
            Console.WriteLine(game.Name + " oyununa 'BlackFriday' indirimi yapıldı.");
        }
    }
}
