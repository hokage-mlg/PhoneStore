using System;
using System.Collections.Generic;
using System.Text;
using PhoneStore.Domain.Entities;

namespace PhoneStore.Domain.Abstract
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        void AddOrder(Order order);
    }
}
