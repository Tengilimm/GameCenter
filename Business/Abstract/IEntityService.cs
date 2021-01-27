using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.Abstract
{
    interface IEntityService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
