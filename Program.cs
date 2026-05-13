using System;

Console.WriteLine("Assalomu alaykum! CalString dasturiga xush kelibsiz");

string tanlov;

do
{
    Console.WriteLine("\n--- MENYU ---");
    Console.WriteLine("1. Ifodani hisoblash (+/-)");
    Console.WriteLine("2. Eng katta sonni topish");
    Console.WriteLine("3. Faktorial hisoblash");
    Console.WriteLine("4. 1 dan N gacha yig'indi");
    Console.WriteLine("0. Chiqish");
    Console.Write("Tanlovingizni kiriting: ");
    tanlov = Console.ReadLine();

    if (tanlov == "1")
    {
        RunCalculator();
    }
    else if (tanlov == "2")
    {
        RunGetMax();
    }
    else if (tanlov == "3")
    {
        RunFactorial();
    }
    else if (tanlov == "4")
    {
        RunSumToN();
    }

} while (tanlov != "0");

Console.WriteLine("Dastur tugadi. Xayr!");

static void RunCalculator()
{
    Console.Write("Ifodani kiriting (masalan, 1+5-2): ");
    string input = Console.ReadLine();
    int natija = 0;
    int hozirgiSon = 0;
    char amal = '+';

    for (int i = 0; i < input.Length; i++)
    {
        char belgi = input[i];

        if (belgi >= '0' && belgi <= '9')
        {
            hozirgiSon = (hozirgiSon * 10) + (belgi - '0');
        }

        if (belgi == '+' || belgi == '-' || i == input.Length - 1)
        {
            if (amal == '+') natija = natija + hozirgiSon;
            else if (amal == '-') natija = natija - hozirgiSon;

            amal = belgi;
            hozirgiSon = 0;
        }
    }
    Console.WriteLine("Natija: " + natija);
}

static void RunGetMax()
{
    Console.Write("1-sonni kiriting: ");
    int s1 = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("2-sonni kiriting: ");
    int s2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("3-sonni kiriting: ");
    int s3 = Convert.ToInt32(Console.ReadLine());

    int max = GetMax(s1, s2, s3);
    Console.WriteLine("Eng katta son: " + max);
}

static int GetMax(int a, int b, int c)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
}

static void RunFactorial()
{
    Console.Write("Sonni kiriting: ");
    int n = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine(n + "! = " + Factorial(n));
}

static long Factorial(int n)
{
    long natija = 1;
    for (int i = 1; i <= n; i++) natija *= i;
    return natija;
}

static void RunSumToN()
{
    Console.Write("N ni kiriting: ");
    int n = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("1 dan " + n + " gacha yig'indi: " + SumToN(n));
}

static int SumToN(int n)
{
    int yigindi = 0;
    for (int i = 1; i <= n; i++) yigindi += i;
    return yigindi;
}