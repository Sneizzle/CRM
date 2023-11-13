namespace CRM.Client.Components.States
{
    public class ContactStateService
    {

        private List<CRM.Shared.Model.Contact> contacts = new List<CRM.Shared.Model.Contact>();

        public List<CRM.Shared.Model.Contact> GetContacts() => contacts;

        public void AddContacts(CRM.Shared.Model.Contact contact)
        {
            contacts.Add(contact);
            NotifyStateChanged();
        }


        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
