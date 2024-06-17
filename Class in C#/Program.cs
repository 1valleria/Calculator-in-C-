using System.ComponentModel;

namespace Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Calculator
    {
        public Calculator()
        {
            
        }
        public int add(int num1,int num2)
        {
            int ans = num1 + num2;
            return ans;
        }
        public int substract(int num1,int num2)
        {
            int ans = num2 - num1;
            return ans;
        }
        public int multiply(int num1, int num2)
        {
            int ans = num1 * num2;
            return ans;
        }
        public int divide(int num1, int num2)
        {
            int ans = num1 / num2 ;
            return ans;
        }
        public void Mainu()
        {
            int num1;
            int num2;
            int choice;


            Console.WriteLine
                ("What operation do you want to do (1-4) : " +
                "1) Add" +
                "2) Substract" +
                "3) Multiply " +
                "4) Divide");
            
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Input one number :");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input another number :");
            num2 = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                add(num1,num2);
            }
            else if (choice == 2)
            {
                substract(num1,num2);
            }
            else if (choice == 3)
            {
                multiply(num1,num2);
            }
            else if (choice == 4)
            {
                divide(num1,num2);
            }
            else
            {
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("You have to enter a valid choice:");
                    choice = int.Parse(Console.ReadLine());
                }
                               
            }
        }

    }   
}