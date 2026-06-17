using App.Core.Models;
using System.Collections.Generic;

namespace App.Core.Contracts
{
    public interface IMatchService
    {
        List<Match> GetAll();
        Match GetById(string id);
        void Add(Match match);
        void Update(Match match);
        void Delete(string id);
        List<Match> Search(string keyword);
    }
}
