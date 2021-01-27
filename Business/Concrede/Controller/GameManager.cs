using GameCenter.Business.Abstract;
using GameCenter.DataAccess.Abstract;
using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.Concrede.Controller
{
    class GameManager : IEntityService
    {
        List<ILoggerService> _loggerServices;
        public GameManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }
        public void Add(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }

        public void Delete(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(game);
            }
        }

        public void Update(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(game);
            }
        }
    }
}
