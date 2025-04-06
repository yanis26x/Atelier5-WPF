using CustomersApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CustomersApp.Data
{

    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(1000); // Simule l'attente

            return new List<Customer> //les donnees
        {
            new Customer { Id = 1, FirstName = "Yanis", LastName = "Djenadi", IsDeveloper = true },
            new Customer { Id = 2, FirstName = "Nassim", LastName = "Djenadi", IsDeveloper = false },
            new Customer { Id = 3, FirstName = "django", LastName = "idk", IsDeveloper = false },
            new Customer { Id = 3, FirstName = "NaNa", LastName = "0sAk1", IsDeveloper = false }
        };

        }
    }
}
