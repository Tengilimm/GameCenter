using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Entities.Concrede
{
    class Game : IEntity
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public string Name { get; set; }
        public string ProductOwner { get; set; }


    }
}
