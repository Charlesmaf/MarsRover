using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int x; // x coordinates of the rover
        public int y; // y coordinates of the rover
        public string direction; //The direction which the rover is facing

        

        public Rover(string location)
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];
        }

        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;

                default:
                    throw new ArgumentException();

            }
        }

        public void Goto(string command) // Goto LMLMLMLMM || MMRMMRMRRM
        {
            Char[] instructions = command.ToCharArray();// Converts string to Characters

            //loop through the letter for SpinLeft , SpinRight ,Moveforward
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                    default:
                        throw new ArgumentException();
                        
                }

            }
            
        }

        public void MoveForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        public void SpinLeft()
        {
            //throw new NotImplementedException();
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;

                default:
                    throw new ArgumentException();
                    
            }


        }
    }
}
