using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    // "record" is "class" but they got some additional systax; and part of that is "we create them once and then in theory they are unchangeable"
    // the "IRequest" is using for "Query" and "Command"s

    // this "record" has no params - implement interface from "MediatR" - return a "List<PersonModel>"
    // this is where we identify "what the handler is?" - each "query" will only have one "handler"
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    // -> equivalent to:
    //public class GetPersonListQueryClass : IRequest<List<PersonModel>> {}
}
// -> the "query" is a read only action (not modify data)