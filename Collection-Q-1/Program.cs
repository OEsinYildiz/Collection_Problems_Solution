// See https://aka.ms/new-console-template for more information

using System.Collections;

ArrayList arrayListPrime = new ArrayList();
ArrayList arrayListNonPrime = new ArrayList();

// Mission 1
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"{i}. sayıyı giriniz: ");
    try
    {
        uint number = Convert.ToUInt32(Console.ReadLine());
        if (PrimeNumber.Check(number)) 
            arrayListPrime.Add(number);
        else
            arrayListNonPrime.Add(number);
    }
    catch (FormatException)
    {
        throw new Exception("Numeric olmayan karakter girilemez.");
    }
    catch (OverflowException)
    {
        throw new Exception("Negatif olmayan sayılar girilemez.");
    }
}

//Mission 2
arrayListPrime.Sort();
arrayListNonPrime.Sort();

Print.ToConsole(arrayListPrime,"Asal Sayılar:");
Print.ToConsole(arrayListNonPrime, "Asal Olmayan Sayılar:");

Print.Calculater(arrayListPrime);
Print.Calculater(arrayListNonPrime);


static class Print
{
    internal static void ToConsole(ArrayList list, string message)
    {
        Console.WriteLine(message);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    internal static void Calculater(ArrayList list)
    {
        Console.WriteLine($"Dizin eleman sayısı: {list.Count}\n" +
                          $"Dizinin Ortalaması: {CalculateAverage(list)}");
    }

    internal static double CalculateAverage(ArrayList list)
    {
        double result = 0;
        foreach (var item in list)
        {
            result += Convert.ToDouble(item);
        }

        return Convert.ToDouble(result /(uint)list.Count);
    }
}


static class PrimeNumber
{
    internal static bool Check(uint number)
    {
        if (number == 1 || number == 0)
            return false;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}