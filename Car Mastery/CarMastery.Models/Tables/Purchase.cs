using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Mastery.Models;


namespace CarMastery.Models.Tables
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int PurchaseTypeId { get; set; }
        public string UserId { get; set; }
        public string PurchaseMessage { get; set; }
        public int CustomerId { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual PurchaseType PurchaseType { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
