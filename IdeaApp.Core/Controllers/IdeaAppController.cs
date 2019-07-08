using IdeaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdeaApp.Core.Controllers
{
    /// <summary>
    /// [5] ASP.NET 컨트롤러 클래스
    /// </summary>
    public class IdeaAppController : Controller
    {
        private IIdeaRepository _repository;

        public IdeaAppController(IIdeaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var ideas = _repository.GetAll();
            return View(ideas);
        }

        [HttpPost]
        public IActionResult Index(Idea model)
        {
            model = _repository.Add(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
