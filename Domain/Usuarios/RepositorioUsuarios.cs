using System;
using System.Collections.Generic;

namespace Domain.Usuarios
{
    public class RepositorioUsuarios
    {
        private static List<Usuario> _usuarios = new List<Usuario>();
        public static IReadOnlyCollection<Usuario> Usuarios => _usuarios;

        public static void Add(Usuario usuario)
        {
            
            _usuarios.Add(usuario);
        }
    }
}
