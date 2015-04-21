
using System.ComponentModel.DataAnnotations.Schema;
namespace BibliotecaVirtual.Domain.Entities
{
    [Table("Categoria")]
    public partial class Categoria : EntityBase
    {
        public string Descripcion { get; set; }
    }
}
