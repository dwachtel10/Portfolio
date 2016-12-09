using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models.Interfaces;


namespace Flooring.BLL
{
    public class OrderManager
    {
        private IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

       // public ViewOrderResponse ViewOrder()
    }

    
    
    
}
