using GameCenter.DataAccess.Abstract;
using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.DataAccess.Concrede.Database
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + " veritabanına eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + " veritabanından kaldırıldı.");

        }
        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + " veritabanında güncellendi.");
        }
    }
}
