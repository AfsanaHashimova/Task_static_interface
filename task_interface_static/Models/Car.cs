

namespace task_interface_static.Models;

internal class Car
{
    public Car()
    { 
        Count++;
        Id = Count;
    }


    public int Id;
    private static int Count;
    public string Name;
    public string Color;
    public int Speed;



}
