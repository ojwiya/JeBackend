using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeBackend.Core.Models
{
    // Should be a noun perhaps the prefix of responseObject
    // Canot change 
    public class GetRestaurantResult
    {
       public string ShortResultText {get;set;}
       public IList<RestaurantSearchResult> Restaurants { get; set; }
    }
}
