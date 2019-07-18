using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    class TaffyFactory : IFactorable<Confectioner>
    {
        public int MinimumWorkers { get; set; }
        public int MaximumWorkers { get; set; }    
        public List<string> TaffyEmployees = new List<string>();
        public void HireEmployee(Confectioner employee)
        {
            TaffyEmployees.Add(employee.Name);
        }
        public void HireEmployees(Confectioner employee)
        {
            TaffyEmployees.Add(employee.Name);
        }
    }
}