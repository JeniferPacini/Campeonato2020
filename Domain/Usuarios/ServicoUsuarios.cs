namespace Domain.Usuarios
{
    public class ServicoUsuarios
    {
        public CriarUsuarioDto Create(string nome, bool cbf)
        {
            var usuario = new Usuario(nome, cbf);
            var validacaoUsuario = usuario.Validar();

            if(validacaoUsuario.valido)
            {
                RepositorioUsuarios.Add(usuario);
                return new CriarUsuarioDto(usuario.Id);
            }

            return new CriarUsuarioDto(validacaoUsuario.erros);
        }
    }
}
