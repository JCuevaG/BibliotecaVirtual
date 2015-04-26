
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace BibliotecaVirtual.Domain.Entities
{
    [Table("Prestamo")]
    public partial class Prestamo : EntityBase
    {
        public int LibroId { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public Libro Libro { get; set; }
        public string Estado { get; set; }
    }
}
