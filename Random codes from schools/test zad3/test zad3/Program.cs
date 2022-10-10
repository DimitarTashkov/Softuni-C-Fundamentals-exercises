using System;

namespace test_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double priceForOnePerson = 18.00;
            double priceForApartament = 25.00;
            double priceForPresidentApartament = 35.00;
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            double totalPrice = 0;
            if(type == "room for one person")
            {
                          
                    if (days < 10)
                    {
                        totalPrice = (days-1) * priceForOnePerson;
                        
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = (days-1) * priceForOnePerson;
                        
                    }
                    else if (days > 15)
                    {
                        totalPrice = (days-1) * priceForOnePerson;
                       
                    }              
                {
                    
                }
                
            }
            else if (type == "apartment")
            {
                          
                    if (days < 10)
                    {
                        totalPrice = (days-1) * priceForApartament;
                        totalPrice = totalPrice - totalPrice * 0.30;
                        
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = (days-1) * priceForApartament;
                       totalPrice = totalPrice - totalPrice * 0.35;                      
                    }
                    else if (days > 15)
                    {
                        totalPrice = (days-1) * priceForApartament;
                        totalPrice = totalPrice - totalPrice * 0.50;                     
                    }                           
               
            }
            else if (type == "president apartment")
            {
                if (days < 10)
                {
                    totalPrice = (days-1) * priceForPresidentApartament;
                    totalPrice = totalPrice - totalPrice * 0.10;

                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice = (days-1) * priceForPresidentApartament;
                    totalPrice = totalPrice - totalPrice * 0.15;
                }
                else if (days > 15)
                {
                    totalPrice = (days-1) * priceForPresidentApartament;
                    totalPrice = totalPrice - totalPrice * 0.20;
                }
            }
            if(grade == "positive")
            {
                totalPrice = totalPrice + totalPrice*0.25;
                Console.WriteLine($"{totalPrice:f2}");
            }
            else if (grade == "negative")
            {
                totalPrice = totalPrice - totalPrice * 0.10;
                Console.WriteLine($"{totalPrice:f2}");
            }
        }
    }
}
