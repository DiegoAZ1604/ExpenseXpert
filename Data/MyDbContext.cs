using Microsoft.EntityFrameworkCore;
using ExpenseXpertCRUD.Models;

namespace ExpenseXpertCRUD.Data{
    public class MyDbContext : DbContext{
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Ingreso>().ToTable("Ingresos");
            modelBuilder.Entity<Gasto>().ToTable("Gastos");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
        }
    }
}