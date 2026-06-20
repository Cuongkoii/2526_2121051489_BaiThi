
using _2526_2121051489_BaiThi.Models;
using Microsoft.EntityFrameworkCore;

namespace _2526_2121051489_BaiThi.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tensinhvien> Tensinhviens { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get;set; }
        public DbSet<SanPham> SanPhams { get;set; }
    }
}
