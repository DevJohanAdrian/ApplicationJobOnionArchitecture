

using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Application.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Feautres.Company.Commands.CreateCompanyCommand
{
    public class CreateCompanyCommand : IRequest<Response<int>>
    {
        public string CompanyName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
    public class CreateClienteCommandHandler : IRequestHandler<CreateCompanyCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Company> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateClienteCommandHandler(IRepositoryAsync<Cliente> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<Company>(request);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);

            return new Response<int>(data.Id);
        }
    }
}
