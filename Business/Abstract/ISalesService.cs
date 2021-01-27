using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.Abstract
{
    interface ISaleService
    {
        void Discount(IEntity game);
    }
}
