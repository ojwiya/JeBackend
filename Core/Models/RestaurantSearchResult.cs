using JeBackend.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeBackend.Core.Models
{
    // Should be a noun perhaps the prefix of responseObject
    // Canot change 
    public class RestaurantSearchResult
    {
       public string ShortResultText {get;set;}
       public IList<Restaurants> Restaurants { get; set; }
       public Boolean HasErrors{get;set;}
    }
}
