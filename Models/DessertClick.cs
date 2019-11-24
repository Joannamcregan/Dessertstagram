using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DessertIsland.Models
{
    public class DessertClick: IDessertClick
    {
        public int DessertId { get; set; }
        public DateTime WhenClicked { get; set; }
    }
}
