using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMastery.Models.Tables
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public decimal Price { get; set; }
        public string Vin { get; set; }
        public int ModelId { get; set; }
        public int VehicleYear { get; set; }
        public bool IsNew { get; set; }
        public int PurchaseId { get; set; }
        public decimal Msrp { get; set; }
        public string Color { get; set; }
        public string Interior { get; set; }
        public string Transmission { get; set; }
        public int Mileage { get; set; }
        public string VehicleDescription { get; set; }
        public string BodyStyle { get; set; }
        public string Picture { get; set; }

        public virtual Model Model { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
