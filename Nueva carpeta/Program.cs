internal class Program
{
    private static void Main(string[] args)
    {
        Comercial comercial1 = new Comercial("Tubais",20,1000,250);
        Repartidor repartidor1 = new Repartidor("Alan",19,200,"Zona 3");

        Comercial comercial2 = new Comercial("Jerick",31,500,210);
        Repartidor repartidor2 = new Repartidor("Jean",26,400,"Zona 2");

        comercial1.plus();
        repartidor1.plus();
        comercial2.plus();
        repartidor2.plus();

List<Empleado> empleado = new List<Empleado>();
        empleado.Add(comercial1);
        empleado.Add(comercial2);
        empleado.Add(repartidor1);
        empleado.Add(repartidor2);
    
        foreach (Empleado item in empleado)
        {
            item.mostrar();
            item.plus();
        }
    }
}