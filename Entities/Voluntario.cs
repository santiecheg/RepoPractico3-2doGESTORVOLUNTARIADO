using System;

public class Voluntario : Empleado
{
    private int horasTrabajadas;

    public int HorasTrabajadas {get {return this.horasTrabajadas;} set{this.horasTrabajadas=value;}}


    public Voluntario(string nombre,int horasTrabajadas):base (nombre)
    {
        this.horasTrabajadas=horasTrabajadas;
    }
}