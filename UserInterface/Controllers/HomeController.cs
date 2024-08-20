using DemoLibrary.Models;
using DemoLibrary.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using UserInterface.Models;

namespace UserInterface.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public MediatR.IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, MediatR.IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            List<PersonModel> people = new();

            // the ".Send() command" is the only command we really need when using this pattern
            // -> input the query
            people = await _mediator.Send(new GetPersonListQuery());

            return View(people);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}