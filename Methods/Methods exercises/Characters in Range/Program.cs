using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
             Range( first,second);            
        }
        static char Range(char first,char second)
        {
            int firstCharASCII = (int)(first);
            int secondCharASCII = (int)(second);
            int thirdCharASCII = (int)0;
            string resultCollect = "";
            char result = '\0';
            
            if(firstCharASCII > secondCharASCII)
            {
                
                thirdCharASCII = firstCharASCII;
                firstCharASCII = secondCharASCII;
                for (int i = firstCharASCII; i < thirdCharASCII; i++)
                {

                     resultCollect+= (char)(i);
                    
                }
                for (int i = 1; i < resultCollect.Length; i++)
                {
                    result = resultCollect[i];
                    Console.Write(result+" ");
                }

            }
            else
            {
                for (int i = firstCharASCII; i < secondCharASCII; i++)
                {

                     resultCollect+= (char)(i);
                    
                }
                for (int i = 1; i < resultCollect.Length; i++)
                {
                    result = resultCollect[i];
                    Console.Write(result+" ");
                }
                

            }
            return result;
           
        }
    }
}
