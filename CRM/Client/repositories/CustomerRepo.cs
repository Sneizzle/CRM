using CRM.Shared.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http.Json;

namespace CRM.Client.Repositories
{
    public class CustomerRepo
    {
        static HttpClient http = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7047/api")
        };

        private static CustomerRepo instance;
        public static CustomerRepo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerRepo();
                }
                return instance;
            }
            set { instance = value; }
        }

        public List<Customer>? customers;

        public CustomerRepo()
        {
            customers = new List<Customer>();
            //InitializeCustomers();
        }
        public async Task InitializeCustomers()
        {
            try
            {
                customers = await http.GetFromJsonAsync<List<Customer>>("api/Customers");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync("InitializeCustomers error: " + e);
            }
        }
        public void AddToCustomers(Customer customer)
        {
            Console.WriteLine("Added customer to customerslist in repo");
            customers.Add(customer);
        }
    }
}
