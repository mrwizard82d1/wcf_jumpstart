﻿using System.Collections.Generic;
using System.ServiceModel;

namespace ZzaServices
{
    // Make interface public for hosting. However, visibility is ignored  
    // for a service.
    [ServiceContract]
    public interface IZzaServices
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SubmitOrder(Order order);
    }
}
