using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    class SteelFactory : IFactorable<SteelWorker>
    {
        public int MinimumWorkers { get; set; }
        public int MaximumWorkers { get; set; }    
        public List<string> SteelEmployees = new List<string>();
        public void HireEmployee(SteelWorker employee)
        {
            SteelEmployees.Add(employee.Name);
        }
        public void HireEmployees(SteelWorker employee)
        {
            SteelEmployees.Add(employee.Name);
        }
    }
}