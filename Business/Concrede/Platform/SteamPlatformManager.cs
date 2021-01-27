using GameCenter.Business.Abstract;
using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.Concrede.Platform
{
    class SteamPlatformManager : IPlatformService
    {
        List<ISaleService> _salesServices;
        public SteamPlatformManager(List<ISaleService> saleServices)
        {
            _salesServices = saleServices;
        }

        public void BuyGame(IEntity person, IEntity game)
        {
            foreach (var sale in _salesServices)
            {
                sale.Discount(game);
            }
            Console.WriteLine(person.Name + " " + game.Name + " oyununu Steam'den satın aldı.");
        }

        public void ReFund(IEntity person, IEntity game)
        {
            Console.WriteLine(person.Name + " " + game.Name + " oyununu Steam'e iade etti.");
        }
    }
}

