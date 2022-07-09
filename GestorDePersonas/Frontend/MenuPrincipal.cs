

using GestorDePersonas.Modelos;
using GestorDePersonas.Repositorio;

namespace GestorDePersonas.Frontend
{
    public class MenuAplicacion     
    {
        private RepositorioDePersonas _repositorio;

        public MenuAplicacion()
        {
            _repositorio = new RepositorioDePersonas();

        }
        public void Iniciar()
        {
            Console.WriteLine("Bienvenido al Gestor de Personas");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1. Agregar persona");
            Console.WriteLine("2. Listar persona");
            Console.WriteLine("3. Eliminar persona");
            Console.WriteLine("4. Salir");

            int opcionElegidaMenuPrincipal;

            do
            {
                opcionElegidaMenuPrincipal = Convert.ToInt32(Console.ReadLine());

                switch (opcionElegidaMenuPrincipal)
                {
                    case 1:
                        MostrarAgregarPersona();
                        break;
                    //case 2:
                    //    MostrarListarPersonas();
                    //    break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (opcionElegidaMenuPrincipal != 4);



        }

        public void MostrarAgregarPersona()
        {
            Console.WriteLine("Ingrese el tipo de la persona: ");
            Console.WriteLine("1 - Empleado");
            Console.WriteLine("2 - Desempleado");
            Console.WriteLine("3 - Jubilado");

            Persona personaAAgregar;

            var opcionTipoPersona = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese los apellidos: ");
            var apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: (formato DD/MM/AAAA)");
            var fechaNacimiento = Console.ReadLine();

            switch (opcionTipoPersona)
            {
                case 1:
                    //Crear el empleado
                    var empleado = new Empleado
                    {
                        Nombre = nombre,
                        Apellidos = apellidos,
                        FechaNacimiento = fechaNacimiento

                    };
                    Console.WriteLine("Ingrese ocupacion");
                    empleado.Ocupacion = Console.ReadLine();
                    Console.WriteLine("Ingrese la empresa en la que trabaja");
                    empleado.Empresa = Console.ReadLine();
                    Console.WriteLine("Ingrese la obra social");
                    empleado.ObraSocial = Console.ReadLine();
                    // _repositorio.Insertar(empleado);
                    personaAAgregar = empleado;
                    break;
                    
                case 2:
                    // Crear el desempleado
                    var desempleado = new Desempleado
                    {
                        Nombre = nombre,
                        Apellidos = apellidos,
                        FechaNacimiento = fechaNacimiento
                    };
                    Console.WriteLine("Ingrese ultima ocupacion");
                    desempleado.UltimaOcupacion = Console.ReadLine();
                    Console.WriteLine("Ingrese ultima empresa en la que trabajo");
                    desempleado.UltimaEmpresa = Console.ReadLine();
                    Console.WriteLine("Es discapacitado? S/N");
                    var discapacitado = Console.ReadLine();
                    if (discapacitado.ToUpper() == "S")
                    {
                        desempleado.esDiscapacitado = true;
                    }
                    // _repositorio.Insertar(desempleado);
                    personaAAgregar = desempleado;
                    break;
                    
                case 3:
                    //Crear el jubilado
                    var jubilado = new Jubilado
                    {
                        Nombre = nombre,
                        Apellidos = apellidos,
                        FechaNacimiento = fechaNacimiento
                    };
                    Console.WriteLine("Ingrese los años de aporte");
                    jubilado.AniosDeAporte = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la categoria");
                    jubilado.Categoria = Convert.ToChar(Console.ReadLine());
                    //_repositorio.Insertar(jubilado);
                    personaAAgregar = jubilado;
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    return;
                    break;
            }
            _repositorio.Insertar(personaAAgregar);
            Console.WriteLine("Persona Agregada correctamente");
            //Console.ReadKey();
        }

    }
}
