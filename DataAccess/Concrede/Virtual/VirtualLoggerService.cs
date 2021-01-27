using GameCenter.DataAccess.Abstract;
using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.DataAccess.Concrede.Virtual
{
    class VirtualLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + " bulut sistemine eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + " bulut sistemine kaldırıldı.");

        }
        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + " bulut sistemine güncellendi.");
        }
    }
}
