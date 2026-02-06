using MeuCorre.Domain.Entities;
using MeuCorre.Domain.Enums;
using MeuCorre.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Infra.Repositories
{
    public class TagRepository : ITagRepository
    {
        public Task AdicionarAsync(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExisteAsync(Guid tagId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Tag>> ListarTodasPorUsuarioAsync(Guid usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NomeExisteParaUsuarioAsync(string nome, TipoTransacao tipo, Guid usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<Tag?> ObterPorIdAsync(Guid TagId)
        {
            throw new NotImplementedException();
        }

        public Task RemoverAsync(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
