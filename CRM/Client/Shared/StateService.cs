using CRM.Shared.Model;
using System.Collections.Generic;

namespace CRM.Client.Shared
{
    public class StateService
    {
        public event Action OnTableUpdate;

        private List<Customer> tableData = new List<Customer>();

        public IReadOnlyList<Customer> TableData => tableData.AsReadOnly();

        public void UpdateTable(List<Customer> newData)
        {
            tableData = newData;
            NotifyTableUpdate();
        }

        private void NotifyTableUpdate() => OnTableUpdate?.Invoke();
    }
}
