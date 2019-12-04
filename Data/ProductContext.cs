using Microsoft.EntityFrameworkCore;

namespace ElectroniTrading.Data
{

    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options){}
        public DbSet<Models.product> Products { get; set; }
    
         }

}
    
