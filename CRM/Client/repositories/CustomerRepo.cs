using CRM.Shared.Model;
using System.Net;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;



namespace CRM.Client.repositories
{
    public class CustomerRepo
    {

        static HttpClient http = new HttpClient();
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
            //set { _instance = value; }
        }
        public List<Customer> customers;
        private CustomerRepo()
        {
            //customers = await http.GetFromJsonAsync<List<Customer>>("api/Customers");
            customers = new List<Customer>
            {
            new Customer() { Name = "test"},
            new Customer() { Name = "name2"}
            };
        }

        public List<Customer> GetList()
        {
            return customers;
        }


        public async Task gottaGetThemAll()
        {
            customers = await http.GetFromJsonAsync<List<Customer>>("api/Customers");
        }
    }
}
