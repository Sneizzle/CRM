using CRM.Shared.Model;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;



namespace CRM.Client.repositories
{
    public class CustomerRepo
    {
        static HttpClient http = new HttpClient();

        private List<Customer> customers;

        private List<Contact> contacts;

        protected async Task gottaGetThemAll()
        {

            customers = await http.GetFromJsonAsync<List<Customer>>("api/Customers");
            contacts = await http.GetFromJsonAsync<List<Contact>>("api/Contacts");


        }

    }
}
