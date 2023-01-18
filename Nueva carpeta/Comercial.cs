class Comercial: Empleado
{
    public double comision{get; set;}
    public Comercial(string nombre, int edad, double salario,double comision):base(nombre, edad, salario)
    {
        this.comision=comision;
    }
    public new void plus()
    {
        if(Edad>30 && comision>200)
        {
           salario=salario+PLUS; 
        }
    }
    public new void mostrar()
    {
        Console.WriteLine("El nombre del empleado es:"+nombre);
        Console.WriteLine("La edad del empleado es: "+Edad);
        Console.WriteLine("La comision del empleado "+nombre+" es: "+comision);
        Console.WriteLine("El salario del Empleado es:"+salario);
    }
    
}