using PhoneStore.Domain.Entities;
using PhoneStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace PhoneStore.Domain.Concrete
{
    public class EFOrderRepository : IOrderRepository
    {
        readonly string connectionString = null;
        public EFOrderRepository(string conn) => connectionString = conn;
        public List<Order> GetOrders()
        {
            using IDbConnection db = new SqlConnection(connectionString);
            return db.Query<Order>("SELECT * FROM Orders").ToList();
        }
        public void AddOrder(Order order)
        {

        }
    }
}
