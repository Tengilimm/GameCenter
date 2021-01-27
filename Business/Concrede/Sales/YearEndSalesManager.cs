using GameCenter.Business.Abstract;
using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.Concrede.Sales
{
    class YearEndSalesManager : ISaleService
    {
        public void Discount(IEntity game)
        {
            Console.WriteLine(game.Name + " " + "Oyununuza 'Yıl Sonu' indirimi yapıldı.");
        }
    }
}
