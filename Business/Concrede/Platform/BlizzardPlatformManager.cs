using GameCenter.Business.Abstract;
using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.Concrede.Platform
{
    class BlizzardPlatformManager : IPlatformService
    {
        List<ISaleService> _salesServices;
        public BlizzardPlatformManager(List<ISaleService> saleServices)
        {
            _salesServices = saleServices;
        }
        public void BuyGame(IEntity person, IEntity game)
        {
            foreach (var sale in _salesServices)
            {
                sale.Discount(game);
            }

            Console.WriteLine(person.Name + " " + game.Name + " oyununu Blizzard'dan satın aldı.");
        }

        public void ReFund(IEntity person, IEntity game)
        {
            Console.WriteLine(person.Name + " " + game.Name + " oyununu Blizzard'a iade etti.");
        }
    }
}
