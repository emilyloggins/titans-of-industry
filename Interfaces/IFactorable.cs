using System;

namespace titan_of_industry
{
    public interface IFactorable<T>
    {
        int MinimumWorkers { get; set; }
        int MaximumWorkers { get; set; }
        void HireEmployee (T employee);
        void HireEmployees (T employees);
    }
}