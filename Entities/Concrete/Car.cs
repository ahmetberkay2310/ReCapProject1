using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int  Id { get; set; }
        public int? BrandId { get; set; }
        public int? ColorId { get; set; }               
        public int? ModelYear { get; set; }
        public decimal? DailyPrice { get; set; }
        public string CarDescription { get; set; }
        public bool? IsAvailable { get; set; }
    }
}