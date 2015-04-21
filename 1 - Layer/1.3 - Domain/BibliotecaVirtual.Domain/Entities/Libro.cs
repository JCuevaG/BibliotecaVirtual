using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaVirtual.Domain.Entities
{
    [Table("Libro")]
    public partial class Libro : EntityBase
    {
        public string Nombre { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public string NombreAutor { get; set; }
        public int Cantidad { get; set; }
    }
}
