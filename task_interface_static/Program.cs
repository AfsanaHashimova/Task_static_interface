

using task_interface_static.Models;

Car car=new Car();
car.Name = "bmw";
car.Id = 1;
car.Color = "qara";
car.Speed = 10;



 Galery galery=new Galery();
 galery.AddCar(car);

galery.ShowAllCars();
galery.GetAllCars();
galery.FindCarById(1);
galery.FindCarsBySpeedInterval(60, 200);

