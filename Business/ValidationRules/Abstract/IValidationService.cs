using GameCenter.Entities.Concrede;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Business.ValidationRules.Abstract
{
    interface IValidationService
    {
        void Validate(Person person);
    }
}
