using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PhoneStore.Domain.Abstract;
using PhoneStore.Domain.Entities;

namespace PhoneStore.Domain.Concrete
{
    public class EFPhoneRepository : IPhoneRepository
    {
        readonly string connectionString = null;
        public EFPhoneRepository(string conn) => connectionString = conn;
        public List<Phone> GetPhones()
        {
            using IDbConnection db = new SqlConnection(connectionString);
            return db.Query<Phone>("SELECT * FROM Phones").ToList();
        }
    }
}
