using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;

    // -> equivalent to class:
    //public class GetPersonByIdQueryClass : IRequest<PersonModel>
    //{
    //    public int Id { get; set; }
    //    public GetPersonByIdQueryClass(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
