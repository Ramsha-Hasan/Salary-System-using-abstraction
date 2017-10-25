using System;

namespace ConsoleApp3
{
    public  abstract class SalaryDepartment
    {
        public int salary = 0, overTimeHour = 0, fixedTime = 8, perHour = 1000;
        public string name;

        public abstract void Display();

        public void salaryCounter(int bonus, int totalHour)
        {
            salary = fixedTime * perHour;
            totalHour = overTimeHour + fixedTime; // 2+8

            if(totalHour > fixedTime)
            {
                overTimeHour = totalHour - fixedTime;  //10-8
                salary += (perHour * overTimeHour);
            }
                salary = salary + bonus;
                Console.WriteLine("Bonus: {0}  TotalHour: {1} ",bonus,totalHour);
        }
    }
    
    class Worker : SalaryDepartment
    {
        public override void Display()   
        {
            Console.WriteLine("Name:  {0}  FixedTime:  {1}  PerHour  {2}",name,fixedTime,perHour);
            Console.WriteLine("Total salary of {0} is {1}",name,salary);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(" ");
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            Worker Guard = new Worker();
            Guard.salaryCounter(120,6);
            Guard.name = "Maqsood";
            Guard.Display();


            Worker Manager = new Worker();
            Manager.salaryCounter(1000, 3);
            Manager.name = "Bilaal";
            Manager.perHour = 2000;
            Manager.Display();
            
            Console.ReadKey();
        }
    }
}

