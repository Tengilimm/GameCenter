using GameCenter.Entities.Abstract;

namespace GameCenter.Business.Abstract
{
     interface IPlatformService
    {
        void BuyGame(IEntity person, IEntity game);
        void ReFund(IEntity person, IEntity game);
    }
}