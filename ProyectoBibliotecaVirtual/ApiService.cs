using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;

public class ApiService // Servicio para interactuar con la API de Open Library
{
    private readonly HttpClient _httpClient; // Cliente HTTP para realizar solicitudes

    public ApiService() // Constructor que inicializa el HttpClient con la URL base de la API
    {
        _httpClient = new HttpClient // Inicializa el cliente HTTP
        {
            BaseAddress = new Uri("https://openlibrary.org/") // Establece la URL base de la API
        };
    }

    // Buscar libros por título
    public async Task<List<LibroApiDto>> BuscarLibrosPorTituloAsync(string titulo)
    {
        // Codifica el título para URL
        string endpoint = $"search.json?title={Uri.EscapeDataString(titulo)}";
        var response = await _httpClient.GetAsync(endpoint); // Realiza la solicitud GET
        response.EnsureSuccessStatusCode(); // Lanza una excepción si la respuesta no es exitosa

        var json = await response.Content.ReadAsStringAsync(); // Lee el contenido de la respuesta como cadena

        // Deserializa solo los campos necesarios
        var resultado = JsonSerializer.Deserialize<OpenLibraryResponse>(json); // Deserializa la respuesta JSON

        // Mapea a una lista de DTOs simples
        var libros = new List<LibroApiDto>(); // Lista para almacenar los libros encontrados
        if (resultado?.docs != null) // Verifica que la respuesta y los documentos no sean nulos
        {
            foreach (var doc in resultado.docs) // Itera sobre cada documento
            {
                libros.Add(new LibroApiDto // Agrega un nuevo libro a la lista
                {
                    Titulo = doc.title, // Título del libro
                    Autor = doc.author_name != null ? string.Join(", ", doc.author_name) : "Desconocido", // Maneja múltiples autores
                    Año = doc.first_publish_year // Año de la primera publicación
                });
            }
        }
        return libros;
    }
}

// Clases para deserializar la respuesta de la API
public class OpenLibraryResponse // Representa la respuesta completa de la API
{
    public List<Doc> docs { get; set; } // Lista de documentos (libros) en la respuesta
}

public class Doc // Representa un libro en la respuesta de la API
{
    public string title { get; set; }
    public List<string> author_name { get; set; }
    public int? first_publish_year { get; set; }
}

// Aqui definimos un DTO (transferencia de objetos de datos) simple para los libros 
public class LibroApiDto // DTO para transferir datos de libros de manera simplificada
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int? Año { get; set; }
}