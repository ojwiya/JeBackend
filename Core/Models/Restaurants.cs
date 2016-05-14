using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeBackend.Core.Models
   {

       public class Restaurants{
            public Int32 Id {get;set;}
            public string Name {get;set;}
            public string Address {get;set;}
            public string Postcode {get;set;}
            public string City {get;set;}
            public IList<CuisineType> CuisineTypes {get;set;}
            public Int32 AverageRating {get;set;}
            public string Url {get;set;}
            public Boolean IsOpenNow {get;set;}
            public Boolean IsSponsored {get;set;}
            public Boolean IsNew {get;set;}
            public Boolean IsTemporarilyOffline {get;set;}
            public  string ReasonWhyTemporarilyOffline {get;set;}
            public string UniqueName {get;set;}
            public Boolean IsCloseBy {get;set;}
            public Double RatingForDisplay {get;set;}
            public Boolean IsHalal {get;set;}
            public Int32 DefaultDisplayRank {get;set;}
            public Boolean IsOpenNowForDelivery {get;set;}
            public Boolean IsOpenNowForCollection {get;set;}
            public Double RatingStars {get;set;}
            public IList<Image> Logo { get; set; }
            public IList<Deal> Deals {get;set;}
            public Int32 NumberOfRatings  {get;set;}
            public Boolean ShowSmiley  {get;set;}
            public DateTime SmileyDate  {get;set;}
            public Int32 SmileyResult  {get;set;}
            public string SmileyUrl  {get;set;}
            public string SmileyElite { get; set; }
            public double Score { get; set; }
            public Double? DriveDistance{ get; set; }
            public Boolean DriveInfoCalculated { get; set; }
            public DateTime NewnessDate{ get; set; }
            public Int32? DeliveryMenuId { get; set; }
            public DateTime? DeliveryOpeningTime{ get; set; }
            public Double? DeliveryCost { get; set; }
            public Double? MinimumDeliveryValue { get; set; }
            public Int32? DeliveryTime { get; set; }
            public DateTime OpeningTime { get; set; }
            public string OpeningTimeIso{ get; set; }
            public Boolean SendsOnItsWayNotifications { get; set; }





}
}
