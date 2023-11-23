using Microsoft.EntityFrameworkCore;




namespace EFWithLinq
{
    internal class Nordwind :DbContext
    {
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KJ07M75\SQLEXPRESS;
                                            Database=Northwind;
                                            Trusted_Connection=True;
                                            MultipleActiveResultSets=True; 
                                            trustServerCertificate=True;
                                            ");
        }

        

    }
}
