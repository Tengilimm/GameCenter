using GameCenter.Business.Abstract;
using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.Concrede.Sales
{
    class NewYearSalesManager : ISaleService
    {
        public void Discount(IEntity game)
        {
            Console.WriteLine(game.Name + " " + "oyununuza 'Yeni Yıl' indirimi yapıldı." );
        }
    }
}
