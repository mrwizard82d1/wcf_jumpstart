using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Zza.Data;
using Zza.Entities;

namespace Zza.Services
{
    // Creates a service every time it is called from a client.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ZzaService : IZzaServices, IDisposable
    {
        readonly ZzaDbContext _context = new ZzaDbContext();

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        // Scopes entire call to occur within a (platform-created) 
        // transaction.
        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            _context.Orders.Add(order);
            order.OrderItems.ForEach(oi => _context.OrderItems.Add(oi));
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
