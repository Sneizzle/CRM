using CRM.Client.Repositories;
using CRM.Shared.Model;
using System.Net.Http.Json;
using System.Security.Cryptography;

namespace CRM.Client.repositories
{
    public class ContactsRepo
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

        public List<Contact> contacts;

        public ContactsRepo()
        {
            contacts = new List<Contact>();
        }

        public async Task InitializeContacts()
        {
            try
            {
                contacts = await http.GetFromJsonAsync<List<Contact>>("api/Contacts");
            }
            catch (Exception e)
            {
                await Console.Out.WriteLineAsync("InitializeContacts error: " + e);
            }
        }

        public void AddToContacts(Contact contact)
        {
            contacts.Add(contact);
        }

    }
}
