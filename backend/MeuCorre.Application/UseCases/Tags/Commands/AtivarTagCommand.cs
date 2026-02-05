using MediatR;
using MeuCorre.Application.UseCases.Categorias.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    public class AtivarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "É necessário informar o ID da Tag")]
        public required Guid TagId { get; set; }
    }
    internal class AtivarCategoriaCommandHandler : IRequestHandler<AtivarCategoriaCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(AtivarCategoriaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
