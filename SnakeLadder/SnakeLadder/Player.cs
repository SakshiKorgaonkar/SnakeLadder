using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Player
    {
        static int startPos = 0;
        static int endPos = 100;

        public string? Name { get; set; }
        public int currentPos;
        public int dice;
        public int count;

        Player()
        {
            this.Name = "Player1";
            this.currentPos = 0;
            this.count = 0;
        }

        public Player(string name)
        {
            this.Name = name;
            this.currentPos = 0;
            this.count = 0;
        }

        public int RollDice()
        {
            Random rnd = new Random();
            this.dice = rnd.Next(1, 7);
            this.count++;
            return this.dice;
        }

        public void ChOption()
        {
            Random rnd = new Random();
            int option = rnd.Next(1, 4);

            switch (option)
            {
                case 1:
                    Console.WriteLine("-----\nNo Play");
                    Console.WriteLine("Name of Player : " + this.Name);
                    Console.WriteLine("Position : " + this.currentPos);
                    Console.WriteLine("Count : " + this.count);

                    break;

                case 2:
                    Console.WriteLine("-----\nLadder");
                    currentPos += this.dice;

                    if (currentPos > endPos)
                    {
                        currentPos -= dice;
                    }

                    Console.WriteLine("Name of Player : " + this.Name);
                    Console.WriteLine("Dice : " + this.dice);
                    Console.WriteLine("Position : " + this.currentPos);
                    Console.WriteLine("Count : " + this.count);

                    if (this.currentPos == endPos)
                    {
                        return;
                    }

                    this.RollDice();
                    this.ChOption();

                    break;

                case 3:
                    Console.WriteLine("-----\nSnake");
                    currentPos -= dice;
                    if (currentPos <= startPos)
                    {
                        currentPos = startPos;
                    }

                    Console.WriteLine("Name of Player : " + this.Name);
                    Console.WriteLine("Dice : " + this.dice);
                    Console.WriteLine("Position : " + this.currentPos);
                    Console.WriteLine("Count : " + this.count);


                    break;
            }
        }


    }
}