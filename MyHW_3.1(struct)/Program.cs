
using System;


class Program
{
    static void Main()
    {
        View view = new View();
        Nol(view);
        view.Pause();


    }


    public static void Nol(View view)
    {
        double zero = 1;
        double sumNechPol = 0;


        try
        {
            while (zero != 0)
            {
                double N = view.GetDouble("Введите число  : ");

                if ((N % 2 != 0) && (N > 0))
                {
                    sumNechPol = sumNechPol + N;
                }

                zero = N;

            }
            view.Print($" Это 0! Дело сделано ! Cумма  всех нечётных- положительных чисел введённых ранне  = {sumNechPol}");
        }

        catch
        {
            view.Print("Я написал введите число , теперь запускай блин заного !!!");

        }



        




    }
}
