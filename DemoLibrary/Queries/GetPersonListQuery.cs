using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    // "record" is "class" but they got some additional systax; and part of that is "we create them once and then in theory they are unchangeable"

    // this "record" has no params - implement interface from "MediatR" - return a "List<PersonModel>"
    // this is where we identify "what the handler is?" - each "query" will have one "handler"
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
    // same as: public class GetPersonListQueryClass : IRequest<List<PersonModel>> {}
}
