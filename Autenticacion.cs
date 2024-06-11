using System.Linq;

public static class Autenticacion
{
    // Método para validar las credenciales del usuario
    public static bool ValidarCredenciales(string username, string password)
    {

        // Verificar si las credenciales coinciden con el conjunto específico de administrador
        if (username == "2" && password == "2")
        {
            return true;  // Credenciales válidas para el administrador
        }
        if (username == "1" && password == "1")
        {
            return true;  // Credenciales válidas para el administrador
        }
        // Lógica de validación, buscar las credenciales en la lista
        return Registro.credencialesUsuarios.Any(c => c.Usuario == username && c.Contraseña == password);
    }

    public static bool EsAdmin(string username)
    {
        // Lógica para determinar si el usuario es administrador
        return username == "2";
    }
}

// Clase para representar las credenciales de usuario
public class CredencialUsuario
{
    public string Usuario { get; set; }
    public string Contraseña { get; set; }
    public bool EsAdmin { get; set; }
}


