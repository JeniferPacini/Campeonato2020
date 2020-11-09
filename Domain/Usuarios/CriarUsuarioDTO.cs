using System;
using System.Collections.Generic;

namespace Domain.Usuarios
{
    public class CriarUsuarioDto
    {
        public Guid Id { get; private set; }
        public IList<string> Erros { get; set; }
        public bool Valido { get; set; }

        public CriarUsuarioDto(Guid id)
        {
            Id = id;
            Valido = true;

        }
        public CriarUsuarioDto(IList<string> erros)
        {
            Erros = erros;
            Valido = false;
        }
    }
}
