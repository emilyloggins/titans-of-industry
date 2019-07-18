using System;
using System.Collections.Generic;

namespace titan_of_industry
{
    class InsulinFactory : IFactorable<LabTechnician>
    {
        public int MinimumWorkers { get; set; }
        public int MaximumWorkers { get; set; }    
        public List<string> LabEmployees = new List<string>();
        public void HireEmployee(LabTechnician employee)
        {
            LabEmployees.Add(employee.Name);
        }
        public void HireEmployees(LabTechnician employee)
        {
            LabEmployees.Add(employee.Name);
        }
    }
}