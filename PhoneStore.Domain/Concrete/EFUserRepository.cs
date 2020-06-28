using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using PhoneStore.Domain.Abstract;
using PhoneStore.Domain.Entities;

namespace PhoneStore.Domain.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        readonly string connectionString = null;
        public EFUserRepository(string conn) => connectionString = conn;
        public List<User> GetUsers()
        {
            using IDbConnection db = new SqlConnection(connectionString);
            return db.Query<User>("SELECT * FROM Users").ToList();
        }
    }
}
