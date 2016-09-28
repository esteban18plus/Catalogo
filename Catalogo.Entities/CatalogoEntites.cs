namespace Catalogo.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CatalogoEntites : DbContext
    {
        public CatalogoEntites()
            : base("name=CatalogoEntites")
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoCategoria> ProductoCategoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.ProductoCategoria)
                .WithOptional(e => e.Categoria)
                .HasForeignKey(e => e.IdCategoria);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Precio)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.ProductoCategoria)
                .WithOptional(e => e.Producto)
                .HasForeignKey(e => e.IdProducto);
        }
    }
}
