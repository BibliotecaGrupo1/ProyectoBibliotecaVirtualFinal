using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBibliotecaVirtual.Models
{
    [Table("ADMINISTRADORES")]
    public class Administradores
    {
        private int id;
        private string adminUsuario;
        private string tag;
        private string adminUserId;
        private DateTime fechaNacimiento;
        private DateTime fechaRegistro;
        private int edad;
        private string adminContraseña;
        public Administradores(string adminUsuario, DateTime fechaNacimiento, string adminContraseña)
        {            
            this.AdminUsuario = adminUsuario;
            this.AdminUserId = adminUsuario + Tag;
            this.FechaNacimiento = fechaNacimiento;
            this.Edad = DateTime.Now.Year - fechaNacimiento.Year;
            this.AdminContraseña = adminContraseña;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id {  get; set; }

        [Required]
        [MaxLength(100)]
        [Column("USER_ADMIN")]
        public string AdminUsuario { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("ADMIN_TAG")]
        public string Tag { get; set; } = " #0010";

        [Required]
        [MaxLength(100)]
        [Column("ADMIN_ID")]
        public string AdminUserId { get; set; }

        [Required]
        [Column("FECHA_NACIMIENTO")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Column("FECHA_REGISTRO")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(10)]
        [Column("ADMIN_EDAD")]
        public int Edad {  get; set; }

        [Required]
        [Column("CLAVE_ADMIN")]
        public string AdminContraseña { get; set; }

        public void ImprimirADMIN()
        {
            Console.WriteLine("══════════════════════════════════════════════");
            Console.WriteLine(" DATOS DE ADMINISTRADOR:");
            Console.WriteLine($" ID: {Id}");
            Console.WriteLine($" ADMIN: {AdminUserId}");
            Console.WriteLine($" Edad: {Edad}");
        }
    }
}
