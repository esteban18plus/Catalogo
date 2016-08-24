namespace Catalogo.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CatalogoEntities : DbContext
    {
        public CatalogoEntities()
            : base("name=CatalogoEntities")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<ProductoCategoria> ProductoCategorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.ProductoCategorias)
                .WithRequired(e => e.Categoria)
                .HasForeignKey(e => e.IdCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Precio)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.ProductoCategorias)
                .WithRequired(e => e.Producto)
                .HasForeignKey(e => e.IdProducto)
                .WillCascadeOnDelete(false);
        }
    }
}
