using System.Collections.Generic;
using System.Linq;

public static class Registro
{
    // Lista para almacenar las credenciales de usuario
    public static List<CredencialUsuario> credencialesUsuarios = new List<CredencialUsuario>();

    // Clase para representar las credenciales de usuario
    public class CredencialUsuario
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
       
    }

    // Método para validar las credenciales del nuevo usuario
    public static bool NuevoUsuarioValido(string nuevoUsuario, string nuevaContraseña)
    {
        // Lógica de validación, por ejemplo, verificar si el usuario ya existe en la lista
        if (!string.IsNullOrWhiteSpace(nuevoUsuario) && !string.IsNullOrWhiteSpace(nuevaContraseña))
        {
            // Verificar si el usuario ya existe
            if (credencialesUsuarios.Any(c => c.Usuario == nuevoUsuario))
            {
                return false; // El usuario ya existe
            }

            // Agregar nuevas credenciales a la lista
            credencialesUsuarios.Add(new CredencialUsuario { Usuario = nuevoUsuario, Contraseña = nuevaContraseña });
            return true; // Registro exitoso
        }

        return false; // Usuario o contraseña vacíos
    }

   
}

