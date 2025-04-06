//Accepting the i value and j value comparing i and j using if else.

/*namespace Conditional_Statements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter i value:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter j value:");
        int j = int.Parse(Console.ReadLine());
        if (i > j)
        {
            Console.WriteLine("i is greater than j");
            Console.WriteLine("i value is:" + i);
        }
        else
        {
            Console.WriteLine("j is grater than i");
            Console.WriteLine("j value is:" + j);
        }
        Console.ReadLine();

    }
}

//accept 2 numbers and perform division and display user friendly message to accept
//other than zero if the second number is zero by using simple if?

namespace Conditional_Statements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1st num:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd num:");
        int b = int.Parse(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("Please enter 2nd num other than zero");
            b = int.Parse(Console.ReadLine());
        }
        int div = a / b;
        Console.WriteLine("Division result is:" + div);
        Console.ReadLine();

    }
}

//if else if condition:
namespace Conditional_Statements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter i value:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter j value:");
        int j = int.Parse(Console.ReadLine());
        if (i > j)
        {
            Console.WriteLine("i is greater than j");
        }
        else if(j>i)
        {
            Console.WriteLine("j is grater than i");
        }
        else
        {
            Console.WriteLine("I is equal to j");
        }
        Console.ReadLine();

    }
}

//Accept a letter(a to z) check is it vowel or not?

namespace Conditional_Statements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a letter:");
        char c = char.Parse(Console.ReadLine());
        if (c == 'a')
        {
            Console.WriteLine("It is vowel");
        }
        else if (c == 'e')
        {
            Console.WriteLine("It is vowel");
        }
        else if (c == 'i')
        {
            Console.WriteLine("It is vowel");
        }
        else if (c == 'o')
        {
            Console.WriteLine("It is vowel");
        }
        else if (c == 'u')
        {
            Console.WriteLine("It is vowel");
        }
        else
        {
            Console.WriteLine("It is not vowel");
        }
        Console.ReadLine();

    }

}

//write a c#.net program to accept 6 subject marks..store into m1 to m6 variablse
//calaculate total marks and average marks then display result if student got
//less than 35 in any one subject result is:Fail
//if student got avgmarks>=60 result is first class
//if student got avgmarks between 50 to 59 result is:second class
//if student got avgmarks between 35 to 49 result is: -third class


namespace Conditional_Statements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first subject marks:");
        double m1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second subject marks:");
        double m2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third subject marks:");
        double m3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth subject marks:");
        double m4 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth subject marks:");
        double m5 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter sixth subject marks:");
        double m6 = double.Parse(Console.ReadLine());
        double totmarks = m1 + m2 + m3 + m4 + m5 + m6;
        double avgmarks = totmarks / 6;
        if (m1 < 35 || m2 < 35 || m3 < 35 || m4 < 35 || m5 < 35 || m6 < 35)
        {
            Console.WriteLine("Result is: FAIL");
        }
        else if (avgmarks >= 60)
        {
            Console.WriteLine("Result is: FIRST CLASS");
        }
        else if(avgmarks >= 50)
        {
            Console.WriteLine("Result is: SECOND CLASS");
        }
        else 
        {
            Console.WriteLine("Result is: THIRD CLASS");
        }
        Console.ReadLine();

    }
}

//multiple if
namespace Conditional_Statements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter i value:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter j value:");
        int j = int.Parse(Console.ReadLine());
        if (i > j)
        {
            Console.WriteLine("i is greater than j");
        }
        if (j > i)
        {
            Console.WriteLine("j is grater than i");
        }
        if(i == j)
        {
            Console.WriteLine("I is equal to j");
        }
        Console.ReadLine();

    }
}

//Nested if most used command control in the realtime projects

namespace Conditional_Statements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter i value:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter j value:");
        int j = int.Parse(Console.ReadLine());
        if (i > j)
        {
            Console.WriteLine("i is greater than j");
        }
        else
        {
            if(j > i)
            Console.WriteLine("j is grater than i");
            else
            Console.WriteLine("I is equal to j");
            
        }
        Console.ReadLine();

    }
}*/



