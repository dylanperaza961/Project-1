using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> music = new List<string>();
            while (true)
            {

                Console.WriteLine("What is the command?");
                string command = Console.ReadLine();
                if (command == "add")
                {
                    //add to list
                    Console.WriteLine("What is the song?");
                    string song = Console.ReadLine();
                    music.Add(song);
                    Console.WriteLine($"The song {song} was added");
                }
                if (command == "list")
                {
                    //shows list
                    music.ForEach(Console.WriteLine) ;
                }
                if (command == "remove")
                {
                    Console.WriteLine("Which song would you like to remove?");
                    string song = Console.ReadLine();
                    if (music.Contains(song))
                    {
                        music.Remove(song);
                        Console.WriteLine($"The song {song} was removed");
                    }
                    else
                    {
                        Console.WriteLine($"The song {song} was not found");
                    }
                }
                if (command == "quit")
                {
                    break;
                }
    }
        }
    }
}
