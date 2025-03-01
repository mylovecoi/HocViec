
using Infrastructure.Models.DanhMuc;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<DanhMucLoaiHang> DanhMucLoaiHang { get; set; }

        

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //}
    }
}

