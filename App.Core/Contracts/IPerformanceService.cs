using App.Core.Models;
using System.Collections.Generic;

namespace App.Core.Contracts
{
    public interface IPerformanceService
    {
        List<Performance> GetAll();
        Performance GetById(string id);
        void Add(Performance performance);
        void Update(Performance performance);
        void Delete(string id);
    }
}
