using CRM.Shared.Model;
using System.Net;
using System.Net.Http.Json;



namespace CRM.Client.Repositories
{
    public class CustomerRepo
    {
        static HttpClient http = new HttpClient();

        //private static CustomerRepo instance;
        //public static CustomerRepo Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new CustomerRepo();
        //        }
        //        return instance;
        //    }
        //    //set { _instance = value; }
        //}
        public List<Customer>? customers;

        //private CustomerRepo() // Hvad er implikationerne af en private constructor? 
        //{
        //    //customers = await http.GetFromJsonAsync<List<Customer>>("api/Customers");
        //}

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

        public List<Customer> GetList()
        {
            return customers;
        }
    }
}
