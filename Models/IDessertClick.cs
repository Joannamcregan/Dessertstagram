using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DessertIsland.Models
{
    public interface IDessertClick
    {
        int DessertId { get; set; }
        DateTime WhenClicked { get; set; }
    }
}
