using System;

//The Rover has 2 sets of command inputs
// *(x,y ,E)  = The rover's position x = x-coordinates | y = y-coordinates | E = Directions its facing
// *(L R M) = Movement of Rover

//List of Behaviours
// 1. Rover Must Spin Left (L)
// 2. Rover Must Spin Right (R)
// 3. Rover Must Move Forward (M)


namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: *Note add a space after each Character (x y E)");
            string coordinates = Console.ReadLine().ToUpper();


            
            Rover rover1 = new Rover(coordinates);

            Console.WriteLine("Please enter Rover's commands | format L = left R = right M = move");
            string coms = Console.ReadLine();

            rover1.Goto(coms);
           

            Console.WriteLine("New Location:");
            Console.WriteLine(rover1.x +" "+ rover1.y + " " + rover1.direction);

            
            Console.ReadKey();
            
        }
    }
}
