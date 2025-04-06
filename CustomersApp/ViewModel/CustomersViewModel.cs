using CustomersApp.Data;
using CustomersApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CustomersApp.ViewModel
{
    public class CustomersViewModel
    {
        public ObservableCollection<Customer> Customers { get; } = new ObservableCollection<Customer>();

        //Constucteur

        private readonly ICustomerDataProvider _customerDataProvider;

        public CustomersViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
        }

        // Méthode asynchrone pour charger les données des clients
        public async Task LoadAsync()
        {
            var customers = await _customerDataProvider.GetAllAsync();
            if (customers != null)
            {
                foreach (var customer in customers)
                {
                    Customers.Add(customer);
                }
            }
        }

        //public Customer SelectedCustomer { get; set; } idk step 6 


    }
}



