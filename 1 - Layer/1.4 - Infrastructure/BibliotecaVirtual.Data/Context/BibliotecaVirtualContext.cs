using System.Data.Entity;
using BibliotecaVirtual.Domain.Entities;

namespace BibliotecaVirtual.Data.Context
{
    public class BibliotecaVirtualContext : DbContext
    {
        public BibliotecaVirtualContext()
            : base("BibliotecaVirtual")
        {

        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>()
                .HasRequired(c => c.Categoria)
                .WithMany()
                .HasForeignKey(c => c.CategoriaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>();

            modelBuilder.Entity<Prestamo>()
                .HasRequired(l => l.Libro)
                .WithMany()
                .HasForeignKey(l => l.LibroId)
                .WillCascadeOnDelete(false);
        }
    }
}
