using ItprogerShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ItprogerShop.Data;

public class AppDbContext : DbContext
{

    public DbSet<Blog> posts { get; set; } = null!;
    public DbSet<Item> items { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Order> orders { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


}
