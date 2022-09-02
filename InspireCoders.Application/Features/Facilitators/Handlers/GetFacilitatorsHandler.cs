using AutoMapper;
using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Facilitators.Queries;
using InspireCoders.Application.Features.Facilitators.ViewModels;
using InspireCoders.Domain.Entities;
using MediatR;

namespace InspireCoders.Application.Features.Facilitators.Handlers
{
    public class GetFacilitatorsHandler : IRequestHandler<GetFacilitatorsQuery, IEnumerable<GetFacilitatorsVm>>
    {
        private readonly IFacilitatorFakeDataStore _fakeDataStore;
        private readonly IMapper _mapper;
        public GetFacilitatorsHandler(IFacilitatorFakeDataStore fakeDataStore, IMapper mapper)
        {
            _fakeDataStore = fakeDataStore;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<GetFacilitatorsVm>> Handle(GetFacilitatorsQuery request,
            CancellationToken cancellationToken)
        {
            var facilitators = await _fakeDataStore.GetAllFacilitators();
            return _mapper.Map<List<GetFacilitatorsVm>>(facilitators);
        } 
    }
}
