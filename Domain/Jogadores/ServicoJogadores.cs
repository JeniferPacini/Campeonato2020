namespace Domain.Jogadores
{
    public class ServicoJogadores
    {
        public CriarJogadorDto Create(string nome)
        {
            var jogador = new Jogador(nome);
            var validacaoJogador = jogador.Validar();

            if(validacaoJogador.valido)
            {
                RepositorioJogadores.Add(jogador);
                return new CriarJogadorDto(jogador.Id);
            }

            return new CriarJogadorDto(validacaoJogador.erros);
        }
    }
}
