using PhoneStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneStore.Domain.Abstract
{
    public interface IRoleRepository
    {
        List<Role> GetRoles();
    }
}
