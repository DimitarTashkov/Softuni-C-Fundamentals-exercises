using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe rabotnici = new Employe();
            int max = int.MinValue;
            int employees = int.Parse(Console.ReadLine());
            for(int i =1;i<=employees;i++)
            {
                rabotnici.Name = Console.ReadLine();
                rabotnici.Salary = double.Parse(Console.ReadLine());
                rabotnici.Position = Console.ReadLine();
                rabotnici.Otdel = int.Parse(Console.ReadLine());
                rabotnici.Email = Console.ReadLine();
                if(rabotnici.Salary>max)
                {
                    Console.WriteLine(rabotnici.Name+rabotnici.Salary+rabotnici.Position+rabotnici.Otdel+rabotnici.Email);
                }

            }

        }
    }
    class Employe
    {
        private double salary;
        private string position;
        private int otdel;
        private string email;
        public string Name { get; set; }
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public int Otdel
        {
            get { return this.otdel; }
            set { this.otdel = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }     

    }
}
