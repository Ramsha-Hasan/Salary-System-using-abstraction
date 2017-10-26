using System;

namespace ConsoleApp3
{
    public  abstract class SalaryDepartment
    {
        public int salary = 0, totalHour = 0, fixedTime = 8;
        public string name;

        public abstract void Display();

        public void salaryCounter(int bonus, int overTimeHour, int perHour)
        {
            salary = fixedTime * perHour;
            totalHour = overTimeHour + fixedTime; // 2+8

            if(totalHour > fixedTime)
            {
                overTimeHour = totalHour - fixedTime;  //10-8
                salary += (perHour * overTimeHour);
            }
                salary = salary + bonus;
                Console.WriteLine("Bonus: {0} \nTotalHour: {1}  \nPerHour: {2}  \nOverTime: {3}",bonus,totalHour,perHour,overTimeHour);
        }
    }
    
    class Worker : SalaryDepartment
    {
        public override void Display()   
        {
            Console.WriteLine("Name:  {0} \nFixedTime:  {1}",name,fixedTime);
            Console.WriteLine("Total salary of {0} is {1}",name,salary);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(" ");
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            SalaryDepartment Guard = new Worker();
            Guard.salaryCounter(120,6,1000);
            Guard.name = "Maqsood";
            //Guard.perHour = 1000;
            Guard.Display();


            Worker Manager = new Worker();
            Manager.salaryCounter(1000, 3,2000);
            Manager.name = "Bilaal";
            //Manager.perHour = 2000;
            Manager.Display();
           
            
            Console.ReadKey();
        }
    }
}

