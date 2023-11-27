using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionService.DTO;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item); // go from auction to auctionDto
            CreateMap<Item, AuctionDto>(); // go from auction to auctionDto
            CreateMap<CreateAuctionDto, Auction>().ForMember(d => d.Item, o => o.MapFrom(s => s)); // go from auction to auctionDto
            CreateMap<CreateAuctionDto, Item>();
        }
    }
}