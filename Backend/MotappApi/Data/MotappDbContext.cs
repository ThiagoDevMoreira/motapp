using Microsoft.EntityFrameworkCore;
using MotappApi.Models;

namespace MotappApi.Data;
public class MotappDbContext : DbContext{
    public MotappDbContext(DbContextOptions<MotappDbContext> options) : base (options){}
    public DbSet<Moto> Motos => Set<Moto>();
}