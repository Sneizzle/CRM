namespace CRM.Client.Components.States
{
    public class CustomerStateService
    {
        private List<CRM.Shared.Model.Customer> customers = new List<CRM.Shared.Model.Customer>();

        public List<CRM.Shared.Model.Customer> GetCustomers() => customers;

        public void AddCustomer(CRM.Shared.Model.Customer customer)
        {
            customers.Add(customer);
            NotifyStateChanged();
        }


        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
