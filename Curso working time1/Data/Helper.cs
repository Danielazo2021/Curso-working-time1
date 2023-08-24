using Curso_working_time1.Model;

namespace Curso_working_time1.Data
{
    public  class Helper {
        private static Helper instance;

        public List<Persona> personas { get; set; } = new List<Persona>();

        public static Helper GetInstance()
        {                         
            if (instance == null)
            {
                instance = new Helper();
            }                
            
            return instance;
        }

            
        public void addPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void removePersona(int id)
        {
            for(int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Id ==id)
                {
                    personas.Remove(personas[i]);
                }
            }
            
        }

    }
}
