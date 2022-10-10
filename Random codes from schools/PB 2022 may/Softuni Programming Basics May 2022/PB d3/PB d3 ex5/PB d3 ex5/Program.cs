using System;

namespace PB_d3_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double availablebudget = double.Parse(Console.ReadLine());
            int GpuNum = int.Parse(Console.ReadLine());
            int cpuNum = int.Parse(Console.ReadLine());
            int RamslotNum = int.Parse(Console.ReadLine());

            double totalGPU = GpuNum * 250;
            double CpuSingleprice = 0.35 * totalGPU;
            double totalcpu = cpuNum * CpuSingleprice;

            double ramsingleprice = 0.1 * totalGPU;
            double ramtotal = RamslotNum * ramsingleprice;

            double total = totalcpu + totalGPU + ramtotal;

            if(GpuNum>cpuNum)
            {
                double discount = 0.15 * total;
                total -= discount;
            }
            if(availablebudget>=total)
            {
                double moneyremaining = availablebudget - total;
                Console.WriteLine($"You have {moneyremaining:f2} leva left!");
            }
            else
            {
                double moneyneeded = total - availablebudget;
                Console.WriteLine($"Not enough money! You need {moneyneeded:f2} leva more!");
            }



        }
    }
}
