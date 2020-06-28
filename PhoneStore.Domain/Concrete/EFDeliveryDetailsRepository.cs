using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using PhoneStore.Domain.Abstract;
using PhoneStore.Domain.Entities;

namespace PhoneStore.Domain.Concrete
{
    public class EFDeliveryDetailsRepository:IDeliveryDetailsRepository
    {
        readonly string connectionString = null;
        public EFDeliveryDetailsRepository(string conn) => connectionString = conn;
        public List<DeliveryDetails> GetDeliveryDetails()
        {
            using IDbConnection db = new SqlConnection(connectionString);
            return db.Query<DeliveryDetails>("SELECT * FROM DeliveryDetails").ToList();
        }
    }
}
