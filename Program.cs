using System;
// Belangrijk bij het gebruik van een List class
using System.Collections.Generic;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Let op deze opdracht is in het Engels.
             * 
             * De opdracht beschrijving: Er moet een kleine dobbelsteen generator gemaakt worden.
             * Deze dobbelsteen applicatie is echter nog niet helemaal af en deze moet jij af maken.
             * In de applicatie vind je verschillende TODO's. Op deze plekken moet jij de code aanvullen of
             * repareren.
             * BELANGRIJK: Zorg ervoor dat je voor elke TODO een commit maakt met een juiste bericht. 
             * De TODO comment mag je weg halen na het repareren van de code.
             * TODO #5 Staat in de Dice class.
             */
            

            //Console.WriteLine("Hello Dice player what's your name?");
            //string playerName = Console.ReadLine();

            // TODO #2 Use the filled in name to say hello to the player
           // Console.WriteLine("Oh hello there. player " + playerName);

            Console.WriteLine("How many dice do you want to throw?");
            int diceAmount = Convert.ToInt32(Console.ReadLine());
            // TODO #3 Create a list/array variable with the amount of dice the player want to throw. Don't forget to fill the list with the Die object class.
            Die[] cup = new Die[diceAmount];


            Console.WriteLine("When ever you are ready. You can throw the dice by pressing the 'any'-key.");
            Console.ReadLine();
            int totalDie = 0;
            // TODO #4 Fix the for-loop and loop through the list/array and throw the dice using the Throw() Mehtod.
            for(int i = 0; i<diceAmount; i++)
            {
                int diceCount = i + 1;
                cup[i] = new Die();
                cup[i].ThrowDice();
                Console.WriteLine("Die " + diceCount + ": " + cup[i].GetEyes());
                totalDie = totalDie + cup[i].GetEyes();
                /* TODO #6 Use the GetEyes() method to print the eyes of the die.
                * the print in the console should look somthing like this if the user chooses 4 dice:
                * Die 1: 4
                * Die 2: 2
                * Die 3: 6
                * Die 4: 1
                */
            }
            //Console.WriteLine("Total amount of eyes: " + totalDie);

            // TODO #7 Print out the total number of eyes the user has thrown.
        }
    }
}
