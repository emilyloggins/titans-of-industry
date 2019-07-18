using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    class AutoFactory : IFactorable<AutoWorker>
    {
        public int MinimumWorkers { get; set; }
        public int MaximumWorkers { get; set; }    
        public List<string> AutoEmployees = new List<string>();
        public void HireEmployee(AutoWorker employee)
        {
            AutoEmployees.Add(employee.Name);
        }
        public void HireEmployees(AutoWorker employee)
        {
            AutoEmployees.Add(employee.Name);
        }
    }
}