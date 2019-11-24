using DessertIsland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DessertIsland.DAL
{
    public interface IClickSQLDAO
    {
        IList<DessertClick> GetAllClicks();
        void AddClick(int dessertId);
        //void CountClicksById(int dessertId);
    }
}
