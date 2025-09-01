// See https://aka.ms/new-console-template for more information
//NUEVO FORMATO DEL PROYECTO

using ProyectoBibliotecaVirtual.Context;
using ProyectoBibliotecaVirtual.Models;



var DB = new BSD();

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
    Console.WriteLine("░░██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░░█████╗░░░");
    Console.WriteLine("░░██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗░░");
    Console.WriteLine("░░██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║░░");
    Console.WriteLine("░░██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║░░");
    Console.WriteLine("░░██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║░░");
    Console.WriteLine("░░╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝░░");
    Console.WriteLine("░░░░░░░░░░██╗░░░██╗██╗██████╗░████████╗██╗░░░██╗░█████╗░██╗░░░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░██║░░░██║██║██╔══██╗╚══██╔══╝██║░░░██║██╔══██╗██║░░░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░╚██╗░██╔╝██║██████╔╝░░░██║░░░██║░░░██║███████║██║░░░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░╚████╔╝░██║██╔══██╗░░░██║░░░██║░░░██║██╔══██║██║░░░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░╚██╔╝░░██║██║░░██║░░░██║░░░╚██████╔╝██║░░██║███████╗░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░╚═╝░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚══════╝░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░╔════════════════════════════════════════════╗░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░║        MENU        DE      OPCIONES        ║░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░╠════════════════════════════════════════════╣░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░║            1. Registrarse                  ║░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░║            2. Iniciar Sesión               ║░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░║            3. salir                        ║░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░╠════════════════════════════════════════════╣░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░║            Ingrese una Opcion:             ║░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░╚════════════════════════════════════════════╝░░░░░░░░░░░░░░");
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
    string opcion = Console.ReadLine();

    // esta parte del código es para validar la opción ingresada por el usuario
    switch (opcion)
    {
        case "1":
            Console.Clear();
            crearCuenta();
            break;
        case "2":
            Console.Clear();
            iniciarSesion();
            break;
        case "3":
            Console.WriteLine("Saliendo del sistema...");
            return;
        case "0801":
            Console.Clear();
            RegistrarAdministrador();
            break;
        case "2001":
            Console.Clear();
            IniciarSesionAdmin();
            break;
        default:
            Console.WriteLine("Opción no válida, intentar de nuevo.");
            Console.ReadLine();
            Console.Clear();
            break;
    }

}

/////////////// REGISTRO DE USUARIOS ///////////////
void crearCuenta()
{
    // Aquí se implementa la lógica para crear una cuenta de usuario
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║           REGISTRAR NUEVO USUARIO          ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();

    // Solicitar al usuario que ingrese sus datos
    Console.Write("Ingrese sus nombres: "); // para nombres
    string nombres = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Ingrese sus apellidos: ");
    string apellidos = Console.ReadLine(); // para apellidos
    Console.WriteLine();

    Console.Write("Ingrese su fecha de nacimiento (Use el formato DD/MM/AA): ");
    DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine()); // para fecha de nacimiento
    Console.WriteLine();

    Console.Write("Ingrese su nombre de usuario: ");
    string nombreUsuario = Console.ReadLine(); // para nombre de usuario
    Console.WriteLine();

    Console.Write("Ingrese su correo electrónico: ");
    string correo = Console.ReadLine(); // para correo
    Console.WriteLine();

    Console.Write("Ingrese su contraseña: ");
    string contraseña = ContraseñaOculta(); // para contraseña
    Console.WriteLine();

    Console.Write("Confirme su contraseña: ");
    string confirmacionContraseña = ContraseñaOculta(); // para confirmar contraseña
    Console.WriteLine();

    if (contraseña != confirmacionContraseña) // esto valida que la contraseña y su confirmación sean iguales
    {
        Console.WriteLine("Las contraseñas no coinciden. Intente de nuevo.");
        Console.ReadLine();
        Console.Clear();
        crearCuenta(); // vuelve a llamar al método para crear cuenta si las contraseñas no coinciden
        return;
    }

    Console.Write("Cuenta Creada con éxito! Presione Enter para continuar..."); // El mensaje que se mostrará cuando el registro se complete correctamente.
    SesionUsuario objRegistro = new SesionUsuario(nombres, apellidos, fechaNacimiento, nombreUsuario, correo, contraseña);
    Mail.EnviarCorreoBienvenida(correo, nombres);  // Agredo Falta Pulir
    DB.SesionesUsuarios.Add(objRegistro); 
    DB.SaveChanges(); // !!!NUEVO¡¡¡ // Esta linea ejecuta el código de guardado de datos en la BDS de las sesiones del usuario, clasifica los datos segun su respectiva tabla
    Console.ReadLine();
    Console.Clear();
}

/////////////// INICIO DE SESIÓN DE USUARIOS ///////////////
void iniciarSesion()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║                INICIAR SESION              ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Ingrese su nombre de usuario: "); // aquí pedimos ingresar las credenciales como nombre de usuario

    string credencial = Console.ReadLine();

    var db = new BSD();
    var User = db.SesionesUsuarios.FirstOrDefault(a => a.NombreUsuario == credencial); // !!!NUEVO¡¡¡ // Esta es la línea de verificación modificada para asegurar que el nombre exista en nuestra Base de Datos en SQL

    if (User == null)  // esto es la condicional, si el usuario no existe en la base de datos Usuario, mostrará el mensaje de credencial no registrada, caso contrario, pedirá la clave.
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║                INICIAR SESION              ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Usuario no registrado.");
        Console.ReadLine();
        Console.Clear();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║                INICIAR SESION              ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Usuario encontrado: " + User.NombreUsuario); // !!!NUEVO¡¡¡ // Al estar modificada la linea de verificacion de usuario en BSD, tambien se modifica la manera en que imprimimos el usuario con el que queremos logear
        Console.Write("Ingrese su contraseña: ");
        string contraseña = ContraseñaOculta();

        if (User.Contraseña == contraseña)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║        PLATAFORMA BIBLIOTECA VIRTUAL       ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine($"\t      Bienvenido {User.NombreUsuario}"); // una vez dentro la consola mostrará el nombre de usuario que se usó para el inicio de sesion, mostrando su nombre de usuario y las opciones del menu
                User.ImprimirSesionUsuario();
                Console.WriteLine("══════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║                MENU DE USUARIO             ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine(" 1. Agregar libro a mi lista");
                Console.WriteLine(" 3. Listar todos mis libros");
                Console.WriteLine(" 4. Cerrar Sesión");
                Console.WriteLine();
                Console.Write(" Seleccione una opción: ");

                string opcionUsuario = Console.ReadLine();
                
                // Corrección en el switch del menú de usuario para evitar el error CS0163
                switch (opcionUsuario)
                {
                    case "1":
                        BuscarLibroEnOpenLibrary().GetAwaiter().GetResult();
                        // Por la siguiente línea, pasando los argumentos requeridos:
                        Mail.EnviarCorreoPrimerLogro(User.Correo, User.NombreUsuario);
                        break; // Se agrega break para evitar el paso explícito al siguiente case

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Volviendo al Menu Principal.");
                        Console.WriteLine("Presiona ENTER para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                
                }

            }
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta, serás redirigido al menú.");
            Console.ReadLine();
            Console.Clear();
            return;
        }
    }
}

/////////////// REGISTRO DE ADMINISTRADORES ///////////////
void RegistrarAdministrador()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("**************REGISTRO ADMINISTRADOR***************"); // Sigue el mismo protocolo de registro
    Console.Write("Ingrese su nombre de usuario de ADMIN: "); // Pide ingresar un nombre de usuario ADMIN
    string adminUsuario = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Ingrese su fecha de nacimiento (DD/MM/AA): "); // Fecha de nacimiento del ADMIN
    DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Ingrese su contraseña: "); // Contraseña del ADMIN, esta parte no tiene validación de contraseña, pq al ser administradores siempre tenemos acceso al menú de ADMINISTRADORES, es solo el protocolo
    string adminContraseña = ContraseñaOculta();
    Console.WriteLine();
    
    Console.WriteLine("USUARIO ADMINISTRADOR REGISTRADO");
    Console.WriteLine("Ya puedes continuar como administrador.");

    Administradores ObjAdmin = new Administradores(adminUsuario, fechaNacimiento, adminContraseña);
    DB.Admins.Add(ObjAdmin);
    DB.SaveChanges(); // ¡¡¡NUEVO!!! // Guardado en la BSD de SQL
    Console.ReadLine();
    Console.Clear();
}

/////////////// INICIO DE SESIÓN ADMINISTRADORES ///////////////
void IniciarSesionAdmin()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Usuario ADMIN: ");
    string adminUsuario = Console.ReadLine();

    var db = new BSD();
    var UserAdmin = db.Admins.FirstOrDefault(a => a.AdminUsuario == adminUsuario); // !!!NUEVO¡¡¡ // Esta es la línea de verificación modificada para asegurar que el nombre exista en nuestra Base de Datos en SQL
    
    if (UserAdmin == null)  // esto es la condicional, si el usuario no existe en la base de datos ADMINISTRADOR, mostrará el mensaje de credencial no registrada, caso contrario, pedirá la clave.
    {
        Console.WriteLine("ADMIN no registrado.");
        Console.ReadLine();
        Console.Clear();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Usuario encontrado: " + UserAdmin.AdminUsuario); // !!!NUEVO¡¡¡ // Al estar modificada la linea de verificacion de usuario en BSD, tambien se modifica la manera en que imprimimos el usuario con el que queremos logear
        Console.Write("Ingrese su contraseña: ");
        string contraseña = ContraseñaOculta();

        if (UserAdmin.AdminContraseña == contraseña)
        {
            while (true)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red; // Esto modifica el color del menú, para distinguir entre menú principal, menu de usuario y menú de ADMINISTRADOR
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║             Modo Administrador             ║");  // MENU DE ADMINISTRADOR
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine($"\t     ADMIN: {UserAdmin.AdminUsuario}");
                UserAdmin.ImprimirADMIN();
                Console.WriteLine();
                Console.WriteLine("╔════════════════════════════════════════════╗╔════════════════════════════════════════════╗");
                Console.WriteLine("║            MENU OPCIONAL DE LIBROS         ║║           MENU OPCIONAL DE USUARIOS        ║"); // Se usó este estilo compacto para mejorar el resultado visual, y no ocupar mucho espacio en la pantalla de impresión
                Console.WriteLine("╚════════════════════════════════════════════╝╚════════════════════════════════════════════╝");
                Console.WriteLine(" 1. Agregar Libro.                               5. Listar Usuarios.");
                Console.WriteLine(" 2. Ver Lista de Libros.                         6. Modificar un Usuario.");
                Console.WriteLine(" 3. Modificar Datos de Libro.                    7. Eliminar un usuario.");
                Console.WriteLine(" 4. Eliminar Libro.");
                Console.WriteLine();
                Console.WriteLine(" 8. Salir al Menú Principal");
                Console.WriteLine();
                Console.Write(" Seleccione una opción: ");

                string opcionAdmin = Console.ReadLine();
                Console.Clear();
                switch (opcionAdmin)
                {
                    case "1": // el bucle de opciones con operaciones solo disponibles para ADMINISTRADORES
                        Console.Clear();
                        //AgregarNuevoLibro(); // Registrar un nuevo libro
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        //ListaLibros(); // Lista de todos los libros
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        //ModificarLibros(); // Modificar información de libros
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        //EliminarLibro(); // Eliminar un libro de la lista
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        ListaUsuarios(); // Lista de Usuarios
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        ModificarUsuarioComoAdmin(); // Modificar Usuarios
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        EliminarUsuario(); // Eliminar Usuarios
                        Console.Clear();
                        break;
                    case "8":
                        Console.WriteLine("Saliendo del modo ADMIN...");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                }
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("La contraseña es incorrecta...");
            Console.WriteLine("No ha sido posible iniciar sesión.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}


/////////////// LISTA DE USUARIOS PARA ADMINISTRADOR ///////////////
void ListaUsuarios()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║     LISTA DE USUARIOS EN LA BIBLIOTECA     ║"); // Esto imprime la lista completa de todos los libros en la biblioteca
    Console.WriteLine("╚════════════════════════════════════════════╝");

    var db = new BSD();
    var Users = db.SesionesUsuarios.ToList();
    foreach (var Usuarios in Users)
    {
        Usuarios.ImprimirSesionUsuarioParaAdministrador();
    }
    Console.ReadLine();
}

/////////////// MODIFICAR USUARIOS ///////////////
void ModificarUsuarioComoAdmin()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║    MODIFICAR USUARIOS DE LA BIBLIOTECA     ║"); // Esto imprime los libros y proporciona las opciones correspondientes para modificar el libro en cuestión
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();

    var db = new BSD();
    var Users = db.SesionesUsuarios.ToList();
    foreach (var Usuarios in Users)
    {
        Usuarios.ImprimirSesionUsuarioParaAdministrador();
    }
    Console.WriteLine("══════════════════════════════════════════════");
    Console.WriteLine();
    Console.Write("Escriba la ID del Usuario que va a modificar: ");
    int UserID = Convert.ToInt32(Console.ReadLine());

    var ModificarUser = db.SesionesUsuarios.FirstOrDefault(b => b.Id == UserID);
    if (ModificarUser != null)
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║          MODIFICAR DATOS DE USUARIO        ║"); // Esto imprime los libros y proporciona las opciones correspondientes para modificar el libro en cuestión
        Console.WriteLine("╚════════════════════════════════════════════╝");
        ModificarUser.ImprimirSesionUsuarioParaAdministrador();
        Console.WriteLine("══════════════════════════════════════════════");
        Console.Write("Seleccione el dato que se va a modificar: ");
        int OpcionMod = Convert.ToInt32(Console.ReadLine());

        Console.ReadLine();
    }
}

///////////////////////// ELIMINAR USUARIOS /////////////////////////
void EliminarUsuario()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║     ELIMINAR USUARIOS DE LA BIBLIOTECA     ║"); // Esto imprime los libros y proporciona las opciones correspondientes para modificar el libro en cuestión
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();

    var db = new BSD();
    var Users = db.SesionesUsuarios.ToList();
    foreach (var Usuarios in Users)
    {
        Usuarios.ImprimirSesionUsuarioParaAdministrador();
    }
    Console.WriteLine("══════════════════════════════════════════════");
    Console.WriteLine();
    Console.Write("Escriba la ID del Usuario que va a eliminar: ");
    int UserID = Convert.ToInt32(Console.ReadLine());

    var EliminarUser = db.SesionesUsuarios.FirstOrDefault(b => b.Id == UserID);
    if (EliminarUser != null)
    {
        Console.Clear();
        Console.WriteLine("Usuario seleccionado: ");
        EliminarUser.ImprimirSesionUsuario();
        Console.WriteLine("══════════════════════════════════════════════");
        Console.WriteLine();
        Console.WriteLine("¿Está seguro que desea eliminar este Usuario? (S/N)");
        string confirmacion = Console.ReadLine();

        if (confirmacion?.ToUpper() == "S")
        {
            db.SesionesUsuarios.Remove(EliminarUser);
            db.Usuarios.Remove(EliminarUser);

            

            db.SaveChanges();
            Console.WriteLine("Usuario eliminado correctamente.");
            Console.ReadLine();
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Operación cancelada.");
            Console.WriteLine("Volviendo al menu ADMINISTRADOR...");
            Console.ReadLine();
            Console.Clear();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("No se encontró al Usuario.");
        Console.WriteLine("Volviendo al menu ADMINISTRADOR...");
        Console.ReadLine();
        Console.Clear();
    }

}

/////////////// CÓDIGO PARA OCULTAR/HASHTEAR LA CONTRASEÑA ///////////////
static string ContraseñaOculta() // Esta funcion permite realizar la creación de contraseña privada ocultando los caracteres e imprimiento "*" en lugar de mostrar las letras
{
    string contraseña = "";
    ConsoleKeyInfo key;
    do
    {
        key = Console.ReadKey(true); // lee las letras ingresadas
        if (!char.IsControl(key.KeyChar)) // esto define un operador NOT lógico usando "!" = "si la tecla ingresada NO es una tecla de control''
        {
            contraseña += key.KeyChar; // la funcion contraseña = contraseña + caracter, pero simplificada
            Console.Write("*");
        }
        else if (key.Key == ConsoleKey.Backspace && contraseña.Length > 0) // esa condificonal aplica que si la tecla presiona es backspace no sumará las teclas como "*" dentro de la clave
        {
            contraseña = contraseña.Remove(contraseña.Length - 1);
            Console.Write("\b \b");  // el uso del doble "\b" es para borrar correctamente los caracteres dentro del campo de la contraseña, uno coloca el cursor al final de la palabra mientras que el otro elimina correctamente los *, si se usara solo uno, borraría el caracter pero en la pantalla seguiría apareciendo el "*"
        }
    }
    while (key.Key != ConsoleKey.Enter); // Mientras la tecla presionada no sea ENTER el campo seguirá recibiendo cada caracter como parte de la contraseña, exceptuando las teclas de comando
    Console.WriteLine();
    return contraseña;
}

/////////////////// AQUI EMPIEZA LA FUNCIÓN PARA BUSCAR LIBROS EN OPENLIBRARY Y GUARDARLOS EN LA BASE DE DATOS LOCAL///////////////////
static async Task BuscarLibroEnOpenLibrary() // Esta función permite buscar libros en la API de OpenLibrary y guardar los seleccionados en la base de datos local
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("***** BÚSQUEDA DE LIBROS EN OPENLIBRARY *****"); // Título del módulo
    Console.Write("Ingrese el título del libro a buscar: ");
    string titulo = Console.ReadLine(); // Lee el título del libro ingresado por el usuario

    var apiService = new ApiService(); // Crea una instancia del servicio API
    var libros = await apiService.BuscarLibrosPorTituloAsync(titulo); // Llama al método asíncrono para buscar libros por título

    if (libros.Count == 0) // Verifica si se encontraron libros
    {
        Console.WriteLine("No se encontraron libros con ese título."); // Mensaje si no se encuentran libros
    }
    else
    {
        Console.WriteLine("\nResultados encontrados:"); // Muestra los resultados encontrados
        int i = 1; // Contador para numerar los libros
        foreach (var libro in libros.Take(10)) // Muestra solo los primeros 10 resultados (puede ser ajustable)
        {
            Console.WriteLine($"{i++}. {libro.Titulo} - {libro.Autor} ({libro.Año?.ToString() ?? "Año desconocido"})"); // Imprime el título, autor y año del libro
        }

        Console.Write("\n¿Desea guardar alguno de estos libros en la base de datos? (s/n): "); // Pregunta si el usuario desea guardar un libro
        var respuesta = Console.ReadLine(); // Lee la respuesta del usuario
        if (respuesta?.ToUpper() == "S") // Si la respuesta es "s" (sí), procede a guardar el libro
        {
            Console.Write("Ingrese el número del libro a guardar (1-10): "); // Solicita el número del libro a guardar
            if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion >= 1 && seleccion <= libros.Take(10).Count()) // Valida la selección del usuario
            {
                var libroSeleccionado = libros[seleccion - 1]; // Obtiene el libro seleccionado basado en la entrada del usuario
                var nuevoLibro = new ProyectoBibliotecaVirtual.Models.Libro // Crea una nueva instancia del modelo Libro para guardar en la base de datos
                {
                    Titulo = libroSeleccionado.Titulo,
                    Autor = libroSeleccionado.Autor,
                    Año = libroSeleccionado.Año
                };

                var DB = new ProyectoBibliotecaVirtual.Context.BSD(); // Crea una nueva instancia del contexto de la base de datos
                DB.Libros.Add(nuevoLibro); // Agrega el nuevo libro al contexto
                DB.SaveChanges(); // Guarda los cambios en la base de datos

                Console.WriteLine("¡Libro guardado exitosamente en la base de datos!");
            }
            else
            {
                Console.WriteLine("Selección inválida. No se guardó ningún libro."); // Mensaje si la selección es inválida
            }
        }
    }
    Console.WriteLine("\nPresione Enter para continuar...");
    Console.ReadLine();
    Console.Clear();
}
