//Un controller è una classe pubblica con uno o più metodi pubblici chiamati azioni. 
//Per convenzione, un controller viene posizionato nella directory Controllers della radice del progetto. 
//Le azioni vengono esposte come endpoint HTTP all'interno del controller dell'API Web.

using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
    PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
    var pizza = PizzaService.Get(id);

    if(pizza == null)
        return NotFound();

    return pizza;
    }

    // POST action

    // PUT action

    // DELETE action
}