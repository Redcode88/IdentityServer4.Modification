using API.Models;
using DataAccess.Data;
using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class CoffeeShopService : ICoffeeShopService
    {
        private readonly ApplicationDbContext _ctx;
        public CoffeeShopService(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<CoffeshopModel>> List()
        {
          var data = await (from shop in _ctx.CoffeShops
          select new CoffeshopModel()
          {
                Id= shop.Id,
                Name= shop.Name,
                Address= shop.Address,
                OpeningHours= shop.OpeningHours,
          }).ToListAsync();
          return data;
        } 
    }
}
