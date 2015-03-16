using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Zza.Entities;

namespace Zza.Client
{
    class MainWindowVm
    {
        public MainWindowVm()
        {
            LoadProductsAndCustomers();
        }

        public ObservableCollection<Customer> Customers { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        private void LoadProductsAndCustomers()
        {
            var proxy = new ZzaService.ZzaServicesClient("BasicHttpBinding_IZzaServices");
            Products = proxy.GetProducts();
            Customers = proxy.GetCustomers();
        }

    }
}
