using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DessertIsland.Models
{
    public class DessertVM: DessertClick, IDessert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string ImageSource { get; set; }
        public string Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsLowFat { get; set; }
        public bool IsSugarFree { get; set; }
        public bool IsFiveIngredientsOrLess { get; set; }
        public DateTime DateAdded { get; set; }
        public int RecentClicks { get; set; }
        public bool IsTrending { get; set; }
        public string HashTag1 { get; set; }
        public string HashTag2 { get; set; }
        public string HashTag3 { get; set; }
        public string HashTag4 { get; set; }
        public string HashTag5 { get; set; }
        public string HashTag6 { get; set; }
        public string HashTag7 { get; set; }
        public string HashTag8 { get; set; }
        public string HashTag9 { get; set; }
        public string HashTag10 { get; set; }
        public int TotalLikes { get; set; }
        
        
    }
}
