using System.Collections.Generic;
using PhoneStore.Domain.Abstract;
using PhoneStore.Domain.Entities;
using Dapper;
using System.Linq;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PhoneStore.Domain.Concrete
{
    public class EFRoleRepository : IRoleRepository
    {
        readonly string connectionString = null;
        public EFRoleRepository(string conn) => connectionString = conn;
        public List<Role> GetRoles()
        {
            using IDbConnection db = new SqlConnection(connectionString);
            return db.Query<Role>("SELECT * FROM Roles").ToList();
        }
    }
}
