using AutoMapper;
using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Features.Forums.Queries;
using InspireCoders.Application.Features.Forums.ViewModels;
using MediatR;

namespace InspireCoders.Application.Features.Forums.Handlers
{
    public class GetForumsHandler : IRequestHandler<GetForumsQuery, IEnumerable<GetForumsVm>>
    {
        private readonly IForumFakeDataStore _fakeDataStore;
        private readonly IMapper _mapper;
        public GetForumsHandler(IForumFakeDataStore fakeDataStore, IMapper mapper)
        {
            _fakeDataStore = fakeDataStore;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<GetForumsVm>> Handle(GetForumsQuery request,
            CancellationToken cancellationToken)
        {
            var Forums = await _fakeDataStore.GetAllForums();
            return _mapper.Map<List<GetForumsVm>>(Forums);
        }
    }
}
