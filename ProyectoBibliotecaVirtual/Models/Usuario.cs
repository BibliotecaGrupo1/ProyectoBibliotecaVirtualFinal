using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBibliotecaVirtual.Models
{
    [Table("USUARIOS")]
    public class Usuario // !!!NUEVO¡¡¡ //  Esta clase representa un usuario en la biblioteca, conutilizando un nuevo formato adaptado a la herencia de datos y simplificado
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string nombreCompleto;
        private DateTime fechaNacimiento;
        private int edad;

        // !!!NUEVO¡¡¡ // Constructor actualizado para inicializar el registro de datos de un nuevo usuario
        public Usuario(string nombres, string apellidos, DateTime fechaNacimiento)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.NombreCompleto = nombres + " " + apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Edad = DateTime.Now.Year - fechaNacimiento.Year;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("NOMBRES")]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("APELLIDOS")]
        public string Apellidos { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("NOMBRE_COMPLETO")]
        public string NombreCompleto { get; set; }

        [Required]
        [Column("FECHA_NACIMIENTO")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("USUARIO_EDAD")]
        public int Edad { get; set; }

        public void ImprimirUsuario() // esto devuelve la información del usuario consultado
        {
            Console.WriteLine("══════════════════════════════════════════════");
            Console.WriteLine(" DATOS PERSONALES DEL USUARIO:");
            Console.WriteLine($" ID: {Id}");
            Console.WriteLine($" Nombre Completo: {NombreCompleto}");
            Console.WriteLine($" Edad: {Edad}");
        }

        public void ImprimirUsuarioParaAdministrador() // esto devuelve la información del usuario consultado, mostrando la lista completa para los administradores
        {
            Console.WriteLine("══════════════════════════════════════════════");
            Console.WriteLine(" DATOS PERSONALES DEL USUARIO:");
            Console.WriteLine($" ID: {Id}");
            Console.WriteLine($" Nombres: {Nombres}");
            Console.WriteLine($" Apellidos: {Apellidos}");
            Console.WriteLine($" Nombre Completo: {NombreCompleto}");
            Console.WriteLine($" Fecha de Nacimiento: {FechaNacimiento}");
            Console.WriteLine($" Edad: {Edad}");
        }
        
    }
}
