using System;
using System.Linq;
using System.Collections.Generic;

namespace probvamnesh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dinosaurs = new List<int>();

            dinosaurs.Add(567);
            dinosaurs.Add(321);
            dinosaurs.Add(898);
            dinosaurs.Add(121213);
            dinosaurs.Add(5674474);
            dinosaurs.Add(305);

            Console.WriteLine();
            foreach (int dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            dinosaurs.Reverse();

            Console.WriteLine();
            foreach (int dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            dinosaurs.Reverse(1, 4);

            Console.WriteLine();
            foreach (int dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
        }
    }
}
