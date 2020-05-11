//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

//Выполнил: Ивницкий Дмитрий Николаевич;





using System;

class Complex
{
    
    public double im;
    public double re;

    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }

    public Complex Multi(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = re * x2.im + im * x2.re;
        x3.re = re * x2.re - im * x2.im;
        return x3;
    }

    public Complex Minus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im - im;
        x3.re = x2.re - re;
        return x3;
    }


    public string  GetString()
    {
        return re + "+" + im + "i";
    }
}

class Class
{
    static void Main()
    {
        Complex complex1 = new Complex();
        complex1.re = 1;
        complex1.im = 1;

        Complex complex2 = new Complex();
        complex2.re = 2;
        complex2.im = 2;

       Complex result = complex1.Plus(complex2);
        Console.WriteLine(result.GetString());

        result = complex1.Multi(complex2);
        Console.WriteLine(result.GetString());

        result = complex1.Minus(complex2);
        Console.WriteLine(result.GetString());
        Console.ReadKey();
    }
}
