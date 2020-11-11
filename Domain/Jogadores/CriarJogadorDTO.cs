using System;
using System.Collections.Generic;

namespace Domain.Jogadores
{
    public class CriarJogadorDto
    {
        public Guid Id { get; private set; }
        public IList<string> Erros { get; set; }
        public bool Valido { get; set; }

        public CriarJogadorDto(Guid id)
        {
            Id = id;
            Valido = true;

        }
        public CriarJogadorDto(IList<string> erros)
        {
            Erros = erros;
            Valido = false;
        }
    }
}
