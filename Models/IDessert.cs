using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DessertIsland.Models
{
    public interface IDessert
    {
        int Id { get; set; }
        string Name { get; set; }
        string Source { get; set; }
        string ImageSource { get; set; }
        string Type { get; set; }
        bool IsVegan { get; set; }
        bool IsLowFat { get; set; }
        bool IsSugarFree { get; set; }
        bool IsFiveIngredientsOrLess { get; set; }
        DateTime DateAdded { get; set; }
        int RecentClicks { get; set; }
        bool IsTrending { get; set; }
        string HashTag1 {get; set; }
        string HashTag2 { get; set; }
        string HashTag3 { get; set; }
        string HashTag4 { get; set; }
        string HashTag5 { get; set; }
        string HashTag6 { get; set; }
        string HashTag7 { get; set; }
        string HashTag8 { get; set; }
        string HashTag9 { get; set; }
        string HashTag10 { get; set; }
        int TotalLikes { get; set; }
    }
}
