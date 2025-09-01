using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBibliotecaVirtual.Models
{
    [Table("SESION_USUARIOS")]
    public class SesionUsuario: Usuario // !!!NUEVO¡¡¡ // Se dividió la manera en que registramos los datos, tanto personales como de perfil y se está utilizando el formato de herencia de datos para la correcta clasificación de datos de un usuario
    {
        private DateTime fechaRegistro;
        private string nombreUsuario;
        private string correo;
        private string contraseña;

        public SesionUsuario(string nombres, string apellidos, DateTime fechaNacimiento, string nombreUsuario, string correo, string contraseña) : base(nombres, apellidos, fechaNacimiento)
        {
            this.NombreUsuario = NombreCompleto;
            this.Correo = correo;
            this.Contraseña = contraseña;
        }

        [Required]
        [Column("FECHA_REGISTRO")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(100)]
        [Column("NOMBRE_USUARIO")]
        public string NombreUsuario { get; set; }

        [Required]
        [Column("E-MAIL")]
        public string Correo { get; set; }

        [Required]
        [Column("CLAVE_USUARIO")]
        public string Contraseña { get; set; }

        public void ImprimirSesionUsuario()
        {
            ImprimirUsuario();
            Console.WriteLine("..............................................");
            Console.WriteLine(" DATOS DEL PERFIL DEL USUARIO: ");
            Console.WriteLine($" Fecha de registro: {FechaRegistro}");
            Console.WriteLine($" Nombre de Usuario: {NombreUsuario}");
            Console.WriteLine($" E-Mail: {Correo}");
        }

        public void ImprimirSesionUsuarioParaAdministrador()
        {
            ImprimirUsuarioParaAdministrador();
            Console.WriteLine("..............................................");
            Console.WriteLine(" DATOS DEL PERFIL DEL USUARIO: ");
            Console.WriteLine($" Fecha de registro: {FechaRegistro}");
            Console.WriteLine($" Nombre de Usuario: {NombreUsuario}");
            Console.WriteLine($" E-Mail: {Correo}");
            Console.WriteLine($" Contraseña: {Contraseña}");

        }
    }
}
