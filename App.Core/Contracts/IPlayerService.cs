using App.Core.Models;
using System.Collections.Generic;

namespace App.Core.Contracts
{
    public interface IPlayerService
    {
        List<Player> GetAll();
        Player GetById(string id);
        void Add(Player player);
        void Update(Player player);
        void Delete(string id);
        List<Player> Search(string keyword);
    }
}
