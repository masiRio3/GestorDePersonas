using GestorDePersonas.Modelos;


namespace GestorDePersonas.Repositorio
{
    public class RepositorioDePersonas
    {
        //public List <Persona> Personas { get; set; }

        // Usamos un diccionario para guardar las personas. (Pares de Datos Clave-Valor
        public Dictionary<string, Persona> Personas { get; set; }

        public RepositorioDePersonas() //constructor
        {
            Personas = new Dictionary<string, Persona>();
        }

        public void Insertar(Persona persona)
        {
            //var numeroDocumento = persona.NumeroDeDocumento;
            var personaExiste = Personas.ContainsKey(persona.NumeroDeDocumento);

            if (!personaExiste)
            {
                Personas[persona.NumeroDeDocumento] = persona;

                //Personas.Add(persona.NumeroDeDocumento, persona);
            }

            //Personas.Add(persona);
        }

        public void Eliminar(string numeroDocumento)
        {
            //foreach (var personaActual in Personas)
            //{
            //    if (personaActual.NumeroDeDocumento == numeroDocumento)
            //    {
            //        Personas.Remove(personaActual);
            //    }

            //    else
            //    {
            //        Console.WriteLine("No se encontro una persona con ese D.N.I.");
            //    }

            //} MI SOLUCION!!! :)


            //SOLUCION DEL PROFE
            //(Lista)

            //Persona personaAEliminar=null;
            //foreach (var persona in Personas)
            //{
            //    if (persona.NumeroDeDocumento == numeroDocumento)
            //    {
            //        personaAEliminar = persona;
            //        break;
            //    }
            //}

            //if (personaAEliminar!=null)
            //{
            //    Personas.Remove(personaAEliminar);
            //}

            //(DICCIONARIO)

            Personas[numeroDocumento] = null;


        }

        public void Actualizar(Persona persona)
        {
            //Definir como actualizar una persona de la lista

            //(LISTA)
            //foreach (var personaActual in Personas)
            //{
            //    if (personaActual.NumeroDeDocumento == persona.NumeroDeDocumento)
            //    {
            //        personaActual.Nombre = persona.Nombre;
            //        personaActual.Apellidos = persona.Apellidos;
            //        personaActual.FechaNacimiento = persona.FechaNacimiento;
            //    }

            //}

            //(DICCIONARIO)
            var personaAActualizar = Personas[persona.NumeroDeDocumento];

            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = persona.Nombre;
                personaAActualizar.Apellidos = persona.Apellidos;
                personaAActualizar.FechaNacimiento = persona.FechaNacimiento;
            }


        }

        //Sobrecarga que permite actualizar alguno de los datos

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {

            //(LISTA)
            //foreach (var personaActual in Personas)
            //{
            //    if (personaActual.NumeroDeDocumento==numeroDocumento)
            //    {
            //        personaActual.Nombre = nombre;
            //        personaActual.Apellidos = apellido;
            //    }
            //}

            //(DICCIONARIO)

            var personaAActualizar = Personas[numeroDocumento];
            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = nombre;
                personaAActualizar.Apellidos = apellido;
            }
        }

        public bool Existe(string numeroDocumento)
        {
            return Personas.ContainsKey(numeroDocumento);
        }

        public bool Existe(Persona persona)
        {
            return Existe(persona.NumeroDeDocumento);
        }

        

    }
}
