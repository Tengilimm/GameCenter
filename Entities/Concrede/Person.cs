using GameCenter.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Entities.Concrede
{
    class Person : IEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public int BirthDay { get; set; }
    }
}
