using Curso_working_time1.Model;
using Curso_working_time1.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Curso_working_time1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _personaServicio;

        public PersonaController(PersonaService personaServicio)
        {
            _personaServicio = personaServicio;
        }


        // GET: api/<PersonaController>
        [HttpGet]
        public IActionResult GetPersonas()
        {
            var personas = _personaServicio.getPersonas();
            return Ok(personas.Result);
        }


        [HttpPost]
        public  IActionResult AddPersona([FromBody] Persona persona)
        {
            var respuesta = _personaServicio.addPersonas(persona);

            return Ok(respuesta.Result);


        }
      

        [HttpDelete("{id}")]
        public IActionResult RemovePersona(int id)
        {
            return Ok(_personaServicio.removePersonas(id).Result);
           
        }


    }
}
