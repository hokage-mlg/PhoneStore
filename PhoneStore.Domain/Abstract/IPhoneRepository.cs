using System;
using System.Collections.Generic;
using System.Text;
using PhoneStore.Domain.Entities;

namespace PhoneStore.Domain.Abstract
{
    public interface IPhoneRepository
    {
        List<Phone> GetPhones();
    }
}
