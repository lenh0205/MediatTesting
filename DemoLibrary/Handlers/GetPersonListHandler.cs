using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    // -> the handle will be the one that contain all the works
    // -> we can initiate this class without "mediatR" - convenient for Unit Test

    // handle 1 Query or 1 Command ("GetPersonListQuery" in this case) as the input
    // and output the "List<PersonModel>"
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;
        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }

        // the "GetPersonListQuery" is the data we need for the request
        // CancellationToken - because everything in mediatR is asynchronous
        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}
