using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models
{
    public interface IOrderRepository

    {
        //Order LoadOrder(string Date, int OrderNumber);
        void AddOrder(DateTime Date, 
            Order order);
        void EditOrder(Order order, Order editedOrder);
        void DeleteOrder(Order order);
        List<Order> ListOrdersByDate(DateTime Date);
        //Order GetOrderByNumber(int orderNumber, List<Order> orders);

    }
}
