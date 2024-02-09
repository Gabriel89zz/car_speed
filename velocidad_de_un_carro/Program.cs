double distance, time,vel;

Console.WriteLine("What is the distance in km that your car traveled?");
distance=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What was the time in hours in which your car traveled the previous distance?");
time = Convert.ToDouble(Console.ReadLine());

vel = distance / time;

Console.WriteLine("Its speed is:" + vel + "km/h");
Console.ReadKey();