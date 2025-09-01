using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBibliotecaVirtual.Models
{
    [Table("LIBROS")]
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("NOMBRE_LIBRO")]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("NOMBRE_AUTOR")]
        public string Autor { get; set; }

        [Required]
        [Column("FECHA_PUBLICACION")]
        public int? Año { get; set; }
    }
}
