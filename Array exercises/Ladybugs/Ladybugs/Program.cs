using System;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            //field size
            
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];
            //2.Spawn LadyBugs
            //This collection remains unchanged
            int[] initialIndex = Console.ReadLine()
                .Split(" " ,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (int index in initialIndex)
            {
                if (index >= 0 && index < field.Length)
                {
                    //Valid index-Initialise a ladybug
                    field[index] = 1;
                }
                
            }
            //3.Proceed moves
            string command;
            while ((command = Console.ReadLine())!="end")
            {
                string[] commandArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladyBugIndex = int.Parse(commandArguments[0]);
                string direction = commandArguments[1];
                int flyingLenght = int.Parse(commandArguments[2]);
                //3.1 Validate ladyBug index is in the field
                if(ladyBugIndex < 0||ladyBugIndex >= field.Length)
                {
                    //Invalid index => nothing happens
                    continue;
                }
                //3.2 Validate ladybugindex contains ladybug
                if(field[ladyBugIndex] == 0)
                {
                    //There is no ladybug here => nothing happens
                    continue;
                }

                //3.3 Try to proceed move
                //Right -> ladybugindex + flylenght
                //Left -> ladybugindex - flylenght
                //First -> Our ladybug starts flying => it removes from the field,it is in the air
                field[ladyBugIndex] = 0;
                if(direction == "left")
                {
                    flyingLenght *= -1;//1 => -1
                }
                //0 right 1 => 0+1 = 1
                //1 left 1 => 1+(-1) = 0
                int nextIndex = ladyBugIndex + flyingLenght;
                while(nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyingLenght;
                }
                //There are two posibilities
                //A: Index is calculated somewhere in the field
                //B: Next index can not be calculated in the field
                if(nextIndex<0||nextIndex>=field.Length)
                {
                    //Outside the fields
                    continue;
                }
                //Variant a
                //Land the ladybug on the valid next index
                field[nextIndex] = 1;
            }
            Console.WriteLine(String.Join(" ",field));

        }
    }
}
