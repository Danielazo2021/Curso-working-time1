using Curso_working_time1.Model;
using Curso_working_time1.Data;

namespace Curso_working_time1.Service
{
    public class PersonaService
    {
        public async Task<List<Persona>> getPersonas()
        {
            return Helper.GetInstance().personas;
        }

        public async Task<List<Persona>> addPersonas(Persona persona)
        {
            Helper.GetInstance().personas.Add(persona);
            return   Helper.GetInstance().personas;
        }

        public async Task<List<Persona>> removePersonas(int id)
        {
            Helper.GetInstance().removePersona(id);

            return Helper.GetInstance().personas;
        }


    }
}
