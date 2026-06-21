/* 

sistema de voluntariado desarrollar un sistema de consola, que permita:

*administrar personas de una organización solidaria 

deben existir, voluntarios y coordinadores .

los voluntarios deberán mostrar cantidad de horas trabajadas 
y los coordinadores áreas asignadas y cantidad de personas a cargo. 

*/

using System;
using System.Dynamic;

public abstract class Empleado
{
    private string nombre;

    public string Nombre {get {return this.nombre;} set{this.nombre=value;}}

    public Empleado (string nombre)
    {
        this.nombre=nombre;
    }

}