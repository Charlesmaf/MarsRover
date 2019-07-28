using System;
using MarsRover;
using Xunit;


namespace MarsRoverTest
{
    public class RoverMust
    {
        [Fact]
        public void SpinLeft()            
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinLeft();
            //assert
            Assert.Equal("W", rover.direction);
        }

        [Fact]
        public void SpinRight()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinRight();
            //assert
            Assert.Equal("E", rover.direction);
        }

        [Fact]
        public void MoveForward()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.MoveForward();
            //assert
            Assert.Equal(3, rover.y);
        }

        [Fact]
        public void Goto()
        {
            //arrange
            Rover rover = new Rover("3 3 E");
            //act
            rover.Goto("MMRMMRMRRM");
            //assert
            Assert.Equal("5 1 E",rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}
