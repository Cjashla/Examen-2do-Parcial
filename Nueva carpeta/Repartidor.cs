class Repartidor:Empleado
{
    public String Zona {get; set;}
    public Repartidor(string nombre, int edad, double salario, String Zona):base(nombre, edad, salario)
    {
        this.Zona=Zona;
    }
    public new void plus()
    {
        if(Edad<25 && Zona=="Zona 3")
        {
           salario=salario+PLUS; 
        }
    }
    public new void mostrar()
    {
        Console.WriteLine("El nombre del empleado es:"+nombre);
        Console.WriteLine("La edad del empleado es: "+Edad);
        Console.WriteLine("La zona donde se encuentra el trabajador"+nombre+" es: "+Zona);
        Console.WriteLine("El salario del Empleado es:"+salario);
    }
}