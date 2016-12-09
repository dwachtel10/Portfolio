using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models.Interfaces;
using Flooring.Models.Responses;


namespace Flooring.BLL
{
    public class OrderManager
    {
        private IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderLookupResponse LookupOrder(int dateResult)



        {
            OrderLookupResponse response = new OrderLookupResponse();

            
            response.Order = _orderRepository.LoadDate(dateResult);

            if (response.Order == null || dateResult == 0)
            {
                response.Success = false;
                response.Message = $"{dateResult} is not a valid date.";
                Console.ReadLine();


            }
            //else if (response.Order != )
            //{
                
            //}
            else
            {
                response.Success = true;
            }

            return response;
        }
    }

    
    
    
}
