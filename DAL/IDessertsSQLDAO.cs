using DessertIsland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DessertIsland.DAL
{
    public interface IDessertsSQLDAO
    {
        IList<Dessert> GetAllDesserts();
        //Dessert GetDessertById(int id);
        void AddDessert(Dessert newDessert);
    }
}
