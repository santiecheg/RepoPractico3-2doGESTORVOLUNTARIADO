using System;

public class Coordinador:Empleado
{
    private string areaAsignada;

    private int personasACargo;

    public string AreaAsignada {get {return this.areaAsignada;} set{this.areaAsignada=value;}}

    public int PersonasACargo {get {return this.personasACargo;} set{this.personasACargo=value;}}

    public Coordinador (string nombre, string areaAsignada, int personasACargo):base(nombre)
    {
        this.areaAsignada=areaAsignada;
        this.personasACargo=personasACargo;
    }

    public override void MostrarDatosEmpleado()
    {
        base.MostrarDatosEmpleado();
        Console.WriteLine($"Area asignada: {this.areaAsignada}");
        Console.WriteLine($"Personas a cargo: {this.personasACargo}");
    }
}