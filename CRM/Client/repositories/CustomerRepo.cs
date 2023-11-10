using CRM.Shared.Model;
using System.Net;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;



namespace CRM.Client.repositories
{
    public class CustomerRepo
    {

        static HttpClient http = new HttpClient();

        public List<Customer> customers = new List<Customer>();

        public List<Customer> GetList()
        {
            return customers;
        }

        public List<Contact> contacts;

      
        public async Task gottaGetThemAll()
        {
            customers = await http.GetFromJsonAsync<List<Customer>>("api/Customers");
            contacts = await http.GetFromJsonAsync<List<Contact>>("api/Contacts");
     
        }

    }
}
