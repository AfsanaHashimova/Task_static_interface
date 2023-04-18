

namespace task_interface_static.Models;

internal class Galery
{

    Car[] cars=new Car[0];

    public Galery()
    {
        Count++;
        Id = Count;
    }
    
    public int Id;
    private static int Count;



     public void AddCar(Car car)
    {
        
        Array.Resize<Car>(ref cars, cars.Length+1);
        cars[cars.Length-1]=car;

        
    
    }

     public void ShowAllCars()
    {
        foreach (Car car in cars)
        {
            Console.WriteLine($"name: {car.Name} id: {car.Id} color: {car.Color} speed: {car.Speed} ");
        }
    }

    public Car[] GetAllCars()
    {
        return cars;
            
    }
    
    public Car FindCarById(int carId)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i].Id==carId)
            {
                return (Car)cars[i];
            }  
        }
        return null;
    }

    public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
    {
        Car[] NewCars=new Car[0];
       
        foreach (Car item in cars)
        {
            if (item.Speed>=minSpeed && item.Speed<=maxSpeed)
            {
                Array.Resize(ref NewCars, NewCars.Length + 1);
                NewCars[NewCars.Length-1]=item;
            }
        }
        return NewCars;

    }
}
