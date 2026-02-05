using MediatR;
using MeuCorre.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    public class AtualizarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "Id da Tag é obrigatório")]
        public required Guid TagId { get; set; }

        [Required(ErrorMessage = "Nome da Tag é obrigatório")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Cor da Tag é obrigatório")]
        public required string Cor { get; set; }
    }
    internal class AtualizarTagCommandHandler : IRequestHandler<AtualizarTagCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(AtualizarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
