// See https://aka.ms/new-console-template for more information
using SnakeAndLadder;
using System;
using System.Numerics;

namespace SnakeAndLadder
{
    class Game
    {

        static int size;
        Player[] players;

        Game(int size)
        {
            players = new Player[size];
        }

        static Game()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Welcome to Snake and Ladder Game!!!");
            Console.WriteLine("====================================");
        }



        public static int MenuDriven()
        {

            int choice = 0;

            Console.WriteLine("0. Enter Zero to Exit the Game.");
            Console.WriteLine("1. Enter One to Play the Game!!!");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input : Enter only number.");
            }


            return choice;
        }

        static void Main()
        {
            Game game;

            int choice = 0;

            while ((choice = MenuDriven()) != 0)
            {
                switch (choice)
                {
                    case 0: break;
                    case 1:
                        Console.WriteLine("Enter the number of players : ");

                        try
                        {
                            Game.size = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(size);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.ToString());
                        }


                        if (Game.size == 0) break;

                        game = new Game(Game.size);

                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine($"Enter the name of Player{i + 1} : ");
                            game.players[i] = new Player(Console.ReadLine());
                        }

                        while (true)
                        {
                            bool flag = false;
                            for (int i = 0; i < size; i++)
                            {
                                game.players[i].dice = game.players[i].RollDice();
                                game.players[i].ChOption();
                                if (game.players[i].currentPos == 100)
                                {
                                    flag = true;

                                    Console.WriteLine("\n====================================");
                                    Console.WriteLine($"{game.players[i].Name} is Winner!!!");
                                    Console.WriteLine("====================================\n");

                                    break;
                                }
                            }

                            if (flag == true)
                            {
                                break;
                            }
                        }


                        break;
                }
            }
        }
    }
}