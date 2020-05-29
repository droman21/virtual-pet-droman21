﻿using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet newPet = new Pet();
            Shelter petShelter = new Shelter();
            petShelter.AddPet(newPet);
            bool keepThinking = true;
            while (keepThinking)
            
            {
                Console.WriteLine ($"{petShelter.PrintAllPets()}");
                Console.WriteLine("Hi and Welcome to the Perrysburg Pet Shelter!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. I'm Bringing in a new Pet");
                Console.WriteLine("2. Feed the Pets");
                Console.WriteLine("3. Play with all of the Pets");
                Console.WriteLine("4. Play with a single Pet");
                Console.WriteLine("5. Adopt a Pet");
                Console.WriteLine("6. Admit a Pet");
                Console.WriteLine("7. Quit");
                //Console.Clear();
                string menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("What is your pet's name?");
                        string name = Console.ReadLine();
                        newPet.SetName(name);

                        Console.WriteLine("What species is your pet?");
                        string species = Console.ReadLine();
                        newPet.SetSpecies(species);
                        break;
                    case "2":
                        Console.WriteLine($"{petShelter.PrintAllPets()}");
                        petShelter.FeedAll();
                        Console.WriteLine("You fed the pets!");
                        break;
                    case "3":
                        petShelter.PrintAllPets();
                        petShelter.PlayAll();
                        Console.WriteLine("You played with the pets!");
                        break;
                    case "4":
                        petShelter.PrintAllPets();
                        Console.WriteLine("Which pet would you like to play with?");
                        newPet.SetPetType(Console.ReadLine());
                        newPet.Play();
                        Console.WriteLine($"You played with {newPet.GetName()}!");
                        break;
                    case "5":
                        petShelter.PrintAllPets();
                        Console.WriteLine("Which pet would you like to adpot?");
                        newPet.SetPetType(Console.ReadLine());
                        petShelter.RemovePet(newPet);
                        Console.WriteLine($"You gave {newPet.GetName()} a good home!");
                        break;
                    case "6":
                        petShelter.PrintAllPets();
                        Console.WriteLine("Which pet would you like to add to the shelter?");
                        newPet.SetPetType(Console.ReadLine());
                        petShelter.AddPet(newPet);
                        break;
                    case "7":
                        keepThinking = false;
                        Console.WriteLine("Good Bye! Thanks for Visiting!");
                        break;
                    default:
                        break;

                        
                }
            }

        }
        
    }

}
