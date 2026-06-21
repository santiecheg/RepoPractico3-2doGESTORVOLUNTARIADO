using System;

/*
sistema de voluntariado desarrollar un sistema de consola, que permita:

*administrar personas de una organización solidaria 

deben existir, voluntarios y coordinadores .

los voluntarios deberán mostrar cantidad de horas trabajadas 
y los coordinadores áreas asignadas y cantidad de personas a cargo. 

*/

public class Program
{

    static List<Empleado> listaEmpleados =new List<Empleado>();
    static void Main()
    {

        MostrarMenu();

    }

    static public void MostrarMenu()
    {

        int opcion = 10;

        while (opcion != 0)
        {
            int opcionUsuario = 10;
            Console.WriteLine("Bienvenido al programa de gestor de voluntarios");


            Console.WriteLine("Opcion 1 Crear Voluntario");
            Console.WriteLine("Opcion 2 Crear Coordinador");
            Console.WriteLine("Opcion 3 Eliminar Empleado");
            Console.WriteLine("Opción 4 Ver empleados");
            Console.WriteLine("Opción 5 Salir");

            Console.WriteLine("Ingrese opción elegida");
            opcionUsuario = int.Parse(Console.ReadLine());

            switch (opcionUsuario)
            {

                case 1:
                    CrearVoluntario();
                    break;

                case 2:
                    CrearCoordinador();
                    break;

                case 3:
                    EliminarEmpleado();
                    break;

                case 4:
                    VerEmpleados();
                    break;

                case 5:
                    Console.WriteLine("Ha elegido salir, gracias por utilizar gestor de voluntariados gatito");
                    opcion = 0;
                    break;
                default:
                    Console.WriteLine("Elija una opción válida");
                    break;

            }
        }
    }

/* 
public Voluntario(string nombre,int horasTrabajadas):base (nombre)
    {
        this.horasTrabajadas=horasTrabajadas;
    }
*/
    static public void CrearVoluntario(){

        Console.Clear();
        Console.WriteLine("Has elegido la opción de crear Voluntario");

        Console.WriteLine("Ingrese nombre");
        string nombre =Console.ReadLine();

        Console.WriteLine("Ingrese horas trabajadas");
        int horasTrabajadas=int.Parse(Console.ReadLine());

        listaEmpleados.Add(new Voluntario(nombre,horasTrabajadas));


    }

    static public void CrearCoordinador(){

        Console.Clear();
        Console.WriteLine("Has elegido la opción de crear Coordinador");

        Console.WriteLine("Ingrese nombre");
        string nombre =Console.ReadLine();


        Console.WriteLine("Ingrese area asignada");
        string area=Console.ReadLine();

        Console.WriteLine("Ingrese personas a cargo");
        int personasACargo=int.Parse(Console.ReadLine());

        listaEmpleados.Add(new Coordinador(nombre,area,personasACargo));

    }

    static public void EliminarEmpleado(){

        int indiceDeEmpleadoAEliminar=0;

        foreach (Empleado c in listaEmpleados){
            indiceDeEmpleadoAEliminar++;
            Console.WriteLine($"Empleado de nombre: {c.Nombre} tiene el número {indiceDeEmpleadoAEliminar}");
        }

        Console.WriteLine("Escriba el índice del empleado que desea eliminar");
        int empleadoAeliminarIngresadoPorUsuario=int.Parse(Console.ReadLine());

        
        listaEmpleados.RemoveAt((empleadoAeliminarIngresadoPorUsuario-1));
        Console.WriteLine("Empleado eliminado con éxito");

    }

    static public void VerEmpleados(){

        Console.WriteLine("\n =============================__=======================");
        Console.WriteLine(" \n Opcion de reporte de empleados");
        foreach (Empleado c in listaEmpleados){

            Console.WriteLine("\n =============================__=======================");
            c.MostrarDatosEmpleado();           

        }

    }
}