using GameCenter.Business.ValidationRules.Abstract;
using GameCenter.Entities.Concrede;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.ValidationRules.Concrede.Mernis
{
    class MernisValidationService : IValidationService
    {
        public void Validate(Person person)
        {
            if (person.Name.Length > 1 && person.LastName.Length > 1 && person.NationalId.Length == 11 && person.BirthDay > 1800)
            {
                Console.WriteLine(person.Name + " " + person.LastName + " mernis doğrulamasından geçti.");
            }
            else
            {
                throw new Exception(person.Name + " " + person.LastName + " mernis doğrulamasından geçemedi.");

            }
        }
    }
}
