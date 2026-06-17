using App.Core.Models;
using System.Collections.Generic;

namespace App.Core.Contracts
{
    public interface ITeamService
    {
        List<Team> GetAll();
        Team GetById(string id);
        void Add(Team team);
        void Update(Team team);
        void Delete(string id);
        List<Team> Search(string keyword);
    }
}
