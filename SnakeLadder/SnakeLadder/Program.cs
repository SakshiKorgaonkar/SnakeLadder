// See https://aka.ms/new-console-template for more information
using System;

namespace SnakeLadder
{
    internal class Program
    {
        private int position; // Encapsulate as private field
        private int diceRollCount; // Counter to track the number of dice rolls

        public Program()
        {
            this.position = 0;
            this.diceRollCount = 0;
        }

        // Public method to get current position
        public int GetPosition()
        {
            return position;
        }

        // Method to get the number of dice rolls
        public int GetDiceRollCount()
        {
            return diceRollCount;
        }

        // Method to handle player's movement
        public void Move(int steps)
        {
            // Implement logic for snakes and ladders here
            int newPosition = position + steps;
            if (newPosition <= 100)
            {
                position = newPosition;
                Console.WriteLine($"Player moved {steps} steps. Current position: {position}");
            }
            else
            {
                Console.WriteLine($"Player stayed in the same position: {position}");
            }
        }

        // Method to simulate dice roll
        public int RollDice()
        {
            Random random = new Random();
            diceRollCount++;
            return random.Next(1, 7);
        }

        // Method to simulate player's option (No Play, Ladder, Snake)
        public string ChooseOption()
        {
            Random random = new Random();
            int option = random.Next(0, 3);
            switch (option)
            {
                case 0:
                    return "No Play";
                case 1:
                    return "Ladder";
                case 2:
                    return "Snake";
                default:
                    return "No Play";
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            do
            {
                int steps = program.RollDice();
                Console.WriteLine($"Dice rolled: {steps}");
                Console.WriteLine($"Number of times dice rolled: {program.GetDiceRollCount()}");
                string option = program.ChooseOption();
                Console.WriteLine($"Player chose: {option}");

                switch (option)
                {
                    case "Ladder":
                        program.Move(steps);
                        break;
                    case "Snake":
                        program.Move(-steps); // Move backward (negative steps)
                        break;
                    case "No Play":
                    default:
                        Console.WriteLine("Player stays in the same position.");
                        break;
                }
            } while (program.GetPosition() < 100); // Loop until player reaches or surpasses 100
            Console.WriteLine($"Congratulations! You reached the winning position of 100 in {program.GetDiceRollCount()} dice rolls.");
        }
    }
}
