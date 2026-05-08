bool davomEtish = true; 

while (davomEtish)
{
    Console.Write("Ifodani kiriting (masalan, 1+5-2): ");
    string input = Console.ReadLine();

    int natija = 0;
    int hozirgiSon = 0;
    char amal = '+';
    int i = 0;

    while (i < input.Length)
    {
        char belgi = input[i];

        if (belgi >= '0' && belgi <= '9')
        {
            hozirgiSon = (hozirgiSon * 10) + (belgi - '0');
        }

        if (belgi == '+' || belgi == '-' || i == input.Length - 1)
        {
            if (amal == '+')
            {
                natija = natija + hozirgiSon;
            }
            else if (amal == '-')
            {
                natija = natija - hozirgiSon;
            }

            amal = belgi;
            hozirgiSon = 0;
        }
        i++;
    }

    Console.WriteLine("Natija: " + natija);

    Console.Write("\nYana hisoblashni xohlaysizmi? (ha/yo'q): ");
    string javob = Console.ReadLine().ToLower();

    if (javob != "ha")
    {
        davomEtish = false;
    }
}

Console.WriteLine("Dastur tugadi. Xayr!");