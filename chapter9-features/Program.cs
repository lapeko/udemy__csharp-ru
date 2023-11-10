using chapter9_features;

var car = new Car();
car.ToHighSpeedDriving += (speed) =>
{
    Console.WriteLine($"Speed is to high: {speed}. We have to stop the car");
    car.Stop();
};

for (var i = 0; i < 10; i++)
    car.IncreaseSpeed();
