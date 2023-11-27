using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;

namespace AuctionService.Entities
{
    public class Auction
    {
        public Guid Id { get; set; }
        public int ReservedPrice { get; set; } = 0;
        public string Seller { get; set; }
        public string Winner { get; set; }
        public int? SoldAmount { get; set; }
        public int? CurremtHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;// standard international time format and good for postgres
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;//
        public DateTime AuctionEnd { get; set; } = DateTime.UtcNow;//
        public Status Status { get; set; }
        public Item Item { get; set; }
    }
}