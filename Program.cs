using System.Reflection.Metadata.Ecma335;

namespace MedianV3
{
    internal class Program
    {
        static int Ccounter(int n1)
        {
            int counter = 0;    
            while (n1 >= 1)
            {
            n1 = n1 / 10;
                counter++;  
            }
            return counter; 
        }
        static int factorial(int n)
        {
            int prod = 1;
            for (int i = 1; i < n; i++)
            {

                prod = prod * i;

            }
            return prod;
        }
        static double median(int n1, int n2)
        {
            int sum = 0, switcher = 0, ncounter = 0;
            if (n1 > n2)
            {
                switcher = n2;
                n2 = n1;
                n1 = switcher;
            }
            for (int i = n1 - 1; i <= n2; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                    ncounter++;
                }

            }
            return sum / ncounter;
        }
        static bool intervalCheck(int checkedN,int n1, int n2)
        {
            bool result;
            int switcher = 0;
            if (n1 > n2)
            {
                switcher = n2;
                n2 = n1;
                n1 = switcher;
            }   
            if (checkedN>n1&& checkedN< n2)
            {
                result = true;
            }
            else
            {
                result = false;
            }   
            return result;  
        }
        static bool Perfect(int number)
        {
            int sum = 0;    
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        sum = sum + i;
                    }
                }
            if (sum == number)
            {
                return true;
            }
            else
            {
                return false;   
            }

        }
        static void Main(string[] args)
        {
            int Pcounter = 0;
            string function;
            Console.WriteLine("choose the function you want to use: factorial,interval,cypher counter, interval checker or Pchecker");
            function = Console.ReadLine();
            if (function == "interval")
            {
                Console.WriteLine("insert the two interval values");
                int v1 = Convert.ToInt32(Console.ReadLine());
                int v2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(median(v1, v2));
            }
            else if (function == "factorial")
            {
                Console.WriteLine("insert the value you want the factorial of");
                int v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(factorial(v1));
            }
            else if (function == "counter")
            {
                Console.WriteLine("insert value");
                int v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Ccounter(v1));

            }
            else if (function == "checker")
            {
                Console.WriteLine("insert the two interval values");
                int v1 = Convert.ToInt32(Console.ReadLine());
                int v2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("insert the value you want to check");
                int v3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(intervalCheck(v3,v1,v2));
            }
            else if (function == "Pnumber")
            {
                Console.WriteLine("insert interval");
                int v1 = Convert.ToInt32(Console.ReadLine());
                    for (int i=0; i<= v1; i++)
                    {
                        if ((Perfect(i))==true)
                        {
                        Pcounter++;
                        } 
                    }
                Console.WriteLine("there were " + Pcounter + " perfect numbers");
            }
            else 
            {
                Console.WriteLine("invalid function");
            }
        }
    }
}
